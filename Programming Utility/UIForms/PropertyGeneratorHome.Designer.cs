namespace bhojarajsahu88.Programming_Utility.UIForms
{
    partial class PropertyGeneratorHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyGeneratorHome));
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxElement = new System.Windows.Forms.TextBox();
            this.labelElement = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.labelProperty = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelAM = new System.Windows.Forms.Label();
            this.comboBoxAM = new System.Windows.Forms.ComboBox();
            this.buttonLoadFIle = new System.Windows.Forms.Button();
            this.comboBoxReturn = new System.Windows.Forms.ComboBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonClearSource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDestination.Location = new System.Drawing.Point(0, 0);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDestination.Size = new System.Drawing.Size(494, 363);
            this.textBoxDestination.TabIndex = 0;
            // 
            // textBoxElement
            // 
            this.textBoxElement.Enabled = false;
            this.textBoxElement.Location = new System.Drawing.Point(399, 80);
            this.textBoxElement.Name = "textBoxElement";
            this.textBoxElement.Size = new System.Drawing.Size(200, 20);
            this.textBoxElement.TabIndex = 13;
            this.textBoxElement.Text = "ID";
            // 
            // labelElement
            // 
            this.labelElement.AutoSize = true;
            this.labelElement.Location = new System.Drawing.Point(379, 60);
            this.labelElement.Name = "labelElement";
            this.labelElement.Size = new System.Drawing.Size(145, 13);
            this.labelElement.TabIndex = 12;
            this.labelElement.Text = "Element In XML For Property:";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(399, 33);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(200, 20);
            this.textBoxClass.TabIndex = 11;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(379, 17);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(66, 13);
            this.labelClass.TabIndex = 10;
            this.labelClass.Text = "Class Name:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(704, 95);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(107, 30);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy to Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(12, 94);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(67, 13);
            this.labelFile.TabIndex = 8;
            this.labelFile.Text = "File Location";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(620, 17);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 67);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Generate Property";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 137);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSource);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.textBoxDestination);
            this.splitContainerMain.Size = new System.Drawing.Size(900, 363);
            this.splitContainerMain.SplitterDistance = 402;
            this.splitContainerMain.TabIndex = 3;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource.Location = new System.Drawing.Point(0, 0);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSource.Size = new System.Drawing.Size(402, 363);
            this.textBoxSource.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files|*.*";
            this.openFileDialog.Title = "Property Generator File Selector";
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Location = new System.Drawing.Point(233, 68);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProperty.TabIndex = 6;
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(156, 71);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(76, 13);
            this.labelProperty.TabIndex = 5;
            this.labelProperty.Text = "Property Type:";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Location = new System.Drawing.Point(158, 44);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(69, 13);
            this.labelReturn.TabIndex = 3;
            this.labelReturn.Text = "Return Type:";
            // 
            // labelAM
            // 
            this.labelAM.AutoSize = true;
            this.labelAM.Location = new System.Drawing.Point(142, 17);
            this.labelAM.Name = "labelAM";
            this.labelAM.Size = new System.Drawing.Size(85, 13);
            this.labelAM.TabIndex = 2;
            this.labelAM.Text = "Access Modifier:";
            // 
            // comboBoxAM
            // 
            this.comboBoxAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAM.FormattingEnabled = true;
            this.comboBoxAM.Location = new System.Drawing.Point(233, 14);
            this.comboBoxAM.Name = "comboBoxAM";
            this.comboBoxAM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAM.TabIndex = 1;
            // 
            // buttonLoadFIle
            // 
            this.buttonLoadFIle.Location = new System.Drawing.Point(12, 17);
            this.buttonLoadFIle.Name = "buttonLoadFIle";
            this.buttonLoadFIle.Size = new System.Drawing.Size(75, 67);
            this.buttonLoadFIle.TabIndex = 0;
            this.buttonLoadFIle.Text = "Load File";
            this.buttonLoadFIle.UseVisualStyleBackColor = true;
            this.buttonLoadFIle.Click += new System.EventHandler(this.buttonLoadFIle_Click);
            // 
            // comboBoxReturn
            // 
            this.comboBoxReturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReturn.FormattingEnabled = true;
            this.comboBoxReturn.Location = new System.Drawing.Point(233, 41);
            this.comboBoxReturn.Name = "comboBoxReturn";
            this.comboBoxReturn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReturn.TabIndex = 4;
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.buttonClearSource);
            this.panelHead.Controls.Add(this.textBoxElement);
            this.panelHead.Controls.Add(this.labelElement);
            this.panelHead.Controls.Add(this.textBoxClass);
            this.panelHead.Controls.Add(this.labelClass);
            this.panelHead.Controls.Add(this.buttonCopy);
            this.panelHead.Controls.Add(this.labelFile);
            this.panelHead.Controls.Add(this.buttonGenerate);
            this.panelHead.Controls.Add(this.comboBoxProperty);
            this.panelHead.Controls.Add(this.labelProperty);
            this.panelHead.Controls.Add(this.comboBoxReturn);
            this.panelHead.Controls.Add(this.labelReturn);
            this.panelHead.Controls.Add(this.labelAM);
            this.panelHead.Controls.Add(this.comboBoxAM);
            this.panelHead.Controls.Add(this.buttonLoadFIle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(900, 137);
            this.panelHead.TabIndex = 2;
            // 
            // buttonClearSource
            // 
            this.buttonClearSource.Location = new System.Drawing.Point(192, 95);
            this.buttonClearSource.Name = "buttonClearSource";
            this.buttonClearSource.Size = new System.Drawing.Size(107, 30);
            this.buttonClearSource.TabIndex = 14;
            this.buttonClearSource.Text = "Clear Source";
            this.buttonClearSource.UseVisualStyleBackColor = true;
            this.buttonClearSource.Click += new System.EventHandler(this.buttonClearSource_Click);
            // 
            // PropertyGeneratorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "PropertyGeneratorHome";
            this.ShowInTaskbar = false;
            this.Text = "Property Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PropertyGeneratorHome_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxElement;
        private System.Windows.Forms.Label labelElement;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox comboBoxProperty;
        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelAM;
        private System.Windows.Forms.ComboBox comboBoxAM;
        private System.Windows.Forms.Button buttonLoadFIle;
        private System.Windows.Forms.ComboBox comboBoxReturn;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button buttonClearSource;
    }
}