using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karaté_mission_1
{
    public partial class Frm_GestionMembres : Form
    {
        public Frm_GestionMembres()
        {
            InitializeComponent();
            LoadFormInPanel(new Frm_GestionMembres_Accueil());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form);
            form.Show();
        }

        private void gestionLicencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajoutDuneLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Frm_GestionMembres_AJ());
        }

        private void modificationDUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Frm_GestionMembres_MS());
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Frm_GestionMembres_Accueil());
        }

        private void Frm_GestionMembres_Load(object sender, EventArgs e)
        {

        }

        private void consultationDesLicencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Frm_GestionMembre_Cons());
        }
    }
}