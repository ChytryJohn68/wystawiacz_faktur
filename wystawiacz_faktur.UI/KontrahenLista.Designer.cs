namespace wystawiacz_faktur.UI
{
    partial class KontrahenLista
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
            this.colid_nabywca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumer_konta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj Kontrahenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Skasuj Kontrahenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edytuj Kontrahenta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid_nabywca,
            this.colnazwa,
            this.coladres,
            this.colnumer_konta,
            this.coltyp});
            this.dataGridView1.Location = new System.Drawing.Point(6, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 365);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // colid_nabywca
            // 
            this.colid_nabywca.DataPropertyName = "id_nabywca";
            this.colid_nabywca.HeaderText = "ID";
            this.colid_nabywca.MinimumWidth = 6;
            this.colid_nabywca.Name = "colid_nabywca";
            this.colid_nabywca.ReadOnly = true;
            this.colid_nabywca.Width = 125;
            // 
            // colnazwa
            // 
            this.colnazwa.DataPropertyName = "nazwa";
            this.colnazwa.HeaderText = "Nazwa";
            this.colnazwa.MinimumWidth = 6;
            this.colnazwa.Name = "colnazwa";
            this.colnazwa.ReadOnly = true;
            this.colnazwa.Width = 125;
            // 
            // coladres
            // 
            this.coladres.DataPropertyName = "adres";
            this.coladres.HeaderText = "Adres";
            this.coladres.MinimumWidth = 6;
            this.coladres.Name = "coladres";
            this.coladres.ReadOnly = true;
            this.coladres.Width = 125;
            // 
            // colnumer_konta
            // 
            this.colnumer_konta.DataPropertyName = "numer_konta";
            this.colnumer_konta.HeaderText = "Numer Konta";
            this.colnumer_konta.MinimumWidth = 6;
            this.colnumer_konta.Name = "colnumer_konta";
            this.colnumer_konta.ReadOnly = true;
            this.colnumer_konta.Width = 125;
            // 
            // coltyp
            // 
            this.coltyp.DataPropertyName = "typ";
            this.coltyp.HeaderText = "Typ";
            this.coltyp.MinimumWidth = 6;
            this.coltyp.Name = "coltyp";
            this.coltyp.ReadOnly = true;
            this.coltyp.Width = 125;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(863, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Odświerz Strone";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KontrahenLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KontrahenLista";
            this.Size = new System.Drawing.Size(984, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid_nabywca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn coladres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumer_konta;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltyp;
        private System.Windows.Forms.Button button4;
    }
}
