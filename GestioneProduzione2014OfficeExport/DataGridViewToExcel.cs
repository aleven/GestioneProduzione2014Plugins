using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GestioneProduzione2014OfficeExport
{
    public class DataGridViewToExcel
    {
        public static void toCSV(String nome, DataGridView dataGridView)
        {
            String StrExport = "";
            foreach (DataGridViewColumn C in dataGridView.Columns)
            {
                StrExport += "\"" + C.HeaderText + "\",";
            }
            StrExport = StrExport.Substring(0, StrExport.Length - 1);
            StrExport += Environment.NewLine;

            foreach (DataGridViewRow R in dataGridView.Rows)
            {
                foreach (DataGridViewCell C in R.Cells)
                {
                    if (C.Value != null)
                    {
                        StrExport += "\"" + C.Value.ToString() + "\",";
                    }
                    else
                    {
                        StrExport += "\"" + "" + "\",";
                    }
                }
                StrExport = StrExport.Substring(0, StrExport.Length - 1);
                StrExport += Environment.NewLine;
            }

            String file = nome + "_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm") + ".csv";
            file = Path.Combine(Path.GetTempPath(), file);
            using (TextWriter tw = new StreamWriter(file))
            {
                tw.Write(StrExport);
            }

            Process.Start(file);
        }
    }
}
