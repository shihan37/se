using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;;

namespace WindowsFormsApplication1
{
    private OleDbConnection connection = new OleDbConnection();
    public partial class note : Form
    {
        public note()
        {

            connection.ConnectionString = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Shihan\Documents\Database2.accdb; Persist Security Info=False;";
            InitializeComponent();
        }

        private void note_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnote f1 = new addnote();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
