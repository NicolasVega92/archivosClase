using Entities;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FrmPrincipal
{
    public partial class FrmCargaMensaje : Form
    {
        
        public FrmCargaMensaje()
        {
            InitializeComponent();
        }

        private void FrmCargaMensaje_Load(object sender, EventArgs e)
        {
            //ESTO ES PARA TXT
            //foreach (string item in Directory.GetFiles(Environment.CurrentDirectory, "*.txt")) //.txt", true) concatena los siguientes mensajes
            //{
            //    using (StreamReader reader = new StreamReader(item))
            //    {
            //        rbtCargaMensaje.Text += reader.ReadToEnd();
            //    }
            //};

            //PARA XML
            //foreach (string item in Directory.GetFiles(Environment.CurrentDirectory, "*.xml")) //.txt", true) concatena los siguientes mensajes
            //{
            //    XmlTextReader xmlTextReader = new XmlTextReader(item); //es la URL el item
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Mensaje));
            //    rbtCargaMensaje.Text += (Mensaje)xmlSerializer.Deserialize(xmlTextReader);
            //    xmlTextReader.Close();
            //    rbtCargaMensaje.Text += "\n";
            //};

            //PARA BINARIO
            foreach (string item in Directory.GetFiles(Environment.CurrentDirectory, "*.dat")) //.txt", true) concatena los siguientes mensajes
            {
                FileStream archivo = new FileStream(item, FileMode.Open);//path y formato de acceso
                BinaryFormatter serializer = new BinaryFormatter();
                rbtCargaMensaje.Text += (Mensaje)serializer.Deserialize(archivo);
                archivo.Close();
                rbtCargaMensaje.Text += "\n";
            };


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
