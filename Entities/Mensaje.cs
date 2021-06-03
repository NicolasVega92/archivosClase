using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entities
{
    [Serializable]
    public class Mensaje
    {
        public string Nombre { get; set; }
        public string Destino { get; set; }
        public string MensajeFinal { get; set; }
        public DateTime Fecha { get; set; }
        public Mensaje() //ES NECESARIO PARA EL Serialize 
        {
        }
        public Mensaje(string nombre, string destino, string mensajeFinal, DateTime fecha)
        {
            Nombre = nombre;
            Destino = destino;
            MensajeFinal = mensajeFinal;
            Fecha = fecha;
        }
        public override string ToString()
        {
            return MostrarCampos();
        }
        public string MostrarCampos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Fecha:{Fecha}");
            sb.Append($"Emisor: {Nombre}");
            sb.Append($"Destinatario: {Destino}");
            sb.Append($"Mensaje: {MensajeFinal}");
            return sb.ToString();
        }
        public static bool operator ==(List<Mensaje> listaMensaje, Mensaje mensaje)
        {
            bool retorno = false;
            foreach (Mensaje item in listaMensaje)
            {
                if (mensaje.MensajeFinal.Equals(item.MensajeFinal))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(List<Mensaje> listaMensaje, Mensaje mensaje)
        {
            return !(listaMensaje == mensaje);
        }
        public static List<Mensaje> operator +(List<Mensaje> misMensajes, Mensaje mensaje)
        {
            if(misMensajes != mensaje)
            {
                misMensajes.Add(mensaje);
            }
            return misMensajes;
        }
        public bool Guardar() //se guarda en la carpeta BIN/Debug dentro del Form
        {
            StreamWriter streamWriter = new StreamWriter($"{Nombre}.txt");
            streamWriter.WriteLine(MostrarCampos().Replace('\n',';'));
            streamWriter.Close();
            return File.Exists($"{Nombre}.txt"); //retorna TRUE si lo pudo guardar, es decir existe esta ruta
        }
        public void GuardarXml()
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Nombre}.xml", Encoding.UTF8);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Mensaje));
            xmlSerializer.Serialize(xmlTextWriter, this);
            xmlTextWriter.Close();

        }
        public void GuardarBynary()
        {
            FileStream fileStream = new FileStream($"{Nombre}.dat", FileMode.Create);//path y formato de acceso
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fileStream, this);
            fileStream.Close();
        }

    }
}
