using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using VS2005Commons;
using GestioneProduzione2014Data;

namespace GestioneProduzione2014GinuxImport
{
    public partial class frmArticoliImporta : frmPlugin
    {
        enum View
        {
            ViewAll1,
            ViewLike2,
            ViewMatch3,
            ViewGP4,
            ViewGinux5,
            ViewNotLike6
        }

        View view = View.ViewAll1;
        Dictionary<string, double> prezziGinux = new Dictionary<string, double>();
        Dictionary<string, double> prezziGP = new Dictionary<string, double>();
        Dictionary<string, double> articoliGinuxNonTrovati = new Dictionary<string, double>();
        String desc = "";

        private String filter;
        private String selectionFormula;

        public frmArticoliImporta()
        {
            InitializeComponent();
        }

        private void frmArticoliImporta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            refreshText();
        }

        private void btnImporta_Click(object sender, EventArgs e)
        {
            caricaDati(true);
        }

        private void caricaDati(bool importa)
        {
            bool ciSonoDatiGinux = false;
            this.Cursor = Cursors.WaitCursor;
            if (importa)
            {
                ciSonoDatiGinux = caricaDatiGinux();
            }

            if (!importa || ciSonoDatiGinux)
            {
                caricaDati();
                verificaDati();
            }

            this.Cursor = Cursors.Default;
        }

        private void verificaDati()
        {
            int gp = 0;
            articoliGinuxNonTrovati.Clear();
            prezziGP.Clear();
            foreach (DataSetImport.t20_articoliRow row in this.dataSetImport1.t20_articoli.Rows)
            {
                gp++;
                row.stato = "";

                string codiceGestioneProduzione = null;
                if (!row.Ist20_cod_articoloNull())
                {
                    codiceGestioneProduzione = row.t20_cod_articolo.Trim().ToUpper();
                    prezziGP.Add(codiceGestioneProduzione, 0);
                }
                if (codiceGestioneProduzione != null && prezziGinux.ContainsKey(codiceGestioneProduzione))
                {
                    articoliGinuxNonTrovati.Remove(codiceGestioneProduzione);

                    row.ginux_codice = codiceGestioneProduzione;
                    double prezzoGinux = prezziGinux[codiceGestioneProduzione];
                    row.ginux_prezzo = prezzoGinux;

                    double perc = double.Parse(txtDifferenzaPerc.Text, System.Globalization.NumberStyles.Float);
                    double prezzoGestioneProduzione = decimal.ToDouble(row.t20_prezzo);
                    /*
                     * METODO 1
                     */
                    //double diff = Math.Abs(1 - (prezzoGinux / prezzoGestioneProduzione));
                    //if (diff == 0)
                    //{
                    //    row.stato = "=";
                    //}
                    //else if (diff * 100 > perc)
                    //{
                    //    row.stato = "<>";
                    //}
                    //else
                    //{
                    //    row.stato = "~";
                    //}
                    /*
                     * METODO2
                     */
                    double min = prezzoGestioneProduzione - (prezzoGestioneProduzione * (perc / 100));
                    double max = prezzoGestioneProduzione + (prezzoGestioneProduzione * (perc / 100));
                    if (prezzoGestioneProduzione - prezzoGinux == 0)
                    {
                        row.stato = "=";
                    }
                    else if (prezzoGinux > min && prezzoGinux < max)
                    {
                        row.stato = "~";
                    }
                    else if (prezzoGinux < min)
                    {
                        row.stato = "<";
                    }
                    else
                    {
                        row.stato = ">";
                    }
                }
                else
                {
                    row.stato = "---";
                }

                Application.DoEvents();
            }

            /*
             * Verifica dei Codici Ginux non presenti nella mappa dei codici GP
             */
            foreach (string codiceGinux in prezziGinux.Keys)
            {
                if (!prezziGP.ContainsKey(codiceGinux))
                {
                    double prezzoGinux = prezziGinux[codiceGinux];
                    this.dataSetImport1.t20_articoli.Addt20_articoliRow(null, codiceGinux, prezzoGinux, 0, "---", null);
                }
            }

            filtraDati();

            FormsHelper.Inform("OK, verificati " + gp + " articoli di GestioneProduzione con " + prezziGinux.Keys.Count + " articoli Ginux.", this.Text);
        }

        private void txtDifferenzaPerc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelectAll.Text = String.Format(desc, txtDifferenzaPerc.Text);
                // DataGridView1.Focus();
                // verificaDati();
                // txtDifferenzaPerc.Focus();
                caricaDati(false);
            }
        }

        private void btnViewGP_Click(object sender, EventArgs e)
        {
            view = View.ViewGP4;
            filtraDati();
        }

        private void btnViewGinux_Click(object sender, EventArgs e)
        {
            view = View.ViewGinux5;
            filtraDati();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            view = View.ViewAll1;
            filtraDati();
        }

        private void filtraDati()
        {
            btnViewAll.Checked = (view == View.ViewAll1);
            btnViewLike.Checked = (view == View.ViewLike2);
            btnViewMatch.Checked = (view == View.ViewMatch3);
            btnViewGP.Checked = (view == View.ViewGP4);
            btnViewGinux.Checked = (view == View.ViewGinux5);
            btnViewNotLike.Checked = (view == View.ViewNotLike6);

            filter = "";
            selectionFormula = "";

            if (btnViewAll.Checked)
            {
                //                
            }
            else if (btnViewGP.Checked)
            {
                filter += " " + dataSetImport1.t20_articoli.ginux_codiceColumn.ColumnName + " is null ";
                filter += " AND not " + dataSetImport1.t20_articoli.t20_cod_articoloColumn.ColumnName + " is null";

                selectionFormula += " isnull({" + dataSetImport1.t20_articoli.TableName + "." + dataSetImport1.t20_articoli.ginux_codiceColumn.ColumnName + "}) ";
                selectionFormula += " AND not isnull({" + dataSetImport1.t20_articoli.TableName + "." + dataSetImport1.t20_articoli.t20_cod_articoloColumn.ColumnName + "}) ";
            }
            else if (btnViewGinux.Checked)
            {
                filter += " not " + dataSetImport1.t20_articoli.ginux_codiceColumn.ColumnName + " is null ";
                filter += " AND " + dataSetImport1.t20_articoli.t20_cod_articoloColumn.ColumnName + " is null";

                selectionFormula += " not isnull({" + dataSetImport1.t20_articoli.TableName + "." + dataSetImport1.t20_articoli.ginux_codiceColumn.ColumnName + "}) ";
                selectionFormula += " AND isnull({" + dataSetImport1.t20_articoli.TableName + "." + dataSetImport1.t20_articoli.t20_cod_articoloColumn.ColumnName + "}) ";
            }
            else if (btnViewMatch.Checked)
            {
                filter += " not " + dataSetImport1.t20_articoli.ginux_codiceColumn.ColumnName + " is null ";
                filter += " AND not " + dataSetImport1.t20_articoli.t20_cod_articoloColumn.ColumnName + " is null";

                selectionFormula += " not isnull({" + dataSetImport1.t20_articoli.TableName + "." + dataSetImport1.t20_articoli.ginux_codiceColumn.ColumnName + "}) ";
                selectionFormula += " AND not isnull({" + dataSetImport1.t20_articoli.TableName + "." + dataSetImport1.t20_articoli.t20_cod_articoloColumn.ColumnName + "}) ";
            }
            else if (btnViewLike.Checked)
            {
                filter += " " + dataSetImport1.t20_articoli.statoColumn.ColumnName + " = '~' ";
                selectionFormula += " {" + dataSetImport1.t20_articoli + "." + dataSetImport1.t20_articoli.statoColumn.ColumnName + "} = '~' ";
            }
            else if (btnViewNotLike.Checked)
            {
                filter += " " + dataSetImport1.t20_articoli.statoColumn.ColumnName + " <> '~' ";
                filter += " AND " + dataSetImport1.t20_articoli.statoColumn.ColumnName + " <> '=' ";
                filter += " AND " + dataSetImport1.t20_articoli.statoColumn.ColumnName + " <> '---' ";
                selectionFormula += " {" + dataSetImport1.t20_articoli + "." + dataSetImport1.t20_articoli.statoColumn.ColumnName + "} <> '~' ";
                selectionFormula += " AND {" + dataSetImport1.t20_articoli + "." + dataSetImport1.t20_articoli.statoColumn.ColumnName + "} <> '=' ";
                selectionFormula += " AND {" + dataSetImport1.t20_articoli + "." + dataSetImport1.t20_articoli.statoColumn.ColumnName + "} <> '---' ";
            }

            this.t20_articoliBindingSource.Filter = filter;

        }

        private void btnViewMatch_Click(object sender, EventArgs e)
        {
            view = View.ViewMatch3;
            filtraDati();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (FormsHelper.ConfirmDefaultNo("Procedere con l'aggiornamento dei costi per gli Articoli Selezionati?", this.Text))
            {
                /* 
                 * aggiorno una copia dei dati perche' in griglia ci sono righe "nuove da ginux" che ho aggiunto che non voglio vengano inserite nel DB
                 */
                this.DataGridView1.EndEdit();
                DataSetImport.t20_articoliDataTable datiOriginali = t20_articoliTableAdapter.GetData();

                int modificati = 0;
                foreach (DataGridViewRow row in this.DataGridView1.Rows)
                {
                    if (row.Cells[ColumnSeleziona.Name].Value != null && row.Cells[ColumnSeleziona.Name].Value.ToString().Equals(Boolean.TrueString))
                    {
                        int idArticolo = Int32.Parse(row.Cells[t20idarticoloDataGridViewTextBoxColumn.Name].Value.ToString());
                        double prezzoGinux = Double.Parse(row.Cells[ginuxprezzoDataGridViewTextBoxColumn.Name].Value.ToString());

                        DataSetImport.t20_articoliRow articolo = datiOriginali.FindByt20_id_articolo(idArticolo);
                        // DataSetImport.t20_articoliRow articolo = this.dataSetImport1.t20_articoli.FindByt20_id_articolo(idArticolo);
                        articolo.t20_prezzo = new Decimal(prezzoGinux);
                        // this.t20_articoliTableAdapter.Update(articolo);this.t20_articoliTableAdapter.Update(articolo);
                        modificati++;
                    }
                }

                if (modificati > 0)
                {
                    int res = this.t20_articoliTableAdapter.Update(datiOriginali);
                    FormsHelper.Inform("Aggiornato il costo di " + res + " articoli.", this.Text);

                    caricaDati(false);
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            this.DataGridView1.EndEdit();
            this.DataGridView1.ClearSelection();
            foreach (DataGridViewRow row in this.DataGridView1.Rows)
            {
                if (row.Cells[stato.Name].Value.ToString() == "~")
                {
                    row.Cells[ColumnSeleziona.Name].Value = true;
                    row.Selected = true;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreview("REDA-ReportPrezzi.rpt");
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            this.DataGridView1.EndEdit();
            this.DataGridView1.ClearSelection();
            foreach (DataGridViewRow row in this.DataGridView1.Rows)
            {
                row.Cells[1].Value = false;
            }
        }

        private void txtDifferenzaPerc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void refreshText()
        {
            if (String.IsNullOrEmpty(desc))
                desc = btnSelectAll.Text;
            btnSelectAll.Text = String.Format(desc, txtDifferenzaPerc.Text);
        }

        private void caricaDati()
        {
            this.DataGridView1.EndEdit();
            this.DataGridView1.ClearSelection();

            this.dataSetImport1.Clear();
            if (this.DataGridView1.Rows != null && this.DataGridView1.Rows.Count > 0) this.DataGridView1.Rows.Clear();

            this.t20_articoliTableAdapter.Connection.ConnectionString = this.ConnectionString;
            this.t20_articoliTableAdapter.ClearBeforeFill = true;
            this.t20_articoliTableAdapter.Fill(this.dataSetImport1.t20_articoli);
        }

        private bool caricaDatiGinux()
        {
            bool res = false;
            List<String> data = new List<String>();
            String nomeFile = Path.Combine(GinuxPath, "COSTI.txt");

            if (File.Exists(nomeFile))
            {
                data = FileUtils.LeggiFileDiTesto(nomeFile);
            }

            if (data.Count > 0)
            {
                /* MAPPA di CODICI e PREZZI GINUX */
                bool duplicatiInGinux = false;
                prezziGinux.Clear();
                foreach (String riga in data)
                {
                    if (StringUtils.isNotBlank(riga))
                    {
                        string[] campi = riga.Split(';');
                        string strCodiceGinux = campi[0];
                        string strPrezzoGinux = campi[1];
                        strCodiceGinux = strCodiceGinux.Trim().ToUpper();
                        strPrezzoGinux = strPrezzoGinux.Trim();

                        // double prezzoGinux = double.Parse(strPrezzoGinux.Replace(",", "."));
                        double prezzoGinux = double.Parse(strPrezzoGinux, System.Globalization.NumberStyles.Float);

                        if (!prezziGinux.ContainsKey(strCodiceGinux))
                        {
                            prezziGinux.Add(strCodiceGinux, prezzoGinux);
                        }
                        else
                        {
                            duplicatiInGinux = true;
                        }
                    }
                }

                if (duplicatiInGinux)
                {
                    FormsHelper.Warn("Attenzione, ci sono dei duplicati.", this.Text);
                }

                res = true;
            }
            else
            {
                FormsHelper.Error("Nessuna riga dal file Ginux.\n" + nomeFile, this.Text);
            }

            return res;
        }

        private void btnViewLike_Click(object sender, EventArgs e)
        {
            view = View.ViewLike2;
            filtraDati();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PrintPreview("REDA-Etichette.rpt");
        }

        private void PrintPreview(String reportName)
        {
            frmReport2 report = new frmReport2();
            report.Init(this.ConnectionString, this.GinuxPath);
            // report.MdiParent = this.MdiParent;
            report.WindowState = FormWindowState.Maximized;
            report.reportDocumentSource.Load(GetAppPath2(reportName));
            report.reportDocumentSource.SetDataSource(this.dataSetImport1);

            //report.reportDocumentSource.SetParameterValue("btnViewAll", btnViewAll.Checked);
            //report.reportDocumentSource.SetParameterValue("btnViewMatch", btnViewMatch.Checked);
            //report.reportDocumentSource.SetParameterValue("btnViewGP", btnViewGP.Checked);
            //report.reportDocumentSource.SetParameterValue("btnViewGinux", btnViewGinux.Checked);
            //report.reportDocumentSource.SetParameterValue("btnViewLike", btnViewLike.Checked);

            // column binding sort

            // String filter = this.t20_articoliBindingSource.Filter;
            //report.reportDocumentSource.SetParameterValue("sortField", field);
            //report.reportDocumentSource.SetParameterValue("sortOrder", sortOrder);

            report.reportDocumentSource.RecordSelectionFormula = selectionFormula;
            // alemno un criterio di ordinamento impostato sul report mi permette di cambiarne il valore a piacimento
            String field = (DataGridView1.SortedColumn != null) ? DataGridView1.SortedColumn.DataPropertyName : null;
            if (field != null && this.dataSetImport1.t20_articoli.Columns.Contains(field))
            {
                String sortOrder = DataGridView1.SortOrder.ToString();
                CrystalDecisions.CrystalReports.Engine.FieldDefinition sortfield;
                sortfield = report.reportDocumentSource.Database.Tables[this.dataSetImport1.t20_articoli.TableName].Fields[field];
                report.reportDocumentSource.DataDefinition.SortFields[0].Field = sortfield;
                report.reportDocumentSource.DataDefinition.SortFields[0].SortDirection = (sortOrder.StartsWith("Asc")) ? CrystalDecisions.Shared.SortDirection.AscendingOrder : CrystalDecisions.Shared.SortDirection.DescendingOrder;
            }

            report.ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewNotLike_Click(object sender, EventArgs e)
        {
            view = View.ViewNotLike6;
            filtraDati();
        }

        private void btnUpdateGruppi_Click(object sender, EventArgs e)
        {
            

            String message = "Questa procedura aggiorna il prezzo dei Gruppi in funzione del prezzo degli articoli che lo compongono.";
            message += "\n" + "Sicuro di voler procedere?";

            if (FormsHelper.Confirm(message, this.Text))
            {
                this.Cursor = Cursors.WaitCursor;
                this.progressBar1.Visible = true;

                GestioneProduzione2009DataSet.t20_articoliDataTable articoli = t20_articoliTableAdapter1.GetData(); ;
                GestioneProduzione2009DataSet.t22_articoli_articoliDataTable relazioni = t22_articoli_articoliTableAdapter1.GetData();

                // aggiornaCostiGruppo(null, articoli, relazioni);
                int numGruppi = 0;
                this.progressBar1.Minimum = 0;
                this.progressBar1.Maximum = articoli.Rows.Count;
                foreach (GestioneProduzione2009DataSet.t20_articoliRow articolo in articoli.Rows)
                {
                    if (!articolo.Ist20_is_gruppoNull() && articolo.t20_is_gruppo)
                    {
                        // Console.WriteLine("gruppo {0}", articolo.t20_id_articolo);
                        aggiornaCostiGruppo(articolo, articoli, relazioni);
                        numGruppi++;
                    }

                    this.progressBar1.Value++;
                    Application.DoEvents();
                }

                this.Cursor = Cursors.Default;
                this.progressBar1.Visible = false;

                if (FormsHelper.Confirm(String.Format("Confermi aggiornamento di {0} gruppi?", numGruppi), this.Text))
                {
                    this.Cursor = Cursors.WaitCursor;
                    t20_articoliTableAdapter1.Update(articoli);
                    this.Cursor = Cursors.Default;
                    FormsHelper.Inform(String.Format("aggiornati {0} gruppi", numGruppi), this.Text);
                }
            }
        }

        private double aggiornaCostiGruppo(GestioneProduzione2009DataSet.t20_articoliRow articoloPadre, GestioneProduzione2009DataSet.t20_articoliDataTable articoli, GestioneProduzione2009DataSet.t22_articoli_articoliDataTable relazioni)
        {
            double prezzoCalcolato = 0;


            if (!articoloPadre.Ist20_is_gruppoNull() && articoloPadre.t20_is_gruppo)
            {
                /* stiamo valutando un gruppo */
                Console.WriteLine("gruppo id:{0} codice:{1}", articoloPadre.t20_id_articolo, articoloPadre.t20_cod_articolo);

                prezzoCalcolato = 0;
                /* per tutti i figli di questo */
                foreach (GestioneProduzione2009DataSet.t22_articoli_articoliRow relazione in relazioni.Rows)
                {
                    if (relazione.t22_id_articolo_padre_t20 == articoloPadre.t20_id_articolo)
                    {
                        GestioneProduzione2009DataSet.t20_articoliRow articoloFiglio = null;
                        foreach (GestioneProduzione2009DataSet.t20_articoliRow articolo in articoli.Rows)
                        {
                            if (articolo.t20_id_articolo == relazione.t22_id_articolo_t20)
                            {
                                articoloFiglio = articolo;
                                break;
                            }
                        }
                        if (articoloFiglio == null)
                        {
                            Console.WriteLine("Impossibile trovare articolo {0}", articoloFiglio.t20_id_articolo);
                        }
                        else
                        {

                            double consumo = (relazione.Ist22_consumoNull()) ? 0 : decimal.ToDouble(relazione.t22_consumo);
                            double prezzoArticolo = aggiornaCostiGruppo(articoloFiglio, articoli, relazioni);
                            Console.WriteLine("consumo {0} x {1} (gruppo:{2})", consumo, articoloFiglio.t20_id_articolo, articoloPadre.t20_is_gruppo);
                            Console.WriteLine("costo {0} ", (consumo * prezzoArticolo));
                            prezzoCalcolato = prezzoCalcolato + (consumo * prezzoArticolo);
                            
                        }
                    }
                }

                if (prezzoCalcolato > 0)
                {
                    articoloPadre.t20_prezzo = new Decimal(prezzoCalcolato);
                    Console.WriteLine("prezzo gruppo {0} = {1}", articoloPadre.t20_id_articolo, prezzoCalcolato);
                }

            }
            else
            {
                /* questo e' un articolo foglia, quindi utilizziamo il prezzo di questo articolo */
                double prezzo = (articoloPadre.Ist20_prezzoNull()) ? 0 : decimal.ToDouble(articoloPadre.t20_prezzo);
                double prezzo_forzato = (articoloPadre.Ist20_prezzo_forzatoNull()) ? 0 : decimal.ToDouble(articoloPadre.t20_prezzo_forzato);
                if (prezzo_forzato > 0)
                {
                    prezzo = prezzo_forzato;
                }
                prezzoCalcolato = prezzo;
                Console.WriteLine("articolo id:{0} codice:{1}", articoloPadre.t20_id_articolo, articoloPadre.t20_cod_articolo);
                Console.WriteLine("prezzo {0}", prezzoCalcolato);
            }


            return prezzoCalcolato;
        }
    }
}