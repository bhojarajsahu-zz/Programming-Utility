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
    public partial class NewHome : Form
    {
        public NewHome()
        {
            InitializeComponent();
        }
        private void NewHome_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //UtilityClass.UtilityOperations.updateRegistryValue("", "", true);
            //UtilityClass.UtilityOperations.checkRegistryValue();
            labelVersion.Text = this.ProductVersion.ToString();

            DisposeAllButThis();
            if (UtilityClass.UtilityOperations.checkRegistryValue())
            {
                UIForms.LazzyCoderSearchHome newInstance = new UIForms.LazzyCoderSearchHome();
                newInstance.MdiParent = this;
                newInstance.Show();
                panelCodeAddSearch.BackColor = Color.FromArgb(66, 131, 222);
                panelProperty.BackColor = Color.DimGray;
                panelXML.BackColor = Color.DimGray;
                panelCompare.BackColor = Color.DimGray;
            }
            else
            {
                panelCodeAddSearch.BackColor = Color.FromArgb(66, 131, 222);
                panelProperty.BackColor = Color.DimGray;
                panelXML.BackColor = Color.DimGray;
                UserLogin newLogin = new UserLogin();
                newLogin.MdiParent = this;
                newLogin.Show();
            }
            Cursor.Current = Cursors.Default;
        }
        public void DisposeAllButThis()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != this)
                {
                    frm.Close();
                    frm.Dispose();
                    return;
                }
            }
        }

        private void panelMenuProperty_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DisposeAllButThis();
            UIForms.PropertyGeneratorHome newInstance = new UIForms.PropertyGeneratorHome();
            newInstance.MdiParent = this;
            //newInstance.Height = this.Height;
            //newInstance.Width = this.Width;
            newInstance.Show();
            panelProperty.BackColor = Color.FromArgb(66, 131, 222);
            panelXML.BackColor = Color.DimGray;
            panelCodeAddSearch.BackColor = Color.DimGray;
            panelCompare.BackColor = Color.DimGray;
            Cursor.Current = Cursors.Default;
        }
        private void panelXML_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DisposeAllButThis();
            UIForms.Utility newInstance = new UIForms.Utility();
            newInstance.MdiParent = this;
            //newInstance.Height = this.Height;
            //newInstance.Width = this.Width;
            newInstance.Show();
            panelXML.BackColor = Color.FromArgb(66, 131, 222);
            panelProperty.BackColor = Color.DimGray;
            panelCodeAddSearch.BackColor = Color.DimGray;
            panelCompare.BackColor = Color.DimGray;
            Cursor.Current = Cursors.Default;
        }

        private void panelCodeAddSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DisposeAllButThis();
            if (UtilityClass.UtilityOperations.checkRegistryValue())
            {
                UIForms.LazzyCoderSearchHome newInstance = new UIForms.LazzyCoderSearchHome();
                newInstance.MdiParent = this;
                //newInstance.Height = this.Height;
                //newInstance.Width = this.Width;
                newInstance.Show();
                panelCodeAddSearch.BackColor = Color.FromArgb(66, 131, 222);
                panelProperty.BackColor = Color.DimGray;
                panelXML.BackColor = Color.DimGray;
                panelCompare.BackColor = Color.DimGray;
            }
            else
            {
                panelCodeAddSearch.BackColor = Color.FromArgb(66, 131, 222);
                panelProperty.BackColor = Color.DimGray;
                panelXML.BackColor = Color.DimGray;
                panelCompare.BackColor = Color.DimGray;
                UserLogin newLogin = new UserLogin();
                newLogin.MdiParent = this;
                newLogin.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        private void panelCompare_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DisposeAllButThis();
            UIForms.TextDifference newInstance = new UIForms.TextDifference();
            newInstance.MdiParent = this;
            //newInstance.Height = this.Height;
            //newInstance.Width = this.Width;
            newInstance.Show();
            panelCompare.BackColor = Color.FromArgb(66, 131, 222);
            panelProperty.BackColor = Color.DimGray;
            panelCodeAddSearch.BackColor = Color.DimGray;
            panelXML.BackColor = Color.DimGray;
            Cursor.Current = Cursors.Default;

        }
    }
}
