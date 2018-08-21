using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanColleAutoTool.Masters;
using System.Net;
using System.Net.Cache;
using System.IO;

namespace KanColleAutoTool.Masters.NetworkMasterComponent
{
    public class HttpPoster
    {
        public bool httpPost(string _url, string _postData, out string outBody)
        {
            Encoding myEncoding = Encoding.UTF8;
            string sMode = "POST";
            string sContentType = "application/x-www-form-urlencoded";
            HttpWebRequest req;

            try
            {
                // init
                req = initHttpRequest(_url, _postData, myEncoding, sMode, sContentType);

                // Response
                HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                try
                {
                    outBody = tryGetResponse(res);

                    return true;
                }
                finally
                {
                    res.Close();
                }
            }
            catch (Exception ex)
            {
                OutLog(ex.ToString());
            }
            outBody = "";
            return false;
        }

        private static void OutLog(string _fomat, params object[] _args)
        {
            LogMaster.Log("Log By HttpPoster: " + string.Format(_fomat, _args));
        }

        private static string tryGetResponse(HttpWebResponse res)
        {
            string outBody;
            OutLog("Response.ContentLength:\t{0}", res.ContentLength);
            OutLog("Response.ContentType:\t{0}", res.ContentType);
            OutLog("Response.CharacterSet:\t{0}", res.CharacterSet);
            OutLog("Response.ContentEncoding:\t{0}", res.ContentEncoding);
            OutLog("Response.IsFromCache:\t{0}", res.IsFromCache);
            OutLog("Response.IsMutuallyAuthenticated:\t{0}", res.IsMutuallyAuthenticated);
            OutLog("Response.LastModified:\t{0}", res.LastModified);
            OutLog("Response.Method:\t{0}", res.Method);
            OutLog("Response.ProtocolVersion:\t{0}", res.ProtocolVersion);
            OutLog("Response.ResponseUri:\t{0}", res.ResponseUri);
            OutLog("Response.Server:\t{0}", res.Server);
            OutLog("Response.StatusCode:\t{0}\t# {1}", res.StatusCode, (int)res.StatusCode);
            OutLog("Response.StatusDescription:\t{0}", res.StatusDescription);

            // header
            OutLog(".\t#Header:");	// 头.
            for (int i = 0; i < res.Headers.Count; ++i)
            {
                OutLog("[{2}] {0}:\t{1}", res.Headers.Keys[i], res.Headers[i], i);
            }

            // 找到合适的编码
            Encoding encoding = null;
            //encoding = Encoding_FromBodyName(res.CharacterSet);	// 后来发现主体部分的字符集与Response.CharacterSet不同.
            //if (null == encoding) encoding = myEncoding;
            //encoding = _ResEncoding;
            System.Diagnostics.Debug.WriteLine(Encoding.UTF8);

            // body
            OutLog(".\t#Body:");	// 主体.
            using (Stream resStream = res.GetResponseStream())
            {
                using (StreamReader resStreamReader = new StreamReader(resStream, encoding))
                {
                    outBody = resStreamReader.ReadToEnd();
                    OutLog(outBody);
                }
            }
            OutLog(".\t#OK.");	// 成功.
            return outBody;
        }

        private static HttpWebRequest initHttpRequest(string _url, string _postData, Encoding myEncoding, string sMode, string sContentType)
        {
            HttpWebRequest req;
            req = HttpWebRequest.Create(_url) as HttpWebRequest;
            req.Method = sMode;
            req.Accept = "*/*";
            req.KeepAlive = true;
            req.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);

            byte[] bufPost = myEncoding.GetBytes(_postData);
            req.ContentType = sContentType;
            req.ContentLength = bufPost.Length;

            req.Referer = "http://125.6.189.103/kcs/port.swf?version=1.5.1";
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
            Stream newStream = req.GetRequestStream();
            newStream.Write(bufPost, 0, bufPost.Length);
            newStream.Close();
            return req;
        }
    }
}
