using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using VS2005Commons;
using System.IO;
using System.Runtime.InteropServices;
using GestioneProduzione2014Data;
using GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters;
using System.Globalization;

namespace GestioneProduzione2014OfficeExport
{
    /// <summary>
    /// http://www.codeproject.com/Articles/22279/A-Complete-Excel-Programming-Sample
    /// </summary>
    public class GeneratoreOfferta
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeModelloExcel"></param>
        /// <returns></returns>
        public String Genera(String nomeModelloExcel, int idOfferta)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Workbook workbook = null;
            Worksheet worksheet = null;
            string res = null;

            try
            {
                // "Reda-Modello-Offerta-Italia.xls"
                String fileName = Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), nomeModelloExcel);

                if (File.Exists(fileName))
                {
                    GestioneProduzione2009DataSet dataset = new GestioneProduzione2009DataSet();
                    new t28_testate_ordini_cliTableAdapter().FillById(dataset.t28_testate_ordini_cli, idOfferta);
                    new t29_righe_ordine_cliTableAdapter().FillByIdTestataAll(dataset.t29_righe_ordine_cli, idOfferta);

                    if (dataset.t28_testate_ordini_cli.Rows.Count == 1)
                    {
                        GestioneProduzione2009DataSet.t28_testate_ordini_cliRow testata = (GestioneProduzione2009DataSet.t28_testate_ordini_cliRow)dataset.t28_testate_ordini_cli.Rows[0];
                        int numRighe = dataset.t29_righe_ordine_cli.Rows.Count;
                        int numFoglio = (numRighe < 24) ? 1 : 2;

                        xlApp = new Microsoft.Office.Interop.Excel.Application();

                        if (xlApp == null)
                        {
                            throw new NullReferenceException("EXCEL could not be started. Check that your office installation and project references are correct.");
                        }
                        xlApp.Visible = true;

                        // Workbook workbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                        workbook = xlApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        // workbook.Unprotect("password");
                        worksheet = (Worksheet)workbook.Worksheets[numFoglio];
                        // worksheet.Activate();

                        //workbook.Close(false, Type.Missing, Type.Missing);
                        //xlApp.Quit();

                        if (worksheet == null)
                        {
                            throw new NullReferenceException("Worksheet could not be created. Check that your office installation and project references are correct.");
                        }

                        /* Casella di Testo */
                        Shape shape = null;
                        String text = (testata.Ist28_offerta_clienteNull()) ? "Spett.\n" : testata.t28_offerta_cliente;

                        foreach (Shape shp in worksheet.Shapes)
                        {
                            String curText = shp.TextFrame.Characters(ExcelUtils.missing, ExcelUtils.missing).Text;
                            if (curText.StartsWith("Spett."))
                            {
                                shape = shp;
                                break;
                            }
                        }
                        if (shape != null)
                        {
                            shape.TextFrame.Characters(ExcelUtils.missing, ExcelUtils.missing).Text = text;
                        }


                        // 
                        // Range range = null;
                        // Tipo Documento
                        ExcelUtils.setValue(worksheet, "C13", "OFFERTA");
                        // Numero G13
                        ExcelUtils.setValue(worksheet, "G13", (testata.Ist28_offerta_numNull()) ? "" : testata.t28_offerta_num);
                        // Data I13
                        ExcelUtils.setValue(worksheet, "I13", (testata.Ist28_offerta_delNull()) ? new DateTime() : testata.t28_offerta_del);
                        // Codice Cliente C15
                        ExcelUtils.setValue(worksheet, "C15", (testata.Ist28_offerta_cliente_codNull()) ? "" : testata.t28_offerta_cliente_cod);
                        // Partita Iva G15
                        ExcelUtils.setValue(worksheet, "G15", (testata.Ist28_offerta_cliente_piNull()) ? "" : testata.t28_offerta_cliente_pi);
                        // ns. rif. C18
                        ExcelUtils.setValue(worksheet, "C18", (testata.Ist28_rif_redaNull()) ? "" : testata.t28_rif_reda);
                        // vs. rif. L18
                        ExcelUtils.setValue(worksheet, "L18", (testata.Ist28_rif_ordineNull()) ? "" : testata.t28_rif_ordine);
                        // Termini di Consegna C20
                        ExcelUtils.setValue(worksheet, "C20", (testata.Ist28_consegnaNull()) ? "" : testata.t28_consegna);
                        // Luogo di Consegna G20
                        ExcelUtils.setValue(worksheet, "G20", "");
                        // Trasporto L20
                        ExcelUtils.setValue(worksheet, "L20", "");
                        // Vettore Q20
                        ExcelUtils.setValue(worksheet, "Q20", "");

                        //if (aRange == null)
                        //{
                        //    Console.WriteLine("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
                        //}

                        //// Fill the cells in the C1 to C7 range of the worksheet with the number 6.
                        //Object[] args = new Object[1];
                        //args[0] = 6;
                        //aRange.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, aRange, args);

                        // Change the cells in the C1 to C7 range of the worksheet to the number 8.
                        // aRange.Value2 = 8;

                        //worksheet.get_Range("A10", "A10").Value2 = "INIZIO";

                        /*
                         * Svuotiamo le righe Excel
                         */
                        int numRigaExcel = 24;
                        //for (int i = 24; i < 48; i++)
                        //{
                        //    ExcelUtils.setValue(worksheet, "C" + numRigaExcel, "");
                        //    ExcelUtils.setValue(worksheet, "F" + numRigaExcel, "");
                        //    ExcelUtils.setValue(worksheet, "O" + numRigaExcel, "");
                        //    ExcelUtils.setValue(worksheet, "Q" + numRigaExcel, "");
                        //    ExcelUtils.setValue(worksheet, "R" + numRigaExcel, "");
                        //}

                        String lingua = (testata.Ist28_offerta_linguaNull()) ? "Italiano" : testata.t28_offerta_lingua;
                        
                        foreach (GestioneProduzione2009DataSet.t29_righe_ordine_cliRow rigaOfferta in dataset.t29_righe_ordine_cli.Rows)
                        {
                            //Range r = worksheet.get_Range("F" + row.ToString(), "F" + row.ToString()).EntireRow;
                            //r.Insert(XlInsertShiftDirection.xlShiftDown);
                            //r.Value2 = "for" + row.ToString();

                            // Codice
                            ExcelUtils.setValue(worksheet, "C" + numRigaExcel, (rigaOfferta.Ist29_matricolaNull()) ? "" : rigaOfferta.t29_matricola);
                            // Descrizione
                            // di default prendo la descrizione (che l'utente potrebbe aver inserito a mano
                            String descrizione = (rigaOfferta.Ist29_descrizioneNull()) ? "" : rigaOfferta.t29_descrizione;
                            if (!rigaOfferta.Ist29_id_articolo_t20Null() && rigaOfferta.t29_id_articolo_t20 > 0)
                            {
                                // provo a vedere se c'e' la descrizione in lingua
                                descrizione = descrizioneInLingua(rigaOfferta, lingua, "");
                                if (String.IsNullOrEmpty(descrizione))
                                {
                                    // se non ho trovato la lingua giusta verifico se c'e' almeno in inglese
                                    if (!rigaOfferta.Ist29_descrizione_commerciale_enNull() && !String.IsNullOrEmpty(rigaOfferta.t29_descrizione_commerciale_en))
                                    {
                                        descrizione = rigaOfferta.t29_descrizione_commerciale_en;
                                    }
                                }
                            }
                            ExcelUtils.setValue(worksheet, "F" + numRigaExcel, descrizione);
                            // Quantita
                            float quantita = 0;
                            if (!rigaOfferta.Ist29_qt_ordinataNull())
                            {
                                // float.TryParse(rigaOfferta.t29_qt_ordinata.ToString(), System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out quantita);
                                quantita = Convert.ToSingle(rigaOfferta.t29_qt_ordinata);
                            }
                            String quantitaTesto = (quantita != 0) ? quantita.ToString() : "";
                            ExcelUtils.setValue(worksheet, "O" + numRigaExcel, quantitaTesto);
                            // Sconto
                            float sconto = 0;
                            if (!testata.Ist28_scontoNull())
                            {
                                float.TryParse(testata.t28_sconto, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out sconto);
                            }
                            // sconto = sconto * -1;
                            sconto = sconto / 100;
                            // se sconto = 50 excel sottrae già il 50% quindi devo renderlo positivo essendo memorizzato come -50 nel db
                            //String sconto = (testata.Ist28_scontoNull()) ? "0" : testata.t28_sconto;
                            //if (sconto.StartsWith("-"))
                            //{
                            //    sconto = sconto.Substring(1);
                            //}
                            String scontoTesto = (quantita != 0 && sconto != 0) ? sconto.ToString() : "";
                            ExcelUtils.setValue(worksheet, "Q" + numRigaExcel, scontoTesto);
                            // Prezzo Unitario
                            String prezzoUniTesto = (quantita != 0 && !rigaOfferta.Ist29_prezzo_uniNull()) ? rigaOfferta.t29_prezzo_uni.ToString() : "";
                            ExcelUtils.setValue(worksheet, "R" + numRigaExcel, prezzoUniTesto);

                            numRigaExcel++;
                        }

                        //int row = 10;
                        //// To shift down a set of cells from columns A to F
                        //Range r = worksheet.get_Range("A" + row.ToString(), "F" + row.ToString());
                        //r.Insert(XlInsertShiftDirection.xlShiftDown, null);
                        //r.Value2 = "TEST" + row.ToString();

                        //// To shift down all of a row
                        //Range r1 = worksheet.get_Range("A" + row.ToString(), "A" + row.ToString()).EntireRow;
                        //r1.Insert(XlInsertShiftDirection.xlShiftDown, null);
                        //r1.Value2 = "TEST" + row.ToString();

                        String tempFileName = Path.GetTempFileName().Replace(".tmp", ".xls");
                        workbook.SaveCopyAs(tempFileName);
                        workbook.Close(false, Type.Missing, Type.Missing);
                        xlApp.Quit();

                        res = tempFileName;
                    }
                    else
                    {
                        throw new Exception("Carica i dati di una Offerta.");
                    }
                }
                else
                {
                    throw new FileNotFoundException("Impossibile trovare il file " + fileName + ".");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (worksheet != null)
                    Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                    Marshal.ReleaseComObject(workbook);
                if (xlApp != null)
                    Marshal.ReleaseComObject(xlApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            return res;
        }

        public static string descrizioneInLingua(GestioneProduzione2009DataSet.t29_righe_ordine_cliRow ricambio, String lingua, String defaultValue)
        {
            String res;
            res = defaultValue;
            if (lingua == "Italiano")
            {
                if (!ricambio.Ist29_descrizione_commerciale_itNull())
                {
                    res = ricambio.t29_descrizione_commerciale_it;
                }
            }
            else if (lingua == "Inglese")
            {
                if (!ricambio.Ist29_descrizione_commerciale_enNull())
                {
                    res = ricambio.t29_descrizione_commerciale_en;
                }
            }
            else if (lingua == "Spagnolo")
            {
                if (!ricambio.Ist29_descrizione_commerciale_esNull())
                {
                    res = ricambio.t29_descrizione_commerciale_es;
                }
            }
            else if (lingua == "Francese")
            {
                if (!ricambio.Ist29_descrizione_commerciale_frNull())
                {
                    res = ricambio.t29_descrizione_commerciale_fr;
                }
            }
            return res;
        }
    }
}
