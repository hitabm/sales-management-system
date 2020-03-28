using System;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class AddStuff : Form
    {
        DataBaseConnection dbc;

        public AddStuff()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dbc = new DataBaseConnection();
            string[] values = new string[4] { textBox1.Text, textBox2.Text, textBox3.Text , textBox4.Text };
            if (dbc.InsertQuery("Stuff", values))
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                MessageBox.Show(".کالای جدید درج شد");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
