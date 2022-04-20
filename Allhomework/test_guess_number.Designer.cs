
namespace Allhomework
{
    partial class test_guess_number
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
            this.txtBox_GuessNumber = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lab_InputNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_GuessNumber
            // 
            this.txtBox_GuessNumber.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_GuessNumber.Location = new System.Drawing.Point(118, 239);
            this.txtBox_GuessNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_GuessNumber.Name = "txtBox_GuessNumber";
            this.txtBox_GuessNumber.Size = new System.Drawing.Size(340, 52);
            this.txtBox_GuessNumber.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancel.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(533, 236);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(173, 69);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Enter.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(533, 145);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(173, 69);
            this.btn_Enter.TabIndex = 6;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lab_InputNumber
            // 
            this.lab_InputNumber.AutoSize = true;
            this.lab_InputNumber.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InputNumber.Location = new System.Drawing.Point(94, 155);
            this.lab_InputNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_InputNumber.Name = "lab_InputNumber";
            this.lab_InputNumber.Size = new System.Drawing.Size(380, 45);
            this.lab_InputNumber.TabIndex = 5;
            this.lab_InputNumber.Text = "Please Input a Number!";
            // 
            // test_guess_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox_GuessNumber);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.lab_InputNumber);
            this.Name = "test_guess_number";
            this.Text = "test_guess_number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_GuessNumber;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lab_InputNumber;
    }
}