using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace DataAccess
{
    public class SerializerForXml
    {

        public void Serialize(List<Podcast> podCastList)
        {


            try {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));

                //FileStream
                using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, podCastList);
                }
                //StreamWriter writer = new StreamWriter(fileStream);

            }

            catch(Exception e)
            {
                throw new SerializerException ("Podcasts.xml", "You could not serialize the file");
                
            }

            
        }
        public List<Podcast> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open, FileAccess.Read))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch(Exception e)
            {
                throw new SerializerException("Podcasts.xml", "You could not deserialize the file");
            }
        }
    }
}
