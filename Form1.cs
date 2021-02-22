using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWFormsApp
{
    public partial class DemoApp : Form
    {
        public DemoApp()
        {
            InitializeComponent();
            customiseDesing();
        }

        private void customiseDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolsSubmenu.Visible == true)
                panelToolsSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) { 
                hideSubMenu();
            subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }
        #region MediaSubmenu

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }
        #endregion
        private void btnPlaylistManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
           
        }
        #region PlaylistSubmenu
        private void button9_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }
        #endregion
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubmenu);
        }
        #region ToolsSubmenu
        private void button15_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // we write our code here for the spesific button and then hide the submenu
            hideSubMenu();
        }
        #endregion
        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        
        private Form activeForm = null;
        
        private void openChildForm(Form childForm)
        {
            //to open a single form its necessary to close the previous form
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            //we set top level form false because if its true it will act as it has no parent form or its parent is the complete desktop window
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //we add the form to the controls
            panelChildForm.Controls.Add(childForm);
            //panelChildForm.Tag = childForm;
            //if we want to put a logo its best to bring it to the front to be sure it will be visible to user and not another control hiding it
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
