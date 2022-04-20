
namespace Allhomework
{
    partial class hw02_loan
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
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.labInterestRate = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labMoney = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(237, 234);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(150, 35);
            this.txtDownPayment.TabIndex = 32;
            this.txtDownPayment.Text = "0";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestRate.Location = new System.Drawing.Point(237, 175);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(150, 35);
            this.txtInterestRate.TabIndex = 31;
            this.txtInterestRate.Text = "10";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(237, 119);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 35);
            this.txtYear.TabIndex = 30;
            this.txtYear.Text = "2";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.Location = new System.Drawing.Point(237, 53);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(150, 35);
            this.txtMoney.TabIndex = 29;
            this.txtMoney.Text = "100000";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(61, 231);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(114, 38);
            this.labDownPayment.TabIndex = 28;
            this.labDownPayment.Text = "頭期款:";
            // 
            // labInterestRate
            // 
            this.labInterestRate.AutoSize = true;
            this.labInterestRate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterestRate.Location = new System.Drawing.Point(61, 169);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(130, 38);
            this.labInterestRate.TabIndex = 27;
            this.labInterestRate.Text = "利率(%):";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(61, 110);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(134, 38);
            this.labYear.TabIndex = 26;
            this.labYear.Text = "期限(年):";
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMoney.Location = new System.Drawing.Point(61, 51);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(144, 38);
            this.labMoney.TabIndex = 25;
            this.labMoney.Text = "貸款金額:";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(575, 340);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(164, 60);
            this.btnReport.TabIndex = 24;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(277, 340);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(164, 60);
            this.btnTotal.TabIndex = 23;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonth.Location = new System.Drawing.Point(97, 340);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(164, 60);
            this.btnMonth.TabIndex = 22;
            this.btnMonth.Text = "PMT(月付";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // hw02_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labMoney);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMonth);
            this.Name = "hw02_loan";
            this.Text = "hw02_loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.Label labInterestRate;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnMonth;
    }
}