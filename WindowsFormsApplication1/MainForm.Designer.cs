namespace System_Forush
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DataView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Factor = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.FindFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewStuff = new System.Windows.Forms.ToolStripMenuItem();
            this.FindStuff = new System.Windows.Forms.ToolStripMenuItem();
            this.Payments = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.StartNewPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCustomerStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.Companies = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCompanyStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TableType = new System.Windows.Forms.ComboBox();
            this.SelectTable = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataView.Location = new System.Drawing.Point(0, 24);
            this.DataView.Name = "DataView";
            this.DataView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataView.Size = new System.Drawing.Size(522, 258);
            this.DataView.TabIndex = 2;
            this.DataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Factor,
            this.Warehouse,
            this.Payments,
            this.Customers,
            this.Companies,
            this.About,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Factor
            // 
            this.Factor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewFactor,
            this.FindFactor});
            this.Factor.Name = "Factor";
            this.Factor.Size = new System.Drawing.Size(49, 20);
            this.Factor.Text = "فاکتور";
            // 
            // AddNewFactor
            // 
            this.AddNewFactor.Name = "AddNewFactor";
            this.AddNewFactor.Size = new System.Drawing.Size(162, 22);
            this.AddNewFactor.Text = "صدور فاکتور جدید";
            this.AddNewFactor.Click += new System.EventHandler(this.AddNewFactor_Click);
            // 
            // FindFactor
            // 
            this.FindFactor.Name = "FindFactor";
            this.FindFactor.Size = new System.Drawing.Size(162, 22);
            this.FindFactor.Text = "جستجوی فاکتور";
            this.FindFactor.Click += new System.EventHandler(this.FindFactor_Click);
            // 
            // Warehouse
            // 
            this.Warehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewStuff,
            this.FindStuff});
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Size = new System.Drawing.Size(38, 20);
            this.Warehouse.Text = "انبار";
            // 
            // AddNewStuff
            // 
            this.AddNewStuff.Name = "AddNewStuff";
            this.AddNewStuff.Size = new System.Drawing.Size(161, 22);
            this.AddNewStuff.Text = "افزودن کالای جدید";
            this.AddNewStuff.Click += new System.EventHandler(this.AddNewStuff_Click);
            // 
            // FindStuff
            // 
            this.FindStuff.Name = "FindStuff";
            this.FindStuff.Size = new System.Drawing.Size(161, 22);
            this.FindStuff.Text = "جستجوی کالا";
            this.FindStuff.Click += new System.EventHandler(this.FindStuff_Click);
            // 
            // Payments
            // 
            this.Payments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAPayment,
            this.StartNewPayment});
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(96, 20);
            this.Payments.Text = "اقساط مشتریان";
            // 
            // AddAPayment
            // 
            this.AddAPayment.Name = "AddAPayment";
            this.AddAPayment.Size = new System.Drawing.Size(174, 22);
            this.AddAPayment.Text = "افزودن پرداختی جدید";
            this.AddAPayment.Click += new System.EventHandler(this.AddAPayment_Click);
            // 
            // StartNewPayment
            // 
            this.StartNewPayment.Name = "StartNewPayment";
            this.StartNewPayment.Size = new System.Drawing.Size(174, 22);
            this.StartNewPayment.Text = "شروع اقساط جدید";
            this.StartNewPayment.Click += new System.EventHandler(this.StartNewPayment_Click);
            // 
            // Customers
            // 
            this.Customers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewCustomer,
            this.ViewCustomerStatus});
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(53, 20);
            this.Customers.Text = "مشتری";
            // 
            // AddNewCustomer
            // 
            this.AddNewCustomer.Name = "AddNewCustomer";
            this.AddNewCustomer.Size = new System.Drawing.Size(194, 22);
            this.AddNewCustomer.Text = "افزودن مشتری جدید";
            this.AddNewCustomer.Click += new System.EventHandler(this.AddNewCustomer_Click);
            // 
            // ViewCustomerStatus
            // 
            this.ViewCustomerStatus.Name = "ViewCustomerStatus";
            this.ViewCustomerStatus.Size = new System.Drawing.Size(194, 22);
            this.ViewCustomerStatus.Text = "مشاهده وضعیت مشتری";
            this.ViewCustomerStatus.Click += new System.EventHandler(this.ViewCustomerStatus_Click);
            // 
            // Companies
            // 
            this.Companies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewCompany,
            this.ViewCompanyStatus});
            this.Companies.Name = "Companies";
            this.Companies.Size = new System.Drawing.Size(136, 20);
            this.Companies.Text = "شرکت های طرف قرارداد";
            // 
            // AddNewCompany
            // 
            this.AddNewCompany.Name = "AddNewCompany";
            this.AddNewCompany.Size = new System.Drawing.Size(190, 22);
            this.AddNewCompany.Text = "افزودن شرکت جدید";
            this.AddNewCompany.Click += new System.EventHandler(this.AddNewCompany_Click);
            // 
            // ViewCompanyStatus
            // 
            this.ViewCompanyStatus.Name = "ViewCompanyStatus";
            this.ViewCompanyStatus.Size = new System.Drawing.Size(190, 22);
            this.ViewCompanyStatus.Text = "مشاهده وضعیت شرکت";
            this.ViewCompanyStatus.Click += new System.EventHandler(this.ViewCompanyStatus_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(89, 20);
            this.About.Text = "درباره نرم افزار";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 20);
            this.Exit.Text = "خروج";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(220, 288);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(105, 21);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "افزودن رکورد جدید";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TableType
            // 
            this.TableType.AutoCompleteCustomSource.AddRange(new string[] {
            "فاکتور ها",
            "اجناس",
            "مشتریان",
            "اقساط",
            "شرکت ها"});
            this.TableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableType.FormattingEnabled = true;
            this.TableType.Items.AddRange(new object[] {
            "فاکتور ها",
            "اجناس",
            "مشتریان",
            "اقساط",
            "شرکت ها"});
            this.TableType.Location = new System.Drawing.Point(12, 288);
            this.TableType.Name = "TableType";
            this.TableType.Size = new System.Drawing.Size(121, 21);
            this.TableType.TabIndex = 17;
            // 
            // SelectTable
            // 
            this.SelectTable.Location = new System.Drawing.Point(139, 288);
            this.SelectTable.Name = "SelectTable";
            this.SelectTable.Size = new System.Drawing.Size(75, 21);
            this.SelectTable.TabIndex = 18;
            this.SelectTable.Text = "نمایش جدول";
            this.SelectTable.UseVisualStyleBackColor = true;
            this.SelectTable.Click += new System.EventHandler(this.SelectTable_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(382, 296);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "حیتا بارسم ممقانی";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(480, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SelectTable);
            this.Controls.Add(this.TableType);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(538, 360);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "سیستم مدیریت فروش";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Factor;
        private System.Windows.Forms.ToolStripMenuItem AddNewFactor;
        private System.Windows.Forms.ToolStripMenuItem FindFactor;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Warehouse;
        private System.Windows.Forms.ToolStripMenuItem FindStuff;
        private System.Windows.Forms.ToolStripMenuItem AddNewStuff;
        private System.Windows.Forms.ToolStripMenuItem Payments;
        private System.Windows.Forms.ToolStripMenuItem AddAPayment;
        private System.Windows.Forms.ToolStripMenuItem StartNewPayment;
        private System.Windows.Forms.ToolStripMenuItem Customers;
        private System.Windows.Forms.ToolStripMenuItem AddNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem ViewCustomerStatus;
        private System.Windows.Forms.ToolStripMenuItem Companies;
        private System.Windows.Forms.ToolStripMenuItem AddNewCompany;
        private System.Windows.Forms.ToolStripMenuItem ViewCompanyStatus;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox TableType;
        private System.Windows.Forms.Button SelectTable;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

