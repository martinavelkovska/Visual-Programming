namespace Aerodromi_Juni
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
            this.lbAerodromi = new System.Windows.Forms.ListBox();
            this.lbDestinacii = new System.Windows.Forms.ListBox();
            this.btnDodadiAerodrom = new System.Windows.Forms.Button();
            this.tbNajskapaDestinacija = new System.Windows.Forms.TextBox();
            this.gbDestinacii = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProsecnaDolzina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzbrisiAerodrom = new System.Windows.Forms.Button();
            this.btnDodadiDestinacija = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDestinacii.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAerodromi
            // 
            this.lbAerodromi.FormattingEnabled = true;
            this.lbAerodromi.ItemHeight = 16;
            this.lbAerodromi.Location = new System.Drawing.Point(46, 50);
            this.lbAerodromi.Name = "lbAerodromi";
            this.lbAerodromi.Size = new System.Drawing.Size(376, 276);
            this.lbAerodromi.TabIndex = 0;
            this.lbAerodromi.SelectedIndexChanged += new System.EventHandler(this.lbAerodromi_SelectedIndexChanged);
            // 
            // lbDestinacii
            // 
            this.lbDestinacii.FormattingEnabled = true;
            this.lbDestinacii.ItemHeight = 16;
            this.lbDestinacii.Location = new System.Drawing.Point(448, 50);
            this.lbDestinacii.Name = "lbDestinacii";
            this.lbDestinacii.Size = new System.Drawing.Size(376, 276);
            this.lbDestinacii.TabIndex = 1;
            // 
            // btnDodadiAerodrom
            // 
            this.btnDodadiAerodrom.Location = new System.Drawing.Point(46, 383);
            this.btnDodadiAerodrom.Name = "btnDodadiAerodrom";
            this.btnDodadiAerodrom.Size = new System.Drawing.Size(376, 23);
            this.btnDodadiAerodrom.TabIndex = 2;
            this.btnDodadiAerodrom.Text = "Додади аеродром";
            this.btnDodadiAerodrom.UseVisualStyleBackColor = true;
            this.btnDodadiAerodrom.Click += new System.EventHandler(this.btnDodadiAerdrom_Click);
            // 
            // tbNajskapaDestinacija
            // 
            this.tbNajskapaDestinacija.Location = new System.Drawing.Point(6, 65);
            this.tbNajskapaDestinacija.Name = "tbNajskapaDestinacija";
            this.tbNajskapaDestinacija.Size = new System.Drawing.Size(364, 22);
            this.tbNajskapaDestinacija.TabIndex = 3;
            // 
            // gbDestinacii
            // 
            this.gbDestinacii.Controls.Add(this.label3);
            this.gbDestinacii.Controls.Add(this.label2);
            this.gbDestinacii.Controls.Add(this.tbProsecnaDolzina);
            this.gbDestinacii.Controls.Add(this.tbNajskapaDestinacija);
            this.gbDestinacii.Location = new System.Drawing.Point(448, 358);
            this.gbDestinacii.Name = "gbDestinacii";
            this.gbDestinacii.Size = new System.Drawing.Size(376, 172);
            this.gbDestinacii.TabIndex = 4;
            this.gbDestinacii.TabStop = false;
            this.gbDestinacii.Text = "Дестинации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродороми";
            // 
            // tbProsecnaDolzina
            // 
            this.tbProsecnaDolzina.Location = new System.Drawing.Point(6, 140);
            this.tbProsecnaDolzina.Name = "tbProsecnaDolzina";
            this.tbProsecnaDolzina.Size = new System.Drawing.Size(364, 22);
            this.tbProsecnaDolzina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Најскапа дестинација";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Просечна должина на дестинациите";
            // 
            // btnIzbrisiAerodrom
            // 
            this.btnIzbrisiAerodrom.Location = new System.Drawing.Point(46, 439);
            this.btnIzbrisiAerodrom.Name = "btnIzbrisiAerodrom";
            this.btnIzbrisiAerodrom.Size = new System.Drawing.Size(376, 23);
            this.btnIzbrisiAerodrom.TabIndex = 5;
            this.btnIzbrisiAerodrom.Text = "Избриши аеродром";
            this.btnIzbrisiAerodrom.UseVisualStyleBackColor = true;
            this.btnIzbrisiAerodrom.Click += new System.EventHandler(this.btnIzbrisiAerodrom_Click);
            // 
            // btnDodadiDestinacija
            // 
            this.btnDodadiDestinacija.Location = new System.Drawing.Point(46, 497);
            this.btnDodadiDestinacija.Name = "btnDodadiDestinacija";
            this.btnDodadiDestinacija.Size = new System.Drawing.Size(376, 23);
            this.btnDodadiDestinacija.TabIndex = 6;
            this.btnDodadiDestinacija.Text = "Додади дестинација";
            this.btnDodadiDestinacija.UseVisualStyleBackColor = true;
            this.btnDodadiDestinacija.Click += new System.EventHandler(this.btnDodadiDestinacija_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дестинации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 597);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodadiDestinacija);
            this.Controls.Add(this.btnIzbrisiAerodrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDestinacii);
            this.Controls.Add(this.btnDodadiAerodrom);
            this.Controls.Add(this.lbDestinacii);
            this.Controls.Add(this.lbAerodromi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDestinacii.ResumeLayout(false);
            this.gbDestinacii.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAerodromi;
        private System.Windows.Forms.ListBox lbDestinacii;
        private System.Windows.Forms.Button btnDodadiAerodrom;
        private System.Windows.Forms.TextBox tbNajskapaDestinacija;
        private System.Windows.Forms.GroupBox gbDestinacii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProsecnaDolzina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrisiAerodrom;
        private System.Windows.Forms.Button btnDodadiDestinacija;
        private System.Windows.Forms.Label label4;
    }
}

