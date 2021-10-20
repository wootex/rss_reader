using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.SyndicationFeed;
using System.Xml;
namespace rss_reader_group3
{
    class XmlReader
    {
        
        private void getURL(String url)
        {
            XmlReaderSettings rSettings = new XmlReaderSettings();
            System.Xml.XmlReader.Create("https://www.espn.com/espn/rss/news", rSettings);
            SyndicationFeed feed = new SyndicationFeed("Feed Title", "Feed Description", new Uri("http://Feed/Alternate/Link"), "FeedID", DateTime.Now);


        }

       
    }
}
