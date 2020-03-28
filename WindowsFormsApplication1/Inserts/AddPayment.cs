using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class AddPayment : Form
    {
        DataBaseConnection dbc;

        public AddPayment()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dbc = new DataBaseConnection();
            string[] values = new string[4] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            if (dbc.InsertQuery("Payments", values))
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                MessageBox.Show(".پرداخت جدید درج گردید");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
