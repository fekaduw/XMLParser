namespace XMLParser
{
    partial class frmXMLParser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXMLParser));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnOpenXMLFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnParse = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenGMLFile = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblSelectedGMLFile = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblSelectedXMLFile = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtNodeName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectedGMLFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectedXMLFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNodeName);
            this.layoutControl1.Controls.Add(this.btnOpenXMLFile);
            this.layoutControl1.Controls.Add(this.btnParse);
            this.layoutControl1.Controls.Add(this.btnOpenGMLFile);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(463, 143);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnOpenXMLFile
            // 
            this.btnOpenXMLFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenXMLFile.Image")));
            this.btnOpenXMLFile.Location = new System.Drawing.Point(12, 72);
            this.btnOpenXMLFile.Name = "btnOpenXMLFile";
            this.btnOpenXMLFile.Size = new System.Drawing.Size(108, 22);
            this.btnOpenXMLFile.StyleController = this.layoutControl1;
            this.btnOpenXMLFile.TabIndex = 6;
            this.btnOpenXMLFile.Text = "&Select XML file";
            this.btnOpenXMLFile.Click += new System.EventHandler(this.btnOpenXMLFile_Click);
            // 
            // btnParse
            // 
            this.btnParse.Image = ((System.Drawing.Image)(resources.GetObject("btnParse.Image")));
            this.btnParse.Location = new System.Drawing.Point(323, 109);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(128, 22);
            this.btnParse.StyleController = this.layoutControl1;
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "&Parse";
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnOpenGMLFile
            // 
            this.btnOpenGMLFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenGMLFile.Image")));
            this.btnOpenGMLFile.Location = new System.Drawing.Point(12, 36);
            this.btnOpenGMLFile.Name = "btnOpenGMLFile";
            this.btnOpenGMLFile.Size = new System.Drawing.Size(108, 22);
            this.btnOpenGMLFile.StyleController = this.layoutControl1;
            this.btnOpenGMLFile.TabIndex = 4;
            this.btnOpenGMLFile.Text = "&Select GML file";
            this.btnOpenGMLFile.Click += new System.EventHandler(this.btnOpenGMLFile_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblSelectedGMLFile,
            this.emptySpaceItem4,
            this.lblSelectedXMLFile,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(463, 143);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lblSelectedGMLFile
            // 
            this.lblSelectedGMLFile.AllowHotTrack = false;
            this.lblSelectedGMLFile.AppearanceItemCaption.BorderColor = System.Drawing.Color.Gray;
            this.lblSelectedGMLFile.AppearanceItemCaption.Options.UseBorderColor = true;
            this.lblSelectedGMLFile.Location = new System.Drawing.Point(112, 24);
            this.lblSelectedGMLFile.Name = "lblSelectedGMLFile";
            this.lblSelectedGMLFile.Size = new System.Drawing.Size(331, 26);
            this.lblSelectedGMLFile.Text = " ";
            this.lblSelectedGMLFile.TextSize = new System.Drawing.Size(54, 0);
            this.lblSelectedGMLFile.TextVisible = true;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 50);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(443, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblSelectedXMLFile
            // 
            this.lblSelectedXMLFile.AllowHotTrack = false;
            this.lblSelectedXMLFile.CustomizationFormText = " ";
            this.lblSelectedXMLFile.Location = new System.Drawing.Point(112, 60);
            this.lblSelectedXMLFile.Name = "lblSelectedXMLFile";
            this.lblSelectedXMLFile.Size = new System.Drawing.Size(331, 26);
            this.lblSelectedXMLFile.Text = " ";
            this.lblSelectedXMLFile.TextSize = new System.Drawing.Size(54, 0);
            this.lblSelectedXMLFile.TextVisible = true;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 86);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(443, 11);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnOpenGMLFile;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnOpenXMLFile;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 97);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(311, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnParse;
            this.layoutControlItem2.Location = new System.Drawing.Point(311, 97);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(132, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(347, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 22);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "&Select GML file";
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(69, 12);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(382, 20);
            this.txtNodeName.StyleController = this.layoutControl1;
            this.txtNodeName.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtNodeName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(443, 24);
            this.layoutControlItem4.Text = "Node name";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(54, 13);
            // 
            // frmXMLParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 143);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmXMLParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Parser";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectedGMLFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectedXMLFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnOpenGMLFile;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem lblSelectedGMLFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btnParse;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem lblSelectedXMLFile;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnOpenXMLFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit txtNodeName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}