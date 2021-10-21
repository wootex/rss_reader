using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess
{
    public static class ReadXml
    {
        public static void ReadFile(string url)
        {
            FileStream xmlFile = new FileStream("podcasts.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(xmlFile);

            

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            foreach (SyndicationItem item in feed.Items)
            {
                Console.WriteLine(item.Title.Text);
                Console.WriteLine("->" + item.Summary.Text);

                writer.WriteLine(item.Title.Text);
                writer.WriteLine("->" + item.Summary.Text);

            }
            writer.Close();
            xmlFile.Close();
        }
    }
}
