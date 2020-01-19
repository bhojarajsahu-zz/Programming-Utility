namespace bhojarajsahu88.Programming_Utility.UIForms
{
    partial class TextDifference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextDifference));
            this.panelHead = new System.Windows.Forms.Panel();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.labelFile2 = new System.Windows.Forms.Label();
            this.buttonF2 = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.labelFile1 = new System.Windows.Forms.Label();
            this.buttonF1 = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerSourcePanel = new System.Windows.Forms.SplitContainer();
            this.textBoxSource1 = new System.Windows.Forms.TextBox();
            this.textBoxSource2 = new System.Windows.Forms.TextBox();
            this.panelSourcePanel = new System.Windows.Forms.Panel();
            this.panelSF2 = new System.Windows.Forms.Panel();
            this.labelSF2 = new System.Windows.Forms.Label();
            this.panelSF1 = new System.Windows.Forms.Panel();
            this.labelSF1 = new System.Windows.Forms.Label();
            this.splitContainerDifferencePanel = new System.Windows.Forms.SplitContainer();
            this.lvSource = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDiff1 = new System.Windows.Forms.TextBox();
            this.lvDestination = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDifferencePanel = new System.Windows.Forms.Panel();
            this.panelDF2 = new System.Windows.Forms.Panel();
            this.labelDF2 = new System.Windows.Forms.Label();
            this.panelDF1 = new System.Windows.Forms.Panel();
            this.labelDF1 = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSourcePanel)).BeginInit();
            this.splitContainerSourcePanel.Panel1.SuspendLayout();
            this.splitContainerSourcePanel.Panel2.SuspendLayout();
            this.splitContainerSourcePanel.SuspendLayout();
            this.panelSourcePanel.SuspendLayout();
            this.panelSF2.SuspendLayout();
            this.panelSF1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDifferencePanel)).BeginInit();
            this.splitContainerDifferencePanel.Panel1.SuspendLayout();
            this.splitContainerDifferencePanel.Panel2.SuspendLayout();
            this.splitContainerDifferencePanel.SuspendLayout();
            this.panelDifferencePanel.SuspendLayout();
            this.panelDF2.SuspendLayout();
            this.panelDF1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.radioButtonText);
            this.panelHead.Controls.Add(this.radioButtonFile);
            this.panelHead.Controls.Add(this.textBoxFile2);
            this.panelHead.Controls.Add(this.labelFile2);
            this.panelHead.Controls.Add(this.buttonF2);
            this.panelHead.Controls.Add(this.buttonCompare);
            this.panelHead.Controls.Add(this.textBoxFile1);
            this.panelHead.Controls.Add(this.labelFile1);
            this.panelHead.Controls.Add(this.buttonF1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(884, 81);
            this.panelHead.TabIndex = 5;
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(568, 44);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(91, 17);
            this.radioButtonText.TabIndex = 15;
            this.radioButtonText.Text = "Text Compare";
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonText_CheckedChanged);
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Checked = true;
            this.radioButtonFile.Location = new System.Drawing.Point(568, 18);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(86, 17);
            this.radioButtonFile.TabIndex = 14;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File Compare";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            this.radioButtonFile.CheckedChanged += new System.EventHandler(this.radioButtonFile_CheckedChanged);
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.Location = new System.Drawing.Point(144, 43);
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.ReadOnly = true;
            this.textBoxFile2.Size = new System.Drawing.Size(314, 20);
            this.textBoxFile2.TabIndex = 11;
            // 
            // labelFile2
            // 
            this.labelFile2.AutoSize = true;
            this.labelFile2.Location = new System.Drawing.Point(32, 46);
            this.labelFile2.Name = "labelFile2";
            this.labelFile2.Size = new System.Drawing.Size(32, 13);
            this.labelFile2.TabIndex = 13;
            this.labelFile2.Text = "File2:";
            // 
            // buttonF2
            // 
            this.buttonF2.Location = new System.Drawing.Point(468, 42);
            this.buttonF2.Name = "buttonF2";
            this.buttonF2.Size = new System.Drawing.Size(77, 21);
            this.buttonF2.TabIndex = 12;
            this.buttonF2.Text = "File2";
            this.buttonF2.UseVisualStyleBackColor = true;
            this.buttonF2.Click += new System.EventHandler(this.buttonF2_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(693, 46);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(109, 30);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.Location = new System.Drawing.Point(144, 17);
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.ReadOnly = true;
            this.textBoxFile1.Size = new System.Drawing.Size(314, 20);
            this.textBoxFile1.TabIndex = 1;
            // 
            // labelFile1
            // 
            this.labelFile1.AutoSize = true;
            this.labelFile1.Location = new System.Drawing.Point(32, 20);
            this.labelFile1.Name = "labelFile1";
            this.labelFile1.Size = new System.Drawing.Size(32, 13);
            this.labelFile1.TabIndex = 10;
            this.labelFile1.Text = "File1:";
            // 
            // buttonF1
            // 
            this.buttonF1.Location = new System.Drawing.Point(468, 16);
            this.buttonF1.Name = "buttonF1";
            this.buttonF1.Size = new System.Drawing.Size(77, 21);
            this.buttonF1.TabIndex = 2;
            this.buttonF1.Text = "File1";
            this.buttonF1.UseVisualStyleBackColor = true;
            this.buttonF1.Click += new System.EventHandler(this.buttonF1_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 81);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerSourcePanel);
            this.splitContainerMain.Panel1.Controls.Add(this.panelSourcePanel);
            this.splitContainerMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMain.Panel1Collapsed = true;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerDifferencePanel);
            this.splitContainerMain.Panel2.Controls.Add(this.panelDifferencePanel);
            this.splitContainerMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMain.Size = new System.Drawing.Size(884, 381);
            this.splitContainerMain.SplitterDistance = 197;
            this.splitContainerMain.TabIndex = 6;
            // 
            // splitContainerSourcePanel
            // 
            this.splitContainerSourcePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSourcePanel.Location = new System.Drawing.Point(0, 28);
            this.splitContainerSourcePanel.Name = "splitContainerSourcePanel";
            // 
            // splitContainerSourcePanel.Panel1
            // 
            this.splitContainerSourcePanel.Panel1.Controls.Add(this.textBoxSource1);
            // 
            // splitContainerSourcePanel.Panel2
            // 
            this.splitContainerSourcePanel.Panel2.Controls.Add(this.textBoxSource2);
            this.splitContainerSourcePanel.Size = new System.Drawing.Size(150, 169);
            this.splitContainerSourcePanel.SplitterDistance = 49;
            this.splitContainerSourcePanel.TabIndex = 1;
            // 
            // textBoxSource1
            // 
            this.textBoxSource1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource1.Location = new System.Drawing.Point(0, 0);
            this.textBoxSource1.Multiline = true;
            this.textBoxSource1.Name = "textBoxSource1";
            this.textBoxSource1.Size = new System.Drawing.Size(49, 169);
            this.textBoxSource1.TabIndex = 14;
            // 
            // textBoxSource2
            // 
            this.textBoxSource2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource2.Location = new System.Drawing.Point(0, 0);
            this.textBoxSource2.Multiline = true;
            this.textBoxSource2.Name = "textBoxSource2";
            this.textBoxSource2.Size = new System.Drawing.Size(97, 169);
            this.textBoxSource2.TabIndex = 15;
            // 
            // panelSourcePanel
            // 
            this.panelSourcePanel.Controls.Add(this.panelSF2);
            this.panelSourcePanel.Controls.Add(this.panelSF1);
            this.panelSourcePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSourcePanel.Location = new System.Drawing.Point(0, 0);
            this.panelSourcePanel.Name = "panelSourcePanel";
            this.panelSourcePanel.Size = new System.Drawing.Size(150, 28);
            this.panelSourcePanel.TabIndex = 0;
            // 
            // panelSF2
            // 
            this.panelSF2.Controls.Add(this.labelSF2);
            this.panelSF2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSF2.Location = new System.Drawing.Point(41, 0);
            this.panelSF2.Name = "panelSF2";
            this.panelSF2.Size = new System.Drawing.Size(109, 28);
            this.panelSF2.TabIndex = 1;
            // 
            // labelSF2
            // 
            this.labelSF2.AutoSize = true;
            this.labelSF2.Location = new System.Drawing.Point(20, 8);
            this.labelSF2.Name = "labelSF2";
            this.labelSF2.Size = new System.Drawing.Size(69, 13);
            this.labelSF2.TabIndex = 12;
            this.labelSF2.Text = "Source File2:";
            // 
            // panelSF1
            // 
            this.panelSF1.Controls.Add(this.labelSF1);
            this.panelSF1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSF1.Location = new System.Drawing.Point(0, 0);
            this.panelSF1.Name = "panelSF1";
            this.panelSF1.Size = new System.Drawing.Size(109, 28);
            this.panelSF1.TabIndex = 0;
            // 
            // labelSF1
            // 
            this.labelSF1.AutoSize = true;
            this.labelSF1.Location = new System.Drawing.Point(32, 7);
            this.labelSF1.Name = "labelSF1";
            this.labelSF1.Size = new System.Drawing.Size(69, 13);
            this.labelSF1.TabIndex = 11;
            this.labelSF1.Text = "Source File1:";
            // 
            // splitContainerDifferencePanel
            // 
            this.splitContainerDifferencePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDifferencePanel.Location = new System.Drawing.Point(0, 28);
            this.splitContainerDifferencePanel.Name = "splitContainerDifferencePanel";
            // 
            // splitContainerDifferencePanel.Panel1
            // 
            this.splitContainerDifferencePanel.Panel1.Controls.Add(this.lvSource);
            this.splitContainerDifferencePanel.Panel1.Controls.Add(this.textBoxDiff1);
            // 
            // splitContainerDifferencePanel.Panel2
            // 
            this.splitContainerDifferencePanel.Panel2.Controls.Add(this.lvDestination);
            this.splitContainerDifferencePanel.Size = new System.Drawing.Size(884, 353);
            this.splitContainerDifferencePanel.SplitterDistance = 294;
            this.splitContainerDifferencePanel.TabIndex = 2;
            // 
            // lvSource
            // 
            this.lvSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSource.FullRowSelect = true;
            this.lvSource.HideSelection = false;
            this.lvSource.Location = new System.Drawing.Point(0, 0);
            this.lvSource.MultiSelect = false;
            this.lvSource.Name = "lvSource";
            this.lvSource.Size = new System.Drawing.Size(294, 353);
            this.lvSource.TabIndex = 16;
            this.lvSource.UseCompatibleStateImageBehavior = false;
            this.lvSource.View = System.Windows.Forms.View.Details;
            this.lvSource.SelectedIndexChanged += new System.EventHandler(this.lvSource_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Line";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Text (Source)";
            this.columnHeader2.Width = 147;
            // 
            // textBoxDiff1
            // 
            this.textBoxDiff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiff1.Location = new System.Drawing.Point(0, 0);
            this.textBoxDiff1.Multiline = true;
            this.textBoxDiff1.Name = "textBoxDiff1";
            this.textBoxDiff1.Size = new System.Drawing.Size(294, 353);
            this.textBoxDiff1.TabIndex = 15;
            // 
            // lvDestination
            // 
            this.lvDestination.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDestination.FullRowSelect = true;
            this.lvDestination.HideSelection = false;
            this.lvDestination.Location = new System.Drawing.Point(0, 0);
            this.lvDestination.MultiSelect = false;
            this.lvDestination.Name = "lvDestination";
            this.lvDestination.Size = new System.Drawing.Size(586, 353);
            this.lvDestination.TabIndex = 3;
            this.lvDestination.UseCompatibleStateImageBehavior = false;
            this.lvDestination.View = System.Windows.Forms.View.Details;
            this.lvDestination.SelectedIndexChanged += new System.EventHandler(this.lvDestination_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Line";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Text (Destination)";
            this.columnHeader4.Width = 198;
            // 
            // panelDifferencePanel
            // 
            this.panelDifferencePanel.Controls.Add(this.panelDF2);
            this.panelDifferencePanel.Controls.Add(this.panelDF1);
            this.panelDifferencePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDifferencePanel.Location = new System.Drawing.Point(0, 0);
            this.panelDifferencePanel.Name = "panelDifferencePanel";
            this.panelDifferencePanel.Size = new System.Drawing.Size(884, 28);
            this.panelDifferencePanel.TabIndex = 1;
            // 
            // panelDF2
            // 
            this.panelDF2.Controls.Add(this.labelDF2);
            this.panelDF2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDF2.Location = new System.Drawing.Point(742, 0);
            this.panelDF2.Name = "panelDF2";
            this.panelDF2.Size = new System.Drawing.Size(142, 28);
            this.panelDF2.TabIndex = 2;
            // 
            // labelDF2
            // 
            this.labelDF2.AutoSize = true;
            this.labelDF2.Location = new System.Drawing.Point(32, 7);
            this.labelDF2.Name = "labelDF2";
            this.labelDF2.Size = new System.Drawing.Size(84, 13);
            this.labelDF2.TabIndex = 11;
            this.labelDF2.Text = "Difference File2:";
            // 
            // panelDF1
            // 
            this.panelDF1.Controls.Add(this.labelDF1);
            this.panelDF1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDF1.Location = new System.Drawing.Point(0, 0);
            this.panelDF1.Name = "panelDF1";
            this.panelDF1.Size = new System.Drawing.Size(142, 28);
            this.panelDF1.TabIndex = 1;
            // 
            // labelDF1
            // 
            this.labelDF1.AutoSize = true;
            this.labelDF1.Location = new System.Drawing.Point(32, 7);
            this.labelDF1.Name = "labelDF1";
            this.labelDF1.Size = new System.Drawing.Size(84, 13);
            this.labelDF1.TabIndex = 11;
            this.labelDF1.Text = "Difference File1:";
            // 
            // TextDifference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "TextDifference";
            this.Text = "TextDifference";
            this.Load += new System.EventHandler(this.TextDifference_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerSourcePanel.Panel1.ResumeLayout(false);
            this.splitContainerSourcePanel.Panel1.PerformLayout();
            this.splitContainerSourcePanel.Panel2.ResumeLayout(false);
            this.splitContainerSourcePanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSourcePanel)).EndInit();
            this.splitContainerSourcePanel.ResumeLayout(false);
            this.panelSourcePanel.ResumeLayout(false);
            this.panelSF2.ResumeLayout(false);
            this.panelSF2.PerformLayout();
            this.panelSF1.ResumeLayout(false);
            this.panelSF1.PerformLayout();
            this.splitContainerDifferencePanel.Panel1.ResumeLayout(false);
            this.splitContainerDifferencePanel.Panel1.PerformLayout();
            this.splitContainerDifferencePanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDifferencePanel)).EndInit();
            this.splitContainerDifferencePanel.ResumeLayout(false);
            this.panelDifferencePanel.ResumeLayout(false);
            this.panelDF2.ResumeLayout(false);
            this.panelDF2.PerformLayout();
            this.panelDF1.ResumeLayout(false);
            this.panelDF1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.Label labelFile1;
        private System.Windows.Forms.Button buttonF1;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Label labelFile2;
        private System.Windows.Forms.Button buttonF2;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelSourcePanel;
        private System.Windows.Forms.Panel panelDifferencePanel;
        private System.Windows.Forms.SplitContainer splitContainerSourcePanel;
        private System.Windows.Forms.SplitContainer splitContainerDifferencePanel;
        private System.Windows.Forms.Panel panelSF2;
        private System.Windows.Forms.Panel panelSF1;
        private System.Windows.Forms.Label labelSF2;
        private System.Windows.Forms.Label labelSF1;
        private System.Windows.Forms.Panel panelDF2;
        private System.Windows.Forms.Label labelDF2;
        private System.Windows.Forms.Panel panelDF1;
        private System.Windows.Forms.Label labelDF1;
        private System.Windows.Forms.TextBox textBoxSource1;
        private System.Windows.Forms.TextBox textBoxSource2;
        private System.Windows.Forms.ListView lvSource;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxDiff1;
        private System.Windows.Forms.ListView lvDestination;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.RadioButton radioButtonFile;
    }
}