using bhojarajsahu88.Programming_Utility.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace bhojarajsahu88.Programming_Utility.UIForms
{
    public partial class Utility : Form
    {
        public Utility()
        {
            InitializeComponent();
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSource.Text))
                textBoxDestination.Text = "";
            try
            {
                XmlDocument newDocument = new XmlDocument();
                newDocument.LoadXml(textBoxSource.Text);
                string Destination = XmlOperation.Beautify(newDocument);
                textBoxDestination.Text = Destination;
                textBoxSource.ForeColor = Color.Black;
            }
            catch
            {
                textBoxSource.ForeColor = Color.Red;
            }
        }
        //static private string Beautify(XmlDocument doc)
        //{
        //    try
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        XmlWriterSettings settings = new XmlWriterSettings
        //        {
        //            Indent = true,
        //            IndentChars = "  ",
        //            NewLineChars = "\r\n",
        //            NewLineHandling = NewLineHandling.Replace
        //        };
        //        using (XmlWriter writer = XmlWriter.Create(sb, settings))
        //        {
        //            doc.Save(writer);
        //        }

        //        return sb.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        private void buttonCopyS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSource.Text))
                Clipboard.SetText(textBoxSource.Text, TextDataFormat.Text);
        }

        private void buttonCopyD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSource.Text))
                Clipboard.SetText(textBoxDestination.Text, TextDataFormat.Text);
        }

        private void buttonClearSource_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
        }

        private void Utility_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
