using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using WinForms = System.Windows.Forms;
using System.Windows.Forms;

namespace Backup_XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection("server = LAPTOP-2V1GBPKR; database= LearnHub; integrated security =true");
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var dlg = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dlg.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = dlg.SelectedPath;
                    Backup_button.IsEnabled = true;
                }
            }
        }

        private void Backup_Click(object sender, RoutedEventArgs e)
        {
            string database = con.Database.ToString();
            if (textBox1.Text == string.Empty)
            {
                System.Windows.MessageBox.Show("Ingrese una ubicacion de backup");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + textBox1.Text + "\\"+"database"+"-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Backup realizado exitosamente");
                con.Close();
                Backup_button.IsEnabled = false;
            }
        }

        private void Browse_button2(object sender, RoutedEventArgs e)
        {
            using (var dlg = new System.Windows.Forms.OpenFileDialog())
            {
                dlg.Filter = "SQL SERVER database backup files (*.bak)|*.bak";
                dlg.Title = "Database restore";

                System.Windows.Forms.DialogResult result = dlg.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    textBox2.Text = dlg.FileName;
                    Restore_buttonB.IsEnabled = true;
                }
            }

        }

        private void Restore_button(object sender, RoutedEventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();

            try
            {
                string str1 = string.Format("ALTER DATABASE[" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK '" + textBox2.Text + "' WITH REPLACE;";
                SqlCommand cm2 = new SqlCommand(str2, con);
                cm2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Restauracion de la base de datos exitosa");
                con.Close();
            }
            catch
            {

            }
        }
    }
}
