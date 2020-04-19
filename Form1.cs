using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string cs = "server=192.168.0.16;port=3306;username=root;password=SqlAdmin;database=testdb";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            string query = "select * from students";
            MySqlCommand cmd = new MySqlCommand(query, connection); ;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                textBox1.Text+=$"{reader["name"]}  {reader["surname"]}   {reader["group"]}\r\n";
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
