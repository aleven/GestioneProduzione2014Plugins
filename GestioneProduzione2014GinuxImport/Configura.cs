using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneProduzione2014GinuxImport
{
    public class Configura
    {
        public static void Imposta(String connectionString)
        {
            GestioneProduzione2014GinuxImport.Properties.Settings.Default["GestioneProduzione2009ConnectionString"] = connectionString;
        }
    }
}
