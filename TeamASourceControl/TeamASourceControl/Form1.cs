using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TeamASourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePlayerList();
            PopulateTeamList();
        }

        /// <summary>
        /// Functionality for buttons to add, update or delete player's registration to a specific team
        /// </summary>
        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {
            TeamAEntities db = new TeamAEntities();

            //get player from database
            int p = GetSelectedPlayer().PlayerID;
            Player foundPlayer = db.Players.Find(p);

            //get team id from datbase
            int t = GetSelectedTeam().TeamID;
            Team foundTeam = db.Teams.Find(t);

            //write TeamID to TeamID column in DB
            foundPlayer.TeamID = (byte)t;

            var result = db.Players.SingleOrDefault(player => player.PlayerID == p);
            if (result != null)
            {
                result.TeamID = (byte)t;
                db.SaveChanges();
            }

            //show message that player has been registered
            string playerName = GetSelectedPlayer().PlayerFullName;
            string teamName = GetSelectedTeam().TeamName;
            MessageBox.Show($"You have successfully registered {playerName} to {teamName}!");
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            TeamAEntities db = new TeamAEntities();
            //get player from database
            int p = GetSelectedPlayer().PlayerID;
            Player foundPlayer = db.Players.Find(p);

            //get team id from datbase
            int t = GetSelectedTeam().TeamID;
            Team foundTeam = db.Teams.Find(t);

            //write TeamID to TeamID column in DB
            foundPlayer.TeamID = (byte)t;
           
            var result = db.Players.SingleOrDefault(player=> player.PlayerID == p);
            if (result != null)
            {
                result.TeamID = (byte)t;
                db.SaveChanges();
            }

            //show message that player has been registered
            string playerName = GetSelectedPlayer().PlayerFullName;
            string teamName = GetSelectedTeam().TeamName;
            MessageBox.Show($"You have succesfully updated {playerName}'s registration to {teamName}!");

        }

        private void btnDeleteRegistration_Click(object sender, EventArgs e)
        {
            TeamAEntities db = new TeamAEntities();

            //get player from database
            int p = GetSelectedPlayer().PlayerID;
            Player foundPlayer = db.Players.Find(p);

            //get team id from datbase
            int t = GetSelectedTeam().TeamID;
            Team foundTeam = db.Teams.Find(t);

            //delete TeamID to TeamID column in DB
            var result = db.Players.SingleOrDefault(player => player.PlayerID == p);
            if (result != null)
            {
                result.TeamID = null;
                db.SaveChanges();
            }

            //show message that player has been registered
            string playerName = GetSelectedPlayer().PlayerFullName;
            string teamName = GetSelectedTeam().TeamName;
            MessageBox.Show($"You have succelssfully deleted {playerName}'s registration to {teamName}!");

        }

        /// <summary>
        /// Button functionality for add/delete player, add/delete team and close
        /// </summary>
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var team = new AddTeam();
            team.ShowDialog();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var addPlayer = new frmAddPlayer();
            addPlayer.ShowDialog();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            //deletes a vendor
            TeamAEntities db = new TeamAEntities();

            //find id of selected vendor
            int p = GetSelectedPlayer().PlayerID;

            //get that vendor from db context 
            Player found = db.Players.Find(p);

            //remove vendor that was found
            db.Players.Remove(found);
            db.SaveChanges();

            //refresh list
            PopulatePlayerList();
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            TeamAEntities db = new TeamAEntities();
            int t = GetSelectedTeam().TeamID;

            Team found = db.Teams.Find(t);

            //remove vendor that was found
            db.Teams.Remove(found);
            db.SaveChanges();

            //refresh list
            PopulateTeamList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Helper methods
        /// </summary>
        public void PopulatePlayerList()
        {
            TeamAEntities db = new TeamAEntities();
            List<Player> player = db
                                  .Players
                                  .ToList();
            cboPlayer.DataSource = player;
            cboPlayer.DisplayMember = nameof(Player.PlayerFullName);
        }

        public void PopulateTeamList()
        {
            TeamAEntities db = new TeamAEntities();
            List<Team> team = db
                             .Teams
                             .ToList();
            cboTeam.DataSource = team;
            cboTeam.DisplayMember = nameof(Team.TeamName);
        }

        private Player GetSelectedPlayer()
        {
            return cboPlayer.SelectedItem as Player;
        }

        private Team GetSelectedTeam()
        {
            return cboTeam.SelectedItem as Team;
        }


    }
}
