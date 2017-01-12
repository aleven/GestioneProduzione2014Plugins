namespace GestioneProduzione2014OfficeExport
{
    partial class frmOffertaExcel
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
            this.gestioneProduzione2009DataSet1 = new GestioneProduzione2014Data.GestioneProduzione2009DataSet();
            this.t28_testate_ordini_cliTableAdapter1 = new GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter();
            this.t29_righe_ordine_cliTableAdapter1 = new GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter();
            this.btnTest = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProduzione2009DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gestioneProduzione2009DataSet1
            // 
            this.gestioneProduzione2009DataSet1.DataSetName = "GestioneProduzione2009DataSet";
            this.gestioneProduzione2009DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t28_testate_ordini_cliTableAdapter1
            // 
            this.t28_testate_ordini_cliTableAdapter1.ClearBeforeFill = true;
            // 
            // t29_righe_ordine_cliTableAdapter1
            // 
            this.t29_righe_ordine_cliTableAdapter1.ClearBeforeFill = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmOffertaExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 142);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnTest);
            this.Name = "frmOffertaExcel";
            this.Text = "frmOffertaExcel";
            this.Load += new System.EventHandler(this.frmOffertaExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProduzione2009DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestioneProduzione2014Data.GestioneProduzione2009DataSet gestioneProduzione2009DataSet1;
        private GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter t28_testate_ordini_cliTableAdapter1;
        private GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter t29_righe_ordine_cliTableAdapter1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}