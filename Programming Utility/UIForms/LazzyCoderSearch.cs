using bhojarajsahu88.Programming_Utility.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhojarajsahu88.Programming_Utility.UIForms
{
    public partial class LazzyCoderSearchHome : Form
    {
        List<PropertyClass> resultList;
        AllMethodsClass AM = null;
        Dictionary<string, string> newCategoryList = new Dictionary<string, string>();
        public LazzyCoderSearchHome()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AM = new AllMethodsClass();
            resultList = new List<PropertyClass>();
            int userKey = 0;
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                int cDbKey = 0;
                if (string.IsNullOrEmpty(comboBoxCatagory.Text))
                    UtilityOperations.showMessage("Please select some category");
                else
                {
                    if (newCategoryList.ContainsKey(comboBoxCatagory.Text))
                        cDbKey = Convert.ToInt32(newCategoryList[comboBoxCatagory.Text]);

                    if (checkBoxAllorMine.Checked)
                        userKey = UtilityOperations.getUserKey();
                    else
                        userKey = 0;


                    resultList = AM.getResultList(textBoxSearch.Text, cDbKey, userKey);
                }
            }
            else
                UtilityOperations.showMessage("Please enter the search text");

            loadDataGrid();

            foreach (PropertyClass pClass in resultList)
                dataGridViewResult.Rows.Add(pClass.Id, pClass.Title, pClass.ArticleType, pClass.URL);

            Cursor.Current = Cursors.Default;
        }

        private void listBoxResultList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LazzyCoderSearchHome_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.WindowState = FormWindowState.Maximized;

            panelAddNew.Visible = false;
            splitContainerMain.Visible = true;
            splitContainerMain.Dock = DockStyle.Fill;
            panelHead.Visible = true;


            AM = new AllMethodsClass();
            newCategoryList = AM.getCategoryList();
            foreach (KeyValuePair<string, string> category in newCategoryList)
            {
                comboBoxCatagory.Items.Add(category.Key);
                comboBoxCategoryAdd.Items.Add(category.Key);
            }

            loadDataGrid();
            Cursor.Current = Cursors.Default;
        }
        public void loadDataGrid()
        {
            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Clear();

            dataGridViewResult.Columns.Add("Id", "Id");
            dataGridViewResult.Columns.Add("Title", "Title");
            dataGridViewResult.Columns.Add("ArticleType", "ArticleType");
            dataGridViewResult.Columns.Add("Url", "Url");

            dataGridViewResult.Columns[0].Visible = false;
            dataGridViewResult.Columns[2].Visible = false;
            dataGridViewResult.Columns[3].Visible = false;
        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AM = new AllMethodsClass();
                string articletype = string.Empty;
                string url = string.Empty;
                if (dataGridViewResult.Rows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewResult.SelectedRows[0];
                    string selId = selectedRow.Cells[0].Value.ToString();
                    string code = AM.getSingleCode(selId);
                    articletype = (selectedRow.Cells[2].Value.ToString() == "SNIPPET") ? "snippets" : "article";
                    url = selectedRow.Cells[3].Value.ToString();

                    string htmlView = string.Format("<HTML><HEAD><TITLE></TITLE></HEAD><BODY>{0}</BODY></HTML>", code);
                    webBrowserResult.DocumentText = htmlView;
                }
                else
                {
                    string htmlView = string.Format("<HTML><HEAD><TITLE></TITLE></HEAD><BODY><H5>{0}<H5></BODY></HTML>", "No result found");
                    webBrowserResult.DocumentText = htmlView;
                }

                webBrowserGoogleView.Navigate("https://www.google.co.in/?gfe_rd=cr&ei=Vu1NV5C3EPTI8Ae7pLHYDA#q=lazzycoder");
                webBrowserlazzycoderView.Navigate(string.Format("http://www.lazzycoder.com/{0}/{1}", articletype, url));
                webBrowserlazzycoderView.ScriptErrorsSuppressed = true;
            }
            catch
            { }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            splitContainerMain.Visible = false;
            panelAddNew.Dock = DockStyle.Fill;
            panelAddNew.Visible = true;
            panelHead.Visible = false;

            textBoxCodeAdd.Text = "";
            textBoxTitleAdd.Text = "";
            //LazzyCoderAddNew newInstance = new LazzyCoderAddNew();
            //newInstance.Show();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            UtilityClass.UtilityOperations.updateRegistryValue(" ", " ", 0, false);
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            panelAddNew.Visible = false;
            splitContainerMain.Visible = true;
            splitContainerMain.Dock = DockStyle.Fill;
            panelHead.Visible = true;
        }

        private void buttonAddArticle_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AM = new AllMethodsClass();
            if (!string.IsNullOrEmpty(textBoxTitleAdd.Text) && !string.IsNullOrEmpty(textBoxCodeAdd.Text))
            {
                int cDbKey = 0;
                if (string.IsNullOrEmpty(comboBoxCategoryAdd.Text))
                    UtilityOperations.showMessage("Please select some category");
                else
                {
                    if (newCategoryList.ContainsKey(comboBoxCategoryAdd.Text))
                        cDbKey = Convert.ToInt32(newCategoryList[comboBoxCategoryAdd.Text]);

                    bool status = AM.addArticle("<pre><xmp>" + textBoxCodeAdd.Text + "</xmp></pre>", textBoxTitleAdd.Text, cDbKey);
                    if (status)
                    {
                        UtilityOperations.showMessage("Article added successfully");
                        clearAddFields();
                    }
                    else
                        UtilityOperations.showMessage("Error adding article");

                }
            }
            else
                UtilityOperations.showMessage("Please enter the required fields");

            Cursor.Current = Cursors.Default;
        }
        public void clearAddFields()
        {
            textBoxCodeAdd.Text = "";
            textBoxTitleAdd.Text = "";

        }
    }
}
