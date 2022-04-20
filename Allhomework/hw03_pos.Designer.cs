
namespace Allhomework
{
    partial class hw03_pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hw03_pos));
            this.groPay = new System.Windows.Forms.GroupBox();
            this.labDiscount = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groList = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.groTotalPrice = new System.Windows.Forms.GroupBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.groMenu = new System.Windows.Forms.GroupBox();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.groPay.SuspendLayout();
            this.groList.SuspendLayout();
            this.groTotalPrice.SuspendLayout();
            this.groMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groPay
            // 
            this.groPay.Controls.Add(this.labDiscount);
            this.groPay.Controls.Add(this.btnCreditCard);
            this.groPay.Controls.Add(this.btnCash);
            this.groPay.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groPay.Location = new System.Drawing.Point(719, 237);
            this.groPay.Name = "groPay";
            this.groPay.Size = new System.Drawing.Size(242, 198);
            this.groPay.TabIndex = 13;
            this.groPay.TabStop = false;
            this.groPay.Text = "付款方式";
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.Location = new System.Drawing.Point(27, 155);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(160, 24);
            this.labDiscount.TabIndex = 2;
            this.labDiscount.Text = "信用卡打九折";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(22, 103);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(147, 47);
            this.btnCreditCard.TabIndex = 1;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(22, 39);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(147, 47);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groList
            // 
            this.groList.Controls.Add(this.btnClear);
            this.groList.Controls.Add(this.labList);
            this.groList.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groList.Location = new System.Drawing.Point(338, 104);
            this.groList.Name = "groList";
            this.groList.Size = new System.Drawing.Size(375, 415);
            this.groList.TabIndex = 14;
            this.groList.TabStop = false;
            this.groList.Text = "購物清單 List";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 47);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labList.Location = new System.Drawing.Point(6, 31);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(363, 291);
            this.labList.TabIndex = 1;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groTotalPrice
            // 
            this.groTotalPrice.Controls.Add(this.labTotalPrice);
            this.groTotalPrice.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groTotalPrice.Location = new System.Drawing.Point(720, 106);
            this.groTotalPrice.Name = "groTotalPrice";
            this.groTotalPrice.Size = new System.Drawing.Size(242, 87);
            this.groTotalPrice.TabIndex = 12;
            this.groTotalPrice.TabStop = false;
            this.groTotalPrice.Text = "總金額 Total Price";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotalPrice.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotalPrice.Location = new System.Drawing.Point(12, 35);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(220, 41);
            this.labTotalPrice.TabIndex = 3;
            this.labTotalPrice.Text = " NT$0";
            this.labTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groMenu
            // 
            this.groMenu.Controls.Add(this.btnBeer);
            this.groMenu.Controls.Add(this.btnWine);
            this.groMenu.Controls.Add(this.btnTequila);
            this.groMenu.Controls.Add(this.btnWhisky);
            this.groMenu.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groMenu.Location = new System.Drawing.Point(67, 75);
            this.groMenu.Name = "groMenu";
            this.groMenu.Size = new System.Drawing.Size(264, 444);
            this.groMenu.TabIndex = 11;
            this.groMenu.TabStop = false;
            this.groMenu.Text = "菜單";
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBeer.Location = new System.Drawing.Point(23, 41);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(104, 187);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒\r\nBeer\r＄120\n";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnWine
            // 
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWine.Location = new System.Drawing.Point(147, 247);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(102, 188);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "紅酒 Wine $320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTequila.Location = new System.Drawing.Point(141, 41);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(102, 187);
            this.btnTequila.TabIndex = 1;
            this.btnTequila.Text = "龍舌蘭 Tequila  $180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhisky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWhisky.Location = new System.Drawing.Point(20, 247);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(107, 188);
            this.btnWhisky.TabIndex = 2;
            this.btnWhisky.Text = "威士忌 Whisky $330";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // hw03_pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.groPay);
            this.Controls.Add(this.groList);
            this.Controls.Add(this.groTotalPrice);
            this.Controls.Add(this.groMenu);
            this.Name = "hw03_pos";
            this.Text = "hw03_pos";
            this.groPay.ResumeLayout(false);
            this.groPay.PerformLayout();
            this.groList.ResumeLayout(false);
            this.groTotalPrice.ResumeLayout(false);
            this.groMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groPay;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.GroupBox groList;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Label labList;
        private System.Windows.Forms.GroupBox groTotalPrice;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.GroupBox groMenu;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWhisky;
    }
}