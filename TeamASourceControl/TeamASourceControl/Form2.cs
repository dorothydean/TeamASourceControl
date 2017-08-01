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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player p = new Player()
            {
                PlayerFirstName = "Joe",
                PlayerLastName = "DiMaggio",
                PlayerPhone = "2355551234",
                PlayerEmail = "dimaggio@halloffame.com"
            };

            var db = new TeamAEntities();
            db.Players.Add(p);
            db.SaveChanges();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            //entity framework delete query
            TeamAEntities db = new TeamAEntities();

            //find the id of the selected player
            int p = GetPlayer().PlayerID;

            //get that player from the db context
            Player found = db.Players.Find(p);

            //remove the player that was found
            db.Players.Remove(found);
            db.SaveChanges();

            //refresh player
            
        }

        private object GetPlayer()
        {
            Player p = txtFname.Text && txtLname.Text as Player;
        }
    }
}
