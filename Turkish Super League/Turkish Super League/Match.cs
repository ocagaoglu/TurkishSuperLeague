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
    public partial class Match : Form
    {
        string full = "select homeTeam, opposingTeam, score, week,date,TRIM(CONCAT(firstName, ' ', lastName)) AS result from MATCH,REFEREE where refereeID=referee_ID  ";
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;

        public Match()
        {
            InitializeComponent();
            this.homeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.opposingBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.weekBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.refereeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //-----------------------------------------------------

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd = new SqlCommand("select distinct homeTeam from MATCH", conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                homeBox.Items.Add(read["homeTeam"].ToString());
            }

            conn.Close();

            //-----------------------------------------------------

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd = new SqlCommand("select distinct opposingTeam from MATCH", conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                opposingBox.Items.Add(read["opposingTeam"].ToString());
            }

            conn.Close();

            //-----------------------------------------------------

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd = new SqlCommand("select distinct week from MATCH", conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                weekBox.Items.Add(read["week"].ToString());
            }

            conn.Close();

            //-----------------------------------------------------

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd = new SqlCommand("SELECT TRIM(CONCAT(firstName, ' ', lastName)) AS result FROM REFEREE ORDER BY result asc", conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                refereeBox.Items.Add(read["result"].ToString());
            }

            conn.Close();

        }

        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            weekBox.SelectedIndex = -1;
            refereeBox.SelectedIndex = -1;
            
            string hold = "";

            if (!(homeBox.Text.Equals("")) || !(opposingBox.Text.Equals("")))
            {
                hold += "and ";
            }

            if (!(homeBox.Text.Equals("")))
            {
                hold += "homeTeam='";
                hold += homeBox.Text;
                hold += "'";
                if (!(opposingBox.Text.Equals("")))
                {
                    hold += "and ";
                }
            }
            if (!(opposingBox.Text.Equals("")))
            {
                hold += "opposingTeam='";
                hold += opposingBox.Text;
                hold += "'";
            }
            hold += " order by date asc";

            listView1.Items.Clear();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string complete = full + hold;

            SqlCommand cmd = new SqlCommand(complete, conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["homeTeam"].ToString();
                add.SubItems.Add(read["opposingTeam"].ToString());
                add.SubItems.Add(read["score"].ToString());
                add.SubItems.Add(read["week"].ToString());
                add.SubItems.Add(read["date"].ToString());
                add.SubItems.Add(read["result"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void teamSearchBtn_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            homeBox.SelectedIndex = -1;
            opposingBox.SelectedIndex = -1;
            refereeBox.SelectedIndex = -1;

            string hold = "";

            if (!(weekBox.Text.Equals("")))
            {
                hold += "and week='";
                hold += weekBox.Text;
                hold += "'";
            }
            hold += " order by date asc";

            listView1.Items.Clear();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string complete = full + hold;

            SqlCommand cmd = new SqlCommand(complete, conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["homeTeam"].ToString();
                add.SubItems.Add(read["opposingTeam"].ToString());
                add.SubItems.Add(read["score"].ToString());
                add.SubItems.Add(read["week"].ToString());
                add.SubItems.Add(read["date"].ToString());
                add.SubItems.Add(read["result"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            homeBox.SelectedIndex = -1;
            opposingBox.SelectedIndex = -1;
            weekBox.SelectedIndex = -1;

            string hold = "";

            if (!(refereeBox.Text.Equals("")))
            {
                hold += "and TRIM(CONCAT(firstName, ' ', lastName))='";
                hold += refereeBox.Text;
                hold += "'";
            }
            hold += " order by date ASC";

            listView1.Items.Clear();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string complete = full + hold;
            Console.WriteLine(complete);

            SqlCommand cmd = new SqlCommand(complete, conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["homeTeam"].ToString();
                add.SubItems.Add(read["opposingTeam"].ToString());
                add.SubItems.Add(read["score"].ToString());
                add.SubItems.Add(read["week"].ToString());
                add.SubItems.Add(read["date"].ToString());
                add.SubItems.Add(read["result"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void weekBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
