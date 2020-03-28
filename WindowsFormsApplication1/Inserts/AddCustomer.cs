using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class AddCustomer : Form
    {
        DataBaseConnection dbc;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dbc = new DataBaseConnection();
            string[] values = new string[3] { textBox1.Text, textBox2.Text, textBox3.Text };
            if (dbc.InsertQuery("Customer", values))
            {
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                MessageBox.Show(".مشتری جدید اضافه گردید");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
