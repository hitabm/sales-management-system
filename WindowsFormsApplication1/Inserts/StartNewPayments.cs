using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class StartNewPayments : Form
    {
        DataBaseConnection dbc;

        public StartNewPayments()
        {
            InitializeComponent();
        }

        private void StartNewPayments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbc = new DataBaseConnection();
            string statement = "CustomerDebit = CustomerDebit + " + textBox2.Text + " where CustomerID = " + textBox1.Text;
            if (dbc.UpdateQuery("Customer", statement))
                MessageBox.Show(".مبلغ " + textBox2.Text + " ریال به بدهی های مشتری با شماره " + textBox1.Text + " اضافه شد");
            else MessageBox.Show(".متاسفانه هنگام انجام درخواست خطا رخ داده است. لطفا مجددا تلاش فرمایید");
        }
    }
}
