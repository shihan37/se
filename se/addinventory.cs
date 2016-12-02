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
    public partial class addinventory : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public addinventory()
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
                command.CommandText = "insert into inventory (ID,Item,PurchaseDate,RetireDate,Price) values('" + IDtextBox.Text + "','" + ItemtextBox.Text + "','" + PurchaseTimePicker.Text + "','" + RetireTimePicker.Text + "','" + PricetextBox.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("New Inventory Add Successful");
                connection.Close();
                /* Edit data
                 * string query = "update se set ID='"+IDtextBox.Text+"',FirstName='"+FristtextBox.Text+"'"
                 * MessageBox.Show(query);
                 * commanf.CommandText = query ;
                 * command.ExecuteNonQuery();
                 * MessageBox.Show("Data Edit Succseeful");
                 *connection.Close();
                 * 
                 */

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inventory f1 = new inventory();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
