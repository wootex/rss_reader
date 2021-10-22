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
        private static List<string> episodeList;
        public static void ReadFile(string url)
        {
            

            XmlReader reader = XmlReader.Create(url);
            
            
           
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            List<string> episodeList = new List<string>();
            List<string> titleList = new List<string>();

            //Console.WriteLine(feed.Title.Text); //!!!!!!!
            //Console.WriteLine(feed.Description.Text);

            podcastName = feed.Title.Text;
            
            foreach (SyndicationItem item in feed.Items)
            {
                episodeList.Add(item.Title.Text);

            }

            //episodeList.ForEach(num => Console.WriteLine(num + ", "));
            

            foreach (SyndicationItem title in feed.Items)

            {
                titleList.Add(title.Title.Text);
               
            }
                
            episodeLength = episodeList.Count;
            
        }

        public static int ReturnEpisodes()
        {

            return episodeLength;
        }
        public static string ReturnPodName()
        {

            return podcastName;
        }

        public static List<string> returnEpisodeList()
        {
            return episodeList;
            //Console.WriteLine(episodeList);
        }
    }
}
