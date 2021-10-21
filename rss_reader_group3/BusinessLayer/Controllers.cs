using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DataAccess;
using Models;


namespace BusinessLayer.Controllers
{
    public class Controllers
    {
        SerializerForXml serializer;

        public Controllers()
        {
            serializer = new SerializerForXml();
        }
        public void CreatePodcast(string url, string freq, string category)
        {
            //---------------

            

            //------------------

            Podcast newPodcast = new Podcast();
            newPodcast.title = "Björnen sover";
            newPodcast.category = category;
            newPodcast.episodes = 200;
            newPodcast.frequency = 10;

            List<Podcast> podcastList = new List<Podcast>();
            podcastList.Add(newPodcast);
            serializer.Serialize(podcastList);
        }
    }
}
