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

namespace DataBaseTestApp
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;password= ;database=test;");
        public Form1()
        {
            InitializeComponent();
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void connection_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_connection_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    connection_status.Text = "Connecting to database...";
                    con.Open();
                    connection_status.Text = "\nConnected successfully";
                    button_connection.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    connection_status.Text = "\n" + ex.ToString();
                    throw;
                }
                
            }
            else
            {
                con.Close();
                connection_status.Text = "Disconnected";
                button_connection.Text = "Connect";
            }
            

        }
    }
}
