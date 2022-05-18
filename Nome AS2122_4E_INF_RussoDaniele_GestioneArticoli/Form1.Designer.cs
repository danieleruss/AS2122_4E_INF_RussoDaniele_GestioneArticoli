namespace Nome_AS2122_4E_INF_RussoDaniele_GestioneArticoli
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
            this.lblArticoli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.cmbScelta = new System.Windows.Forms.ComboBox();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUnitaDiMisura = new System.Windows.Forms.ComboBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(91, 355);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(14, 15);
            this.lblArticoli.TabIndex = 18;
            this.lblArticoli.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Articoli";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(663, 70);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(125, 23);
            this.btnVisualizza.TabIndex = 16;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // cmbScelta
            // 
            this.cmbScelta.FormattingEnabled = true;
            this.cmbScelta.Location = new System.Drawing.Point(491, 70);
            this.cmbScelta.Name = "cmbScelta";
            this.cmbScelta.Size = new System.Drawing.Size(152, 23);
            this.cmbScelta.TabIndex = 15;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(491, 99);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(297, 274);
            this.lstVisualizza.TabIndex = 14;
            this.lstVisualizza.SelectedIndexChanged += new System.EventHandler(this.lstVisualizza_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUnitaDiMisura);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 275);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli articolo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbUnitaDiMisura
            // 
            this.cmbUnitaDiMisura.FormattingEnabled = true;
            this.cmbUnitaDiMisura.Location = new System.Drawing.Point(121, 119);
            this.cmbUnitaDiMisura.Name = "cmbUnitaDiMisura";
            this.cmbUnitaDiMisura.Size = new System.Drawing.Size(152, 23);
            this.cmbUnitaDiMisura.TabIndex = 8;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(121, 151);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(152, 23);
            this.txtPrezzo.TabIndex = 7;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(121, 75);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(152, 23);
            this.txtDescrizione.TabIndex = 6;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(121, 39);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(152, 23);
            this.txtCodice.TabIndex = 5;
            this.txtCodice.TextChanged += new System.EventHandler(this.txtCodice_TextChanged);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(117, 195);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(208, 46);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi/modifica articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unità di misura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.cmbScelta);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblArticoli;
        private Label label5;
        private Button btnVisualizza;
        private ComboBox cmbScelta;
        private ListBox lstVisualizza;
        private GroupBox groupBox1;
        private ComboBox cmbUnitaDiMisura;
        private TextBox txtPrezzo;
        private TextBox txtDescrizione;
        private TextBox txtCodice;
        private Button btnAggiungi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}