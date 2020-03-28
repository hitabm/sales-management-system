namespace System_Forush
{
    partial class AddFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFactor));
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.شماره_کالا = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نام_کالا = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تعداد = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.قیمت_واحد = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.توضیحات = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateField = new System.Windows.Forms.TextBox();
            this.CustomerField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PaymentTypeBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToOrderColumns = true;
            this.DataGV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.شماره_کالا,
            this.نام_کالا,
            this.تعداد,
            this.قیمت_واحد,
            this.توضیحات});
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGV.Location = new System.Drawing.Point(0, 77);
            this.DataGV.Name = "DataGV";
            this.DataGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGV.RowHeadersWidth = 55;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGV.Size = new System.Drawing.Size(544, 334);
            this.DataGV.TabIndex = 0;
            // 
            // شماره_کالا
            // 
            this.شماره_کالا.HeaderText = "شماره کالا";
            this.شماره_کالا.Name = "شماره_کالا";
            this.شماره_کالا.Width = 80;
            // 
            // نام_کالا
            // 
            this.نام_کالا.HeaderText = "نام کالا";
            this.نام_کالا.Name = "نام_کالا";
            this.نام_کالا.Width = 80;
            // 
            // تعداد
            // 
            this.تعداد.HeaderText = "تعداد";
            this.تعداد.Name = "تعداد";
            this.تعداد.Width = 80;
            // 
            // قیمت_واحد
            // 
            this.قیمت_واحد.HeaderText = "قیمت واحد";
            this.قیمت_واحد.Name = "قیمت_واحد";
            this.قیمت_واحد.Width = 80;
            // 
            // توضیحات
            // 
            this.توضیحات.HeaderText = "توضیحات";
            this.توضیحات.Name = "توضیحات";
            this.توضیحات.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "صدور فاکتور جدید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاریخ:";
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(14, 51);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(100, 20);
            this.DateField.TabIndex = 3;
            // 
            // CustomerField
            // 
            this.CustomerField.Location = new System.Drawing.Point(203, 51);
            this.CustomerField.Name = "CustomerField";
            this.CustomerField.Size = new System.Drawing.Size(100, 20);
            this.CustomerField.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام مشتری:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(426, 48);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "ذخیره";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PaymentTypeBox
            // 
            this.PaymentTypeBox.AutoSize = true;
            this.PaymentTypeBox.Location = new System.Drawing.Point(436, 20);
            this.PaymentTypeBox.Name = "PaymentTypeBox";
            this.PaymentTypeBox.Size = new System.Drawing.Size(65, 17);
            this.PaymentTypeBox.TabIndex = 10;
            this.PaymentTypeBox.Text = "اقساطی";
            this.PaymentTypeBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(63, 17);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "شماره: ";
            // 
            // AddFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaymentTypeBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerField);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 200);
            this.Name = "AddFactor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صدور فاکتور جدید";
            this.SizeChanged += new System.EventHandler(this.AddFactor_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateField;
        private System.Windows.Forms.TextBox CustomerField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox PaymentTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn شماره_کالا;
        private System.Windows.Forms.DataGridViewTextBoxColumn نام_کالا;
        private System.Windows.Forms.DataGridViewTextBoxColumn تعداد;
        private System.Windows.Forms.DataGridViewTextBoxColumn قیمت_واحد;
        private System.Windows.Forms.DataGridViewTextBoxColumn توضیحات;
    }
}