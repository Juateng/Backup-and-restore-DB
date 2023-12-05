using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Respaldo_base_de_datos
{
    public partial class Form1 : Form
    {
        SqlConnection con=new SqlConnection("server = LAPTOP-2V1GBPKR; database= LearnHub; integrated security =true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            { 
                textBox1.Text = dlg.SelectedPath;
                Backup_button.Enabled = true;
            }
        }

        private void Backup_button_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una ubicacion de backup");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + textBox1.Text + "\\"+"database"+"-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Backup realizado exitosamente");
                con.Close();
                Backup_button.Enabled = false;
            }
        }

        private void Browse_button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                Restore_button.Enabled = true;
            }
        }

        private void Restore_button_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();

            try
            {
                string str1 = string.Format("ALTER DATABASE[" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK '"+ textBox2.Text +"' WITH REPLACE;";
                SqlCommand cm2 = new SqlCommand(str2, con);
                cm2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE ["+ database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Restauracion de la base de datos exitosa");
                con.Close();
            }
            catch
            { 
                
            }
        }
    }
}
