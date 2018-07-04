using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;

namespace GFC_Tools
{
    public class GFC_Downloader
    {
        public void Downloadzip(string url, string path)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/zip";
            try
            {
                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(res.GetResponseStream(), System.Text.Encoding.Default))
                {
                    StreamWriter oWriter = new StreamWriter(path);
                    oWriter.Write(sr.ReadToEnd());
                    oWriter.Close();
                }
                res.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void DownloadZip(string url, string path, [Optional]string extractPath)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/zip";
            try
            {
                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                using (StreamReader sr = new StreamReader(res.GetResponseStream(), System.Text.Encoding.Default))
                {
                    StreamWriter oWriter = new StreamWriter(path);
                    oWriter.Write(sr.ReadToEnd());
                    oWriter.Close();
                }
                res.Close();
                if (extractPath == null) { }else
                { ZipFile.ExtractToDirectory(path, extractPath); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }


    }
}
