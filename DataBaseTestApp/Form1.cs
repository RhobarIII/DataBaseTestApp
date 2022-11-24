using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace DataBaseTestApp
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; user=root;password= ;database=test;");

        private const string databseNotConnectedInfo = "Database is not connected";
        private const string databseConnectedInfo = "Database is connected";

        private const string badQueryInfo = "Query is incorrect";
        private const string goodQueryInfo = "Your Query finished with success";



        private const string databaseButtonActive = "Show Database";
        private const string databaseButtonInActive = "Hide Database";

        private const string emptyTable = "Your Table is empty";


        private Color databaseNotConnectedColor = Color.Red;
        private Color databaseConnectedColor = Color.Green;


        public Form1()
        {
            InitializeComponent();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            connectionStatus.Text = databseNotConnectedInfo;
            connectionStatus.ForeColor = databaseNotConnectedColor;
            InfoLabel.Visible = false;
            button_ShowDatabase.Text = databaseButtonActive;
        }

        private void button_connection_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    connectionStatus.Text = databseConnectedInfo;
                    connectionStatus.ForeColor = databaseConnectedColor;
                    button_connection.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    DisplayInfo(ex.ToString(),MessageType.error);
                    connectionStatus.ForeColor = databaseNotConnectedColor;
                    throw;
                }

            }
            else
            {
                con.Close();
                connectionStatus.Text = databseNotConnectedInfo;
                connectionStatus.ForeColor = databaseNotConnectedColor;
                button_connection.Text = "Connect";
            }


        }

        private void button_query_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                DisplayInfo(databseNotConnectedInfo, MessageType.error);
                return;
            }

            string query = queryPanel.Text;

            MySqlCommand command = new MySqlCommand(query, con);
            command.CommandTimeout = 60;


            try
            {
                command.ExecuteNonQuery();
                DisplayInfo(goodQueryInfo, MessageType.info);
                queryPanel.Clear();
            }
            catch(Exception ex)
            {
                DisplayInfo(badQueryInfo, MessageType.error);
            }
        }

        private void button_ShowDatabase_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                DisplayInfo(databseNotConnectedInfo, MessageType.error);
                return;
            }
            else if(tableDisplay.ColumnCount != 0)
            {
                tableDisplay.Columns.Clear();
                tableDisplay.Rows.Clear();
                button_ShowDatabase.Text = databaseButtonActive;
                return;
            }

            con.Close();
            con.Open();


            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, con);

            MySqlDataReader reader = command.ExecuteReader();


            if(reader.FieldCount == 0)
            {
                DisplayInfo(emptyTable, MessageType.warrning);
                return;
            }

            tableDisplay.Columns.Add("id", "id");
            tableDisplay.Columns.Add("firstname", "firstname");
            tableDisplay.Columns.Add("lastname", "lastname");

            while (reader.Read())
            {
                tableDisplay.Rows.Add((int)reader["id"], (string)reader["firstname"], (string)reader["lastname"]);
            }
            button_ShowDatabase.Text = databaseButtonInActive;
        }




        private void DisplayInfo(string infoMessage, MessageType messageType)
        {
            if (!InfoLabel.Visible)
                InfoLabel.Visible = true;

            InfoLabel.Text = infoMessage;
            InfoLabel.ForeColor = SelectColor(messageType);
        }

        private Color SelectColor(MessageType typeOfMessage)
        {
            switch (typeOfMessage)
            {
                case MessageType.info:
                    return Color.Black;
                case MessageType.warrning:
                    return Color.Orange;
                case MessageType.error:
                    return Color.Red;
            }

            return Color.Black;
        }
    }

    public enum MessageType
    {
        info,
        warrning,
        error
    }
}
