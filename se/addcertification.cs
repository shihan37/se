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
    public partial class addnew : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        string Status;
        public addnew()
        {
            connection.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Shihan\Documents\Database2.accdb; Persist Security Info=False;";
            InitializeComponent();
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrirsttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LasttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
          
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into se (ID,FirstName,LastName,CertificationLevel,ClassCompleteDate,ExpirationDate,CertificationStatus) values('" + IDtextBox.Text + "','" + FrirsttextBox.Text + "','" + LasttextBox.Text + "','"+LeveltextBox.Text+"','"+CdateTimePicker.Text+"','"+EdateTimePicker.Text+"','"+Status+"')";
                command.ExecuteNonQuery();
                MessageBox.Show("New Certificaiton Add Successful");
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

        private void Back_Click(object sender, EventArgs e)
        {
            certification f1 = new certification();
            this.Hide();
            f1.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompletetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpirationtextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Status = "available";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Status = "available";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Status = "expiration";
        }

        private void IDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        
        }
    }
    }

