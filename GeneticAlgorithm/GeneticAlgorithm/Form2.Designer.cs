namespace GeneticAlgorithm
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxCaprazlama = new System.Windows.Forms.ComboBox();
            this.comboBoxMutasyon = new System.Windows.Forms.ComboBox();
            this.comboBoxNesilSayisi = new System.Windows.Forms.ComboBox();
            this.comboBoxBireySayisi = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Graph Dosya Seçin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBireySayisi);
            this.groupBox1.Controls.Add(this.comboBoxNesilSayisi);
            this.groupBox1.Controls.Add(this.comboBoxMutasyon);
            this.groupBox1.Controls.Add(this.comboBoxCaprazlama);
            this.groupBox1.Controls.Add(this.labelFinal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 453);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçim ve Ayarlar";
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinal.Location = new System.Drawing.Point(61, 404);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(67, 39);
            this.labelFinal.TabIndex = 17;
            this.labelFinal.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "            Sonuç\r\n(En Son Neslindeki\r\nEn İyi Bireyin Değeri) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Çaprazlama Rulet \r\nMethodu kullanılmıştır.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mutasyon Oranı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Çaprazlama Oranı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Birey Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nesil Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dosya Adı:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "Genetik Algoritma ile Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(208, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 453);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nesil Sonuçlarını Takip Etme Ekranı";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 430);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBoxCaprazlama
            // 
            this.comboBoxCaprazlama.FormattingEnabled = true;
            this.comboBoxCaprazlama.Items.AddRange(new object[] {
            "0.3",
            "0.8"});
            this.comboBoxCaprazlama.Location = new System.Drawing.Point(107, 124);
            this.comboBoxCaprazlama.Name = "comboBoxCaprazlama";
            this.comboBoxCaprazlama.Size = new System.Drawing.Size(87, 21);
            this.comboBoxCaprazlama.TabIndex = 18;
            // 
            // comboBoxMutasyon
            // 
            this.comboBoxMutasyon.FormattingEnabled = true;
            this.comboBoxMutasyon.Items.AddRange(new object[] {
            "0.02",
            "0.2"});
            this.comboBoxMutasyon.Location = new System.Drawing.Point(107, 151);
            this.comboBoxMutasyon.Name = "comboBoxMutasyon";
            this.comboBoxMutasyon.Size = new System.Drawing.Size(86, 21);
            this.comboBoxMutasyon.TabIndex = 19;
            // 
            // comboBoxNesilSayisi
            // 
            this.comboBoxNesilSayisi.FormattingEnabled = true;
            this.comboBoxNesilSayisi.Items.AddRange(new object[] {
            "200",
            "400"});
            this.comboBoxNesilSayisi.Location = new System.Drawing.Point(83, 66);
            this.comboBoxNesilSayisi.Name = "comboBoxNesilSayisi";
            this.comboBoxNesilSayisi.Size = new System.Drawing.Size(109, 21);
            this.comboBoxNesilSayisi.TabIndex = 20;
            // 
            // comboBoxBireySayisi
            // 
            this.comboBoxBireySayisi.FormattingEnabled = true;
            this.comboBoxBireySayisi.Items.AddRange(new object[] {
            "100",
            "200"});
            this.comboBoxBireySayisi.Location = new System.Drawing.Point(85, 96);
            this.comboBoxBireySayisi.Name = "comboBoxBireySayisi";
            this.comboBoxBireySayisi.Size = new System.Drawing.Size(109, 21);
            this.comboBoxBireySayisi.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Yapay Zeka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMutasyon;
        private System.Windows.Forms.ComboBox comboBoxCaprazlama;
        private System.Windows.Forms.ComboBox comboBoxBireySayisi;
        private System.Windows.Forms.ComboBox comboBoxNesilSayisi;
    }
}