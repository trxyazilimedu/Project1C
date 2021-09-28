
namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxUrunler = new System.Windows.Forms.ListBox();
            this.lbrbaslik = new System.Windows.Forms.Label();
            this.lbrcount = new System.Windows.Forms.Label();
            this.uruncountbaslik = new System.Windows.Forms.Label();
            this.maketurkish = new System.Windows.Forms.Button();
            this.makeing = new System.Windows.Forms.Button();
            this.txburunset = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.lbxsepet = new System.Windows.Forms.ListBox();
            this.lblsptbaslik = new System.Windows.Forms.Label();
            this.btnsptinsert = new System.Windows.Forms.Button();
            this.btnremovecart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxUrunler
            // 
            this.lbxUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxUrunler.FormattingEnabled = true;
            this.lbxUrunler.ItemHeight = 21;
            this.lbxUrunler.Location = new System.Drawing.Point(52, 53);
            this.lbxUrunler.Name = "lbxUrunler";
            this.lbxUrunler.Size = new System.Drawing.Size(112, 298);
            this.lbxUrunler.TabIndex = 0;
            this.lbxUrunler.SelectedIndexChanged += new System.EventHandler(this.lbxUrunler_SelectedIndexChanged);
            // 
            // lbrbaslik
            // 
            this.lbrbaslik.AutoSize = true;
            this.lbrbaslik.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbrbaslik.Location = new System.Drawing.Point(64, 22);
            this.lbrbaslik.Name = "lbrbaslik";
            this.lbrbaslik.Size = new System.Drawing.Size(0, 28);
            this.lbrbaslik.TabIndex = 1;
            // 
            // lbrcount
            // 
            this.lbrcount.AutoSize = true;
            this.lbrcount.Location = new System.Drawing.Point(106, 363);
            this.lbrcount.Name = "lbrcount";
            this.lbrcount.Size = new System.Drawing.Size(38, 15);
            this.lbrcount.TabIndex = 2;
            this.lbrcount.Text = "label1";
            // 
            // uruncountbaslik
            // 
            this.uruncountbaslik.AutoSize = true;
            this.uruncountbaslik.Location = new System.Drawing.Point(22, 363);
            this.uruncountbaslik.Name = "uruncountbaslik";
            this.uruncountbaslik.Size = new System.Drawing.Size(78, 15);
            this.uruncountbaslik.TabIndex = 3;
            this.uruncountbaslik.Text = "Toplam Ürün:";
            // 
            // maketurkish
            // 
            this.maketurkish.Location = new System.Drawing.Point(713, 12);
            this.maketurkish.Name = "maketurkish";
            this.maketurkish.Size = new System.Drawing.Size(75, 23);
            this.maketurkish.TabIndex = 4;
            this.maketurkish.Text = "Türkçe";
            this.maketurkish.UseVisualStyleBackColor = true;
            this.maketurkish.Click += new System.EventHandler(this.maketurkish_Click);
            // 
            // makeing
            // 
            this.makeing.Location = new System.Drawing.Point(617, 12);
            this.makeing.Name = "makeing";
            this.makeing.Size = new System.Drawing.Size(75, 23);
            this.makeing.TabIndex = 5;
            this.makeing.Text = "İngilizce";
            this.makeing.UseVisualStyleBackColor = true;
            this.makeing.Click += new System.EventHandler(this.makeing_Click);
            // 
            // txburunset
            // 
            this.txburunset.Location = new System.Drawing.Point(617, 74);
            this.txburunset.Name = "txburunset";
            this.txburunset.Size = new System.Drawing.Size(100, 23);
            this.txburunset.TabIndex = 6;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(617, 117);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(100, 31);
            this.btninsert.TabIndex = 7;
            this.btninsert.Text = "button1";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lbxsepet
            // 
            this.lbxsepet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxsepet.FormattingEnabled = true;
            this.lbxsepet.ItemHeight = 21;
            this.lbxsepet.Location = new System.Drawing.Point(361, 53);
            this.lbxsepet.Name = "lbxsepet";
            this.lbxsepet.Size = new System.Drawing.Size(120, 298);
            this.lbxsepet.TabIndex = 8;
            // 
            // lblsptbaslik
            // 
            this.lblsptbaslik.AutoSize = true;
            this.lblsptbaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsptbaslik.Location = new System.Drawing.Point(384, 22);
            this.lblsptbaslik.Name = "lblsptbaslik";
            this.lblsptbaslik.Size = new System.Drawing.Size(52, 21);
            this.lblsptbaslik.TabIndex = 9;
            this.lblsptbaslik.Text = "label1";
            // 
            // btnsptinsert
            // 
            this.btnsptinsert.Location = new System.Drawing.Point(202, 74);
            this.btnsptinsert.Name = "btnsptinsert";
            this.btnsptinsert.Size = new System.Drawing.Size(119, 51);
            this.btnsptinsert.TabIndex = 10;
            this.btnsptinsert.Text = "button1";
            this.btnsptinsert.UseVisualStyleBackColor = true;
            this.btnsptinsert.Click += new System.EventHandler(this.btnsptinsert_Click);
            // 
            // btnremovecart
            // 
            this.btnremovecart.Location = new System.Drawing.Point(202, 209);
            this.btnremovecart.Name = "btnremovecart";
            this.btnremovecart.Size = new System.Drawing.Size(119, 53);
            this.btnremovecart.TabIndex = 11;
            this.btnremovecart.Text = "button1";
            this.btnremovecart.UseVisualStyleBackColor = true;
            this.btnremovecart.Click += new System.EventHandler(this.btnremovecart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremovecart);
            this.Controls.Add(this.btnsptinsert);
            this.Controls.Add(this.lblsptbaslik);
            this.Controls.Add(this.lbxsepet);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txburunset);
            this.Controls.Add(this.makeing);
            this.Controls.Add(this.maketurkish);
            this.Controls.Add(this.uruncountbaslik);
            this.Controls.Add(this.lbrcount);
            this.Controls.Add(this.lbrbaslik);
            this.Controls.Add(this.lbxUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxUrunler;
        private System.Windows.Forms.Label lbrbaslik;
        private System.Windows.Forms.Label lbrcount;
        private System.Windows.Forms.Label uruncountbaslik;
        private System.Windows.Forms.Button maketurkish;
        private System.Windows.Forms.Button makeing;
        private System.Windows.Forms.TextBox txburunset;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.ListBox lbxsepet;
        private System.Windows.Forms.Label lblsptbaslik;
        private System.Windows.Forms.Button btnsptinsert;
        private System.Windows.Forms.Button btnremovecart;
    }
}

