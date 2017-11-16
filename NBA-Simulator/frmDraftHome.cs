using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NBA_Simulator
{
    public partial class frmDraftHome : Form
    {
        public frmDraftHome()
        {
            InitializeComponent();
            loadPlayerDGV();
            
        }

        public void loadPlayerDGV()
        {
            SqlCommand selectAll = new SqlCommand("SELECT * FROM Players");
            SqlConnection a = new SqlConnection("Data Source=CHRISPAINTER-AS;Initial Catalog=NationalBasketballAssociation;User ID=sa;Password=sqlSERVER17");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectAll.CommandText, a);
            DataSet ds = new DataSet();
            a.Open();
            dataAdapter.Fill(ds, "Players_table");
            a.Close();
            dgvPlayers.DataSource = ds.Tables[0];

            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;   

        }
    }
}
