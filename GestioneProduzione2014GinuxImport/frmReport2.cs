using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestioneProduzione2014GinuxImport
{
    public partial class frmReport2 : frmPlugin
    {
        public frmReport2()
        {
            InitializeComponent();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReport2_Load(object sender, EventArgs e)
        {
            impostaParametriServer();

            if (reportDocumentSource != null)
            {
                this.crystalReportViewer1.ReportSource = reportDocumentSource;
            }
        }

        private void impostaParametriServer()
        {

        }

        private void frmReport2_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportDocumentSource.Close();
        }
    }
}