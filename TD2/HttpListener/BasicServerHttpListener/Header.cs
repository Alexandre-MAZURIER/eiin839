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

        private WebHeaderCollection header;

        public Header(WebHeaderCollection header)
        {
            this.header = header;
        }

        public void display()
        {
            for(int i = 0; i<header.Count; i++ )
            {
                Console.WriteLine(header.GetKey(i) + ": " + header.Get(i));
            }
        }

    }
}
