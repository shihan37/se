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
    public partial class inventory : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public inventory()
        {
            connection.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Shihan\Documents\Database2.accdb; Persist Security Info=False;";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            track f2 = new track();
            this.Hide();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            addinventory f1 = new addinventory();
            this.Hide();
            f1.ShowDialog();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            remove  f3 = new remove();
            this.Hide();
            f3.ShowDialog();
        }
    }
}
