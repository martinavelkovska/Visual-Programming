namespace BussesSept
{
    partial class AddNewLine
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudCas = new System.Windows.Forms.NumericUpDown();
            this.tbDestinacija = new System.Windows.Forms.TextBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinuta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дестинација:";
            // 
            // nudCas
            // 
            this.nudCas.Location = new System.Drawing.Point(41, 111);
            this.nudCas.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudCas.Name = "nudCas";
            this.nudCas.Size = new System.Drawing.Size(82, 22);
            this.nudCas.TabIndex = 1;
            // 
            // tbDestinacija
            // 
            this.tbDestinacija.Location = new System.Drawing.Point(41, 39);
            this.tbDestinacija.Name = "tbDestinacija";
            this.tbDestinacija.Size = new System.Drawing.Size(259, 22);
            this.tbDestinacija.TabIndex = 2;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(48, 229);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(112, 23);
            this.btnDodadi.TabIndex = 3;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Минута";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Час";
            // 
            // nudMinuta
            // 
            this.nudMinuta.Location = new System.Drawing.Point(145, 111);
            this.nudMinuta.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinuta.Name = "nudMinuta";
            this.nudMinuta.Size = new System.Drawing.Size(82, 22);
            this.nudMinuta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена:";
            // 
            // nudCena
            // 
            this.nudCena.Location = new System.Drawing.Point(48, 175);
            this.nudCena.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(135, 22);
            this.nudCena.TabIndex = 8;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(191, 229);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(109, 23);
            this.btnOtkazi.TabIndex = 9;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // AddNewLine
            // 
            this.AcceptButton = this.btnDodadi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.nudCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMinuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.tbDestinacija);
            this.Controls.Add(this.nudCas);
            this.Controls.Add(this.label1);
            this.Name = "AddNewLine";
            this.Text = "AddNewLine";
            ((System.ComponentModel.ISupportInitialize)(this.nudCas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCas;
        private System.Windows.Forms.TextBox tbDestinacija;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinuta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.Button btnOtkazi;
    }
}