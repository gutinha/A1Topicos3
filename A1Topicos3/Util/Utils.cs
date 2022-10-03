using A1Topicos3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3.Util
{
    public class Utils
    {
        public static void logSair()
        {
            dbContext db = new dbContext();
            try
            {
                db.Log.Add(new Log(DateTime.Now, "Usuário saiu", Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Procure o administrador!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.LogSystem.Add(new LogSystem(DateTime.Now, ex.Message, Const.usuarioLogado.nome));
                db.SaveChanges();
            }
        }

        public static void logEntrar()
        {
            dbContext db = new dbContext();
            try
            {
                db.Log.Add(new Log(DateTime.Now, "Usuário entrou", Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                try
                {
                    db.LogSystem.Add(new LogSystem(DateTime.Now, ex.Message, Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Procure o administrador do sistema!", "Erro crítico!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
