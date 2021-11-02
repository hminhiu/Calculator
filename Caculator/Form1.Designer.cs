namespace Caculator
{
    partial class Form1
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
            this.btcong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbso1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.lbso2 = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.lbketqua = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.bttru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(331, 187);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(54, 23);
            this.btcong.TabIndex = 0;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tinh toan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbso1
            // 
            this.lbso1.AutoSize = true;
            this.lbso1.Location = new System.Drawing.Point(46, 64);
            this.lbso1.Name = "lbso1";
            this.lbso1.Size = new System.Drawing.Size(47, 13);
            this.lbso1.TabIndex = 1;
            this.lbso1.Text = "So thu 1";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(137, 57);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(248, 20);
            this.txtso1.TabIndex = 2;
            // 
            // lbso2
            // 
            this.lbso2.AutoSize = true;
            this.lbso2.Location = new System.Drawing.Point(46, 106);
            this.lbso2.Name = "lbso2";
            this.lbso2.Size = new System.Drawing.Size(47, 13);
            this.lbso2.TabIndex = 1;
            this.lbso2.Text = "So thu 2";
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(137, 103);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(248, 20);
            this.txtso2.TabIndex = 2;
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Location = new System.Drawing.Point(46, 150);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(44, 13);
            this.lbketqua.TabIndex = 1;
            this.lbketqua.Text = "Ket qua";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(137, 143);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(248, 20);
            this.txtketqua.TabIndex = 2;
            // 
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(137, 187);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(54, 23);
            this.bttru.TabIndex = 0;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.bt);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.lbso2);
            this.Controls.Add(this.lbso1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
            this.Name = "Form1";
            this.Text = "tinh toan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbso1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Label lbso2;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button bttru;
    }
}

