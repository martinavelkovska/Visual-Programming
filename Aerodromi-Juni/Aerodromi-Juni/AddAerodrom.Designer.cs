namespace Aerodromi_Juni
{
    partial class AddAerodrom
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbKratenka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDodadiAerodrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDodadiAerodrom
            // 
            this.gbDodadiAerodrom.Controls.Add(this.label3);
            this.gbDodadiAerodrom.Controls.Add(this.label2);
            this.gbDodadiAerodrom.Controls.Add(this.label1);
            this.gbDodadiAerodrom.Controls.Add(this.btnOtkazi);
            this.gbDodadiAerodrom.Controls.Add(this.btnZacuvaj);
            this.gbDodadiAerodrom.Controls.Add(this.tbKratenka);
            this.gbDodadiAerodrom.Controls.Add(this.tbIme);
            this.gbDodadiAerodrom.Controls.Add(this.tbGrad);
            this.gbDodadiAerodrom.Location = new System.Drawing.Point(38, 28);
            this.gbDodadiAerodrom.Name = "gbDodadiAerodrom";
            this.gbDodadiAerodrom.Size = new System.Drawing.Size(465, 292);
            this.gbDodadiAerodrom.TabIndex = 0;
            this.gbDodadiAerodrom.TabStop = false;
            this.gbDodadiAerodrom.Text = "Додади аеродром";
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(16, 69);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(396, 22);
            this.tbGrad.TabIndex = 0;
            this.tbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.tbGrad_Validating);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(16, 134);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(396, 22);
            this.tbIme.TabIndex = 1;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // tbKratenka
            // 
            this.tbKratenka.Location = new System.Drawing.Point(16, 192);
            this.tbKratenka.Name = "tbKratenka";
            this.tbKratenka.Size = new System.Drawing.Size(114, 22);
            this.tbKratenka.TabIndex = 2;
            this.tbKratenka.Validating += new System.ComponentModel.CancelEventHandler(this.tbKratenka_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Град:";
            // 
            // btnZacuvaj
            // 
            this.btnZacuvaj.Location = new System.Drawing.Point(26, 246);
            this.btnZacuvaj.Name = "btnZacuvaj";
            this.btnZacuvaj.Size = new System.Drawing.Size(153, 23);
            this.btnZacuvaj.TabIndex = 2;
            this.btnZacuvaj.Text = "Зачувај";
            this.btnZacuvaj.UseVisualStyleBackColor = true;
            this.btnZacuvaj.Click += new System.EventHandler(this.btnZacuvaj_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кртатенка:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddAerodrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDodadiAerodrom);
            this.Name = "AddAerodrom";
            this.Text = "AddAerodrom";
            this.gbDodadiAerodrom.ResumeLayout(false);
            this.gbDodadiAerodrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDodadiAerodrom;
        private System.Windows.Forms.TextBox tbKratenka;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbGrad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnZacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}