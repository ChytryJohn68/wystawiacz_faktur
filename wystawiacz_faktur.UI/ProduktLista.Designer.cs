namespace wystawiacz_faktur.UI
{
    partial class ProduktLista
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colid_faktura_poz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcena_netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colwartosc_vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj produkt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid_faktura_poz,
            this.colnazwa,
            this.colcena_netto,
            this.colwartosc_vat,
            this.colilosc});
            this.dataGridView1.Location = new System.Drawing.Point(6, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // colid_faktura_poz
            // 
            this.colid_faktura_poz.DataPropertyName = "id_faktura_poz";
            this.colid_faktura_poz.HeaderText = "ID";
            this.colid_faktura_poz.MinimumWidth = 6;
            this.colid_faktura_poz.Name = "colid_faktura_poz";
            this.colid_faktura_poz.ReadOnly = true;
            this.colid_faktura_poz.Width = 125;
            // 
            // colnazwa
            // 
            this.colnazwa.DataPropertyName = "nazwa";
            this.colnazwa.HeaderText = "Nazwa";
            this.colnazwa.MinimumWidth = 6;
            this.colnazwa.Name = "colnazwa";
            this.colnazwa.Width = 125;
            // 
            // colcena_netto
            // 
            this.colcena_netto.DataPropertyName = "cena_netto";
            this.colcena_netto.HeaderText = "Cena Netto";
            this.colcena_netto.MinimumWidth = 6;
            this.colcena_netto.Name = "colcena_netto";
            this.colcena_netto.Width = 125;
            // 
            // colwartosc_vat
            // 
            this.colwartosc_vat.DataPropertyName = "wartosc_vat";
            this.colwartosc_vat.HeaderText = "Vat";
            this.colwartosc_vat.MinimumWidth = 6;
            this.colwartosc_vat.Name = "colwartosc_vat";
            this.colwartosc_vat.Width = 125;
            // 
            // colilosc
            // 
            this.colilosc.DataPropertyName = "ilosc";
            this.colilosc.HeaderText = "Ilosc";
            this.colilosc.MinimumWidth = 6;
            this.colilosc.Name = "colilosc";
            this.colilosc.Width = 125;
            // 
            // ProduktLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProduktLista";
            this.Size = new System.Drawing.Size(984, 499);
            this.Load += new System.EventHandler(this.ProduktLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid_faktura_poz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcena_netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colwartosc_vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colilosc;
    }
}
