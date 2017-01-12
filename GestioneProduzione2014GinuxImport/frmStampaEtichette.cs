using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestioneProduzione2014GinuxImport
{
    public partial class frmStampaEtichette : frmPlugin
    {
        private int startPos = 1;


        public frmStampaEtichette()
        {
            InitializeComponent();
        }

        private void frmStampaEtichette_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void PrintPreview(String reportName)
        {
            frmReport2 report = new frmReport2();
            report.Init(this.ConnectionString, this.GinuxPath);
            // report.MdiParent = this.MdiParent;
            report.WindowState = FormWindowState.Maximized;
            report.reportDocumentSource.Load(GetAppPath2(reportName));
            report.reportDocumentSource.SetDataSource(this.dataSetEtichette1);


            //report.reportDocumentSource.RecordSelectionFormula = selectionFormula;
            //// alemno un criterio di ordinamento impostato sul report mi permette di cambiarne il valore a piacimento
            //String field = (DataGridView1.SortedColumn != null) ? DataGridView1.SortedColumn.DataPropertyName : null;
            //if (field != null && this.dataSetImport1.t20_articoli.Columns.Contains(field))
            //{
            //    String sortOrder = DataGridView1.SortOrder.ToString();
            //    CrystalDecisions.CrystalReports.Engine.FieldDefinition sortfield;
            //    sortfield = report.reportDocumentSource.Database.Tables[this.dataSetImport1.t20_articoli.TableName].Fields[field];
            //    report.reportDocumentSource.DataDefinition.SortFields[0].Field = sortfield;
            //    report.reportDocumentSource.DataDefinition.SortFields[0].SortDirection = (sortOrder.StartsWith("Asc")) ? CrystalDecisions.Shared.SortDirection.AscendingOrder : CrystalDecisions.Shared.SortDirection.DescendingOrder;
            //}

            report.ShowDialog();
        }

        private void caricaDati()
        {
            // this.dataSetEtichette1.Etichette.Clear();
            for (int i = 0; i < this.dataSetEtichette1.Etichette.Rows.Count; i++)
            {
                DataSetEtichette.EtichetteRow riga = (DataSetEtichette.EtichetteRow)this.dataSetEtichette1.Etichette.Rows[i];
                if (riga.Spazio)
                {
                    this.dataSetEtichette1.Etichette.Rows.RemoveAt(i);
                }
            }

            for (int i = 1; i < startPos; i++)
            {
                DataSetEtichette.EtichetteRow nuovaRiga = this.dataSetEtichette1.Etichette.NewEtichetteRow();
                nuovaRiga.Codice = "";
                nuovaRiga.Descrizione = "";
                nuovaRiga.Qta = 0;
                nuovaRiga.Spazio = true;
                // this.dataSetEtichette1.Etichette.AddEtichetteRow(nuovaRiga);
                this.dataSetEtichette1.Etichette.Rows.InsertAt(nuovaRiga, 0);
                // this.dataSetEtichette1.Etichette.AddEtichetteRow("-", 0, "-");
            }

            //foreach (DataSetEtichette.EtichetteRow riga in this.datiEtichette.Etichette.Rows)
            //{
            //    // this.dataSetEtichette1.Etichette.AddEtichetteRow("C" + i, i, "DESC" + i);
            //    this.dataSetEtichette1.Etichette.AddEtichetteRow(riga);
            //}
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            caricaDati();
            PrintPreview("REDA-Etichette.rpt");
        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            // Button btn = (Button)sender;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if (btn.Checked)
            {
                startPos = Int32.Parse(btn.Name.Replace("radioButton", ""));
                btn.BackColor = Color.White;
            }
            else
            {
                btn.BackColor = SystemColors.Control;
            }
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}