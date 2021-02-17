using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BasicServerHTTPlistener
{
    class Header
    {

        private string mime;
        private string charset;
        private string encoding;
        private string langage;
        private string methods;
        private string authorizations;
        private string cookie;
        private string from;
        private string host;

        public Header(WebHeaderCollection headers)
        {
            mime = headers.Get(HttpRequestHeader.Accept.ToString());
            charset = headers.Get(HttpRequestHeader.AcceptCharset.ToString());
            encoding = headers.Get(HttpRequestHeader.AcceptEncoding.ToString());
            langage = headers.Get(HttpRequestHeader.AcceptLanguage.ToString());
            methods = headers.Get(HttpRequestHeader.Allow.ToString());
            authorizations = headers.Get(HttpRequestHeader.Authorization.ToString());
            cookie = headers.Get(HttpRequestHeader.Cookie.ToString());
            from = headers.Get(HttpRequestHeader.From.ToString());
            host = headers.Get(HttpRequestHeader.Host.ToString());
        }

        public void display()
        {
            Console.WriteLine($"MIME : {mime}");
            Console.WriteLine($"Charset: {charset}");
            Console.WriteLine($"Encoding: {encoding}");
            Console.WriteLine($"Langage: {langage}");
            Console.WriteLine($"Methods: {methods}");
            Console.WriteLine($"Authorizations: {authorizations}");
            Console.WriteLine($"Cookie: {cookie}");
            Console.WriteLine($"From: {from}");
            Console.WriteLine($"Host: {host}");
        }




    }
}
