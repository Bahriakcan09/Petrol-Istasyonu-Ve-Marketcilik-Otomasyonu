﻿namespace Petrol_Istasyonu_Ve_Marketcilik_Otomasyonu
{
    partial class MarketPageForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.UrunFiyatTxt = new System.Windows.Forms.TextBox();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.UrunAdetTxt = new System.Windows.Forms.TextBox();
            this.UrunAdTxt = new System.Windows.Forms.TextBox();
            this.UrunIdTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(660, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Güncelle ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(660, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Listele";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // UrunFiyatTxt
            // 
            this.UrunFiyatTxt.Location = new System.Drawing.Point(660, 261);
            this.UrunFiyatTxt.Name = "UrunFiyatTxt";
            this.UrunFiyatTxt.Size = new System.Drawing.Size(118, 22);
            this.UrunFiyatTxt.TabIndex = 5;
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Location = new System.Drawing.Point(12, 12);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.RowHeadersWidth = 51;
            this.dataGridUrunler.RowTemplate.Height = 24;
            this.dataGridUrunler.Size = new System.Drawing.Size(626, 386);
            this.dataGridUrunler.TabIndex = 6;
            // 
            // UrunAdetTxt
            // 
            this.UrunAdetTxt.Location = new System.Drawing.Point(660, 233);
            this.UrunAdetTxt.Name = "UrunAdetTxt";
            this.UrunAdetTxt.Size = new System.Drawing.Size(118, 22);
            this.UrunAdetTxt.TabIndex = 5;
            // 
            // UrunAdTxt
            // 
            this.UrunAdTxt.Location = new System.Drawing.Point(660, 205);
            this.UrunAdTxt.Name = "UrunAdTxt";
            this.UrunAdTxt.Size = new System.Drawing.Size(118, 22);
            this.UrunAdTxt.TabIndex = 5;
            // 
            // UrunIdTxt
            // 
            this.UrunIdTxt.Location = new System.Drawing.Point(660, 177);
            this.UrunIdTxt.Name = "UrunIdTxt";
            this.UrunIdTxt.Size = new System.Drawing.Size(118, 22);
            this.UrunIdTxt.TabIndex = 5;
            // 
            // MarketPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 424);
            this.Controls.Add(this.dataGridUrunler);
            this.Controls.Add(this.UrunIdTxt);
            this.Controls.Add(this.UrunAdTxt);
            this.Controls.Add(this.UrunAdetTxt);
            this.Controls.Add(this.UrunFiyatTxt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MarketPageForm";
            this.Text = "MarketForm";
            this.Load += new System.EventHandler(this.MarketPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox UrunFiyatTxt;
        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.TextBox UrunAdetTxt;
        private System.Windows.Forms.TextBox UrunAdTxt;
        private System.Windows.Forms.TextBox UrunIdTxt;
    }
}