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
    public partial class Assist : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JS311S9\OMERSQL;Initial Catalog=turkishSuperLeague;Integrated Security=True");

        public Assist()
        {
            InitializeComponent();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("select firstName,lastName,team_name,number from PLAYER,ASSIST where playerID=player_id ORDER BY number desc", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["firstName"].ToString();
                add.SubItems.Add(read["lastName"].ToString());
                add.SubItems.Add(read["team_name"].ToString());
                add.SubItems.Add(read["number"].ToString());

                listView1.Items.Add(add);
            }

            conn.Close();
        }

        private void Assist_Load(object sender, EventArgs e)
        {

        }
    }
}
