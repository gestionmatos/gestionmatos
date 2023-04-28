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
using WindowsFormsGMF;

namespace WindowsFormsApp2SI
{
    public partial class intervention : Form
    {

        private string strcon = @"Server = .\SQLEXPRESS; Database=GM;Trusted_Connection=True;";
        public intervention()
        {
            InitializeComponent();
        }

        private void intervention_Load(object sender, EventArgs e)
        {
          

            fillComboMatos();
        }

        private void fillComboMatos()
        {
            comboBoxMatos.Items.Clear();
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string sql = "select * from MATERIEL";
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBoxMatos.Items.Add(dr["Nom"].ToString());
            }

            dr.Close();
            cn.Close();
        }



        private int getMatosID(string name)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();

            string strsqL = "select ID_MAT from MATERIEL where Nom = '" + name + "'";

            SqlCommand com = new SqlCommand(strsqL, cn);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            int nb = Convert.ToInt32(dr["ID_MAT"]);
            cn.Close();

            return nb;
        }


        private string getMatosName(int id)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string strsqL = "select Nom from MATERIEL where ID_MAT = " + id;

            SqlCommand com = new SqlCommand(strsqL, cn);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            string lenom = dr["Nom"].ToString();
            cn.Close();

            return lenom;
        }



        private void buttonAffInter_Click(object sender, EventArgs e)
        {
            listViewListI.Items.Clear();
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            SqlCommand com = new SqlCommand("AffInter", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Beginning_Date", dateTimePickerDeb.Value);
            com.Parameters.AddWithValue("@Ending_Date", dateTimePickerEnd.Value);

            SqlDataReader dr = com.ExecuteReader();

            string date, comment, tech, matos;

            while (dr.Read())
            {
                date = Convert.ToDateTime(dr["DATE_INTER"]).ToShortDateString();
                comment = dr["Commentaire"].ToString();
                tech = dr["Technicien"].ToString();
                matos = getMatosName(Convert.ToInt32(dr["ID_MAT"]));

                string[] itemData = new string[] { date, comment, tech, matos };
                ListViewItem item = new ListViewItem(itemData);
                listViewListI.Items.Add(item);
            }

            dr.Close();
            cn.Close();

            
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCI_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();

            string Commentaire = textBoxComment.Text;
            string tech = textBoxTech.Text;
            string dateInstall = dateTimePickerDI.Value.ToString("yyyy-MM-dd");
            int idc = getMatosID(comboBoxMatos.SelectedItem.ToString());

            string strsqL = "insert into Intervention values('" + dateInstall + "','" +
                Commentaire + "','" + tech + "'," + idc + ")";

            SqlCommand com = new SqlCommand(strsqL, cn);
            com.ExecuteNonQuery();
            cn.Close();

            cleanInter();

            MessageBox.Show("Intervention bien ajoutée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cleanInter()
        {
            textBoxTech.Text = textBoxComment.Text = "";

            dateTimePickerDI.Value = DateTime.Today;
            comboBoxMatos.SelectedIndex = -1;
        }



    }
}
