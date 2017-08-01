using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamASourceControl
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //grab all info off form and put in player object
            Player p = new Player()
            {
                PlayerFirstName = "",
                PlayerLastName = "",
                PlayerPhone = "",
                PlayerEmail = ""

            };
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
                PlayerFirstName = "",
                PlayerLastName = "",
                PlayerPhone = "",
                PlayerEmail = ""

            };

            //do validation
            var db = new TeamAEntities();
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            //entity framework delet query
            TeamAEntities db = new TeamAEntities();

            //find the id of the selected player
            Int16 p = Get
        }
    }
}
