using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneProduzione2014Data
{
    public class Configura
    {
        public static void Imposta(String connectionString)
        {
            GestioneProduzione2014Data.Properties.Settings.Default["GestioneProduzione2009ConnectionString"] = connectionString;
        }
    }
}
