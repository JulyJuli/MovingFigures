using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MovingFigures
{
    class Serialize
    {

      //  private byte[] bytes;

        public void To_Binary(object objToBin, string filepath)
        {
            MemoryStream xStream = new MemoryStream();
            BinaryFormatter xFormatter = new BinaryFormatter();
            xFormatter.Serialize(xStream, objToBin);
            File.WriteAllBytes(filepath, xStream.ToArray());
        }

      


        public void To_JSON(object o, string filepath)
        {

            MemoryStream xStream = new MemoryStream();
            BinaryFormatter xFormatter = new BinaryFormatter();
            xFormatter.Serialize(xStream, o);
            var data = Convert.ToBase64String(xStream.ToArray());
            var json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(data);
            File.WriteAllText(filepath, json);

        }


       

        public void To_XML(object o, string filepath)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Figures));

            MemoryStream xStream = new MemoryStream();
            BinaryFormatter xFormatter = new BinaryFormatter();
            xFormatter.Serialize(xStream, o);
            var data = Convert.ToBase64String(xStream.ToArray());

            XmlTextWriter writer = new XmlTextWriter(filepath, Encoding.UTF32);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Figures");
            writer.WriteStartElement("List");
            writer.WriteString(data);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.Close();


        }
    }
}


