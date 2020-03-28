using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class FindCustomer : Form
    {
        DataBaseConnection dbc;

        public FindCustomer()
        {
            InitializeComponent();
            dbc = new DataBaseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sel;
            if (radioButton1.Checked)
                sel = "select * from Customer where CustomerID like '%" + textBox1.Text + "%'";
            else
                sel = "select * from Customer where CustomerName like N'%" + textBox1.Text + "%'";
            if (checkBox1.Checked)
                sel += " and CustomerDebit > 0";
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dbc.SelectQuery(sel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            dataGridView1.DataSource = null;
            checkBox1.Checked = false;
        }
    }
}
