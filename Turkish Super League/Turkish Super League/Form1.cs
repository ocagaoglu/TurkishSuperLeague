using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turkish_Super_League
{

    public partial class Form1 : Form
    {

        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");

        Team teamForm;
        Player playerForm;
        Manager managerForm;
        Goal goalForm;
        Assist assistForm;
        Referee refereeForm;
        Stadium stadiumForm;
        Match matchForm;
        bool teamFormOpen = false,playerFormOpen=false,managerFormOpen=false,goalFormOpen=false,assistFormOpen=false,refereeFormOpen=false,stadiumFormOpen=false,matchFormOpen=false;


        public Form1()
        {
            InitializeComponent();
            sound.SoundLocation = "entryMusic.wav";
            sound.PlayLooping();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teamBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = teamBtn.Width;
            selector.Left = teamBtn.Left;

            if (teamFormOpen == false)
            {
                if (playerForm != null)
                {
                    playerForm.Close();
                    playerForm = null;
                    playerFormOpen = false;
                }

                if (managerForm != null)
                {
                    managerForm.Close();
                    managerForm = null;
                    managerFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (assistForm != null)
                {
                    assistForm.Close();
                    assistForm = null;
                    assistFormOpen = false;
                }

                if (refereeForm != null)
                {
                    refereeForm.Close();
                    refereeForm = null;
                    refereeFormOpen = false;
                }

                if (stadiumForm != null)
                {
                    stadiumForm.Close();
                    stadiumForm = null;
                    stadiumFormOpen = false;
                }

                if (matchForm != null)
                {
                    matchForm.Close();
                    matchForm = null;
                    matchFormOpen = false;
                }

                teamForm = new Team();
                teamForm.TopLevel = false;
                teamForm.TopMost = true;
                teamPnl.Controls.Add(teamForm);
                teamForm.Show();
                teamFormOpen = true;
            }
            
        }

        private void playerBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = playerBtn.Width;
            selector.Left = playerBtn.Left;

            if (playerFormOpen == false)
            {
                if (teamForm != null)
                {
                    teamForm.Close();
                    teamForm = null;
                    teamFormOpen = false;
                }

                if (managerForm != null)
                {
                    managerForm.Close();
                    managerForm = null;
                    managerFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (assistForm != null)
                {
                    assistForm.Close();
                    assistForm = null;
                    assistFormOpen = false;
                }

                if (refereeForm != null)
                {
                    refereeForm.Close();
                    refereeForm = null;
                    refereeFormOpen = false;
                }

                if (stadiumForm != null)
                {
                    stadiumForm.Close();
                    stadiumForm = null;
                    stadiumFormOpen = false;
                }

                if (matchForm != null)
                {
                    matchForm.Close();
                    matchForm = null;
                    matchFormOpen = false;
                }


                playerForm = new Player();
                playerForm.TopLevel = false;
                playerForm.TopMost = true;
                teamPnl.Controls.Add(playerForm);
                playerForm.Show();
                playerFormOpen = true;
            }
        }

        private void managerBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = managerBtn.Width;
            selector.Left = managerBtn.Left;

            if (managerFormOpen == false)
            {
                if (teamForm != null)
                {
                    teamForm.Close();
                    teamForm = null;
                    teamFormOpen = false;
                }

                if (playerForm != null)
                {
                    playerForm.Close();
                    playerForm = null;
                    playerFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (assistForm != null)
                {
                    assistForm.Close();
                    assistForm = null;
                    assistFormOpen = false;
                }

                if (refereeForm != null)
                {
                    refereeForm.Close();
                    refereeForm = null;
                    refereeFormOpen = false;
                }

                if (stadiumForm != null)
                {
                    stadiumForm.Close();
                    stadiumForm = null;
                    stadiumFormOpen = false;
                }

                if (matchForm != null)
                {
                    matchForm.Close();
                    matchForm = null;
                    matchFormOpen = false;
                }


                managerForm = new Manager();
                managerForm.TopLevel = false;
                managerForm.TopMost = true;
                teamPnl.Controls.Add(managerForm);
                managerForm.Show();
                managerFormOpen = true;
            }
        }

        private void goalBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = goalBtn.Width;
            selector.Left = goalBtn.Left;

            if (goalFormOpen == false)
            {
                if (teamForm != null)
                {
                    teamForm.Close();
                    teamForm = null;
                    teamFormOpen = false;
                }

                if (playerForm != null)
                {
                    playerForm.Close();
                    playerForm = null;
                    playerFormOpen = false;
                }

                if (managerForm != null)
                {
                    managerForm.Close();
                    managerForm = null;
                    managerFormOpen = false;
                }

                if (assistForm != null)
                {
                    assistForm.Close();
                    assistForm = null;
                    assistFormOpen = false;
                }

                if (refereeForm != null)
                {
                    refereeForm.Close();
                    refereeForm = null;
                    refereeFormOpen = false;
                }

                if (stadiumForm != null)
                {
                    stadiumForm.Close();
                    stadiumForm = null;
                    stadiumFormOpen = false;
                }

                if (matchForm != null)
                {
                    matchForm.Close();
                    matchForm = null;
                    matchFormOpen = false;
                }


                goalForm = new Goal();
                goalForm.TopLevel = false;
                goalForm.TopMost = true;
                teamPnl.Controls.Add(goalForm);
                goalForm.Show();
                goalFormOpen = true;
            }
        }

        private void assistBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = assistBtn.Width;
            selector.Left = assistBtn.Left;

            if (assistFormOpen == false)
            {
                if (teamForm != null)
                {
                    teamForm.Close();
                    teamForm = null;
                    teamFormOpen = false;
                }

                if (playerForm != null)
                {
                    playerForm.Close();
                    playerForm = null;
                    playerFormOpen = false;
                }

                if (managerForm != null)
                {
                    managerForm.Close();
                    managerForm = null;
                    managerFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (refereeForm != null)
                {
                    refereeForm.Close();
                    refereeForm = null;
                    refereeFormOpen = false;
                }

                if (stadiumForm != null)
                {
                    stadiumForm.Close();
                    stadiumForm = null;
                    stadiumFormOpen = false;
                }

                if (matchForm != null)
                {
                    matchForm.Close();
                    matchForm = null;
                    matchFormOpen = false;
                }


                assistForm = new Assist();
                assistForm.TopLevel = false;
                assistForm.TopMost = true;
                teamPnl.Controls.Add(assistForm);
                assistForm.Show();
                assistFormOpen = true;
            }
        }

        private void refereeBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = refereeBtn.Width;
            selector.Left = refereeBtn.Left;

            if (refereeFormOpen == false)
            {
                if (teamForm != null)
                {
                    teamForm.Close();
                    teamForm = null;
                    teamFormOpen = false;
                }

                if (playerForm != null)
                {
                    playerForm.Close();
                    playerForm = null;
                    playerFormOpen = false;
                }

                if (managerForm != null)
                {
                    managerForm.Close();
                    managerForm = null;
                    managerFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (assistForm != null)
                {
                    assistForm.Close();
                    assistForm = null;
                    assistFormOpen = false;
                }

                if (stadiumForm != null)
                {
                    stadiumForm.Close();
                    stadiumForm = null;
                    stadiumFormOpen = false;
                }

                if (matchForm != null)
                {
                    matchForm.Close();
                    matchForm = null;
                    matchFormOpen = false;
                }


                refereeForm = new Referee();
                refereeForm.TopLevel = false;
                refereeForm.TopMost = true;
                teamPnl.Controls.Add(refereeForm);
                refereeForm.Show();
                refereeFormOpen = true;
            }
        }

        private void stadiumBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = stadiumBtn.Width;
            selector.Left = stadiumBtn.Left;

            if (stadiumFormOpen == false)
            {
                if (teamForm != null)
                {
                    teamForm.Close();
                    teamForm = null;
                    teamFormOpen = false;
                }

                if (playerForm != null)
                {
                    playerForm.Close();
                    playerForm = null;
                    playerFormOpen = false;
                }

                if (managerForm != null)
                {
                    managerForm.Close();
                    managerForm = null;
                    managerFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (assistForm != null)
                {
                    assistForm.Close();
                    assistForm = null;
                    assistFormOpen = false;
                }

                if (refereeForm != null)
                {
                    refereeForm.Close();
                    refereeForm = null;
                    refereeFormOpen = false;
                }

                if (matchForm != null)
                {
                    matchForm.Close();
                    matchForm = null;
                    matchFormOpen = false;
                }


                stadiumForm = new Stadium();
                stadiumForm.TopLevel = false;
                stadiumForm.TopMost = true;
                teamPnl.Controls.Add(stadiumForm);
                stadiumForm.Show();
                stadiumFormOpen = true;
            }
        }

        private void matchBtn_Click(object sender, EventArgs e)
        {
            selector.Visible = true;
            selector.Width = matchBtn.Width;
            selector.Left = matchBtn.Left;

            if (matchFormOpen == false)
            {
                if (teamForm != null)
                {
                    teamForm.Close();
                    teamForm = null;
                    teamFormOpen = false;
                }

                if (playerForm != null)
                {
                    playerForm.Close();
                    playerForm = null;
                    playerFormOpen = false;
                }

                if (managerForm != null)
                {
                    managerForm.Close();
                    managerForm = null;
                    managerFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (goalForm != null)
                {
                    goalForm.Close();
                    goalForm = null;
                    goalFormOpen = false;
                }

                if (assistForm != null)
                {
                    assistForm.Close();
                    assistForm = null;
                    assistFormOpen = false;
                }

                if (refereeForm != null)
                {
                    refereeForm.Close();
                    refereeForm = null;
                    refereeFormOpen = false;
                }

                if (stadiumForm != null)
                {
                    stadiumForm.Close();
                    stadiumForm = null;
                    stadiumFormOpen = false;
                }

                matchForm = new Match();
                matchForm.TopLevel = false;
                matchForm.TopMost = true;
                teamPnl.Controls.Add(matchForm);
                matchForm.Show();
                matchFormOpen = true;
            }
        }


    }
}
