namespace WindowsFormsApp
{
    partial class PostavkeForma
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.gbJezik = new System.Windows.Forms.GroupBox();
            this.rbEngleski = new System.Windows.Forms.RadioButton();
            this.rbHrvatski = new System.Windows.Forms.RadioButton();
            this.gbSpol = new System.Windows.Forms.GroupBox();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.gbJezik.SuspendLayout();
            this.gbSpol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(89, 128);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(79, 25);
            this.btnOdustani.TabIndex = 0;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(174, 128);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(90, 25);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // gbJezik
            // 
            this.gbJezik.Controls.Add(this.rbEngleski);
            this.gbJezik.Controls.Add(this.rbHrvatski);
            this.gbJezik.Location = new System.Drawing.Point(16, 12);
            this.gbJezik.Name = "gbJezik";
            this.gbJezik.Size = new System.Drawing.Size(152, 100);
            this.gbJezik.TabIndex = 2;
            this.gbJezik.TabStop = false;
            this.gbJezik.Text = "Jezik";
            // 
            // rbEngleski
            // 
            this.rbEngleski.AutoSize = true;
            this.rbEngleski.Location = new System.Drawing.Point(24, 58);
            this.rbEngleski.Name = "rbEngleski";
            this.rbEngleski.Size = new System.Drawing.Size(65, 17);
            this.rbEngleski.TabIndex = 1;
            this.rbEngleski.TabStop = true;
            this.rbEngleski.Text = "&Engleski";
            this.rbEngleski.UseVisualStyleBackColor = true;
            // 
            // rbHrvatski
            // 
            this.rbHrvatski.AutoSize = true;
            this.rbHrvatski.Location = new System.Drawing.Point(24, 26);
            this.rbHrvatski.Name = "rbHrvatski";
            this.rbHrvatski.Size = new System.Drawing.Size(64, 17);
            this.rbHrvatski.TabIndex = 0;
            this.rbHrvatski.TabStop = true;
            this.rbHrvatski.Text = "&Hrvatski";
            this.rbHrvatski.UseVisualStyleBackColor = true;
            // 
            // gbSpol
            // 
            this.gbSpol.Controls.Add(this.rbZenski);
            this.gbSpol.Controls.Add(this.rbMuski);
            this.gbSpol.Location = new System.Drawing.Point(174, 12);
            this.gbSpol.Name = "gbSpol";
            this.gbSpol.Size = new System.Drawing.Size(152, 100);
            this.gbSpol.TabIndex = 3;
            this.gbSpol.TabStop = false;
            this.gbSpol.Text = "Spol";
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(27, 58);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(57, 17);
            this.rbZenski.TabIndex = 3;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "&Ženski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuski
            // 
            this.rbMuski.AutoSize = true;
            this.rbMuski.Location = new System.Drawing.Point(27, 26);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(53, 17);
            this.rbMuski.TabIndex = 2;
            this.rbMuski.TabStop = true;
            this.rbMuski.Text = "&Muški";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // PostavkeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 169);
            this.ControlBox = false;
            this.Controls.Add(this.gbSpol);
            this.Controls.Add(this.gbJezik);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostavkeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.Postavke_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Postavke_KeyDown);
            this.gbJezik.ResumeLayout(false);
            this.gbJezik.PerformLayout();
            this.gbSpol.ResumeLayout(false);
            this.gbSpol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.GroupBox gbJezik;
        private System.Windows.Forms.RadioButton rbEngleski;
        private System.Windows.Forms.RadioButton rbHrvatski;
        private System.Windows.Forms.GroupBox gbSpol;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.RadioButton rbMuski;
    }
}