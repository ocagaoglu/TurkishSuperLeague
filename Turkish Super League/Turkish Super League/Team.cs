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
    public partial class Team : Form
    {
        int teamNameCounter = 0, teamYearCounter = 0, teamColorCounter = 0, teamCityCounter = 0, teamStadiumCounter = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");

        public Team()
        {
            InitializeComponent();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["name"].ToString();
                add.SubItems.Add(read["yearOfEstablish"].ToString());
                add.SubItems.Add(read["colors"].ToString());
                add.SubItems.Add(read["city"].ToString());
                add.SubItems.Add(read["stadium_name"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void Team_Load(object sender, EventArgs e)
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
                if (teamNameCounter % 2 == 0)
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by name ASC", conn);
                }
                else
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by name DESC", conn);
                }

                teamNameCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["name"].ToString();
                    add.SubItems.Add(read["yearOfEstablish"].ToString());
                    add.SubItems.Add(read["colors"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["stadium_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 1)
            {
                if (teamYearCounter % 2 == 0)
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by yearOfEstablish ASC", conn);
                }
                else
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by yearOfEstablish DESC", conn);
                }

                teamYearCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["name"].ToString();
                    add.SubItems.Add(read["yearOfEstablish"].ToString());
                    add.SubItems.Add(read["colors"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["stadium_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 2)
            {
                if (teamColorCounter % 2 == 0)
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by colors ASC", conn);
                }
                else
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by colors DESC", conn);
                }

                teamColorCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["name"].ToString();
                    add.SubItems.Add(read["yearOfEstablish"].ToString());
                    add.SubItems.Add(read["colors"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["stadium_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 3)
            {
                if (teamCityCounter % 2 == 0)
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by city ASC", conn);
                }
                else
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by city DESC", conn);
                }

                teamCityCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["name"].ToString();
                    add.SubItems.Add(read["yearOfEstablish"].ToString());
                    add.SubItems.Add(read["colors"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["stadium_name"].ToString());
                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 4)
            {
                if (teamStadiumCounter % 2 == 0)
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by stadium_name ASC", conn);
                }
                else
                {
                    cmd = new SqlCommand("select name,yearOfEstablish,colors,city,stadium_name from TEAM order by stadium_name DESC", conn);
                }

                teamStadiumCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["name"].ToString();
                    add.SubItems.Add(read["yearOfEstablish"].ToString());
                    add.SubItems.Add(read["colors"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["stadium_name"].ToString());
                    listView1.Items.Add(add);
                }
            }

            conn.Close();
        }
    }
}
