using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml;
using System.Xml.Serialization;

namespace DataAccess
{
    public class SerializerForXml
    {

        public void Serialize(List<Podcast> podCastList)
        {


            try {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));


            }

            catch(Exception e)
            {
                throw new SerializerException ("Podcast.xml", "You could not serialize to the file");
                
            }


        }
    }
}
