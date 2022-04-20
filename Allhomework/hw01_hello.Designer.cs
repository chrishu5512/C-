
namespace Allhomework
{
    partial class hw01_hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHi = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEnName = new System.Windows.Forms.Label();
            this.labelCnName = new System.Windows.Forms.Label();
            this.textZodiac = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textEnName = new System.Windows.Forms.TextBox();
            this.textCnName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(409, 321);
            this.btnHi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(181, 58);
            this.btnHi.TabIndex = 19;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(181, 321);
            this.btnHello.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(181, 58);
            this.btnHello.TabIndex = 18;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(176, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "星座:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGender.ForeColor = System.Drawing.Color.Orange;
            this.labelGender.Location = new System.Drawing.Point(176, 199);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(81, 30);
            this.labelGender.TabIndex = 16;
            this.labelGender.Text = "性別:";
            // 
            // labelEnName
            // 
            this.labelEnName.AutoSize = true;
            this.labelEnName.BackColor = System.Drawing.Color.Transparent;
            this.labelEnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEnName.ForeColor = System.Drawing.Color.Orange;
            this.labelEnName.Location = new System.Drawing.Point(176, 135);
            this.labelEnName.Name = "labelEnName";
            this.labelEnName.Size = new System.Drawing.Size(183, 30);
            this.labelEnName.TabIndex = 15;
            this.labelEnName.Text = "English Name:";
            // 
            // labelCnName
            // 
            this.labelCnName.AutoSize = true;
            this.labelCnName.BackColor = System.Drawing.Color.Transparent;
            this.labelCnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCnName.ForeColor = System.Drawing.Color.Orange;
            this.labelCnName.Location = new System.Drawing.Point(176, 71);
            this.labelCnName.Name = "labelCnName";
            this.labelCnName.Size = new System.Drawing.Size(81, 30);
            this.labelCnName.TabIndex = 14;
            this.labelCnName.Text = "姓名:";
            // 
            // textZodiac
            // 
            this.textZodiac.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textZodiac.Location = new System.Drawing.Point(409, 264);
            this.textZodiac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textZodiac.Name = "textZodiac";
            this.textZodiac.Size = new System.Drawing.Size(216, 43);
            this.textZodiac.TabIndex = 13;
            // 
            // textGender
            // 
            this.textGender.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textGender.Location = new System.Drawing.Point(409, 199);
            this.textGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(216, 43);
            this.textGender.TabIndex = 12;
            // 
            // textEnName
            // 
            this.textEnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textEnName.Location = new System.Drawing.Point(409, 135);
            this.textEnName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEnName.Name = "textEnName";
            this.textEnName.Size = new System.Drawing.Size(216, 43);
            this.textEnName.TabIndex = 11;
            // 
            // textCnName
            // 
            this.textCnName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textCnName.Location = new System.Drawing.Point(409, 71);
            this.textCnName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCnName.Name = "textCnName";
            this.textCnName.Size = new System.Drawing.Size(216, 43);
            this.textCnName.TabIndex = 10;
            // 
            // hw01_hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEnName);
            this.Controls.Add(this.labelCnName);
            this.Controls.Add(this.textZodiac);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textEnName);
            this.Controls.Add(this.textCnName);
            this.Name = "hw01_hello";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEnName;
        private System.Windows.Forms.Label labelCnName;
        private System.Windows.Forms.TextBox textZodiac;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox textEnName;
        private System.Windows.Forms.TextBox textCnName;
    }
}

