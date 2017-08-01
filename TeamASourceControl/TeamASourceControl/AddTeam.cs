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
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            Team t = new Team();
            t.TeamName = txtTeamName.Text;
            t.Coach = txtCoachName.Text;
            t.Location = txtLocation.Text;
            t.ContactNumber = txtContact.Text;

            SaveToDatabase(t);
        }

        private void SaveToDatabase(Team t)
        {
            TeamAEntities team = new TeamAEntities();
            team.Teams.Add(t);
            team.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(TeamAEntities team = new TeamAEntities())
            {
                var t = new Team();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
