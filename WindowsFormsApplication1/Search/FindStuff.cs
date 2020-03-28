using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class FindStuff : Form
    {
        DataBaseConnection dbc;

        public FindStuff()
        {
            InitializeComponent();
            dbc = new DataBaseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sel;
            if (radioButton1.Checked)
                sel = "select * from Stuff where StuffCode like '%" + textBox1.Text + "%'";
            else
                sel = "select * from Stuff where StuffName like N'%" + textBox1.Text + "%'";
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dbc.SelectQuery(sel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            dataGridView1.DataSource = null;
        }
    }
}
