
namespace Allhomework
{
    partial class test_guess
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
            this.btn_ShowAnswer = new System.Windows.Forms.Button();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.lab_Topic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ShowAnswer
            // 
            this.btn_ShowAnswer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_ShowAnswer.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAnswer.Location = new System.Drawing.Point(432, 241);
            this.btn_ShowAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowAnswer.Name = "btn_ShowAnswer";
            this.btn_ShowAnswer.Size = new System.Drawing.Size(244, 69);
            this.btn_ShowAnswer.TabIndex = 5;
            this.btn_ShowAnswer.Text = "Show Answer";
            this.btn_ShowAnswer.UseVisualStyleBackColor = false;
            this.btn_ShowAnswer.Click += new System.EventHandler(this.btn_ShowAnswer_Click);
            // 
            // btn_Guess
            // 
            this.btn_Guess.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Guess.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guess.Location = new System.Drawing.Point(125, 241);
            this.btn_Guess.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(173, 69);
            this.btn_Guess.TabIndex = 4;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = false;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // lab_Topic
            // 
            this.lab_Topic.AutoSize = true;
            this.lab_Topic.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Topic.Location = new System.Drawing.Point(150, 140);
            this.lab_Topic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Topic.Name = "lab_Topic";
            this.lab_Topic.Size = new System.Drawing.Size(472, 39);
            this.lab_Topic.TabIndex = 3;
            this.lab_Topic.Text = "Select a Number Between 1-100! ";
            // 
            // test_guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ShowAnswer);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.lab_Topic);
            this.Name = "test_guess";
            this.Text = "test_guess";
            this.Load += new System.EventHandler(this.test_guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowAnswer;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Label lab_Topic;
    }
}