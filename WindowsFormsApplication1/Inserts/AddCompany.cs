using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class AddCompany : Form
    {
        DataBaseConnection dbc;

        public AddCompany()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dbc = new DataBaseConnection();
            string[] values = new string[3] { textBox1.Text, textBox2.Text, textBox3.Text };
            if (dbc.InsertQuery("Company", values))
            {
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                MessageBox.Show(".شرکت جدید اضافه شد");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
