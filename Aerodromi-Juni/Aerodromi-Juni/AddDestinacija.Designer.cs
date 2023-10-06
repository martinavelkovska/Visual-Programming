namespace Aerodromi_Juni
{
    partial class AddDestinacija
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
            this.components = new System.ComponentModel.Container();
            this.gbDodadiAerodrom = new System.Windows.Forms.GroupBox();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.nudDolzina = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDodadiAerodrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolzina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDodadiAerodrom
            // 
            this.gbDodadiAerodrom.Controls.Add(this.nudCena);
            this.gbDodadiAerodrom.Controls.Add(this.nudDolzina);
            this.gbDodadiAerodrom.Controls.Add(this.label3);
            this.gbDodadiAerodrom.Controls.Add(this.label2);
            this.gbDodadiAerodrom.Controls.Add(this.label1);
            this.gbDodadiAerodrom.Controls.Add(this.btnOtkazi);
            this.gbDodadiAerodrom.Controls.Add(this.btnDodadi);
            this.gbDodadiAerodrom.Controls.Add(this.tbGrad);
            this.gbDodadiAerodrom.Location = new System.Drawing.Point(45, 40);
            this.gbDodadiAerodrom.Name = "gbDodadiAerodrom";
            this.gbDodadiAerodrom.Size = new System.Drawing.Size(465, 292);
            this.gbDodadiAerodrom.TabIndex = 1;
            this.gbDodadiAerodrom.TabStop = false;
            this.gbDodadiAerodrom.Text = "Додади дестинација";
            // 
            // nudCena
            // 
            this.nudCena.Location = new System.Drawing.Point(16, 197);
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(151, 22);
            this.nudCena.TabIndex = 7;
            // 
            // nudDolzina
            // 
            this.nudDolzina.Location = new System.Drawing.Point(16, 134);
            this.nudDolzina.Name = "nudDolzina";
            this.nudDolzina.Size = new System.Drawing.Size(151, 22);
            this.nudDolzina.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Должина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(259, 246);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(153, 23);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(26, 246);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(153, 23);
            this.btnDodadi.TabIndex = 2;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(16, 69);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(396, 22);
            this.tbGrad.TabIndex = 0;
            this.tbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.tbGrad_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddDestinacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDodadiAerodrom);
            this.Name = "AddDestinacija";
            this.Text = "AddDestinacija";
            this.gbDodadiAerodrom.ResumeLayout(false);
            this.gbDodadiAerodrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolzina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDodadiAerodrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.NumericUpDown nudDolzina;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}