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
    public partial class Referee : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");
        int firstNameCounter = 0, lastNameCounter = 0,nationalityCounter=0;
        string full = "select firstName, lastName, nationality from REFEREE ";


        public Referee()
        {
            InitializeComponent();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("select firstName,lastName,nationality from REFEREE ORDER BY firstName ASC", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["firstName"].ToString();
                add.SubItems.Add(read["lastName"].ToString());
                add.SubItems.Add(read["nationality"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void Referee_Load(object sender, EventArgs e)
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

                    listView1.Items.Add(add);
                }
            }

            conn.Close();

        }
    }
}
