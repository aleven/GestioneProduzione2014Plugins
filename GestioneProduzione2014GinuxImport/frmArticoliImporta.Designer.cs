namespace GestioneProduzione2014GinuxImport
{
    partial class frmArticoliImporta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticoliImporta));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImporta = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewLike = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewNotLike = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewGP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewGinux = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtDifferenzaPerc = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectNone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnUpdateGruppi = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.t20idarticoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20_cod_articolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20prezzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ginuxcodiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ginuxprezzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeleziona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t20_articoliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetImport1 = new GestioneProduzione2014GinuxImport.DataSetImport();
            this.t20_articoliTableAdapter = new GestioneProduzione2014GinuxImport.DataSetImportTableAdapters.t20_articoliTableAdapter();
            this.t22_articoli_articoliTableAdapter1 = new GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter();
            this.t20_articoliTableAdapter1 = new GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter();
            this.ToolStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t20_articoliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetImport1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImporta,
            this.ToolStripDropDownButton1,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.txtDifferenzaPerc,
            this.ToolStripLabel2,
            this.ToolStripSeparator2,
            this.btnPrint,
            this.toolStripDropDownButton3,
            this.toolStripSeparator3});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(940, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnImporta
            // 
            this.btnImporta.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.db_comit;
            this.btnImporta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(65, 22);
            this.btnImporta.Text = "Importa";
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // ToolStripDropDownButton1
            // 
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewAll,
            this.toolStripMenuItem3,
            this.btnViewLike,
            this.btnViewNotLike,
            this.btnViewMatch,
            this.toolStripMenuItem1,
            this.btnViewGP,
            this.btnViewGinux});
            this.ToolStripDropDownButton1.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.cerca;
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(81, 22);
            this.ToolStripDropDownButton1.Text = "Visualizza";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Checked = true;
            this.btnViewAll.CheckOnClick = true;
            this.btnViewAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(315, 22);
            this.btnViewAll.Text = "Tutto";
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(312, 6);
            // 
            // btnViewLike
            // 
            this.btnViewLike.Name = "btnViewLike";
            this.btnViewLike.Size = new System.Drawing.Size(315, 22);
            this.btnViewLike.Text = "Codici Corrispondenti - Costi Simili";
            this.btnViewLike.Click += new System.EventHandler(this.btnViewLike_Click);
            // 
            // btnViewNotLike
            // 
            this.btnViewNotLike.Name = "btnViewNotLike";
            this.btnViewNotLike.Size = new System.Drawing.Size(315, 22);
            this.btnViewNotLike.Text = "Codici Corrispondenti - Costi Diversi";
            this.btnViewNotLike.Click += new System.EventHandler(this.btnViewNotLike_Click);
            // 
            // btnViewMatch
            // 
            this.btnViewMatch.Name = "btnViewMatch";
            this.btnViewMatch.Size = new System.Drawing.Size(315, 22);
            this.btnViewMatch.Text = "Codici Corrispondenti - Tutti";
            this.btnViewMatch.Click += new System.EventHandler(this.btnViewMatch_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(312, 6);
            // 
            // btnViewGP
            // 
            this.btnViewGP.CheckOnClick = true;
            this.btnViewGP.Name = "btnViewGP";
            this.btnViewGP.Size = new System.Drawing.Size(315, 22);
            this.btnViewGP.Text = "Presenti in Gestione Produzione ma non in Ginux";
            this.btnViewGP.Click += new System.EventHandler(this.btnViewGP_Click);
            // 
            // btnViewGinux
            // 
            this.btnViewGinux.CheckOnClick = true;
            this.btnViewGinux.Name = "btnViewGinux";
            this.btnViewGinux.Size = new System.Drawing.Size(315, 22);
            this.btnViewGinux.Text = "Presenti in Ginux ma non in Gestione Produzione";
            this.btnViewGinux.Click += new System.EventHandler(this.btnViewGinux_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(97, 22);
            this.ToolStripLabel1.Text = "Differenza di costo";
            // 
            // txtDifferenzaPerc
            // 
            this.txtDifferenzaPerc.Name = "txtDifferenzaPerc";
            this.txtDifferenzaPerc.Size = new System.Drawing.Size(40, 25);
            this.txtDifferenzaPerc.Text = "10";
            this.txtDifferenzaPerc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDifferenzaPerc_KeyPress);
            this.txtDifferenzaPerc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDifferenzaPerc_KeyUp);
            // 
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(18, 22);
            this.ToolStripLabel2.Text = "%";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.printer;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 22);
            this.btnPrint.Text = "Stampa";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectAll,
            this.btnSelectNone});
            this.toolStripDropDownButton3.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.apply;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton3.Text = "Seleziona";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(321, 22);
            this.btnSelectAll.Text = "Seleziona Articoli con differenza inferiore al {0}%";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(321, 22);
            this.btnSelectNone.Text = "Annulla Selezione";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.progressBar1);
            this.Panel1.Controls.Add(this.btnUpdateGruppi);
            this.Panel1.Controls.Add(this.btnApply);
            this.Panel1.Controls.Add(this.btnAnnulla);
            this.Panel1.Controls.Add(this.DataGridView1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 25);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(940, 393);
            this.Panel1.TabIndex = 2;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(466, 359);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // btnUpdateGruppi
            // 
            this.btnUpdateGruppi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateGruppi.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.ledyellow;
            this.btnUpdateGruppi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGruppi.Location = new System.Drawing.Point(466, 359);
            this.btnUpdateGruppi.Name = "btnUpdateGruppi";
            this.btnUpdateGruppi.Size = new System.Drawing.Size(175, 31);
            this.btnUpdateGruppi.TabIndex = 3;
            this.btnUpdateGruppi.Text = "Aggiorna Costo Gruppi";
            this.btnUpdateGruppi.UseVisualStyleBackColor = true;
            this.btnUpdateGruppi.Click += new System.EventHandler(this.btnUpdateGruppi_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.apply;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(647, 359);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(175, 31);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Aggiorna Costo Selezionati";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.dialog_close;
            this.btnAnnulla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulla.Location = new System.Drawing.Point(828, 359);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(109, 31);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t20idarticoloDataGridViewTextBoxColumn,
            this.t20_cod_articolo,
            this.t20descrizioneDataGridViewTextBoxColumn,
            this.t20prezzoDataGridViewTextBoxColumn,
            this.ginuxcodiceDataGridViewTextBoxColumn,
            this.ginuxprezzoDataGridViewTextBoxColumn,
            this.stato,
            this.ColumnSeleziona});
            this.DataGridView1.DataSource = this.t20_articoliBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(940, 353);
            this.DataGridView1.TabIndex = 0;
            // 
            // t20idarticoloDataGridViewTextBoxColumn
            // 
            this.t20idarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_id_articolo";
            this.t20idarticoloDataGridViewTextBoxColumn.HeaderText = "t20_id_articolo";
            this.t20idarticoloDataGridViewTextBoxColumn.Name = "t20idarticoloDataGridViewTextBoxColumn";
            this.t20idarticoloDataGridViewTextBoxColumn.ReadOnly = true;
            this.t20idarticoloDataGridViewTextBoxColumn.Visible = false;
            // 
            // t20_cod_articolo
            // 
            this.t20_cod_articolo.DataPropertyName = "t20_cod_articolo";
            this.t20_cod_articolo.HeaderText = "Codice";
            this.t20_cod_articolo.Name = "t20_cod_articolo";
            this.t20_cod_articolo.ReadOnly = true;
            // 
            // t20descrizioneDataGridViewTextBoxColumn
            // 
            this.t20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione";
            this.t20descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.t20descrizioneDataGridViewTextBoxColumn.Name = "t20descrizioneDataGridViewTextBoxColumn";
            this.t20descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t20prezzoDataGridViewTextBoxColumn
            // 
            this.t20prezzoDataGridViewTextBoxColumn.DataPropertyName = "t20_prezzo";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.t20prezzoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.t20prezzoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.t20prezzoDataGridViewTextBoxColumn.Name = "t20prezzoDataGridViewTextBoxColumn";
            this.t20prezzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ginuxcodiceDataGridViewTextBoxColumn
            // 
            this.ginuxcodiceDataGridViewTextBoxColumn.DataPropertyName = "ginux_codice";
            this.ginuxcodiceDataGridViewTextBoxColumn.HeaderText = "Codice Ginux";
            this.ginuxcodiceDataGridViewTextBoxColumn.Name = "ginuxcodiceDataGridViewTextBoxColumn";
            this.ginuxcodiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ginuxprezzoDataGridViewTextBoxColumn
            // 
            this.ginuxprezzoDataGridViewTextBoxColumn.DataPropertyName = "ginux_prezzo";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ginuxprezzoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ginuxprezzoDataGridViewTextBoxColumn.HeaderText = "Costo Ginux";
            this.ginuxprezzoDataGridViewTextBoxColumn.Name = "ginuxprezzoDataGridViewTextBoxColumn";
            this.ginuxprezzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stato
            // 
            this.stato.DataPropertyName = "stato";
            this.stato.HeaderText = "Stato";
            this.stato.Name = "stato";
            this.stato.ReadOnly = true;
            // 
            // ColumnSeleziona
            // 
            this.ColumnSeleziona.HeaderText = "Seleziona";
            this.ColumnSeleziona.Name = "ColumnSeleziona";
            this.ColumnSeleziona.Width = 70;
            // 
            // t20_articoliBindingSource
            // 
            this.t20_articoliBindingSource.DataMember = "t20_articoli";
            this.t20_articoliBindingSource.DataSource = this.dataSetImport1;
            // 
            // dataSetImport1
            // 
            this.dataSetImport1.DataSetName = "DataSetImport";
            this.dataSetImport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t20_articoliTableAdapter
            // 
            this.t20_articoliTableAdapter.ClearBeforeFill = true;
            // 
            // t22_articoli_articoliTableAdapter1
            // 
            this.t22_articoli_articoliTableAdapter1.ClearBeforeFill = true;
            // 
            // t20_articoliTableAdapter1
            // 
            this.t20_articoliTableAdapter1.ClearBeforeFill = true;
            // 
            // frmArticoliImporta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnulla;
            this.ClientSize = new System.Drawing.Size(940, 418);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticoliImporta";
            this.Text = "Importa Prezzi da Ginux";
            this.Load += new System.EventHandler(this.frmArticoliImporta_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t20_articoliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetImport1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnImporta;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripMenuItem btnViewAll;
        internal System.Windows.Forms.ToolStripMenuItem btnViewGP;
        internal System.Windows.Forms.ToolStripMenuItem btnViewGinux;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox txtDifferenzaPerc;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private DataSetImport dataSetImport1;
        private System.Windows.Forms.BindingSource t20_articoliBindingSource;
        private GestioneProduzione2014GinuxImport.DataSetImportTableAdapters.t20_articoliTableAdapter t20_articoliTableAdapter;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20codarticoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.ToolStripMenuItem btnViewMatch;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem btnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem btnSelectNone;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20idarticoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSeleziona;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20_cod_articolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20prezzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ginuxcodiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ginuxprezzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stato;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem btnViewLike;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnViewNotLike;
        private System.Windows.Forms.Button btnUpdateGruppi;
        private GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter t22_articoli_articoliTableAdapter1;
        private GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter t20_articoliTableAdapter1;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}

