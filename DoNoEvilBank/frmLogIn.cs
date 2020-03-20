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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CNextAction.NEXT_ACTION = CNextAction.EXITTING;
            this.Hide();
        }

        //Uses a SP to check if login credentials are valid
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string strResult = "";

            try
            {

                strResult = CLogIn.LogIn(txtUserName.Text, txtPassword.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Database Error Logging in" + ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if(strResult == "1")
            {
                this.Hide();
            }
            else
            {
                errP.SetError(btnLogIn, "Invalid Login");
            }


        }
    }
}
