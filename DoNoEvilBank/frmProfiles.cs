using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoNoEvilBank
{
    
    public partial class frmProfiles : Form
    {

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

        #region Toolbar perform next action 

        private void tsbHome_Click(object sender, EventArgs e)
        {
            CNextAction.NEXT_ACTION = CNextAction.HOME;
            this.Hide();
        }

        private void tsbAccountCenter_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbProfileCenter_Click(object sender, EventArgs e)
        {
            //Do nothing we're already there
        }

        #endregion


        public frmProfiles()
        {
            InitializeComponent();
        }

       
        private void frmProfiles_Load(object sender, EventArgs e)
        {
            //Load listview rows
            lvwAccounts.Columns.Add("Profile ID", 85, HorizontalAlignment.Center);
            lvwAccounts.Columns.Add("Account ID", 85, HorizontalAlignment.Center);
            lvwAccounts.Columns.Add("Account Level", 85, HorizontalAlignment.Center);
            lvwAccounts.Columns.Add("Account Type", 85, HorizontalAlignment.Center);
            lvwAccounts.Columns.Add("Balance", 85, HorizontalAlignment.Center);
            lvwAccounts.Columns.Add("Creation Date", 85, HorizontalAlignment.Center);
            lvwAccounts.Columns.Add("Interest Rate", 85, HorizontalAlignment.Center);
        }

        //Passes the current form to a method that clears its controls
        private void btnClear_Click(object sender, EventArgs e)
        {
            tslStatus.Text = "";
            errP.Clear();
            lvwAccounts.Items.Clear();
            CClearForm.ClearScreenControls(this);
        }

        //Search for profile using profile ID, populates form if found
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Used to check if Profile exists or Not
            string strResult = "";

            //Check to see if it exists
            try
            {                
                strResult = CProfiles.CheckProfileExists(Convert.ToInt32(txtProfileID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get single value in btnSearch_Click: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(strResult == "1"))
            {
                tslStatus.Text = "Profile Does Not Exist";
                return;
            }
            else
            {
                //Load the profile
                try
                {
                    SqlDataReader objDR;
                    objDR = CProfiles.GetProfileByID(txtProfileID.Text);
                    if (objDR.Read())
                    {
                        txtFName.Text = objDR.GetString(1);
                        txtLName.Text = objDR.GetString(2);
                        dtmDOB.Text = objDR.GetDateTime(4).ToString();
                        mtbPhone.Text = objDR.GetString(5);
                        txtMailing.Text = objDR.GetString(6);
                        txtCity.Text = objDR.GetString(7);
                        mtbZip.Text = objDR.GetInt32(8).ToString();
                        txtUsername.Text = objDR.GetString(9);
                        txtPassword.Text = objDR.GetString(10);
                        txtEmail.Text = objDR.GetString(11);
                    }
                    objDR.Close();

                    LoadAccounts();

                    tslStatus.Text = "Profile Found";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get data reader in btnSearch_Click: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }              
           
        }

        //Loads accounts into the listview 
        private void LoadAccounts()
        {
            SqlDataReader objDR;
            objDR = CProfiles.GetAccountsByID(txtProfileID.Text);
            lvwAccounts.Items.Clear();

            try
            {
                           
                while (objDR.Read())
                {
                    //Turn this into a loop once we find out how to considering they are all different data types
                    ListViewItem lvRow = new ListViewItem();                    
                    lvRow.Text = objDR.GetInt32(0).ToString();
                    ListViewItem.ListViewSubItem lsiCol1 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem lsiCol2 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem lsiCol3 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem lsiCol4 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem lsiCol5 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem lsiCol6 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem lsiCol7 = new ListViewItem.ListViewSubItem();


                    lsiCol1.Text = objDR.GetInt32(1).ToString();
                    lsiCol2.Text = objDR.GetString(2);
                    lsiCol3.Text = objDR.GetString(3);
                    lsiCol4.Text = objDR.GetSqlMoney(4).ToString();
                    lsiCol5.Text = objDR.GetDateTime(5).ToString();
                    lsiCol6.Text = objDR.GetInt32(6).ToString();
                    

                    lvRow.SubItems.Add(lsiCol1);
                    lvRow.SubItems.Add(lsiCol2);
                    lvRow.SubItems.Add(lsiCol3);
                    lvRow.SubItems.Add(lsiCol4);
                    lvRow.SubItems.Add(lsiCol5);
                    lvRow.SubItems.Add(lsiCol6);

                    lvwAccounts.Items.Add(lvRow);
                    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get data reader in LoadAccounts: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objDR.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {        
            
            if (radNewCustomer.Checked == true)
            {
                CreateProfile();
            }
            else if (radUpdate.Checked)
            {
                UpdateProfile();
            }

        }
        
        //Creates the profile
       private void CreateProfile()
        {
            int intResult;
            try
            {

                ArrayList parameters = new ArrayList();
                parameters.Add(new SqlParameter("firstName", txtFName.Text));
                parameters.Add(new SqlParameter("lastName", txtLName.Text));
                if (!(txtMiddleInitial.Text == "" || txtMiddleInitial.Text == null))
                {
                    parameters.Add(new SqlParameter("middleInitial", txtMiddleInitial.Text));
                }
                parameters.Add(new SqlParameter("dateOfBirth", Convert.ToDateTime(dtmDOB.Text)));
                parameters.Add(new SqlParameter("phoneNumber", mtbPhone.Text));
                parameters.Add(new SqlParameter("mailingAddress", txtMailing.Text));
                parameters.Add(new SqlParameter("City", txtCity.Text));
                parameters.Add(new SqlParameter("ZIP", mtbZip.Text));
                parameters.Add(new SqlParameter("userName", txtUsername.Text));
                parameters.Add(new SqlParameter("password", txtPassword.Text));
                parameters.Add(new SqlParameter("email", txtEmail.Text));

                intResult = CProfiles.CreateProfile(parameters);
                if (!(intResult == 1))
                {
                    errP.SetError(btnSave, "Unable to create profile");
                    tslStatus.Text = "Unable To Save";
                }
                else
                {
                    tslStatus.Text = "Created Profile";
                }

            }
            catch (Exception exeption)
            {
                MessageBox.Show("Failed to get create profile in btnSave_Click: " + exeption.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Updates the profile
        private void UpdateProfile()
        {
            int intResult;
            string strResult = "";

            //Checks to see if it exists
            try
            {
                strResult = CProfiles.CheckProfileExists(Convert.ToInt32(txtProfileID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get single value in UpdateProfile: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(strResult == "1"))
            {
                tslStatus.Text = "Profile Does Not Exist";
                return;
            }
            else
            {

                try
                {
                    ArrayList parameters = new ArrayList();
                    parameters.Add(new SqlParameter("profileID", txtProfileID.Text));
                    parameters.Add(new SqlParameter("firstName", txtFName.Text));
                    parameters.Add(new SqlParameter("lastName", txtLName.Text));
                    if (!(txtMiddleInitial.Text == "" || txtMiddleInitial.Text == null))
                    {
                        parameters.Add(new SqlParameter("middleInitial", txtMiddleInitial.Text));
                    }
                    parameters.Add(new SqlParameter("dateOfBirth", Convert.ToDateTime(dtmDOB.Text)));
                    parameters.Add(new SqlParameter("phoneNumber", mtbPhone.Text));
                    parameters.Add(new SqlParameter("mailingAddress", txtMailing.Text));
                    parameters.Add(new SqlParameter("City", txtCity.Text));
                    parameters.Add(new SqlParameter("ZIP", mtbZip.Text));
                    parameters.Add(new SqlParameter("userName", txtUsername.Text));
                    parameters.Add(new SqlParameter("password", txtPassword.Text));
                    parameters.Add(new SqlParameter("email", txtEmail.Text));
                    intResult = CProfiles.UpdateProfile(parameters);
                    if (!(intResult == 1))
                    {
                        errP.SetError(btnSave, "Unable to update profile");
                        tslStatus.Text = "Unable To Update";
                    }
                    else
                    {
                        tslStatus.Text = "Updated Profile";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update profile in btnSave_Click: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExport_click(object sender, EventArgs e)
        {
            string strFileName = "";
            //Makes the bin/debug folder the initial path
            sfdDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            sfdDialog.Filter = "Text File |*.txt";

            if (sfdDialog.ShowDialog() == DialogResult.OK)
            {
                strFileName = sfdDialog.FileName;
                
                try
                {
                    StreamWriter streamWriter = new StreamWriter(File.Create(strFileName));
                    streamWriter.WriteLine("ProfileID: " + txtProfileID.Text);
                    streamWriter.WriteLine("First Name: " +  txtFName.Text);
                    streamWriter.WriteLine("Middle Initial: " + txtMiddleInitial.Text);
                    streamWriter.WriteLine("Last Name: " + txtLName.Text);
                    streamWriter.WriteLine("Date of Birth: " + dtmDOB.Text);
                    streamWriter.WriteLine("Phone Number: " + mtbPhone.Text);
                    streamWriter.WriteLine("Mailing Address: " + txtMailing.Text);
                    streamWriter.WriteLine("City: " + txtCity.Text);
                    streamWriter.WriteLine("ZIP: " + mtbZip.Text);
                    streamWriter.WriteLine("Username: " + txtUsername.Text);
                    streamWriter.WriteLine("Password: " + txtPassword.Text);
                    streamWriter.WriteLine("Email: " + txtEmail.Text);
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to write to file in btnExport_click: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                tslStatus.Text = "Canceled Export";
                return;
            }
   
        }
    }
    
}

