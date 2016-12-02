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
    public partial class showlist : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public showlist()
        {
            connection.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Shihan\Documents\Database2.accdb; Persist Security Info=False;";
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();

        }

        private void ShowData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from se";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            certification f1 = new certification();
            this.Hide();
            f1.ShowDialog();
        }

        private void showlist_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
