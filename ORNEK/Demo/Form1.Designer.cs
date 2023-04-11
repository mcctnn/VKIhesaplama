namespace Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxKilo = new System.Windows.Forms.TextBox();
            this.tbxBoy = new System.Windows.Forms.TextBox();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxKilo
            // 
            this.tbxKilo.Location = new System.Drawing.Point(151, 64);
            this.tbxKilo.Name = "tbxKilo";
            this.tbxKilo.Size = new System.Drawing.Size(100, 23);
            this.tbxKilo.TabIndex = 0;
            // 
            // tbxBoy
            // 
            this.tbxBoy.Location = new System.Drawing.Point(151, 99);
            this.tbxBoy.Name = "tbxBoy";
            this.tbxBoy.Size = new System.Drawing.Size(100, 23);
            this.tbxBoy.TabIndex = 1;
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(59, 72);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(71, 15);
            this.lblKilo.TabIndex = 2;
            this.lblKilo.Text = "Kilonuz(KG):";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(59, 107);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(81, 15);
            this.lblBoy.TabIndex = 3;
            this.lblBoy.Text = "Boyunuz(cm):";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(160, 139);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(155, 186);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(42, 15);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "sonuc:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.tbxBoy);
            this.Controls.Add(this.tbxKilo);
            this.Name = "Form1";
            this.Text = "VKIHESAPLA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxKilo;
        private TextBox tbxBoy;
        private Label lblKilo;
        private Label lblBoy;
        private Button btnHesapla;
        private Label lblSonuc;
    }
}