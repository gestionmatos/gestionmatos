using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsGMF;


namespace WindowsFormsApp2SI
{


    public partial class Form2SI : Form
    {


        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string strcon = @"Server = .\SQLEXPRESS; Database=GM;Trusted_Connection=True;";

        public Form2SI()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (tempIndex == index)
            {
                 index= random.Next(Themecolor.ColorList.Count);
            }
            tempIndex = index;
            string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelgene.Controls.Add(childForm);
            this.panelgene.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panellogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    panelMenu.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls) {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClients dlg = new FormClients();
            dlg.ShowDialog();
        }

        private void matérielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMateriel dlg = new FormMateriel();
            dlg.ShowDialog();
        }

        private void Form2SI_Load(object sender, EventArgs e)
        {
           FormConnect dlg = new FormConnect();
           dlg.ShowDialog();


          
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




        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void buttonintervention_Click(object sender, EventArgs e)
        {
            OpenChildForm(new intervention(), sender);
        }

        private void buttonclien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClients(), sender);
        }

        private void buttonmatériels_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMateriel(), sender);
        }

        private void parametresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDeb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listViewListI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void interventionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intervention dlg = new intervention();
            dlg.ShowDialog();
        }

        private void interventionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            intervention dlg = new intervention();
            dlg.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void panelgeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelgene_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelgene_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
