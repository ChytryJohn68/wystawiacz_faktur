namespace wystawiacz_faktur.UI
{
    partial class OknoAktualizowania
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colnazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumer_konta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkod_pocztowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmiasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnazwa,
            this.colNIP,
            this.coladres,
            this.colnumer_konta,
            this.colkod_pocztowy,
            this.colmiasto,
            this.coltyp});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1440, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // colnazwa
            // 
            this.colnazwa.DataPropertyName = "nazwa";
            this.colnazwa.HeaderText = "Nazwa";
            this.colnazwa.MinimumWidth = 6;
            this.colnazwa.Name = "colnazwa";
            this.colnazwa.Width = 125;
            // 
            // colNIP
            // 
            this.colNIP.DataPropertyName = "NIP";
            this.colNIP.HeaderText = "NIP";
            this.colNIP.MinimumWidth = 6;
            this.colNIP.Name = "colNIP";
            this.colNIP.Width = 125;
            // 
            // coladres
            // 
            this.coladres.DataPropertyName = "adres";
            this.coladres.HeaderText = "Adres";
            this.coladres.MinimumWidth = 6;
            this.coladres.Name = "coladres";
            this.coladres.Width = 125;
            // 
            // colnumer_konta
            // 
            this.colnumer_konta.DataPropertyName = "numer_konta";
            this.colnumer_konta.HeaderText = "Numer Konta";
            this.colnumer_konta.MinimumWidth = 6;
            this.colnumer_konta.Name = "colnumer_konta";
            this.colnumer_konta.Width = 125;
            // 
            // colkod_pocztowy
            // 
            this.colkod_pocztowy.DataPropertyName = "kod_pocztowy";
            this.colkod_pocztowy.HeaderText = "Kod Pocztowy";
            this.colkod_pocztowy.MinimumWidth = 6;
            this.colkod_pocztowy.Name = "colkod_pocztowy";
            this.colkod_pocztowy.Width = 125;
            // 
            // colmiasto
            // 
            this.colmiasto.DataPropertyName = "miasto";
            this.colmiasto.HeaderText = "Miasto";
            this.colmiasto.MinimumWidth = 6;
            this.colmiasto.Name = "colmiasto";
            this.colmiasto.Width = 125;
            // 
            // coltyp
            // 
            this.coltyp.DataPropertyName = "typ";
            this.coltyp.HeaderText = "Typ";
            this.coltyp.MinimumWidth = 6;
            this.coltyp.Name = "coltyp";
            this.coltyp.Width = 125;
            // 
            // OknoAktualizowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OknoAktualizowania";
            this.Text = "OknoAktualizowania";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn coladres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumer_konta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkod_pocztowy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmiasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltyp;
    }
}