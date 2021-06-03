using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class MensajesGuardados
    {
        private static List<Mensaje> misMensajes;
        static MensajesGuardados()
        {
            misMensajes = new List<Mensaje>();
        }
        public static Mensaje Mensaje
        {
            set
            {
                misMensajes += value;
            }
        }
        public static string MostrarMensajes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Mensaje item in misMensajes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
