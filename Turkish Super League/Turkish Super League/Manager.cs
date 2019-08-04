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
    public partial class Manager : Form
    {

        string full = "select firstName, lastName, birthDate, nationality,name from MANAGER,TEAM ";
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");

        public Manager()
        {
            InitializeComponent();
            this.teamBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("select distinct name from TEAM", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                teamBox.Items.Add(read["name"].ToString());
            }

            conn.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            string hold = "where managerID=manager_id ";

            if (!(nameTxt.Text.Equals("")) || !(lastNameTxt.Text.Equals("")))
            {
                hold += "and ";
            }

            if (!(nameTxt.Text.Equals("")))
            {
                hold += "firstName='";
                hold += nameTxt.Text;
                hold += "'";
                if (!(lastNameTxt.Text.Equals("")))
                {
                    hold += "and ";
                }
            }
            if (!(lastNameTxt.Text.Equals("")))
            {
                hold += "lastName='";
                hold += lastNameTxt.Text;
                hold += "'";
            }

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
                add.Text = read["firstName"].ToString();
                add.SubItems.Add(read["lastName"].ToString());
                add.SubItems.Add(read["birthDate"].ToString());
                add.SubItems.Add(read["nationality"].ToString());
                add.SubItems.Add(read["name"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void teamSearchBtn_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            string hold = "where managerID=manager_id ";

            if (!(teamBox.Text.Equals("")))
            {
                hold += "and name='";
                hold += teamBox.Text;
                hold += "'";
            }

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
                add.Text = read["firstName"].ToString();
                add.SubItems.Add(read["lastName"].ToString());
                add.SubItems.Add(read["birthDate"].ToString());
                add.SubItems.Add(read["nationality"].ToString());
                add.SubItems.Add(read["name"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }
    }
}
