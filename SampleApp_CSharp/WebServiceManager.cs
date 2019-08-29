﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Scanner_SDK_Sample_Application
{
    public class WebServiceManager
    {
        public static async Task<string> SendCreateRequestAsync(string url, string stringifiedJsonData, string method)
        {
            var result = string.Empty;

            //发送请求
            var request = (HttpWebRequest)WebRequest.Create(url);
            var data = Encoding.UTF8.GetBytes(stringifiedJsonData);

            request.Method = method;
            request.ContentType = "application/json";
            request.KeepAlive = false;
            request.ServicePoint.Expect100Continue = false;
            request.ContentLength = data.Length;
            //request.Headers.Add("Authorization", "Bearer " + accessToken);
            request.Accept = "application/json";
            //request.UserAgent = "APIExplorer";
            ServicePointManager.DefaultConnectionLimit = 1000;      //提高每秒默认请求数量

            using (var reqStream = await request.GetRequestStreamAsync())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }

            var response = await request.GetResponseAsync();

            var stream = response.GetResponseStream();

            //获取响应
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = await reader.ReadToEndAsync();
            }

            return result;
        }

        public static string SendCreateRequest(string url, string stringifiedJsonData, string method)
        {
            var result = string.Empty;

            //发送请求
            var request = (HttpWebRequest)WebRequest.Create(url);
            var data = Encoding.UTF8.GetBytes(stringifiedJsonData);

            request.Method = method;
            request.ContentType = "application/json";
            request.KeepAlive = false;
            request.ServicePoint.Expect100Continue = false;
            request.ContentLength = data.Length;
            //request.Headers.Add("Authorization", "Bearer " + accessToken);
            request.Accept = "application/json";
            //request.UserAgent = "APIExplorer";
            ServicePointManager.DefaultConnectionLimit = 1000;      //提高每秒默认请求数量

            using (var reqStream = request.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }

            var response = request.GetResponse();

            var stream = response.GetResponseStream();

            //获取响应
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }

        public static string SendQueryRequest(string url)
        {
            var result = string.Empty;

            //发送请求
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.KeepAlive = false;
            request.ServicePoint.Expect100Continue = false;
            //request.Headers.Add("Authorization", "Bearer " + accessToken);
            request.Accept = "application/json";
            //request.UserAgent = "APIExplorer";
            ServicePointManager.DefaultConnectionLimit = 1000;      //提高每秒默认请求数量

            var response = request.GetResponse();

            var stream = response.GetResponseStream();

            //获取响应
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }
    }

    public class SKU
    {
        public string UPCNumber { get; set; }
    }
}
