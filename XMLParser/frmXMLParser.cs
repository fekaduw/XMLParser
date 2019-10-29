using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.XMLParser;
using DevExpress.XtraEditors;

namespace XMLParser
{
    public partial class frmXMLParser : DevExpress.XtraEditors.XtraForm
    {
        private const string GmlFileType = "*.GML | *.gml";
        private const string XmlFileType = "*.XML | *.xml";
        
        public frmXMLParser()
        {
            InitializeComponent();
        }

        private void btnOpenGMLFile_Click(object sender, EventArgs e)
        {
            try
            {
                var fileName = "";
                
                openFileDialog.Filter = GmlFileType;
                openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;

                lblSelectedGMLFile.Text = fileName;
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                var gmlFile = lblSelectedGMLFile.Text;
                var xmlFile = lblSelectedXMLFile.Text;
                var nodeName = txtNodeName.Text;

                if (!string.IsNullOrEmpty(nodeName) && !string.IsNullOrEmpty(gmlFile) && !string.IsNullOrEmpty(xmlFile))
                {
                    if(Parser.ReadXml(nodeName, gmlFile, Parser.GetDataTable(xmlFile)))
                        XtraMessageBox.Show("Successfully updated data");
                    else
                    {
                        XtraMessageBox.Show("Data reading and/or writing has some problems.");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnOpenXMLFile_Click(object sender, EventArgs e)
        {
            try
            {
                var fileName = "";

                openFileDialog.Filter = XmlFileType;
                openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;

                lblSelectedXMLFile.Text = fileName;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}