using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestioneProduzione2014GinuxImport.Properties;
using System.IO;

namespace GestioneProduzione2014GinuxImport
{
    public partial class frmPlugin : Form
    {
        private String connectionString;
        private String ginuxPath;

        public String ConnectionString
        {
            get
            {
                if (connectionString == null)
                {
                    connectionString = Settings.Default.GestioneProduzione2009ConnectionString.ToString();
                }
                return connectionString;
            }
            set { connectionString = value; }
        }

        public String GinuxPath
        {
            get
            {
                if (ginuxPath == null)
                {
                    ginuxPath = Application.StartupPath;
                }
                return ginuxPath;
            }
            set { ginuxPath = value; }
        }

        public frmPlugin()
        {
            InitializeComponent();
        }

        //public frmPlugin(String connectionString)
        //    : this()
        //{
        //    this.connectionString = connectionString;
        //}

        public void Init(String connectionString, String ginuxPath)
        {
            this.connectionString = connectionString;
            this.ginuxPath = ginuxPath;
        }

        private void frmPlugin_Load(object sender, EventArgs e)
        {

        }

        protected string GetAppPath2(String fileName)
        {
            return Path.Combine(Application.StartupPath, fileName);
        }
    }
}