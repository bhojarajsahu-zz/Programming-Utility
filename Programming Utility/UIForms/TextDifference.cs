using DifferenceEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhojarajsahu88.Programming_Utility.UIForms
{
    public partial class TextDifference : Form
    {
        private DiffEngineLevel _level;
        public TextDifference()
        {
            InitializeComponent();
            _level = DiffEngineLevel.FastImperfect;
        }

        private void TextDifference_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Current = Cursors.Default;
        }
        private string GetFileName()
        {
            string fname = string.Empty;
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fname = dlg.FileName;
            }
            return fname;
        }

        private bool ValidFile(string fname)
        {
            if (fname != string.Empty)
            {
                if (File.Exists(fname))
                {
                    return true;
                }
            }
            return false;
        }

        private void FileDiff(string sFile, string dFile)
        {
            this.Cursor = Cursors.WaitCursor;

            DiffList_TextFile sLF = null;
            DiffList_TextFile dLF = null;
            try
            {
                sLF = new DiffList_TextFile(sFile);
                dLF = new DiffList_TextFile(dFile);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "File Error");
                return;
            }

            try
            {
                double time = 0;
                DiffEngine de = new DiffEngine();
                time = de.ProcessDiff(sLF, dLF, _level);

                ArrayList rep = de.DiffReport();
                Results(sLF, dLF, rep, time);

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                string tmp = string.Format("{0}{1}{1}***STACK***{1}{2}",
                    ex.Message,
                    Environment.NewLine,
                    ex.StackTrace);
                MessageBox.Show(tmp, "Compare Error");
                return;
            }
            this.Cursor = Cursors.Default;
        }
        private void TextDiff(string sText, string dText)
        {
            this.Cursor = Cursors.WaitCursor;

            DiffList_Text sLF = null;
            DiffList_Text dLF = null;
            try
            {
                sLF = new DiffList_Text(sText);
                dLF = new DiffList_Text(dText);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "File Error");
                return;
            }

            try
            {
                double time = 0;
                DiffEngine de = new DiffEngine();
                time = de.ProcessDiff(sLF, dLF, _level);

                ArrayList rep = de.DiffReport();
                Results(sLF, dLF, rep, time);

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                string tmp = string.Format("{0}{1}{1}***STACK***{1}{2}",
                    ex.Message,
                    Environment.NewLine,
                    ex.StackTrace);
                MessageBox.Show(tmp, "Compare Error");
                return;
            }
            this.Cursor = Cursors.Default;
        }
        public void Results(DiffList_TextFile source, DiffList_TextFile destination, ArrayList DiffLines, double seconds)
        {
            //this.Text = string.Format("Results: {0} secs.", seconds.ToString("#0.00"));

            ListViewItem lviS;
            ListViewItem lviD;
            int cnt = 1;
            int i;

            foreach (DiffResultSpan drs in DiffLines)
            {
                switch (drs.Status)
                {
                    case DiffResultSpanStatus.DeleteSource:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.Red;
                            lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line);
                            lviD.BackColor = Color.LightGray;
                            lviD.SubItems.Add("");

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                    case DiffResultSpanStatus.NoChange:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.White;
                            lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line);
                            lviD.BackColor = Color.White;
                            lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line);

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                    case DiffResultSpanStatus.AddDestination:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.LightGray;
                            lviS.SubItems.Add("");
                            lviD.BackColor = Color.LightGreen;
                            lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line);

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                    case DiffResultSpanStatus.Replace:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.Red;
                            lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line);
                            lviD.BackColor = Color.LightGreen;
                            lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line);

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                }

            }
        }
        public void Results(DiffList_Text source, DiffList_Text destination, ArrayList DiffLines, double seconds)
        {
            //this.Text = string.Format("Results: {0} secs.", seconds.ToString("#0.00"));

            ListViewItem lviS;
            ListViewItem lviD;
            int cnt = 1;
            int i;

            foreach (DiffResultSpan drs in DiffLines)
            {
                switch (drs.Status)
                {
                    case DiffResultSpanStatus.DeleteSource:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.Red;
                            lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line);
                            lviD.BackColor = Color.LightGray;
                            lviD.SubItems.Add("");

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                    case DiffResultSpanStatus.NoChange:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.White;
                            lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line);
                            lviD.BackColor = Color.White;
                            lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line);

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                    case DiffResultSpanStatus.AddDestination:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.LightGray;
                            lviS.SubItems.Add("");
                            lviD.BackColor = Color.LightGreen;
                            lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line);

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                    case DiffResultSpanStatus.Replace:
                        for (i = 0; i < drs.Length; i++)
                        {
                            lviS = new ListViewItem(cnt.ToString("00000"));
                            lviD = new ListViewItem(cnt.ToString("00000"));
                            lviS.BackColor = Color.Red;
                            lviS.SubItems.Add(((TextLine)source.GetByIndex(drs.SourceIndex + i)).Line);
                            lviD.BackColor = Color.LightGreen;
                            lviD.SubItems.Add(((TextLine)destination.GetByIndex(drs.DestIndex + i)).Line);

                            lvSource.Items.Add(lviS);
                            lvDestination.Items.Add(lviD);
                            cnt++;
                        }

                        break;
                }

            }
        }

        private void buttonF1_Click(object sender, EventArgs e)
        {
            textBoxFile1.Text = GetFileName();
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            textBoxFile2.Text = GetFileName();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            lvSource.Items.Clear();
            lvDestination.Items.Clear();

            if (radioButtonFile.Checked)
            {
                string sFile = textBoxFile1.Text.Trim();
                string dFile = textBoxFile2.Text.Trim();

                if (!ValidFile(sFile))
                {
                    MessageBox.Show("Source file name is invalid.", "Invalid File");
                    textBoxFile1.Focus();
                    return;
                }

                if (!ValidFile(dFile))
                {
                    MessageBox.Show("Destination file name is invalid.", "Invalid File");
                    textBoxFile2.Focus();
                    return;
                }

                FileDiff(sFile, dFile);
            }
            else
            {
                if (!string.IsNullOrEmpty(textBoxSource1.Text) && !string.IsNullOrEmpty(textBoxSource2.Text))
                {
                    TextDiff(textBoxSource1.Text, textBoxSource2.Text);
                }
                else
                    MessageBox.Show("Enter source string or destination string.", "Invalid String");

            }
        }

        private void lvSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSource.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDestination.Items[lvSource.SelectedItems[0].Index];
                lvi.Selected = true;
                lvi.EnsureVisible();
            }
        }

        private void lvDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDestination.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSource.Items[lvDestination.SelectedItems[0].Index];
                lvi.Selected = true;
                lvi.EnsureVisible();
            }
        }

        private void radioButtonFile_CheckedChanged(object sender, EventArgs e)
        {
            compareSelect();
        }

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            compareSelect();
        }
        public void compareSelect()
        {
            if (radioButtonFile.Checked)
            {
                buttonF1.Enabled = true;
                buttonF2.Enabled = true;
                textBoxFile1.Enabled = true;
                textBoxFile2.Enabled = true;
                splitContainerMain.Panel1Collapsed = true;
                lvSource.Items.Clear();
                lvDestination.Items.Clear();
                textBoxSource1.Text = "";
                textBoxSource2.Text = "";
            }
            else
            {
                buttonF1.Enabled = false;
                buttonF2.Enabled = false;
                textBoxFile1.Enabled = false;
                textBoxFile2.Enabled = false;
                splitContainerMain.Panel1Collapsed = false;
                lvSource.Items.Clear();
                lvDestination.Items.Clear();
                textBoxSource1.Text = "";
                textBoxSource2.Text = "";
            }
        }
    }
}
