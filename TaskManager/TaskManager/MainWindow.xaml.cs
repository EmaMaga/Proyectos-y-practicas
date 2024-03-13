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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String MyConexion = ConfigurationManager.ConnectionStrings["TaskManager.Properties.Settings.GestionTareasConnectionString"].ConnectionString;
            Connection = new SqlConnection(MyConexion);
        }

        private void Login_Clicked(object sender, RoutedEventArgs e)
        {
            String Username = User.Text;
            int Pass = int.Parse(PassBlock.Password);
            if(CheckLogin(Username,Pass)==true)
            {
                MessageBox.Show("Hello {0}",Username);
            }
            else
            {
                MessageBox.Show("User or password incorrect");
            }

        }

        private bool CheckLogin(String Username, int Pass)
        {
            Connection.Open();
            comandoSQL.Connection = Connection;
            comandoSQL.CommandText = "select * from User where Name='" + Username + "' and Password='"+Pass+"'";
            DR = comandoSQL.ExecuteReader();
            if(DR.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        SqlCommand comandoSQL = new SqlCommand();
        SqlConnection Connection;
        SqlDataReader DR;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
