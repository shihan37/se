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
    public partial class trackingcertification : Form
        
    {
        private OleDbConnection connection = new OleDbConnection();
        public trackingcertification()
        {
            connection.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Shihan\Documents\Database2.accdb; Persist Security Info=False;";
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
    
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int count = 0;
             connection.Open();
             OleDbCommand command = connection.CreateCommand();
             command.CommandType = CommandType.Text;
             command.CommandText = "select * from se where ID='" + IDtextbox.Text + "'";
             command.ExecuteNonQuery();
             DataTable dt = new DataTable();
             OleDbDataAdapter da = new OleDbDataAdapter(command);
             da.Fill(dt);
             count = Convert.ToInt32(dt.Rows.Count.ToString());
             dataGridView1.DataSource = dt;
             connection.Close();
             if (count == 0)
             {
                 MessageBox.Show("Invaild ID");
             }
             
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            certification f1 = new certification();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
