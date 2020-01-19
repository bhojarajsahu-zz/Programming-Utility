using bhojarajsahu88.Programming_Utility.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace bhojarajsahu88.Programming_Utility.UIForms
{
    public partial class PropertyGeneratorHome : Form
    {
        string fileLoc = string.Empty;
        XmlDocument newDocument = new XmlDocument();
        bool fileLoadStatus = false;
        List<string> propertyList = new List<string>();
        public PropertyGeneratorHome()
        {
            InitializeComponent();
        }

        public void setSelectedText(string selText)
        {
            if (string.IsNullOrEmpty(selText))
                textBoxSource.Text = selText;
        }

        private void buttonLoadFIle_Click(object sender, EventArgs e)
        {
            if (buttonLoadFIle.Text == "Load File")
            {
                DialogResult result = openFileDialog.ShowDialog();
                fileLoc = openFileDialog.FileName;
                if (result == DialogResult.OK) // Test result.
                {
                    string ext = Path.GetExtension(openFileDialog.FileName);
                    if (ext == ".xml")
                    {
                        labelFile.Text = fileLoc;
                        string xmlRawText = string.Empty;
                        try
                        {
                            try
                            {
                                textBoxSource.Text = XmlOperation.LoadFileToXML(fileLoc, out newDocument);
                                textBoxSource.ForeColor = Color.Black;
                                buttonLoadFIle.Text = "UnLoad File";
                                fileLoadStatus = true;
                            }
                            catch { }
                        }
                        catch
                        {
                            textBoxSource.Text = xmlRawText;
                            textBoxSource.ForeColor = Color.Red;
                        }
                    }
                    else
                        UtilityOperations.ShowMessageBox("File Format Not Supported. (I.E. .XML or .TXT)", MessageBoxIcon.Error);

                    if (ext == ".xml")
                        textBoxElement.Enabled = true;
                    else
                        textBoxElement.Enabled = false;
                }
            }
            else
            {
                buttonLoadFIle.Text = "Load File";
                labelFile.Text = "File Location";
                fileLoadStatus = false;
                textBoxSource.Text = "";
                textBoxElement.Enabled = true;
            }
        }

        private void PropertyGeneratorHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            loadDropDownValue();
        }
        public void loadDropDownValue()
        {
            comboBoxAM.Items.Add("public");
            comboBoxAM.Items.Add("private");
            comboBoxAM.Items.Add("protected");
            comboBoxAM.Items.Add("internal");
            comboBoxAM.Items.Add("protected internal");

            comboBoxReturn.Items.Add("string");
            comboBoxReturn.Items.Add("int");
            comboBoxReturn.Items.Add("bool");

            comboBoxProperty.Items.Add("GET/SET");
            comboBoxProperty.Items.Add("GET");
            comboBoxProperty.Items.Add("SET");
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            propertyList = new List<string>();
            if (comboBoxAM.SelectedIndex == -1 || comboBoxProperty.SelectedIndex == -1 || comboBoxReturn.SelectedIndex == -1 || labelFile.Text == "" || textBoxClass.Text == "" || textBoxElement.Text == "")
                UtilityOperations.ShowMessageBox("Please load a file using load file or fill source text area. Also select \"Access Specifier, Return Type, Property Type, Class Name & Element for Property\" for the same.", MessageBoxIcon.Warning);
            else
            {
                if (fileLoadStatus)
                {
                    try
                    {
                        XmlDocument docIn = new XmlDocument();
                        docIn.Load(fileLoc);

                        XmlNodeList headerNodeList = docIn.SelectSingleNode("/ROOT").ChildNodes;
                        if (headerNodeList != null)
                        {
                            foreach (XmlNode headerAttribute in headerNodeList)
                            {
                                processXMLNodes(headerAttribute);
                            }
                        }
                    }
                    catch { }
                    generateProperty();
                    textBoxDestination.Text = textBoxDestination.Text + "\r\n" + "}";
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxSource.Text))
                        UtilityOperations.ShowMessageBox("Please load a file using load file or fill source text area.", MessageBoxIcon.Warning);
                    else
                    {
                        string[] lines = Regex.Split(textBoxSource.Text, "\r\n");
                        for (int i = 0; i < lines.Length; i++)
                            propertyList.Add(lines[i].ToString());

                        generateProperty();
                        textBoxDestination.Text = textBoxDestination.Text + "\r\n" + "}";
                    }
                }
            }

        }
        public void processXMLNodes(XmlNode xmlNode)
        {
            try
            {
                if (xmlNode.HasChildNodes)
                {
                    XmlNodeList headerNodeList = xmlNode.ChildNodes;
                    if (headerNodeList != null)
                    {
                        foreach (XmlNode headerAttribute in headerNodeList)
                        {
                            processXMLNodes(headerAttribute);
                        }
                    }

                }
                else
                {
                    XmlNode namedItem = xmlNode.Attributes.GetNamedItem(textBoxElement.Text);//("ID");
                    propertyList.Add(namedItem.InnerText);
                }
            }
            catch { }
        }

        private void buttonClearSource_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
        }
        public void generateProperty()
        {
            textBoxDestination.Text = comboBoxAM.Text + " " + "class " + textBoxClass.Text + "\r\n" + "{";
            foreach (string item in propertyList)
            {
                string am = comboBoxAM.Text;
                string returnType = comboBoxReturn.Text;
                string getSet = string.Empty;
                if (comboBoxProperty.Text == "GET/SET")
                    getSet = "{get; set;}";
                else if (comboBoxProperty.Text == "GET")
                    getSet = "{get;}";
                if (comboBoxProperty.Text == "SET")
                    getSet = "{set;}";

                string formattedProperty = "\r\t" + am + " " + returnType + " " + item.ToString() + " " + getSet;
                textBoxDestination.Text = textBoxDestination.Text + Environment.NewLine + formattedProperty;
            }
        }
    }
}
