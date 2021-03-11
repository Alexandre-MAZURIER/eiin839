using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListContract
{
    class Contract
    {
        public string name { get; set; }
        public string commercial_name { get; set; }
        public string[] cities { get; set; }
        public string country_code { get; set; }



        public Contract()
        {
            Console.WriteLine(name);
        }

        override
        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Name : " + name);
            res.Append("Commercial name : " + commercial_name);
            res.Append("Cities : ");
            for(int i = 0; i<cities.Length; i++)
            {
                res.Append(cities[i]);
            }
            res.Append("Country code : " + country_code);
            return res.ToString();
        }
    }

}
