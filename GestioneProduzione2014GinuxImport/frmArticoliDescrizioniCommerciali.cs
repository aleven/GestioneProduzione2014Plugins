using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VS2005Commons;
using GestioneProduzione2014GinuxImport.Properties;
using GestioneProduzione2014Data;

namespace GestioneProduzione2014GinuxImport
{
    public partial class frmArticoliDescrizioniCommerciali : frmPlugin
    {
        private bool someChange = false;
        private object lastValue = null;

        public frmArticoliDescrizioniCommerciali()
        {
            InitializeComponent();
        }

        private void frmArticoliDescrizioniCommerciali_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            caricaDati();
        }

        private void caricaDati()
        {
            try
            {
                this.t20_articoliTableAdapter.Connection.ConnectionString = this.ConnectionString;
                this.t20_articoliTableAdapter.Fill(this.dataSetGestioneProduzione.t20_articoli);
                filtraDati();
            }
            catch (System.Exception ex)
            {
                FormsHelper.Error(ex.Message, this.Text);
            }
        }

        private void filtraDati()
        {
            StringBuilder filtro = new StringBuilder();
            filtro.Append(dataSetGestioneProduzione.t20_articoli.t20_is_ricambioColumn.ColumnName + " = 1");

            if (StringUtils.isNotBlank(txtSemeRicerca.Text))
            {
                String seme = txtSemeRicerca.Text.Trim();
                filtro.Append(" AND (");
                filtro.Append(QueryUtils.likeCondition(dataSetGestioneProduzione.t20_articoli.t20_cod_articoloColumn.ColumnName, seme));
                filtro.Append(" OR ");
                filtro.Append(QueryUtils.likeCondition(dataSetGestioneProduzione.t20_articoli.t20_descrizioneColumn.ColumnName, seme));
                filtro.Append(") ");
            }

            this.t20articoliBindingSource.Filter = filtro.ToString();
            txtRisultati.Text = "Trovati: " + this.t20articoliBindingSource.Count + " Ricambi";
        }

        private void txtSemeRicerca_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            filtraDati();
            //}
        }

        private void ChangeEditMode()
        {
            this.DataGridView1.ReadOnly = !this.DataGridView1.ReadOnly;
            this.DataGridView1.RowHeadersVisible = !this.DataGridView1.RowHeadersVisible;
            btnSalva.Visible = !this.DataGridView1.ReadOnly;

            if (!DataGridView1.ReadOnly)
            {
                btnModifica.Text = "Annulla";
                btnModifica.Image = Resources.undo;

                someChange = true;
                btnChiudi.Enabled = false;
            }
            else
            {

                foreach (GestioneProduzione2009DataSet.t20_articoliRow row in this.dataSetGestioneProduzione.t20_articoli.Rows)
                {
                    row.RejectChanges();
                }

                // CaricaDati()
                btnModifica.Text = "Modifica";
                btnModifica.Image = Resources.edit;

                someChange = false;

                btnChiudi.Enabled = true;
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ChangeEditMode();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lastValue = this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // inEdit = false;
            object currentValue = this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            someChange = someChange || !currentValue.Equals(lastValue);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            caricaDati();
        }

        private void frmArticoliDescrizioniCommerciali_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!someChange)
            {
                // this.Close();
            }
            else
            {
                if (FormsHelper.ConfirmDefaultNo("Chiudere annullando le eventuali modifiche?", this.Text))
                {
                    // this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                t20articoliBindingSource.EndEdit();
                this.t20_articoliTableAdapter.Update(this.dataSetGestioneProduzione.t20_articoli);

                // caricaDati();
                this.DataGridView1.Refresh();

                someChange = false;
                FormsHelper.Inform("Modifiche Salvate.", this.Text);
            }
            catch (System.Exception ex)
            {
                FormsHelper.Error(ex.Message, this.Text);
            }
        }


    }
}