using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace PCView
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            Load += new EventHandler(Form_Load);
        }

        private void Form_Load(object sender, System.EventArgs e)
        {

            Usuario user = new Usuario();
            Sistema sys = new Sistema();

            labelResultName.Text = user.getLoggedUserName();
            labelResultUser.Text = user.getLoggedUser();
            labelResultSys.Text = sys.getSystem();
            labelResultSPK.Text = sys.getSPK();
            labelResultVersionSO.Text = sys.getSOVersion();
            labelResultVersionCLR.Text = sys.getVersionCLR();

            string regkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            listBoxSoftware.Items.Clear();

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regkey))
            {
                var query = from a in
                                key.GetSubKeyNames()
                            let r = key.OpenSubKey(a)
                            select new
                            {
                                Application = r.GetValue("DisplayName")
                            };
                foreach (var item in query)
                {
                    if (item.Application != null)
                        listBoxSoftware.Items.Add(item.Application);
                }
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Sistema sys = new Sistema();
            Usuario user = new Usuario();

            string pathFile = @"\\172.24.8.60\Server\Fields\checklist\" + sys.getHostName() +"_"+ sys.getDate() + ".txt";

            try

            {
                using (FileStream fileStream = File.Create(pathFile))

                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))

                    {                        
                        streamWriter.Write("+---------------------------------------------------------+"+"\r\n");
                        streamWriter.Write("|                                                         |"+"\r\n");
                        streamWriter.Write("|                   Informações do Usuário                |"+"\r\n");
                        streamWriter.Write("|                                                         |"+"\r\n");
                        streamWriter.Write("+---------------------------------------------------------+"+"\r\n");
                        streamWriter.Write("Nome:" + user.getLoggedUserName() + "\r\n");
                        streamWriter.Write("Usuário:" + user.getLoggedUser() + "\r\n");
                        streamWriter.Write("+---------------------------------------------------------+" + "\r\n");
                        streamWriter.Write("|                                                         |" + "\r\n");
                        streamWriter.Write("|                    Informações do Sistema               |" + "\r\n");
                        streamWriter.Write("|                                                         |" + "\r\n");
                        streamWriter.Write("+---------------------------------------------------------+" + "\r\n");
                        streamWriter.Write("Sistema Operacional:" + sys.getSystem() + "\r\n");
                        streamWriter.Write("Service Pack:" + sys.getSPK() + "\r\n");
                        streamWriter.Write("Versão SO:" + sys.getSOVersion() + "\r\n");
                        streamWriter.Write("Versão CLR:" + sys.getVersionCLR() + "\r\n");
                        streamWriter.Write("+---------------------------------------------------------+" + "\r\n");
                        streamWriter.Write("|                                                         |" + "\r\n");
                        streamWriter.Write("|                     Lista de Software                   |" + "\r\n");
                        streamWriter.Write("|                                                         |" + "\r\n");
                        streamWriter.Write("+---------------------------------------------------------+" + "\r\n");

                        string regkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

                        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regkey))
                        {
                            var query = from a in
                                            key.GetSubKeyNames()
                                        let r = key.OpenSubKey(a)
                                        select new
                                        {
                                            Application = r.GetValue("DisplayName")
                                        };
                            foreach (var item in query)
                            {
                                if (item.Application != null)

                                streamWriter.Write(item.Application + "\r\n");
                                
                            }                            
                        }
                        streamWriter.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo criado com sucesso!");    
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Você realmente quer cancelar?", "Cancel",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button2);
            if (cancel == DialogResult.Yes)
                Application.Exit();
        
        }
    }
}
