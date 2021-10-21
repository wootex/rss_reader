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
        public Podcast CreatePodcast(string url, string freq, string category)
        {
            //---------------

            ReadXml.ReadFile(url);

            //------------------

            Podcast newPodcast = new Podcast();

            newPodcast.title = ReadXml.ReturnPodName(); //titel från XML filen
            newPodcast.category = category;
           
            newPodcast.episodes = ReadXml.ReturnEpisodes();//antal episoder från en podcast hämtat från XML
            newPodcast.frequency = Int32.Parse(freq);

            List<Podcast> podcastList = new List<Podcast>();
            podcastList.Add(newPodcast);
            serializer.Serialize(podcastList);
            return newPodcast;
        }
        



    }
}
