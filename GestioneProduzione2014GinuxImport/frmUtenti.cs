using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestioneProduzione2014GinuxImport
{
    public partial class frmUtenti : GestioneProduzione2014GinuxImport.frmPlugin
    {
        public frmUtenti()
        {
            InitializeComponent();
        }

        private void frmUtenti_Load(object sender, EventArgs e)
        {
            this.t30_utentiTableAdapter.Fill(this.gestioneProduzione2009DataSet.t30_utenti);   
        }

        private void t30_articoliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t30_utentiBindingSource.EndEdit();
            this.t30_utentiTableAdapter.Update(this.gestioneProduzione2009DataSet.t30_utenti);
        }
    }
}

