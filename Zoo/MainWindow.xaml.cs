using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
//New Library added
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Net;
using System.Data.Common;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //create a SqlConnection by passing the connection string
            //SqlConnection connection = new SqlConnection("Data Source=localhost;Persist Security Info=True;Integrated Security=False;User ID=SYSTEM;Password=amazon123;");

            //Open sql connection           
            //connection.Open();

            //Create  SqlCommand object and the the sql query
            //SqlCommand command = new SqlCommand("select * from animals)", connection);

            //DataTable dt = new DataTable();
            //dt.Load(command.ExecuteReader());
            //dtGrid.DataContext = dt;
            //MessageBox.Show("Successfully retrieved data", "Success");

            //string connectionString = "Data Source=localhost:1521;Persist Security Info=True;User ID=SYSTEM;Password=amazon123";
            //string connectionString = "User Id=SYSTEM;Password=amazon123;Data Source=localhost";
            string connectionString = "Data Source=XE;User Id=SYSTEM;Password=amazon123;Connection Timeout=600;";
            //string connectionString = "DATA SOURCE=jules_laptop:1521/xe;USER ID=SYSTEM;PASSWORD=amazon123";
            //string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= SYSTEM;Password=amazon123;";
            using (OracleConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connected to Oracle database!");
                    // Perform your database operations here
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to Oracle database: " + ex.StackTrace);
                }
            }
        }
    }
}