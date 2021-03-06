﻿using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace EC_Endpoint_Client.BaseForms
{
    public partial class SoapViewer : Form
    {
        public XmlDocument XmlDocument { get; set; }
        private string FullFileName { get; set; }
        public SoapViewer()
        {
            InitializeComponent();
        }

        public SoapViewer(XmlDocument xmlDoc)
        {
            InitializeComponent();
            XmlDocument = xmlDoc;
            var path = Path.GetTempPath();
            var filename = Guid.NewGuid().ToString() + ".xml";
            FullFileName = Path.Combine(path, filename);
           
            File.WriteAllText(FullFileName, xmlDoc.OuterXml);
            webBrowser1.Navigate(FullFileName);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if(File.Exists(FullFileName))
            {
                File.Delete(FullFileName);
            }
        }

        private void saveSoapMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(XmlDocument);
        }
    }
}
