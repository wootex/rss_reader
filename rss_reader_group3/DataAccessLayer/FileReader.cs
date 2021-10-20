using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;

namespace DataAccessLayer
{
    public class FileReader
    {
        
        public static void getURL(String url)
        {
            //https://www.espn.com/espn/rss/news
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            Console.WriteLine("---Title: " + feed.Title.Text);
            Console.WriteLine("---Description: " + feed.Description.Text);

            //foreach (SyndicationItem item in feed.Items)
            //{
            //    Console.WriteLine(item.Title.Text);
            //    Console.WriteLine("->" + item.Summary.Text);
            //}
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Title"))
                {
                    if (reader.HasAttributes) ;
                }
            }

        }

       
    }
}
