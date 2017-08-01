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
            TeamAEntities db = new TeamAEntities();

            string team = txtTeamName.Text;
            var selectedTeam = (from t in db.Teams
                                where t.TeamName == team
                                select t).Single();
            selectedTeam.TeamName = team;
            db.SaveChanges();
            
        }  

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
