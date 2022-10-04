using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3.Model
{
    public class Const
    {
        public static Usuario usuarioLogado = new Usuario();
        public static Usuario cadAdmin = new Usuario();
        public static Usuario editUser = new Usuario();
        public static Usuario cadUsuario = new Usuario();
        public static string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
    }
}
