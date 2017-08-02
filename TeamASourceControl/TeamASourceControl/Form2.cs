using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeamASourceControl
{
    public partial class frmAddPlayer : Form
    {
        public frmAddPlayer()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player p = new Player()
            {
                PlayerFirstName = txtFname.Text,
                PlayerLastName = txtLname.Text,
                PlayerPhone = txtPhone.Text,
                PlayerEmail = txtEmail.Text

            };

            //do validation
            var db = new TeamAEntities();

        }

        /// <summary>
        /// Updates player from the players lis
        /// </summary>
        /// <param name="sender">player list</param>
        /// <param name="e"></param>
        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            
            //grab all info off form and put in player object
            Player p = new Player()
            {
                PlayerFirstName = txtFname.Text,
                PlayerLastName = txtLname.Text,
                PlayerPhone = txtPhone.Text,
                PlayerEmail = txtEmail.Text

            };

            //do validation
            var db = new TeamAEntities();
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            MessageBox.Show("Your player has been successfully updated");
        }

      
        public static Player FindPlayer(string fName, string lName)
        {
            var db = new TeamAEntities();

            Player p = (from plyr in db.Players
                        where plyr.PlayerFirstName == fName
                        && plyr.PlayerLastName == lName
                        select plyr).Single();
            return p;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
