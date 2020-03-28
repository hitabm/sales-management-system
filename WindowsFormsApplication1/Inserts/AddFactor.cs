using System;
using System.Drawing;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class AddFactor : Form
    {
        DataBaseConnection dbc;
        int FNumber;

        public AddFactor(int FactorNumber)
        {
            InitializeComponent();
            label5.Text += FactorNumber;
            FNumber = FactorNumber;
        }

        private void AddFactor_SizeChanged(object sender, EventArgs e)
        {
            DataGV.Size = new Size(DataGV.Size.Width, Size.Height - 116);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dbc = new DataBaseConnection();
            bool inserted = true;
            string type = (PaymentTypeBox.Checked == true) ? "اقساطی" : "نقدی";
            string[] values = new string[4] { FNumber.ToString(), DateField.Text, type, CustomerField.Text };
            if (dbc.InsertQuery("Factor", values))
                for (int i = 0; i < DataGV.Rows.Count - 1;)
                {
                    string[] vals = new string[6] { FNumber.ToString(), DataGV.Rows[i].Cells[0].Value.ToString(), DataGV.Rows[i].Cells[1].Value.ToString(), DataGV.Rows[i].Cells[2].Value.ToString(), DataGV.Rows[i].Cells[3].Value.ToString(), "" };
                    if (DataGV.Rows[i].Cells[4].Value != null)
                        vals[5] = DataGV.Rows[i].Cells[4].Value.ToString();
                    if (dbc.InsertQuery("Buys", vals)) i++;
                    else
                    {
                        MessageBox.Show(".خطایی رخ داده است، لطفا مجددا تلاش نمایید");
                        inserted = false;
                        break;
                    }
                }
            if (inserted)
            {
                MessageBox.Show(".فاکتور با موفقیت درج شد");
                Close();
            }
        }
    }
}
