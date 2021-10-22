using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLayer.Validator
{
    public static class Validator
    {
            public static bool ValidLink(string url)
            {
                try
                {
                    new XmlDocument().Load(url);
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine("länk funkar inte");
                    return false;
                }
            
            }
        
    }
}
