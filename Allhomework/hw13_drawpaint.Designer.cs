
namespace Allhomework
{
    partial class hw13_drawpaint
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
            this.lab_ColorSize = new System.Windows.Forms.Label();
            this.traBox_PenSize = new System.Windows.Forms.TrackBar();
            this.picbox_color = new System.Windows.Forms.PictureBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.traBox_PenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_color)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_ColorSize
            // 
            this.lab_ColorSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_ColorSize.AutoSize = true;
            this.lab_ColorSize.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ColorSize.Location = new System.Drawing.Point(668, 376);
            this.lab_ColorSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ColorSize.Name = "lab_ColorSize";
            this.lab_ColorSize.Size = new System.Drawing.Size(24, 29);
            this.lab_ColorSize.TabIndex = 7;
            this.lab_ColorSize.Text = "1";
            // 
            // traBox_PenSize
            // 
            this.traBox_PenSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.traBox_PenSize.Location = new System.Drawing.Point(656, 184);
            this.traBox_PenSize.Margin = new System.Windows.Forms.Padding(4);
            this.traBox_PenSize.Maximum = 100;
            this.traBox_PenSize.Minimum = 1;
            this.traBox_PenSize.Name = "traBox_PenSize";
            this.traBox_PenSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.traBox_PenSize.Size = new System.Drawing.Size(56, 188);
            this.traBox_PenSize.TabIndex = 6;
            this.traBox_PenSize.Value = 1;
            this.traBox_PenSize.Scroll += new System.EventHandler(this.traBox_PenSize_Scroll);
            // 
            // picbox_color
            // 
            this.picbox_color.BackColor = System.Drawing.Color.Black;
            this.picbox_color.Location = new System.Drawing.Point(640, 90);
            this.picbox_color.Margin = new System.Windows.Forms.Padding(4);
            this.picbox_color.Name = "picbox_color";
            this.picbox_color.Size = new System.Drawing.Size(100, 41);
            this.picbox_color.TabIndex = 5;
            this.picbox_color.TabStop = false;
            // 
            // btn_color
            // 
            this.btn_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_color.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_color.Location = new System.Drawing.Point(640, 27);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(100, 44);
            this.btn_color.TabIndex = 4;
            this.btn_color.Text = "顏色";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // hw13_drawpaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_ColorSize);
            this.Controls.Add(this.traBox_PenSize);
            this.Controls.Add(this.picbox_color);
            this.Controls.Add(this.btn_color);
            this.Name = "hw13_drawpaint";
            this.Text = "hw13_drawpaint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hw13_drawpaint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hw13_drawpaint_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hw13_drawpaint_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.traBox_PenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ColorSize;
        private System.Windows.Forms.TrackBar traBox_PenSize;
        private System.Windows.Forms.PictureBox picbox_color;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}