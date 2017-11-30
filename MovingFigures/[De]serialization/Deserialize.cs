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

namespace MovingFigures._De_serialization
{
    class Deserialize
    {
        private byte[] bytes;

        public object Binary_To(string filepath)
        {
            try
            {
                bytes = File.ReadAllBytes(filepath);
                MemoryStream xStream = new MemoryStream(bytes);
                BinaryFormatter xFormatter = new BinaryFormatter();

                return xFormatter.Deserialize(xStream);
            }
            catch (DeserializeException e)
            {
                MessageBox.Show("Something wrong with input data..." + '\n' + e.Message);
                FormView.log.Error("Something wrong with input data..." + '\n' + e.Message);
            }
            return null;
        }

        public object JSON_To(string filepath)
        {
            MemoryStream xStream;

            string s = File.ReadAllText(filepath);
            var r = new System.Web.Script.Serialization.JavaScriptSerializer().DeserializeObject(s);

            bytes = Convert.FromBase64String(r.ToString());
            xStream = new MemoryStream(bytes);
            BinaryFormatter xFormatter = new BinaryFormatter();
            try
            {
                object o = xFormatter.Deserialize(xStream);
                xStream.Close();

                return o;
            }
            catch (DeserializeException e)
            {
                MessageBox.Show("Something wrong with input data..." + '\n' + e.Message);
                FormView.log.Error("Something wrong with input data..." + '\n' + e.Message);
            }
            return null;

        }


        public object XML_To(string filePath)
        {
            string s = File.ReadAllText(filePath);

            using (XmlReader reader = XmlReader.Create(new StringReader(s)))
            {
                try
                {
                    while (reader.Read())
                    {
                        if (reader.Name == "List")
                        {
                            string val = reader.ReadElementContentAsString();

                            bytes = Convert.FromBase64String(val);
                            MemoryStream mem = new MemoryStream(bytes);
                            BinaryFormatter xFormatter = new BinaryFormatter();

                            object o = xFormatter.Deserialize(mem);

                            mem.Close();
                            return o;
                        }
                    }
                }

                catch (System.Xml.XmlException e)
                {
                    MessageBox.Show("Something wrong with input data..." + '\n' + e.Message);
                    FormView.log.Error("Something wrong with input data..." + '\n' + e.Message);
                }
                catch (DeserializeException e)
                {
                    MessageBox.Show("Something wrong with input data..." + '\n' + e.Message);
                    FormView.log.Error("Something wrong with input data..." + '\n' + e.Message);
                }
            }
            return null;
        }




    }
}
