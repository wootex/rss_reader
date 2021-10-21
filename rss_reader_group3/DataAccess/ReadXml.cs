using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DataAccess
{
    public class ReadXml
    {
        private static int episodeLength;
        private static string podcastName;
        private static List<string> descList = new List<string>();
        public static void ReadFile(string url)
        {
            //FileStream xmlFile = new FileStream("podcasts.txt", FileMode.Create, FileAccess.Write);
           // StreamWriter writer = new StreamWriter(xmlFile);

            
            XmlReader reader = XmlReader.Create(url);
            
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            List<string> episodeList = new List<string>();
            List<string> titleList = new List<string>();
            
            

            foreach (SyndicationItem item in feed.Items)
            {
                episodeList.Add(item.Title.Text);
                descList.Add(item.Summary.Text);
            }
            
            episodeLength = episodeList.Count;
            

            //----------------
            var combinedList = episodeList.Concat(descList);
            foreach (var item in combinedList)
            {
                Console.WriteLine(item);
            }
        }

        public static int ReturnEpisodes()
        {

            return episodeLength;
        }
        public static string ReturnPodName()
        {

            return podcastName;
        }
        public static List<string> ReturnDesc()
        {

            return descList;
        }
    }
}
