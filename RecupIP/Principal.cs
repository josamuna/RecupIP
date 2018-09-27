using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RecupIP
{
    public partial class Principal : Form
    {
        string[] tbValues = null;
        string[] lstValues = null;
        string[] lstItems = null;
        //List<string> lstValues1 = new List<string>();

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
            lstResult.Items.Clear();
            lstBuild.Items.Clear();

            cmdGenerate.Enabled = false;
            cmdSave.Enabled = false;
            //cmdCarret.Enabled = false;

            txtFormatText.Text = "Mettre ici le texte à formatter avec la génération ...";
            txtFormatText.Enabled = false;

            cboTypeGenerate.SelectedIndex = 0;
            lblElement1.Text = "";
            lblElement2.Text = "";
            lblElement3.Text = "";

            chkMerge.Checked = false;

            txtPath.Clear();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            chkMerge.Checked = false;
            cmdCarret.Enabled = false;
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
                if(chkMerge.Checked)
                {
                    using (StreamWriter sr = new StreamWriter(dlgSave.FileName, false))
                    {
                        sr.Write(Utilities.Instance.FormatStringTableau(lstItems, txtFormatText.Text));
                        sr.Flush();
                        sr.Close();
                    }
                }
                else
                {
                    using (StreamWriter sr = new StreamWriter(dlgSave.FileName, false))
                    {
                        sr.Write(Utilities.Instance.FormatStringTableau(lstValues, txtFormatText.Text));
                        sr.Flush();
                        sr.Close();
                    }
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
                lstResult.Cursor = Cursors.WaitCursor;
                lstBuild.Cursor = Cursors.WaitCursor;

                lstResult.Items.Clear();
                lstBuild.Items.Clear();

                lblElement2.Text = "";
                lblElement3.Text = "";

                switch (cboTypeGenerate.SelectedItem.ToString())
                {
                    case nameof(GenerateType.SplitPoint):
                    {
                        lstValues = Utilities.Instance.GeneratePoint(tbValues);
                        FillListItems(lstValues);
                    }
                    break;
                    case nameof(GenerateType.SplitCarret):
                    {
                        lstValues = Utilities.Instance.GenerateCarret(tbValues);
                        FillListItems(lstValues);
                    }
                    break;
                }

                cmdCarret.Enabled = true;

                if (chkMerge.Checked)
                {
                    List<string> lstRetour = new List<string>();
                    
                    lstItems = Utilities.Instance.SearchDoublons(lstValues, lstRetour);

                    if (lstItems.Length > 0)
                    {
                        lstBuild.Items.Clear();

                        foreach (string str in lstItems)
                            lstBuild.Items.Add(str);

                        lblElement3.Text = lstBuild.Items.Count.ToString() + " Items";
                        cmdSave.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la génération des adresses IP, " + ex.Message, "Génération IP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FillListItems(string[] lstValues)
        {
            if (lstValues.Length > 0)
            {
                lstResult.Items.Clear();

                foreach (string str in lstValues)
                    lstResult.Items.Add(str);

                lblElement2.Text = lstResult.Items.Count.ToString() + " Items";
                cmdSave.Enabled = true;
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

        private void cmdCarret_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            StringBuilder strValuesReturn = new StringBuilder();

            try
            {
                if (lstResult.Items.Count > 0)
                {
                    foreach (string str in lstResult.Items)
                        lst.Add(str);

                    strValuesReturn = Utilities.Instance.AddCarretToSave(lst);

                    dlgSave.ShowDialog();

                    using (StreamWriter sr = new StreamWriter(dlgSave.FileName, false))
                    {
                        sr.Write(strValuesReturn.ToString());
                        sr.Flush();
                        sr.Close();
                    }

                    MessageBox.Show("Ajout effectué ave succès", "Ajout Carret", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'ajout, " + ex.Message, "Ajout Carret", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            //if (lstValues1.Contains("45.64.186.102"))
            //{
            //    Console.WriteLine(lstValues1.IndexOf("45.64.186.102"));
            //}
            ////List<string> lst = lstValues1.FindAll(x => x.Equals("45.64.186.102"));

            ////foreach(string str in lst)
            ////{
            ////    Console.WriteLine(lst.IndexOf("45.64.186.102"));
            ////}

            //List<string> lstRetour = new List<string>();

            //string[] items = Utilities.Instance.SearchDoublons(lstValues, lstRetour);
            //sw.Stop();
            //Console.WriteLine("Temp ecoule1 = {0}", sw.ElapsedMilliseconds / 1000);

            //if (items.Length > 0)
            //{
            //    lstBuild.Items.Clear();

            //    Stopwatch sw1 = new Stopwatch();
            //    sw.Start();

            //    foreach (string str in items)
            //        lstBuild.Items.Add(str);

            //    lblElement3.Text = lstBuild.Items.Count.ToString() + " Items";
            //    cmdSave.Enabled = true;

            //    sw1.Stop();
            //    Console.WriteLine("Temp ecoule2 = {0}", sw.ElapsedMilliseconds / 1000);
            //}

            //string str = lstValues1.Find(x => x.Equals("45.64.186.102"));
        }

        private void CmdLoadFile_MouseHover(object sender, EventArgs e)
        {
            CmdLoadFile.Cursor = Cursors.Hand;
        }

        private void CmdLoadFile_MouseLeave(object sender, EventArgs e)
        {
            CmdLoadFile.Cursor = Cursors.Default;
        }
    }
}
