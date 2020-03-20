using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoNoEvilBank
{
    public partial class frmMain : Form
    {

        Form LogIn = new frmLogIn();
        Form ProfileInfo = new frmProfiles();
       

        #region Toolbar button enter/ leave events
        //Display text when on toolbar buttons
        private void tsb_MouseEnter(object sender, EventArgs e)
        {
            ToolStripButton tsbProxy = (ToolStripButton)sender;
            tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text;
        }

        //Display Icon when not on toolbar buttons
        private void tsb_MouseLeave(object sender, EventArgs e)
        {
            ToolStripButton tsbProxy = (ToolStripButton)sender;
            tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image;
        }

        #endregion

        #region Toolbar click events
        private void tsbProfileCenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileInfo.ShowDialog();
            this.Show();
            performNextAction();
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            //Try to startup the DB
            try
            {
                 CDBConstants.myDB = new CDB();
                CDBConstants.myDB.OpenDB();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open database. Connection string = " + CDBConstants.gstrConn + "Exception: " + ex.ToString(), "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                
            }

            this.Hide();
            LogIn.ShowDialog();          
        }


        //Main will act as a crossroad for all forms to go through,
        //When one is close it is hidden, the user is taken to main and
        //from main the new one that was clicked is opened
        private void frmMain_Shown(object sender, EventArgs e)
        {
            performNextAction();
        }

        private void performNextAction()
        {
            switch (CNextAction.NEXT_ACTION)
            {
                case CNextAction.HOME:
                    //Do nothing we're already here
                    break;
                case CNextAction.PROFILE:
                    tsbAccountCenter.PerformClick();
                    break;
                case CNextAction.EXITTING:
                    Application.Exit();
                    break;
                case null:
                    //Do nothing
                default:
                    //Do nothing
                    break;

            }
        }

        private void tsbLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }



}
