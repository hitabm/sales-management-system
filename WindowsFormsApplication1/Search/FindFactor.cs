using System;
using System.Windows.Forms;
using System.Data;

namespace System_Forush
{
    public partial class FindFactor : Form
    {
        DataBaseConnection dbc;

        public FindFactor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = label6.Text = label7.Text = "-";
            dataGridView1.Rows.Clear();
            if (textBox1.Text != "")
            {
                dbc = new DataBaseConnection();
                string sel = "select stuffcode, stuffname, count, price, description from buys where factornumber = " + textBox1.Text;
                DataTable dt = new DataTable();
                dt = dbc.GetTable(sel);
                foreach (DataRow dr in dt.Rows)
                    if (dt.Rows != null)
                        dataGridView1.Rows.Add(dr.ItemArray);
                sel = "select * from factor where factornumber = " + textBox1.Text;
                label5.Text = dbc.FindRow("factor", "factornumber =" + textBox1.Text, 3);
                label6.Text = dbc.FindRow("factor", "factornumber =" + textBox1.Text, 2);
                label7.Text = dbc.FindRow("factor", "factornumber =" + textBox1.Text, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label5.Text = label6.Text = label7.Text = "-";
            dataGridView1.Rows.Clear();
        }
    }
}
