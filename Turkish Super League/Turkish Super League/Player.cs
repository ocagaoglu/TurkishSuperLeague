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
    public partial class Player : Form
    {
        int firstNameCounter = 0, lastNameCounter = 0, nationalityCounter = 0, positionCounter = 0, birthDateCounter = 0, teamNameCounter = 0;
        string full = "select firstName, lastName, nationality, position, birthDate, team_name from PLAYER ";

        private void nationalityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            nationalityBox.SelectedIndex = -1;
            positionBox.SelectedIndex=-1;
            teamBox.SelectedIndex=-1;
            listView1.Items.Clear();
            full = "select firstName, lastName, nationality, position, birthDate, team_name from PLAYER ";
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");

        public Player()
        {
            InitializeComponent();
            this.nationalityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.positionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.teamBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select firstName,lastName,nationality,position,birthDate,team_name from PLAYER", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["firstName"].ToString();
                add.SubItems.Add(read["lastName"].ToString());
                add.SubItems.Add(read["nationality"].ToString());
                add.SubItems.Add(read["position"].ToString());
                add.SubItems.Add(read["birthDate"].ToString());
                add.SubItems.Add(read["team_name"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();

            //---------------------------------------------------------------------

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd = new SqlCommand("select distinct nationality from PLAYER", conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                nationalityBox.Items.Add(read["nationality"].ToString());
            }

            conn.Close();

            //--------------------------------------------------------------------------

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd = new SqlCommand("select distinct position from PLAYER", conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                positionBox.Items.Add(read["position"].ToString());
            }

            conn.Close();

            //----------------------------------------------------------------------------

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd = new SqlCommand("select distinct team_name from PLAYER", conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                teamBox.Items.Add(read["team_name"].ToString());
            }

            conn.Close();

        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            listView1.Items.Clear();
            SqlCommand cmd;


            if (e.Column == 0)
            {
                if (firstNameCounter % 2 == 0)
                {
                    string hold = full + "order by firstName ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by firstName DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                firstNameCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["firstName"].ToString();
                    add.SubItems.Add(read["lastName"].ToString());
                    add.SubItems.Add(read["nationality"].ToString());
                    add.SubItems.Add(read["position"].ToString());
                    add.SubItems.Add(read["birthDate"].ToString());
                    add.SubItems.Add(read["team_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 1)
            {
                if (lastNameCounter % 2 == 0)
                {
                    string hold = full + "order by lastName ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by lastName DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                lastNameCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["firstName"].ToString();
                    add.SubItems.Add(read["lastName"].ToString());
                    add.SubItems.Add(read["nationality"].ToString());
                    add.SubItems.Add(read["position"].ToString());
                    add.SubItems.Add(read["birthDate"].ToString());
                    add.SubItems.Add(read["team_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 2)
            {
                if (nationalityCounter % 2 == 0)
                {
                    string hold = full + "order by nationality ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by nationality DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                nationalityCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["firstName"].ToString();
                    add.SubItems.Add(read["lastName"].ToString());
                    add.SubItems.Add(read["nationality"].ToString());
                    add.SubItems.Add(read["position"].ToString());
                    add.SubItems.Add(read["birthDate"].ToString());
                    add.SubItems.Add(read["team_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 3)
            {
                if (positionCounter % 2 == 0)
                {
                    string hold = full + "order by position ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by position DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                positionCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["firstName"].ToString();
                    add.SubItems.Add(read["lastName"].ToString());
                    add.SubItems.Add(read["nationality"].ToString());
                    add.SubItems.Add(read["position"].ToString());
                    add.SubItems.Add(read["birthDate"].ToString());
                    add.SubItems.Add(read["team_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 4)
            {
                if (birthDateCounter % 2 == 0)
                {
                    string hold = full + "order by birthDate ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by birthDate DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                birthDateCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["firstName"].ToString();
                    add.SubItems.Add(read["lastName"].ToString());
                    add.SubItems.Add(read["nationality"].ToString());
                    add.SubItems.Add(read["position"].ToString());
                    add.SubItems.Add(read["birthDate"].ToString());
                    add.SubItems.Add(read["team_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 5)
            {
                if (teamNameCounter % 2 == 0)
                {
                    string hold = full + "order by team_name ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by team_name DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                teamNameCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["firstName"].ToString();
                    add.SubItems.Add(read["lastName"].ToString());
                    add.SubItems.Add(read["nationality"].ToString());
                    add.SubItems.Add(read["position"].ToString());
                    add.SubItems.Add(read["birthDate"].ToString());
                    add.SubItems.Add(read["team_name"].ToString());
                    listView1.Items.Add(add);
                }
            }

            conn.Close();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            string hold = "";

            if((!(nationalityBox.Text.Equals(""))) || (!(positionBox.Text.Equals(""))) || (!(teamBox.Text.Equals(""))))
            {
                hold += "where ";
            }

            if (!(nationalityBox.Text.Equals("")))
            {
                hold += "nationality='";
                hold += nationalityBox.Text;
                hold += "'";
                if((!(positionBox.Text.Equals(""))|| !(teamBox.Text.Equals(""))))
                {
                    hold += "and ";
                }
                
            }
            if (!(positionBox.Text.Equals("")))
            {
                hold += "position='";
                hold += positionBox.Text;
                hold += "'";
                if (!(teamBox.Text.Equals("")))
                {
                    hold += "and ";
                }

            }
            if (!(teamBox.Text.Equals("")))
            {
                hold += "team_name='";
                hold += teamBox.Text;
                hold += "'";
            }

            listView1.Items.Clear();
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            full = "select firstName, lastName, nationality, position, birthDate, team_name from PLAYER ";
            full += hold;

            SqlCommand cmd = new SqlCommand(full,conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["firstName"].ToString();
                add.SubItems.Add(read["lastName"].ToString());
                add.SubItems.Add(read["nationality"].ToString());
                add.SubItems.Add(read["position"].ToString());
                add.SubItems.Add(read["birthDate"].ToString());
                add.SubItems.Add(read["team_name"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }
    }
}
