namespace WA_Test_BWG_Tanti_Bwg
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAvvio2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnAvvio100 = new System.Windows.Forms.Button();
            this.btnStop100 = new System.Windows.Forms.Button();
            this.txtAvvio2 = new System.Windows.Forms.TextBox();
            this.txtAvvio100 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAvvio2
            // 
            this.btnAvvio2.Location = new System.Drawing.Point(21, 29);
            this.btnAvvio2.Name = "btnAvvio2";
            this.btnAvvio2.Size = new System.Drawing.Size(75, 23);
            this.btnAvvio2.TabIndex = 0;
            this.btnAvvio2.Text = "Avvio 2";
            this.btnAvvio2.UseVisualStyleBackColor = true;
            this.btnAvvio2.Click += new System.EventHandler(this.btnAvvio2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(21, 71);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(75, 23);
            this.btnStop2.TabIndex = 1;
            this.btnStop2.Text = "Stop 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnAvvio100
            // 
            this.btnAvvio100.Location = new System.Drawing.Point(320, 29);
            this.btnAvvio100.Name = "btnAvvio100";
            this.btnAvvio100.Size = new System.Drawing.Size(75, 23);
            this.btnAvvio100.TabIndex = 2;
            this.btnAvvio100.Text = "Avvio 100";
            this.btnAvvio100.UseVisualStyleBackColor = true;
            this.btnAvvio100.Click += new System.EventHandler(this.btnAvvio100_Click);
            // 
            // btnStop100
            // 
            this.btnStop100.Location = new System.Drawing.Point(320, 71);
            this.btnStop100.Name = "btnStop100";
            this.btnStop100.Size = new System.Drawing.Size(75, 23);
            this.btnStop100.TabIndex = 3;
            this.btnStop100.Text = "Stop 100";
            this.btnStop100.UseVisualStyleBackColor = true;
            this.btnStop100.Click += new System.EventHandler(this.btnStop100_Click);
            // 
            // txtAvvio2
            // 
            this.txtAvvio2.Location = new System.Drawing.Point(102, 29);
            this.txtAvvio2.Multiline = true;
            this.txtAvvio2.Name = "txtAvvio2";
            this.txtAvvio2.Size = new System.Drawing.Size(161, 318);
            this.txtAvvio2.TabIndex = 4;
            // 
            // txtAvvio100
            // 
            this.txtAvvio100.Location = new System.Drawing.Point(401, 29);
            this.txtAvvio100.Multiline = true;
            this.txtAvvio100.Name = "txtAvvio100";
            this.txtAvvio100.Size = new System.Drawing.Size(161, 318);
            this.txtAvvio100.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 373);
            this.Controls.Add(this.txtAvvio100);
            this.Controls.Add(this.txtAvvio2);
            this.Controls.Add(this.btnStop100);
            this.Controls.Add(this.btnAvvio100);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnAvvio2);
            this.Name = "frmMain";
            this.Text = "Tanti bgw";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvvio2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnAvvio100;
        private System.Windows.Forms.Button btnStop100;
        private System.Windows.Forms.TextBox txtAvvio2;
        private System.Windows.Forms.TextBox txtAvvio100;
        private System.ComponentModel.BackgroundWorker bgw1;
    }
}

