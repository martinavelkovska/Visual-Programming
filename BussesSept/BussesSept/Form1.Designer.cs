namespace BussesSept
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
            this.lbAvtobusi = new System.Windows.Forms.ListBox();
            this.lbLinii = new System.Windows.Forms.ListBox();
            this.btnDodadiAvtobus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbNajskapaLinija = new System.Windows.Forms.TextBox();
            this.tbProsecnaCenaNaLinii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAvtobusi
            // 
            this.lbAvtobusi.FormattingEnabled = true;
            this.lbAvtobusi.ItemHeight = 16;
            this.lbAvtobusi.Location = new System.Drawing.Point(34, 36);
            this.lbAvtobusi.Name = "lbAvtobusi";
            this.lbAvtobusi.Size = new System.Drawing.Size(266, 244);
            this.lbAvtobusi.TabIndex = 0;
            this.lbAvtobusi.SelectedIndexChanged += new System.EventHandler(this.lbAvtobusi_SelectedIndexChanged);
            // 
            // lbLinii
            // 
            this.lbLinii.FormattingEnabled = true;
            this.lbLinii.ItemHeight = 16;
            this.lbLinii.Location = new System.Drawing.Point(410, 36);
            this.lbLinii.Name = "lbLinii";
            this.lbLinii.Size = new System.Drawing.Size(266, 244);
            this.lbLinii.TabIndex = 1;
            // 
            // btnDodadiAvtobus
            // 
            this.btnDodadiAvtobus.Location = new System.Drawing.Point(34, 314);
            this.btnDodadiAvtobus.Name = "btnDodadiAvtobus";
            this.btnDodadiAvtobus.Size = new System.Drawing.Size(266, 23);
            this.btnDodadiAvtobus.TabIndex = 2;
            this.btnDodadiAvtobus.Text = "Додади Автобус";
            this.btnDodadiAvtobus.UseVisualStyleBackColor = true;
            this.btnDodadiAvtobus.Click += new System.EventHandler(this.btnDodadiAvtobus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Избриши автобус";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Додади Линија";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbNajskapaLinija
            // 
            this.tbNajskapaLinija.Enabled = false;
            this.tbNajskapaLinija.Location = new System.Drawing.Point(410, 325);
            this.tbNajskapaLinija.Name = "tbNajskapaLinija";
            this.tbNajskapaLinija.Size = new System.Drawing.Size(266, 22);
            this.tbNajskapaLinija.TabIndex = 5;
            this.tbNajskapaLinija.TextChanged += new System.EventHandler(this.tbNajskapaLinija_TextChanged);
            // 
            // tbProsecnaCenaNaLinii
            // 
            this.tbProsecnaCenaNaLinii.Enabled = false;
            this.tbProsecnaCenaNaLinii.Location = new System.Drawing.Point(410, 383);
            this.tbProsecnaCenaNaLinii.Name = "tbProsecnaCenaNaLinii";
            this.tbProsecnaCenaNaLinii.Size = new System.Drawing.Size(266, 22);
            this.tbProsecnaCenaNaLinii.TabIndex = 6;
            this.tbProsecnaCenaNaLinii.TextChanged += new System.EventHandler(this.tbProsecnaCenaNaLinii_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Најскапа линија";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Просечна цена на линиите";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Автобуси";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Линии";
            // 
            // Form1
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProsecnaCenaNaLinii);
            this.Controls.Add(this.tbNajskapaLinija);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodadiAvtobus);
            this.Controls.Add(this.lbLinii);
            this.Controls.Add(this.lbAvtobusi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvtobusi;
        private System.Windows.Forms.ListBox lbLinii;
        private System.Windows.Forms.Button btnDodadiAvtobus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbNajskapaLinija;
        private System.Windows.Forms.TextBox tbProsecnaCenaNaLinii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

