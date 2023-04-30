namespace Adatátvitel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Adatbevitel = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Potlek = new System.Windows.Forms.GroupBox();
            this.KezdoPotlek = new System.Windows.Forms.CheckBox();
            this.GyermekPotlek = new System.Windows.Forms.CheckBox();
            this.NyelvPotlek = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adatok = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DG = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Adatbevitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Potlek.SuspendLayout();
            this.Adatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Adatbevitel);
            this.tabControl1.Controls.Add(this.Adatok);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // Adatbevitel
            // 
            this.Adatbevitel.Controls.Add(this.numericUpDown2);
            this.Adatbevitel.Controls.Add(this.textBox3);
            this.Adatbevitel.Controls.Add(this.textBox2);
            this.Adatbevitel.Controls.Add(this.DatePick);
            this.Adatbevitel.Controls.Add(this.textBox1);
            this.Adatbevitel.Controls.Add(this.numericUpDown1);
            this.Adatbevitel.Controls.Add(this.Potlek);
            this.Adatbevitel.Controls.Add(this.label6);
            this.Adatbevitel.Controls.Add(this.label5);
            this.Adatbevitel.Controls.Add(this.label4);
            this.Adatbevitel.Controls.Add(this.label3);
            this.Adatbevitel.Controls.Add(this.label2);
            this.Adatbevitel.Controls.Add(this.label1);
            this.Adatbevitel.Location = new System.Drawing.Point(4, 22);
            this.Adatbevitel.Name = "Adatbevitel";
            this.Adatbevitel.Padding = new System.Windows.Forms.Padding(3);
            this.Adatbevitel.Size = new System.Drawing.Size(765, 346);
            this.Adatbevitel.TabIndex = 1;
            this.Adatbevitel.Text = "Adatbevitel";
            this.Adatbevitel.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 11;
            // 
            // DatePick
            // 
            this.DatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick.Location = new System.Drawing.Point(161, 74);
            this.DatePick.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.DatePick.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(112, 20);
            this.DatePick.TabIndex = 10;
            this.DatePick.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(161, 201);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            // 
            // Potlek
            // 
            this.Potlek.Controls.Add(this.KezdoPotlek);
            this.Potlek.Controls.Add(this.GyermekPotlek);
            this.Potlek.Controls.Add(this.NyelvPotlek);
            this.Potlek.Location = new System.Drawing.Point(68, 229);
            this.Potlek.Name = "Potlek";
            this.Potlek.Size = new System.Drawing.Size(266, 76);
            this.Potlek.TabIndex = 7;
            this.Potlek.TabStop = false;
            this.Potlek.Text = "Pótlék";
            // 
            // KezdoPotlek
            // 
            this.KezdoPotlek.AutoSize = true;
            this.KezdoPotlek.Location = new System.Drawing.Point(19, 42);
            this.KezdoPotlek.Name = "KezdoPotlek";
            this.KezdoPotlek.Size = new System.Drawing.Size(89, 17);
            this.KezdoPotlek.TabIndex = 8;
            this.KezdoPotlek.Text = "Kezdő Pótlék";
            this.KezdoPotlek.UseVisualStyleBackColor = true;
            // 
            // GyermekPotlek
            // 
            this.GyermekPotlek.AutoSize = true;
            this.GyermekPotlek.Location = new System.Drawing.Point(149, 19);
            this.GyermekPotlek.Name = "GyermekPotlek";
            this.GyermekPotlek.Size = new System.Drawing.Size(101, 17);
            this.GyermekPotlek.TabIndex = 7;
            this.GyermekPotlek.Text = "Gyermek Pótlék";
            this.GyermekPotlek.UseVisualStyleBackColor = true;
            // 
            // NyelvPotlek
            // 
            this.NyelvPotlek.AutoSize = true;
            this.NyelvPotlek.Location = new System.Drawing.Point(19, 19);
            this.NyelvPotlek.Name = "NyelvPotlek";
            this.NyelvPotlek.Size = new System.Drawing.Size(86, 17);
            this.NyelvPotlek.TabIndex = 6;
            this.NyelvPotlek.Text = "Nyelv Pótlék";
            this.NyelvPotlek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alapbér:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Belépés:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Beosztás:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Részleg:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Születési Idő:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:  ";
            // 
            // Adatok
            // 
            this.Adatok.Controls.Add(this.DG);
            this.Adatok.Location = new System.Drawing.Point(4, 22);
            this.Adatok.Name = "Adatok";
            this.Adatok.Padding = new System.Windows.Forms.Padding(3);
            this.Adatok.Size = new System.Drawing.Size(765, 346);
            this.Adatok.TabIndex = 2;
            this.Adatok.Text = "Adatok";
            this.Adatok.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Megszakít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rögzít";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Bezár";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(161, 168);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(3, 6);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(761, 339);
            this.DG.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Adatátvitel";
            this.tabControl1.ResumeLayout(false);
            this.Adatbevitel.ResumeLayout(false);
            this.Adatbevitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Potlek.ResumeLayout(false);
            this.Potlek.PerformLayout();
            this.Adatok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Adatbevitel;
        private System.Windows.Forms.TabPage Adatok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Potlek;
        private System.Windows.Forms.CheckBox GyermekPotlek;
        private System.Windows.Forms.CheckBox NyelvPotlek;
        private System.Windows.Forms.CheckBox KezdoPotlek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker DatePick;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridView DG;
    }
}

