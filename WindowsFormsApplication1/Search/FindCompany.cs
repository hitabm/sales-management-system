using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class FindCompany : Form
    {
        DataBaseConnection dbc;

        public FindCompany()
        {
            InitializeComponent();
            dbc = new DataBaseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sel;
            if (radioButton1.Checked)
                sel = "select * from Company where CompanyID like '%" + textBox1.Text + "%'";
            else
                sel = "select * from Company where CompanyName like N'%" + textBox1.Text + "%'";
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dbc.SelectQuery(sel);
        }
    }
}
