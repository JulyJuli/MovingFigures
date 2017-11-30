using log4net;
using MovingFigures._De_serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace MovingFigures
{

    [Serializable]
    public partial class FormView : Form
    {

        public static Graphics g;
        private Point maxPoint;
        private List<Figures> actions;
        private Serialize s;
        private Deserialize ds;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FormView()
        {
            InitializeComponent();

            actions = new List<Figures>();

            s = new Serialize();
            ds = new Deserialize();

            maxPoint = new Point(320, 200);


            log4net.Config.XmlConfigurator.Configure();

            //  Console.WriteLine(System.Diagnostics.FileVersionInfo.GetVersionInfo(@"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\RandomizerLib\v4.0_1.0.0.0__1dd8ef84a648889e\RandomizerLib.dll"));
        }


        private void Circle_Click(object sender, EventArgs e)
        {

            actions.Add(new Circle("Circle", Color.Red));
            mainTree.Nodes.Add(circleB.Text).Tag = actions.Last();
           
        }


        private void Square_Click(object sender, EventArgs e)
        {

            actions.Add(new Square("Square", Color.BlueViolet));
            mainTree.Nodes.Add(squareB.Text).Tag = actions.Last();

        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            
            actions.Add(new Triangle("Triangle", Color.DarkCyan));
            mainTree.Nodes.Add(triangleB.Text).Tag = actions.Last();
        }

        private void PictureBoxPaint(object sender, PaintEventArgs e)
        {
            Task task;

            g = e.Graphics;

            foreach (Figures f in actions)
            {

                if (f.Type.Equals("Square"))
                {

                    task = Task.Factory.StartNew(() => f.Draw(g));
                    task.Wait();

                    f.Move(maxPoint);
                    if (f.kickFlag) f.Kick((Figures)mainTree.SelectedNode.Tag, actions);
                }

                else if (f.Type.Equals("Circle"))
                {
                    task = Task.Factory.StartNew(() => f.Draw(g));
                    task.Wait();

                    f.Move(maxPoint);
                    if (f.kickFlag) f.Kick((Figures)mainTree.SelectedNode.Tag, actions);
                }
                else if (f.Type.Equals("Triangle"))
                {
                    task = Task.Factory.StartNew(() => f.Draw(g));
                    task.Wait();

                    f.Move(maxPoint);
                    if (f.kickFlag) f.Kick((Figures)mainTree.SelectedNode.Tag, actions);
                }
               
              
            }
        }



            private void TimerView_Tick(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            Figures tmp = (Figures)mainTree.SelectedNode.Tag;
            tmp.flag = !tmp.flag;
        }


        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(saveFile.FileName))
                {
                    case ".xml":
                        s.To_XML(actions, saveFile.FileName);
                        break;
                    case ".bin":
                        s.To_Binary(actions, saveFile.FileName);
                        break;
                    case ".json":
                        s.To_JSON(actions, saveFile.FileName);
                        break;
                    default:
                        break;
                }

            }

        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Figures> tmp;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tmp = new List<Figures>();
                    switch (Path.GetExtension(openFile.FileName))
                    {

                        case ".xml":

                            tmp.AddRange((List<Figures>)ds.XML_To(openFile.FileName));
                            LoadElementsInTreeView(tmp);
                            break;

                        case ".bin":

                            tmp.AddRange((List<Figures>)ds.Binary_To(openFile.FileName));
                            LoadElementsInTreeView(tmp);
                            break;

                        case ".json":

                            tmp.AddRange((List<Figures>)ds.JSON_To(openFile.FileName));
                            LoadElementsInTreeView(tmp);
                            break;

                        default:
                            throw new DeserializeException();

                    }
                }

                catch (System.ArgumentNullException)
                {
                    MessageBox.Show("Invalid file extension." + '\n' + "File should be .bin, .json or .xml. Check it!");
                    log.Error("Something wrong with input data: System.ArgumentNullException");
                }
                
                catch (DeserializeException)
                {
                    MessageBox.Show("Invalid file extension." + '\n' + "File should be .bin, .json or .xml. Check it!");
                    log.Error("Invalid file extension.");
                }

            }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlusB_Click(object sender, EventArgs e)
        {
            Figures tmp = (Figures)mainTree.SelectedNode.Tag;
            if (!tmp.kickFlag) tmp.kickFlag = !tmp.kickFlag;

            tmp.OnKick += Utils.MyBeep;

        }

        private void MinusB_Click(object sender, EventArgs e)
        {
            Figures tmp = (Figures)mainTree.SelectedNode.Tag;

            //if (tmp.kickFlag) tmp.kickFlag = !tmp.kickFlag;
            tmp.OnKick -= Utils.MyBeep;

        }

        private void LoadElementsInTreeView(List<Figures> tmp)
        {

            foreach (Figures f in tmp)
            {
                actions.Add(f);
                mainTree.Nodes.Add(actions.Last().Type).Tag = actions.Last();
            }

        }

       
        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languageComboBox.SelectedItem.ToString() == "English")
            {
                RuntimeLocalizer.ChangeCulture(this, "en");
            }
            else if (languageComboBox.SelectedItem.ToString() == "Русский")
            {
                RuntimeLocalizer.ChangeCulture(this,  "ru");
              
            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            languageComboBox.Items.Add("Русский");
            languageComboBox.Items.Add("English");

            languageComboBox.SelectedIndex = 0;
        }

    }

}
