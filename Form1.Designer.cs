namespace yusifmuasirsdf
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();

            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPayEmpCode = new System.Windows.Forms.Label();
            this.lblPayTitle = new System.Windows.Forms.Label();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.txtPayEmpCode = new System.Windows.Forms.TextBox();
            this.txtPayTitle = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.btnAddPayment = new System.Windows.Forms.Button();

            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEmpInfo = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();

            this.btnExit = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 380);
            this.tabControl1.TabIndex = 0;

            // tabPage1 (İşçi əlavə et)
            this.tabPage1.Controls.Add(this.lblCode);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Controls.Add(this.lblFirstName);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.lblLastName);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.lblAge);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İşçi əlavə et";
            this.tabPage1.UseVisualStyleBackColor = true;

            // Labels & TextBoxes - TabPage 1
            this.lblCode.Location = new System.Drawing.Point(20, 30);
            this.lblCode.Text = "İşçi kodu:";
            this.txtCode.Location = new System.Drawing.Point(120, 27);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(150, 20);

            this.lblFirstName.Location = new System.Drawing.Point(20, 70);
            this.lblFirstName.Text = "Ad:";
            this.txtFirstName.Location = new System.Drawing.Point(120, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);

            this.lblLastName.Location = new System.Drawing.Point(20, 110);
            this.lblLastName.Text = "Soyad:";
            this.txtLastName.Location = new System.Drawing.Point(120, 107);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);

            this.lblAge.Location = new System.Drawing.Point(20, 150);
            this.lblAge.Text = "Yaş:";
            this.txtAge.Location = new System.Drawing.Point(120, 147);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 20);

            this.btnAddEmployee.Location = new System.Drawing.Point(120, 190);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(150, 30);
            this.btnAddEmployee.Text = "Əlavə et";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);

            // tabPage2 (Ödəniş yaz)
            this.tabPage2.Controls.Add(this.lblPayEmpCode);
            this.tabPage2.Controls.Add(this.txtPayEmpCode);
            this.tabPage2.Controls.Add(this.lblPayTitle);
            this.tabPage2.Controls.Add(this.txtPayTitle);
            this.tabPage2.Controls.Add(this.lblPayAmount);
            this.tabPage2.Controls.Add(this.txtPayAmount);
            this.tabPage2.Controls.Add(this.btnAddPayment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödəniş yaz";
            this.tabPage2.UseVisualStyleBackColor = true;

            // Labels & TextBoxes - TabPage 2
            this.lblPayEmpCode.Location = new System.Drawing.Point(20, 30);
            this.lblPayEmpCode.Text = "İşçi kodu:";
            this.txtPayEmpCode.Location = new System.Drawing.Point(120, 27);
            this.txtPayEmpCode.Name = "txtPayEmpCode";
            this.txtPayEmpCode.Size = new System.Drawing.Size(150, 20);

            this.lblPayTitle.Location = new System.Drawing.Point(20, 70);
            this.lblPayTitle.Text = "Ödənişin adı:";
            this.txtPayTitle.Location = new System.Drawing.Point(120, 67);
            this.txtPayTitle.Name = "txtPayTitle";
            this.txtPayTitle.Size = new System.Drawing.Size(150, 20);

            this.lblPayAmount.Location = new System.Drawing.Point(20, 110);
            this.lblPayAmount.Text = "Məbləğ:";
            this.txtPayAmount.Location = new System.Drawing.Point(120, 107);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(150, 20);

            this.btnAddPayment.Location = new System.Drawing.Point(120, 150);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(150, 30);
            this.btnAddPayment.Text = "Ödəniş yaz";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);

            // tabPage3 (Statistika)
            this.tabPage3.Controls.Add(this.lblSearchCode);
            this.tabPage3.Controls.Add(this.txtSearchCode);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.lblEmpInfo);
            this.tabPage3.Controls.Add(this.dgvPayments);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistika";
            this.tabPage3.UseVisualStyleBackColor = true;

            // TabPage 3 Controls
            this.lblSearchCode.Location = new System.Drawing.Point(20, 20);
            this.lblSearchCode.Text = "İşçi kodu:";
            this.txtSearchCode.Location = new System.Drawing.Point(90, 17);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(120, 20);

            this.btnSearch.Location = new System.Drawing.Point(220, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.lblEmpInfo.AutoSize = true;
            this.lblEmpInfo.Location = new System.Drawing.Point(20, 55);
            this.lblEmpInfo.Name = "lblEmpInfo";
            this.lblEmpInfo.Size = new System.Drawing.Size(0, 13);

            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(20, 80);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(510, 250);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(472, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDF-1: İşçi Maaş Proqramı";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblCode, lblFirstName, lblLastName, lblAge;
        private System.Windows.Forms.TextBox txtCode, txtFirstName, txtLastName, txtAge;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblPayEmpCode, lblPayTitle, lblPayAmount;
        private System.Windows.Forms.TextBox txtPayEmpCode, txtPayTitle, txtPayAmount;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label lblSearchCode, lblEmpInfo;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnExit;
    }
}