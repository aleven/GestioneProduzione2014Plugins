namespace GestioneProduzione2014GinuxImport
{
    partial class frmStampaEtichette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStampaEtichette));
            this.dataSetEtichette1 = new GestioneProduzione2014GinuxImport.DataSetEtichette();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEtichette1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetEtichette1
            // 
            this.dataSetEtichette1.DataSetName = "DataSetEtichette";
            this.dataSetEtichette1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.Controls.Add(this.radioButton5);
            this.flowLayoutPanel1.Controls.Add(this.radioButton6);
            this.flowLayoutPanel1.Controls.Add(this.radioButton7);
            this.flowLayoutPanel1.Controls.Add(this.radioButton8);
            this.flowLayoutPanel1.Controls.Add(this.radioButton9);
            this.flowLayoutPanel1.Controls.Add(this.radioButton10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 330);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 56);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pos 1";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(142, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 56);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Pos 2";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton3.Location = new System.Drawing.Point(13, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 56);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.Text = "Pos 3";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton4.Location = new System.Drawing.Point(142, 75);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(123, 56);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.Text = "Pos 4";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton5.Location = new System.Drawing.Point(13, 137);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(123, 56);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.Text = "Pos 5";
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton6.Location = new System.Drawing.Point(142, 137);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(123, 56);
            this.radioButton6.TabIndex = 15;
            this.radioButton6.Text = "Pos 6";
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton7.Location = new System.Drawing.Point(13, 199);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(123, 56);
            this.radioButton7.TabIndex = 16;
            this.radioButton7.Text = "Pos 7";
            this.radioButton7.UseVisualStyleBackColor = false;
            this.radioButton7.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton8.Location = new System.Drawing.Point(142, 199);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(123, 56);
            this.radioButton8.TabIndex = 17;
            this.radioButton8.Text = "Pos 8";
            this.radioButton8.UseVisualStyleBackColor = false;
            this.radioButton8.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton9.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton9.Location = new System.Drawing.Point(13, 261);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(123, 56);
            this.radioButton9.TabIndex = 18;
            this.radioButton9.Text = "Pos 9";
            this.radioButton9.UseVisualStyleBackColor = false;
            this.radioButton9.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton10.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton10.Location = new System.Drawing.Point(142, 261);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(123, 56);
            this.radioButton10.TabIndex = 19;
            this.radioButton10.Text = "Pos 10";
            this.radioButton10.UseVisualStyleBackColor = false;
            this.radioButton10.Click += new System.EventHandler(this.buttonPos_Click);
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPreview.Image = global::GestioneProduzione2014GinuxImport.Properties.Resources.document_preview;
            this.btnPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPreview.Location = new System.Drawing.Point(302, 301);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(128, 38);
            this.btnPrintPreview.TabIndex = 0;
            this.btnPrintPreview.Text = "Anteprima";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // frmStampaEtichette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 351);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnPrintPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStampaEtichette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stampa Etichette";
            this.Load += new System.EventHandler(this.frmStampaEtichette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEtichette1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        public DataSetEtichette dataSetEtichette1;
    }
}