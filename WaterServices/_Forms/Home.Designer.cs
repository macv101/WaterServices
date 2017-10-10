namespace WaterServices
{
    partial class Home
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
            this.dgvHome = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGridDate = new System.Windows.Forms.DateTimePicker();
            this.txtGridFirstName = new System.Windows.Forms.TextBox();
            this.txtGridLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxGridContainer = new System.Windows.Forms.ComboBox();
            this.cbxGridType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGridVolume = new System.Windows.Forms.ComboBox();
            this.txtGridCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGridSave = new System.Windows.Forms.Button();
            this.btnGridCancel = new System.Windows.Forms.Button();
            this.dtFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.dtFilterTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtGridTime = new System.Windows.Forms.DateTimePicker();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHome
            // 
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.Location = new System.Drawing.Point(12, 61);
            this.dgvHome.MultiSelect = false;
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.ReadOnly = true;
            this.dgvHome.RowHeadersVisible = false;
            this.dgvHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHome.Size = new System.Drawing.Size(672, 269);
            this.dgvHome.TabIndex = 0;
            this.dgvHome.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvHome_RowStateChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search Name";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(286, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name";
            // 
            // dtGridDate
            // 
            this.dtGridDate.Location = new System.Drawing.Point(690, 77);
            this.dtGridDate.Name = "dtGridDate";
            this.dtGridDate.Size = new System.Drawing.Size(122, 20);
            this.dtGridDate.TabIndex = 9;
            // 
            // txtGridFirstName
            // 
            this.txtGridFirstName.Location = new System.Drawing.Point(690, 177);
            this.txtGridFirstName.Name = "txtGridFirstName";
            this.txtGridFirstName.Size = new System.Drawing.Size(122, 20);
            this.txtGridFirstName.TabIndex = 10;
            // 
            // txtGridLastName
            // 
            this.txtGridLastName.Location = new System.Drawing.Point(817, 177);
            this.txtGridLastName.Name = "txtGridLastName";
            this.txtGridLastName.Size = new System.Drawing.Size(118, 20);
            this.txtGridLastName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Container";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(816, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Last Name";
            // 
            // cbxGridContainer
            // 
            this.cbxGridContainer.FormattingEnabled = true;
            this.cbxGridContainer.Location = new System.Drawing.Point(691, 227);
            this.cbxGridContainer.Name = "cbxGridContainer";
            this.cbxGridContainer.Size = new System.Drawing.Size(121, 21);
            this.cbxGridContainer.TabIndex = 19;
            // 
            // cbxGridType
            // 
            this.cbxGridType.FormattingEnabled = true;
            this.cbxGridType.Location = new System.Drawing.Point(817, 227);
            this.cbxGridType.Name = "cbxGridType";
            this.cbxGridType.Size = new System.Drawing.Size(118, 21);
            this.cbxGridType.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Volume";
            // 
            // cbxGridVolume
            // 
            this.cbxGridVolume.FormattingEnabled = true;
            this.cbxGridVolume.Location = new System.Drawing.Point(690, 277);
            this.cbxGridVolume.Name = "cbxGridVolume";
            this.cbxGridVolume.Size = new System.Drawing.Size(245, 21);
            this.cbxGridVolume.TabIndex = 23;
            // 
            // txtGridCompany
            // 
            this.txtGridCompany.Location = new System.Drawing.Point(689, 127);
            this.txtGridCompany.Name = "txtGridCompany";
            this.txtGridCompany.Size = new System.Drawing.Size(246, 20);
            this.txtGridCompany.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Company";
            // 
            // btnGridSave
            // 
            this.btnGridSave.Location = new System.Drawing.Point(860, 307);
            this.btnGridSave.Name = "btnGridSave";
            this.btnGridSave.Size = new System.Drawing.Size(75, 23);
            this.btnGridSave.TabIndex = 27;
            this.btnGridSave.Text = "Save";
            this.btnGridSave.UseVisualStyleBackColor = true;
            // 
            // btnGridCancel
            // 
            this.btnGridCancel.Location = new System.Drawing.Point(779, 307);
            this.btnGridCancel.Name = "btnGridCancel";
            this.btnGridCancel.Size = new System.Drawing.Size(75, 23);
            this.btnGridCancel.TabIndex = 28;
            this.btnGridCancel.Text = "Cancel";
            this.btnGridCancel.UseVisualStyleBackColor = true;
            this.btnGridCancel.Click += new System.EventHandler(this.btnGridCancel_Click);
            // 
            // dtFilterFrom
            // 
            this.dtFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFilterFrom.Location = new System.Drawing.Point(372, 35);
            this.dtFilterFrom.Name = "dtFilterFrom";
            this.dtFilterFrom.Size = new System.Drawing.Size(142, 20);
            this.dtFilterFrom.TabIndex = 29;
            this.dtFilterFrom.ValueChanged += new System.EventHandler(this.dtFilterFrom_ValueChanged);
            // 
            // dtFilterTo
            // 
            this.dtFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFilterTo.Location = new System.Drawing.Point(542, 35);
            this.dtFilterTo.Name = "dtFilterTo";
            this.dtFilterTo.Size = new System.Drawing.Size(142, 20);
            this.dtFilterTo.TabIndex = 30;
            this.dtFilterTo.ValueChanged += new System.EventHandler(this.dtFilterTo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "to";
            // 
            // dtGridTime
            // 
            this.dtGridTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGridTime.Location = new System.Drawing.Point(817, 77);
            this.dtGridTime.Name = "dtGridTime";
            this.dtGridTime.Size = new System.Drawing.Size(118, 20);
            this.dtGridTime.TabIndex = 32;
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(12, 355);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(155, 20);
            this.txtScan.TabIndex = 33;
            this.txtScan.Text = "Scan Code";
            this.txtScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScan.Enter += new System.EventHandler(this.txtScan_Enter);
            this.txtScan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtScan_KeyUp);
            this.txtScan.Leave += new System.EventHandler(this.txtScan_Leave);
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(173, 358);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(10, 13);
            this.lblProductDescription.TabIndex = 34;
            this.lblProductDescription.Text = " ";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Test",
            "Fest",
            "Pest",
            "Fast",
            "Past",
            "Paast"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(12, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Enter Client Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.dtGridTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFilterTo);
            this.Controls.Add(this.dtFilterFrom);
            this.Controls.Add(this.btnGridCancel);
            this.Controls.Add(this.btnGridSave);
            this.Controls.Add(this.txtGridCompany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxGridVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGridType);
            this.Controls.Add(this.cbxGridContainer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGridLastName);
            this.Controls.Add(this.txtGridFirstName);
            this.Controls.Add(this.dtGridDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Water Services";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHome;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtGridDate;
        private System.Windows.Forms.TextBox txtGridFirstName;
        private System.Windows.Forms.TextBox txtGridLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxGridContainer;
        private System.Windows.Forms.ComboBox cbxGridType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGridVolume;
        private System.Windows.Forms.TextBox txtGridCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGridSave;
        private System.Windows.Forms.Button btnGridCancel;
        private System.Windows.Forms.DateTimePicker dtFilterFrom;
        private System.Windows.Forms.DateTimePicker dtFilterTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtGridTime;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.TextBox textBox1;

    }
}