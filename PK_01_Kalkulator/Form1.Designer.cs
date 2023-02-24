namespace PK_01_Kalkulator
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
            this.textBoxLiczba1 = new System.Windows.Forms.TextBox();
            this.textBoxLiczba2 = new System.Windows.Forms.TextBox();
            this.textBoxLiczbaWynik = new System.Windows.Forms.TextBox();
            this.buttonLicz = new System.Windows.Forms.Button();
            this.listBoxDzialanie = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLiczba1
            // 
            this.textBoxLiczba1.Location = new System.Drawing.Point(99, 12);
            this.textBoxLiczba1.Name = "textBoxLiczba1";
            this.textBoxLiczba1.Size = new System.Drawing.Size(157, 20);
            this.textBoxLiczba1.TabIndex = 0;
            this.textBoxLiczba1.Text = "0";
            this.textBoxLiczba1.TextChanged += new System.EventHandler(this.textBoxLiczba1_TextChanged);
            // 
            // textBoxLiczba2
            // 
            this.textBoxLiczba2.Location = new System.Drawing.Point(99, 38);
            this.textBoxLiczba2.Name = "textBoxLiczba2";
            this.textBoxLiczba2.Size = new System.Drawing.Size(157, 20);
            this.textBoxLiczba2.TabIndex = 1;
            this.textBoxLiczba2.Text = "0";
            this.textBoxLiczba2.TextChanged += new System.EventHandler(this.textBoxLiczba2_TextChanged);
            // 
            // textBoxLiczbaWynik
            // 
            this.textBoxLiczbaWynik.Enabled = false;
            this.textBoxLiczbaWynik.Location = new System.Drawing.Point(99, 156);
            this.textBoxLiczbaWynik.Name = "textBoxLiczbaWynik";
            this.textBoxLiczbaWynik.Size = new System.Drawing.Size(157, 20);
            this.textBoxLiczbaWynik.TabIndex = 2;
            // 
            // buttonLicz
            // 
            this.buttonLicz.Location = new System.Drawing.Point(99, 127);
            this.buttonLicz.Name = "buttonLicz";
            this.buttonLicz.Size = new System.Drawing.Size(157, 23);
            this.buttonLicz.TabIndex = 3;
            this.buttonLicz.Text = "Licz";
            this.buttonLicz.UseVisualStyleBackColor = true;
            this.buttonLicz.Click += new System.EventHandler(this.buttonLicz_Click);
            // 
            // listBoxDzialanie
            // 
            this.listBoxDzialanie.FormattingEnabled = true;
            this.listBoxDzialanie.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.listBoxDzialanie.Location = new System.Drawing.Point(99, 65);
            this.listBoxDzialanie.Name = "listBoxDzialanie";
            this.listBoxDzialanie.Size = new System.Drawing.Size(157, 56);
            this.listBoxDzialanie.TabIndex = 4;
            this.listBoxDzialanie.SelectedIndexChanged += new System.EventHandler(this.listBoxDzialanie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liczba 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Liczba 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Działanie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 185);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDzialanie);
            this.Controls.Add(this.buttonLicz);
            this.Controls.Add(this.textBoxLiczbaWynik);
            this.Controls.Add(this.textBoxLiczba2);
            this.Controls.Add(this.textBoxLiczba1);
            this.Name = "Form1";
            this.Text = "Kalkulator v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLiczba1;
        private System.Windows.Forms.TextBox textBoxLiczba2;
        private System.Windows.Forms.TextBox textBoxLiczbaWynik;
        private System.Windows.Forms.Button buttonLicz;
        private System.Windows.Forms.ListBox listBoxDzialanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

