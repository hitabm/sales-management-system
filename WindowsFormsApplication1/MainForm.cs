using System;
using System.Drawing;
using System.Windows.Forms;

namespace System_Forush
{
    public partial class MainForm : Form
    {
        DataBaseConnection dbc;
        int FactorNumber;

        public MainForm()
        {
            InitializeComponent();
            TableType.SelectedItem = "فاکتور ها";
            dbc = new DataBaseConnection();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectTable_Click(sender, e);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":طراحی و ساخت توسط\nحیتا بارسم ممقانی\n\n:وبسایت\nhttp://www.barasm.ir", "درباره نرم افزار");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("آیا خارج میشوید؟", "خروج", MessageBoxButtons.YesNo);
            e.Cancel = (window == DialogResult.No);
        }

        private void SelectTable_Click(object sender, EventArgs e)
        {
            string sel = "select * from ";
            switch (TableType.SelectedItem.ToString())
            {
                case "فاکتور ها":
                    sel += "Factor";
                    break;
                case "اجناس":
                    sel += "Stuff";
                    break;
                case "مشتریان":
                    sel += "Customer";
                    break;
                case "اقساط":
                    sel += "Payments";
                    break;
                case "شرکت ها":
                    sel += "Company";
                    break;
            }
            DataView.ReadOnly = true;
            DataView.DataSource = dbc.SelectQuery(sel);
        }

        private void DataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel;
            string sel = "select * from ";
            switch (TableType.SelectedItem.ToString())
            {
                case "فاکتور ها":
                    cel = DataView.CurrentRow.Cells[0].Value.ToString();
                    sel += "Buys where" + DataView.CurrentRow.Cells[0].ToString() + "=" + cel;
                    break;
                case "اجناس":
                    cel = DataView.CurrentRow.Cells[5].Value.ToString();
                    sel += "Company where" + DataView.CurrentRow.Cells[5].ToString() + "=" + cel;
                    break;
                case "مشتریان":
                    cel = DataView.CurrentRow.Cells[0].Value.ToString();
                    sel += "Payments where" + DataView.CurrentRow.Cells[0].ToString() + "=" + cel;
                    break;
                case "اقساط":
                    cel = DataView.CurrentRow.Cells[1].Value.ToString();
                    sel += "Payments where" + DataView.CurrentRow.Cells[1].ToString() + "=" + cel;
                    break;
                case "شرکت ها":
                    cel = DataView.CurrentRow.Cells[0].Value.ToString();
                    sel += "Stuff where" + DataView.CurrentRow.Cells[0].ToString() + "=" + cel;
                    break;
            }
            DataView.ReadOnly = true;
            DataView.DataSource = dbc.SelectQuery(sel);
        }

        private void AddNewFactor_Click(object sender, EventArgs e)
        {
            FactorNumber = Convert.ToInt32(dbc.LastRow_FirstCell_Value("Factor", "FactorNumber")) + 1;
            AddFactor af = new AddFactor(FactorNumber);
            af.ShowDialog();
        }

        private void AddNewStuff_Click(object sender, EventArgs e)
        {
            AddStuff astf = new AddStuff();
            astf.ShowDialog();
        }

        private void AddAPayment_Click(object sender, EventArgs e)
        {
            AddPayment ap = new AddPayment();
            ap.ShowDialog();
        }

        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer acus = new AddCustomer();
            acus.ShowDialog();
        }

        private void AddNewCompany_Click(object sender, EventArgs e)
        {
            AddCompany acom = new AddCompany();
            acom.ShowDialog();
        }

        private void FindFactor_Click(object sender, EventArgs e)
        {
            FindFactor ff = new FindFactor();
            ff.ShowDialog();
        }

        private void FindStuff_Click(object sender, EventArgs e)
        {
            FindStuff fs = new FindStuff();
            fs.ShowDialog();
        }

        private void StartNewPayment_Click(object sender, EventArgs e)
        {
            StartNewPayments snp = new StartNewPayments();
            snp.ShowDialog();
        }

        private void ViewCustomerStatus_Click(object sender, EventArgs e)
        {
            FindCustomer fcus = new FindCustomer();
            fcus.ShowDialog();
        }

        private void ViewCompanyStatus_Click(object sender, EventArgs e)
        {
            FindCompany fcom = new FindCompany();
            fcom.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            switch (TableType.SelectedItem.ToString())
            {
                case "فاکتور ها":
                    FactorNumber = Convert.ToInt32(dbc.LastRow_FirstCell_Value("Factor", "FactorNumber")) + 1;
                    AddFactor f = new AddFactor(FactorNumber);
                    f.ShowDialog();
                    break;
                case "اجناس":
                    AddStuff s = new AddStuff();
                    s.ShowDialog();
                    break;
                case "مشتریان":
                    AddCustomer c = new AddCustomer();
                    c.ShowDialog();
                    break;
                case "اقساط":
                    AddPayment p = new AddPayment();
                    p.ShowDialog();
                    break;
                case "شرکت ها":
                    AddCompany cm = new AddCompany();
                    cm.ShowDialog();
                    break;
            }
            string sel = "select * from ";
            switch (TableType.SelectedItem.ToString())
            {
                case "فاکتور ها":
                    sel += "Factor";
                    break;
                case "اجناس":
                    sel += "Stuff";
                    break;
                case "مشتریان":
                    sel += "Customer";
                    break;
                case "اقساط":
                    sel += "Payments";
                    break;
                case "شرکت ها":
                    sel += "Company";
                    break;
            }
            DataView.ReadOnly = true;
            DataView.DataSource = dbc.SelectQuery(sel);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://barasm.ir");
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            DataView.Size = new Size(DataView.Size.Width, Size.Height - 102);
            TableType.Location = new Point(TableType.Location.X, Size.Height - 72);
            SelectTable.Location = new Point(SelectTable.Location.X, Size.Height - 72);
            AddBtn.Location = new Point(AddBtn.Location.X, Size.Height - 72);
            linkLabel1.Location = new Point(linkLabel1.Location.X, Size.Height - 72);
            pictureBox1.Location = new Point(pictureBox1.Location.X, Size.Height - 72);
        }
    }
}
