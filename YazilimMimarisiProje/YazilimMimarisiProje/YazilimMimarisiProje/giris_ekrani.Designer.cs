
namespace YazilimMimarisiProje
{
    partial class giris_ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_ekrani));
            this.btn_devamet = new System.Windows.Forms.Button();
            this.konaklama = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ulasim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_devamet
            // 
            this.btn_devamet.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_devamet.Location = new System.Drawing.Point(685, 206);
            this.btn_devamet.Name = "btn_devamet";
            this.btn_devamet.Size = new System.Drawing.Size(108, 42);
            this.btn_devamet.TabIndex = 11;
            this.btn_devamet.Text = "DEVAM ET";
            this.btn_devamet.UseVisualStyleBackColor = true;
            this.btn_devamet.Click += new System.EventHandler(this.btn_devamet_Click);
            // 
            // konaklama
            // 
            this.konaklama.FormattingEnabled = true;
            this.konaklama.Items.AddRange(new object[] {
            "OTEL ",
            "ÇADIR"});
            this.konaklama.Location = new System.Drawing.Point(655, 90);
            this.konaklama.Name = "konaklama";
            this.konaklama.Size = new System.Drawing.Size(162, 24);
            this.konaklama.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(625, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "KONAKLAMA TÜRÜ SEÇİNİZ";
            // 
            // ulasim
            // 
            this.ulasim.FormattingEnabled = true;
            this.ulasim.Items.AddRange(new object[] {
            "OTOBÜS",
            "UÇAK"});
            this.ulasim.Location = new System.Drawing.Point(655, 166);
            this.ulasim.Name = "ulasim";
            this.ulasim.Size = new System.Drawing.Size(162, 24);
            this.ulasim.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(652, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ULAŞIM TÜRÜ SEÇİNİZ  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "REZERVASYON SİSTEMİNE HOŞGELDİNİZ";
            // 
            // giris_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btn_devamet);
            this.Controls.Add(this.konaklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ulasim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris_ekrani";
            this.Text = "giris_ekrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_devamet;
        private System.Windows.Forms.ComboBox konaklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ulasim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}