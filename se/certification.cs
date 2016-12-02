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
    public partial class certification : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public certification()
        {
            connection.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Shihan\Documents\Database2.accdb; Persist Security Info=False;";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnew f2 = new addnew();
            this.Hide();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackingcertification f3 = new se.trackingcertification();
            this.Hide();
            f3.ShowDialog();
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            /* return to main page*/
        }

        private void showlist_Click(object sender, EventArgs e)
        {
            showlist f4 = new se.showlist();
            this.Hide();
            f4.ShowDialog();
           /* connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from se";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inventory f5 = new inventory();
            this.Hide();
            f5.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            note f6 = new note();
            this.Hide();
            f6.ShowDialog();
        }
    }
}
