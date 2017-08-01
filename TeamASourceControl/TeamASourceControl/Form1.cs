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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var addPlayer = new Player();
            //addPlayer.ShowDialog();
            PopulatePlayerList();

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var team = new Team();
            //team.ShowDialog();
            PopulatePlayerList();
        }

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
    }
}
