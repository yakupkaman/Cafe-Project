namespace CafeProject
{
    partial class frmUrunler
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
            this.ekle = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ktcomb1 = new System.Windows.Forms.ComboBox();
            this.kategr = new System.Windows.Forms.Label();
            this.urunlerListB = new System.Windows.Forms.ListBox();
            this.urun = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urun2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urun3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.Location = new System.Drawing.Point(300, 25);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(96, 35);
            this.ekle.TabIndex = 0;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click_1);
            // 
            // duzenle
            // 
            this.duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duzenle.Location = new System.Drawing.Point(300, 26);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(96, 37);
            this.duzenle.TabIndex = 1;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(300, 19);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(96, 37);
            this.sil.TabIndex = 2;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ktcomb1
            // 
            this.ktcomb1.FormattingEnabled = true;
            this.ktcomb1.Location = new System.Drawing.Point(185, 36);
            this.ktcomb1.Name = "ktcomb1";
            this.ktcomb1.Size = new System.Drawing.Size(121, 21);
            this.ktcomb1.TabIndex = 3;
            this.ktcomb1.SelectedIndexChanged += new System.EventHandler(this.ktcomb1_SelectedIndexChanged);
            // 
            // kategr
            // 
            this.kategr.AutoSize = true;
            this.kategr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategr.Location = new System.Drawing.Point(28, 34);
            this.kategr.Name = "kategr";
            this.kategr.Size = new System.Drawing.Size(96, 20);
            this.kategr.TabIndex = 4;
            this.kategr.Text = "Kategoriler";
            // 
            // urunlerListB
            // 
            this.urunlerListB.FormattingEnabled = true;
            this.urunlerListB.Location = new System.Drawing.Point(476, 12);
            this.urunlerListB.Name = "urunlerListB";
            this.urunlerListB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.urunlerListB.Size = new System.Drawing.Size(136, 420);
            this.urunlerListB.TabIndex = 5;
            this.urunlerListB.SelectedIndexChanged += new System.EventHandler(this.urunlerListB_SelectedIndexChanged);
            // 
            // urun
            // 
            this.urun.Location = new System.Drawing.Point(19, 33);
            this.urun.Name = "urun";
            this.urun.Size = new System.Drawing.Size(255, 20);
            this.urun.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urun);
            this.groupBox1.Controls.Add(this.ekle);
            this.groupBox1.Location = new System.Drawing.Point(32, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // urun2
            // 
            this.urun2.Location = new System.Drawing.Point(10, 35);
            this.urun2.Name = "urun2";
            this.urun2.Size = new System.Drawing.Size(255, 20);
            this.urun2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.urun2);
            this.groupBox2.Controls.Add(this.duzenle);
            this.groupBox2.Location = new System.Drawing.Point(32, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 80);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // urun3
            // 
            this.urun3.Location = new System.Drawing.Point(6, 35);
            this.urun3.Name = "urun3";
            this.urun3.Size = new System.Drawing.Size(255, 20);
            this.urun3.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sil);
            this.groupBox3.Controls.Add(this.urun3);
            this.groupBox3.Location = new System.Drawing.Point(32, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 80);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.kategr);
            this.Controls.Add(this.ktcomb1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urunlerListB);
            this.Name = "frmUrunler";
            this.Text = "frmYiyecek";
            this.Load += new System.EventHandler(this.frmYiyecek_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.ComboBox ktcomb1;
        private System.Windows.Forms.Label kategr;
        private System.Windows.Forms.ListBox urunlerListB;
        private System.Windows.Forms.TextBox urun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox urun2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urun3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}