using GestioneProduzione2014Data;
namespace GestioneProduzione2014GinuxImport
{
    partial class frmArticoliDescrizioniCommerciali
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
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.txtSemeRicerca = new System.Windows.Forms.ToolStripTextBox();
            this.txtRisultati = new System.Windows.Forms.ToolStripLabel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.t20articoliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGestioneProduzione = new GestioneProduzione2014Data.GestioneProduzione2009DataSet();
            this.t20_articoliTableAdapter = new GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.t20idarticoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20codarticoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20descrizionecommercialeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20descrizionecommercialeenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20descrizionecommercialeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t20descrizionecommercialefrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t20articoliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestioneProduzione)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnPrint,
            this.txtSemeRicerca,
            this.txtRisultati});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(729, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Cerca";
            // 
            // btnPrint
            // 
            this.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.printer;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 22);
            this.btnPrint.Text = "Stampa";
            this.btnPrint.Visible = false;
            // 
            // txtSemeRicerca
            // 
            this.txtSemeRicerca.Name = "txtSemeRicerca";
            this.txtSemeRicerca.Size = new System.Drawing.Size(100, 25);
            this.txtSemeRicerca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSemeRicerca_KeyUp);
            // 
            // txtRisultati
            // 
            this.txtRisultati.Name = "txtRisultati";
            this.txtRisultati.Size = new System.Drawing.Size(48, 22);
            this.txtRisultati.Text = "Trovati: ";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t20idarticoloDataGridViewTextBoxColumn,
            this.t20codarticoloDataGridViewTextBoxColumn,
            this.t20descrizioneDataGridViewTextBoxColumn,
            this.t20descrizionecommercialeitDataGridViewTextBoxColumn,
            this.t20descrizionecommercialeenDataGridViewTextBoxColumn,
            this.t20descrizionecommercialeesDataGridViewTextBoxColumn,
            this.t20descrizionecommercialefrDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.t20articoliBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(0, 28);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(729, 229);
            this.DataGridView1.TabIndex = 3;
            this.DataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView1_CellBeginEdit);
            this.DataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            // 
            // t20articoliBindingSource
            // 
            this.t20articoliBindingSource.DataMember = "t20_articoli";
            this.t20articoliBindingSource.DataSource = this.dataSetGestioneProduzione;
            // 
            // dataSetGestioneProduzione
            // 
            this.dataSetGestioneProduzione.DataSetName = "DataSetGestioneProduzione";
            this.dataSetGestioneProduzione.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t20_articoliTableAdapter
            // 
            this.t20_articoliTableAdapter.ClearBeforeFill = true;
            // 
            // btnChiudi
            // 
            this.btnChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChiudi.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.dialog_close;
            this.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiudi.Location = new System.Drawing.Point(620, 263);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(109, 31);
            this.btnChiudi.TabIndex = 4;
            this.btnChiudi.Text = "&Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalva.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.save_all;
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(390, 263);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(109, 31);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "&Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Visible = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.edit;
            this.btnModifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifica.Location = new System.Drawing.Point(505, 263);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(109, 31);
            this.btnModifica.TabIndex = 5;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // t20idarticoloDataGridViewTextBoxColumn
            // 
            this.t20idarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_id_articolo";
            this.t20idarticoloDataGridViewTextBoxColumn.HeaderText = "t20_id_articolo";
            this.t20idarticoloDataGridViewTextBoxColumn.Name = "t20idarticoloDataGridViewTextBoxColumn";
            this.t20idarticoloDataGridViewTextBoxColumn.ReadOnly = true;
            this.t20idarticoloDataGridViewTextBoxColumn.Visible = false;
            // 
            // t20codarticoloDataGridViewTextBoxColumn
            // 
            this.t20codarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_cod_articolo";
            this.t20codarticoloDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.t20codarticoloDataGridViewTextBoxColumn.Name = "t20codarticoloDataGridViewTextBoxColumn";
            this.t20codarticoloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t20descrizioneDataGridViewTextBoxColumn
            // 
            this.t20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione";
            this.t20descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione Tecnica";
            this.t20descrizioneDataGridViewTextBoxColumn.Name = "t20descrizioneDataGridViewTextBoxColumn";
            this.t20descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t20descrizionecommercialeitDataGridViewTextBoxColumn
            // 
            this.t20descrizionecommercialeitDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione_commerciale_it";
            this.t20descrizionecommercialeitDataGridViewTextBoxColumn.HeaderText = "Desc. Comm. Italiano";
            this.t20descrizionecommercialeitDataGridViewTextBoxColumn.Name = "t20descrizionecommercialeitDataGridViewTextBoxColumn";
            this.t20descrizionecommercialeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t20descrizionecommercialeenDataGridViewTextBoxColumn
            // 
            this.t20descrizionecommercialeenDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione_commerciale_en";
            this.t20descrizionecommercialeenDataGridViewTextBoxColumn.HeaderText = "Desc. Comm. Inglese";
            this.t20descrizionecommercialeenDataGridViewTextBoxColumn.Name = "t20descrizionecommercialeenDataGridViewTextBoxColumn";
            this.t20descrizionecommercialeenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t20descrizionecommercialeesDataGridViewTextBoxColumn
            // 
            this.t20descrizionecommercialeesDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione_commerciale_es";
            this.t20descrizionecommercialeesDataGridViewTextBoxColumn.HeaderText = "Desc. Comm. Spagnolo";
            this.t20descrizionecommercialeesDataGridViewTextBoxColumn.Name = "t20descrizionecommercialeesDataGridViewTextBoxColumn";
            this.t20descrizionecommercialeesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t20descrizionecommercialefrDataGridViewTextBoxColumn
            // 
            this.t20descrizionecommercialefrDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione_commerciale_fr";
            this.t20descrizionecommercialefrDataGridViewTextBoxColumn.HeaderText = "Desc. Comm. Francese";
            this.t20descrizionecommercialefrDataGridViewTextBoxColumn.Name = "t20descrizionecommercialefrDataGridViewTextBoxColumn";
            this.t20descrizionecommercialefrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmArticoliDescrizioniCommerciali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnChiudi;
            this.ClientSize = new System.Drawing.Size(729, 295);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmArticoliDescrizioniCommerciali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descrizioni Commerciali Ricambi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmArticoliDescrizioniCommerciali_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArticoliDescrizioniCommerciali_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t20articoliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestioneProduzione)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.Button btnChiudi;
        private GestioneProduzione2009DataSet dataSetGestioneProduzione;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.BindingSource t20articoliBindingSource;
        private GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter t20_articoliTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSemeRicerca;
        private System.Windows.Forms.ToolStripLabel txtRisultati;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20idarticoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20codarticoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20descrizionecommercialeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20descrizionecommercialeenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20descrizionecommercialeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t20descrizionecommercialefrDataGridViewTextBoxColumn;
    }
}