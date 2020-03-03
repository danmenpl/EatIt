namespace Eat_It_
{
    partial class Formularz
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
            this.textBox_Wiek = new System.Windows.Forms.TextBox();
            this.textBox_Waga = new System.Windows.Forms.TextBox();
            this.label_Wiek = new System.Windows.Forms.Label();
            this.label_Waga = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Plec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton_Kob = new System.Windows.Forms.RadioButton();
            this.radioButton_Men = new System.Windows.Forms.RadioButton();
            this.label_Akt = new System.Windows.Forms.Label();
            this.comboBox_Akt = new System.Windows.Forms.ComboBox();
            this.textBox_Wzrost = new System.Windows.Forms.TextBox();
            this.label_Wzrost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Wiek
            // 
            this.textBox_Wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Wiek.Location = new System.Drawing.Point(158, 42);
            this.textBox_Wiek.Name = "textBox_Wiek";
            this.textBox_Wiek.Size = new System.Drawing.Size(170, 31);
            this.textBox_Wiek.TabIndex = 0;
            this.textBox_Wiek.TextChanged += new System.EventHandler(this.textBox_Wiek_TextChanged);
            // 
            // textBox_Waga
            // 
            this.textBox_Waga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Waga.Location = new System.Drawing.Point(158, 88);
            this.textBox_Waga.Name = "textBox_Waga";
            this.textBox_Waga.Size = new System.Drawing.Size(170, 31);
            this.textBox_Waga.TabIndex = 1;
            this.textBox_Waga.TextChanged += new System.EventHandler(this.textBox_Waga_TextChanged);
            // 
            // label_Wiek
            // 
            this.label_Wiek.AutoSize = true;
            this.label_Wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Wiek.Location = new System.Drawing.Point(50, 45);
            this.label_Wiek.Name = "label_Wiek";
            this.label_Wiek.Size = new System.Drawing.Size(60, 25);
            this.label_Wiek.TabIndex = 4;
            this.label_Wiek.Text = "Wiek";
            // 
            // label_Waga
            // 
            this.label_Waga.AutoSize = true;
            this.label_Waga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Waga.Location = new System.Drawing.Point(50, 91);
            this.label_Waga.Name = "label_Waga";
            this.label_Waga.Size = new System.Drawing.Size(68, 25);
            this.label_Waga.TabIndex = 5;
            this.label_Waga.Text = "Waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label_Plec
            // 
            this.label_Plec.AutoSize = true;
            this.label_Plec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Plec.Location = new System.Drawing.Point(50, 178);
            this.label_Plec.Name = "label_Plec";
            this.label_Plec.Size = new System.Drawing.Size(54, 25);
            this.label_Plec.TabIndex = 7;
            this.label_Plec.Text = "Płeć";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Graj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton_Kob
            // 
            this.radioButton_Kob.AutoSize = true;
            this.radioButton_Kob.Location = new System.Drawing.Point(158, 185);
            this.radioButton_Kob.Name = "radioButton_Kob";
            this.radioButton_Kob.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Kob.TabIndex = 11;
            this.radioButton_Kob.TabStop = true;
            this.radioButton_Kob.Text = "Kobieta";
            this.radioButton_Kob.UseVisualStyleBackColor = true;
            this.radioButton_Kob.CheckedChanged += new System.EventHandler(this.radioButton_Kob_CheckedChanged);
            // 
            // radioButton_Men
            // 
            this.radioButton_Men.AutoSize = true;
            this.radioButton_Men.Location = new System.Drawing.Point(250, 185);
            this.radioButton_Men.Name = "radioButton_Men";
            this.radioButton_Men.Size = new System.Drawing.Size(78, 17);
            this.radioButton_Men.TabIndex = 12;
            this.radioButton_Men.TabStop = true;
            this.radioButton_Men.Text = "Mężczyzna";
            this.radioButton_Men.UseVisualStyleBackColor = true;
            this.radioButton_Men.CheckedChanged += new System.EventHandler(this.radioButton_Men_CheckedChanged);
            // 
            // label_Akt
            // 
            this.label_Akt.AutoSize = true;
            this.label_Akt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Akt.Location = new System.Drawing.Point(31, 223);
            this.label_Akt.Name = "label_Akt";
            this.label_Akt.Size = new System.Drawing.Size(121, 50);
            this.label_Akt.TabIndex = 13;
            this.label_Akt.Text = "Aktywność \r\nfizyczna";
            // 
            // comboBox_Akt
            // 
            this.comboBox_Akt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Akt.FormattingEnabled = true;
            this.comboBox_Akt.Items.AddRange(new object[] {
            "Żadna",
            "1-2 dni w tygodniu",
            "3-4 dni w tygodniu",
            "Codziennie/Prawie codziennie"});
            this.comboBox_Akt.Location = new System.Drawing.Point(158, 224);
            this.comboBox_Akt.Name = "comboBox_Akt";
            this.comboBox_Akt.Size = new System.Drawing.Size(170, 28);
            this.comboBox_Akt.TabIndex = 14;
            this.comboBox_Akt.SelectedIndexChanged += new System.EventHandler(this.comboBox_Akt_SelectedIndexChanged);
            // 
            // textBox_Wzrost
            // 
            this.textBox_Wzrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Wzrost.Location = new System.Drawing.Point(158, 131);
            this.textBox_Wzrost.Name = "textBox_Wzrost";
            this.textBox_Wzrost.Size = new System.Drawing.Size(170, 31);
            this.textBox_Wzrost.TabIndex = 15;
            // 
            // label_Wzrost
            // 
            this.label_Wzrost.AutoSize = true;
            this.label_Wzrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Wzrost.Location = new System.Drawing.Point(50, 134);
            this.label_Wzrost.Name = "label_Wzrost";
            this.label_Wzrost.Size = new System.Drawing.Size(79, 25);
            this.label_Wzrost.TabIndex = 16;
            this.label_Wzrost.Text = "Wzrost";
            // 
            // Formularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label_Wzrost);
            this.Controls.Add(this.textBox_Wzrost);
            this.Controls.Add(this.comboBox_Akt);
            this.Controls.Add(this.label_Akt);
            this.Controls.Add(this.radioButton_Men);
            this.Controls.Add(this.radioButton_Kob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Plec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Waga);
            this.Controls.Add(this.label_Wiek);
            this.Controls.Add(this.textBox_Waga);
            this.Controls.Add(this.textBox_Wiek);
            this.Name = "Formularz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularz";
            this.Load += new System.EventHandler(this.Formularz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Wiek;
        private System.Windows.Forms.TextBox textBox_Waga;
        private System.Windows.Forms.Label label_Wiek;
        private System.Windows.Forms.Label label_Waga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Plec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton_Kob;
        private System.Windows.Forms.RadioButton radioButton_Men;
        private System.Windows.Forms.Label label_Akt;
        private System.Windows.Forms.ComboBox comboBox_Akt;
        private System.Windows.Forms.TextBox textBox_Wzrost;
        private System.Windows.Forms.Label label_Wzrost;
    }
}