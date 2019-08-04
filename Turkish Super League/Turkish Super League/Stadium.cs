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
    public partial class Stadium : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");
        int stadiumNameCounter = 0, capacityCounter = 0, cityCounter = 0,teamCounter=0;
        string full = "select stadiumName, capacity, city,name from STADIUM,TEAM where stadiumName=stadium_name ";

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
                if (stadiumNameCounter % 2 == 0)
                {
                    string hold = full + "order by stadiumName ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by stadiumName DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                stadiumNameCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["stadiumName"].ToString();
                    add.SubItems.Add(read["capacity"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["name"].ToString());

                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 1)
            {
                if (capacityCounter % 2 == 0)
                {
                    string hold = full + "order by capacity ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by capacity DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                capacityCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["stadiumName"].ToString();
                    add.SubItems.Add(read["capacity"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["name"].ToString());

                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 2)
            {
                if (cityCounter % 2 == 0)
                {
                    string hold = full + "order by city ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by city DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                cityCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["stadiumName"].ToString();
                    add.SubItems.Add(read["capacity"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["name"].ToString());

                    listView1.Items.Add(add);
                }
            }
            else if (e.Column == 3)
            {
                if (teamCounter % 2 == 0)
                {
                    string hold = full + "order by name ASC";
                    cmd = new SqlCommand(hold, conn);
                }
                else
                {
                    string hold = full + "order by name DESC";
                    cmd = new SqlCommand(hold, conn);
                }

                teamCounter++;
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = read["stadiumName"].ToString();
                    add.SubItems.Add(read["capacity"].ToString());
                    add.SubItems.Add(read["city"].ToString());
                    add.SubItems.Add(read["name"].ToString());

                    listView1.Items.Add(add);
                }
            }

            conn.Close();
        }

        

        public Stadium()
        {
            InitializeComponent();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("select stadiumName, capacity, city,name from STADIUM,TEAM where stadiumName=stadium_name ORDER BY stadiumName ASC", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["stadiumName"].ToString();
                add.SubItems.Add(read["capacity"].ToString());
                add.SubItems.Add(read["city"].ToString());
                add.SubItems.Add(read["name"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void Stadium_Load(object sender, EventArgs e)
        {

        }
    }
}
