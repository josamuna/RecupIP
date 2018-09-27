using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;
//using Microsoft.VisualBasic;

namespace RecupIP
{
    public partial class Principal : Form
    {
        string[] tbValues = null;
        List<string> lstValues = new List<string>();

        public Principal()
        {
            InitializeComponent();
        }

        private void lblLoadFile_MouseHover(object sender, EventArgs e)
        {
            CmdLoadFile.BackColor = Color.Lavender;

            //Changer forme du curseur
            CmdLoadFile.Cursor = Cursors.Hand;
        }

        private void lblLoadFile_MouseLeave(object sender, EventArgs e)
        {
            CmdLoadFile.BackColor = Color.Transparent;
        }

        private void Initialise()
        {
            //lstResult.Items.Clear();

            cmdGenerate.Enabled = false;
            cmdSave.Enabled = false;

            txtFormatText.Text = "Mettre ici le texte à formatter avec la génération ...";
            txtFormatText.Enabled = false;

            chkMerge.Checked = false;
            cboTypeGenerate.SelectedIndex = 0;
            txtPath.Clear();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            chkMerge.Checked = false;
            cmdGenerate.Enabled = false;
            cmdSave.Enabled = false;
            txtFormatText.Text = "Mettre ici le texte à formatter avec la génération ...";
            txtFormatText.Enabled = false;

            cboTypeGenerate.DataSource = Enum.GetNames(typeof(GenerateType));
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dlgSave.ShowDialog();

            try
            {
                using (StreamWriter sr = new StreamWriter(dlgSave.FileName, false))
                {
                    sr.WriteLine(Utilities.Instance.FormatString(lstValues, txtFormatText.Text));
                    sr.Flush();
                    sr.Close();
                }

                MessageBox.Show("Enregistrement effectué avec succès", "Enregister un fichier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement du fichier, " + ex.Message, "Enregister un fichier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }          
        }

        private void cmdIntitialise_Click(object sender, EventArgs e)
        {
            Initialise();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                lstValues.Clear();
                lstValues = Utilities.Instance.GenerateCarret(tbValues);

                if (lstValues.Count > 0)
                {
                    lstResult.Items.Clear();
                    lstResult.DataSource = lstValues;
                    lblElement2.Text = lstResult.Items.Count.ToString() + " Items";
                    cmdSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la génération des adresses IP, " + ex.Message, "Génération IP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
        }

        private void CmdLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult resultat = dlgOpen.ShowDialog();

            if (File.Exists(dlgOpen.FileName))
            {
                txtPath.Text = dlgOpen.FileName;
                rtfContent.Text = File.ReadAllText(dlgOpen.FileName);
                tbValues = File.ReadAllLines(dlgOpen.FileName);
                lblElement1.Text = tbValues.Length.ToString() + " Items";

                txtFormatText.Enabled = true;
                cmdGenerate.Enabled = true;
            }
            else
                MessageBox.Show("Le fichier choisi est invalide !!", "Chargement fichier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtFormatText_Enter(object sender, EventArgs e)
        {
            txtFormatText.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int va = "A".CompareTo("B");//-1
            Console.WriteLine("va = ", va);
            int va1 = "100.0.14".CompareTo("99.124.35.10");//1
            Console.WriteLine("va1 = ", va1);
            int va2 = "C".CompareTo("C");//0
            Console.WriteLine("va2 = ", va2);
        }
    }
}
