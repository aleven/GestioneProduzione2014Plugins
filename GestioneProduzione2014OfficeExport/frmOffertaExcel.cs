using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestioneProduzione2014Data;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using VS2005Commons;
using System.IO;

namespace GestioneProduzione2014OfficeExport
{
    public partial class frmOffertaExcel : Form
    {
        private int id = 87;

        public frmOffertaExcel()
        {
            InitializeComponent();
        }

        private void frmOffertaExcel_Load(object sender, EventArgs e)
        {
            // GestioneProduzione2009DataSet.t28_testate_ordini_cliDataTable testate = t28_testate_ordini_cliTableAdapter1.GetDataById(id);
            // GestioneProduzione2009DataSet.t29_righe_ordine_cliDataTable righe = t29_righe_ordine_cliTableAdapter1.GetDataByIdTestataAll(id);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                String excel = new GeneratoreOfferta().Genera("Reda-Offerta-Italiano.xls", 97);
                linkLabel1.Text = excel;
            }
            catch (Exception ex)
            {
                FormsHelper.Error(ex.Message, this.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(linkLabel1.Text))
            {
                System.Diagnostics.Process.Start(linkLabel1.Text);
            }
        }
    }
}