using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace se
{
    public partial class addnote : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public addnote()
        {
            connection.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Shihan\Documents\Database2.accdb; Persist Security Info=False;";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //command.CommandText = "insert into dailynote (Title,Content,date) values('" + titleBox.Text + "','" + contentBox.Text + "','"+ dateTimePicker.Text +"')";
                command.CommandText = "insert into dailynote (Title) values ('" +titleBox.Text+"')";
                command.ExecuteNonQuery();
                MessageBox.Show("Note has been post");
                connection.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            note f1 = new note();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
