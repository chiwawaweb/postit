﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostIt.DAL;
using PostIt.DTO;
using PostIt.Classes;

namespace PostIt.Forms
{
    public partial class EvenementsListForm : Form
    {
        private static int idRetour;

        Utils utils = new Utils();

        EvenementProvider evenementProvider = new EvenementProvider();

        public EvenementsListForm()
        {
            InitializeComponent();

            /* Combobox Catégorie */
            var dsCategorie = new List<Categorie>();
            Categorie categorievide = new Categorie();
            categorievide.Nom = "";
            dsCategorie.Add(categorievide);
            foreach (Categorie categorie in utils.AllCategoriesActives())
            {
                if (categorie.Actif == true)
                {
                    dsCategorie.Add(categorie);
                }
            }
            CbxSearchCategorie.DataSource = dsCategorie;
            CbxSearchCategorie.DisplayMember = "FullName";
            CbxSearchCategorie.ValueMember = "FullName";

            /* Date de debut de filtrage */
            DtpDebut.Value = DateTime.Now.AddMonths(-3);
        }

        private void CreateTable(List<Evenement> list, int _idRetour)
        {
            idRetour = _idRetour;

            /* Initialisation du Datagridview des évenements*/
            dgvEvenements.Rows.Clear();
            dgvEvenements.Columns.Clear();

            /* Mise en forme du tableau */
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "#";
            idColumn.Width = 50;
            idColumn.Visible = true;
            idColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "DATE";
            dateColumn.Width = 85;
            dateColumn.MinimumWidth = 85;
            dateColumn.FillWeight = 1;
            dateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn categorieColumn = new DataGridViewTextBoxColumn();
            categorieColumn.Name = "Categorie";
            categorieColumn.HeaderText = "CATEGORIE";
            categorieColumn.Width = 200;
            categorieColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn statutColumn = new DataGridViewTextBoxColumn();
            statutColumn.Name = "Statut";
            statutColumn.HeaderText = "STATUT";
            statutColumn.Width = 80;
            statutColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn tiersColumn = new DataGridViewTextBoxColumn();
            tiersColumn.Name = "Tiers";
            tiersColumn.HeaderText = "TIERS";
            tiersColumn.Width = 200;
            tiersColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.Name = "Description";
            descriptionColumn.HeaderText = "DESCRIPTION";
            descriptionColumn.Width = 500;
            descriptionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn echeanceColumn = new DataGridViewTextBoxColumn();
            echeanceColumn.Name = "Echeance";
            echeanceColumn.HeaderText = "ECHEANCE";
            echeanceColumn.Width = 85;
            echeanceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            echeanceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn operateurColumn = new DataGridViewTextBoxColumn();
            operateurColumn.Name = "Suivi par";
            operateurColumn.HeaderText = "SUIVI PAR";
            operateurColumn.Width = 140;
            operateurColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            dgvEvenements.Columns.Add(idColumn);
            dgvEvenements.Columns.Add(dateColumn);
            dgvEvenements.Columns.Add(categorieColumn);
            dgvEvenements.Columns.Add(statutColumn);
            dgvEvenements.Columns.Add(tiersColumn);
            dgvEvenements.Columns.Add(descriptionColumn);
            dgvEvenements.Columns.Add(echeanceColumn);
            dgvEvenements.Columns.Add(operateurColumn);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvEvenements.Rows.Add();

                string id = list[i].Id.ToString("000000");
                DateTime date = list[i].Date;
                string categorie = list[i].Categorie;
                string statut = list[i].Statut;
                string tiers = list[i].Tiers;
                string description = list[i].Description;
                DateTime echeance = list[i].Echeance;
                string operateur = list[i].Operateur;
                
                dgvEvenements.Rows[number].Cells[0].Value = id;
                dgvEvenements.Rows[number].Cells[1].Value = date.ToString("dd/MM/yyyy");
                dgvEvenements.Rows[number].Cells[2].Value = categorie;
                dgvEvenements.Rows[number].Cells[3].Value = statut;
                dgvEvenements.Rows[number].Cells[4].Value = tiers;
                dgvEvenements.Rows[number].Cells[5].Value = description;
                dgvEvenements.Rows[number].Cells[6].Value = echeance.ToString("dd/MM/yyyy");
                dgvEvenements.Rows[number].Cells[7].Value = operateur;

                /* Coloration des lignes en fonction de l'échance */
                if (echeance == Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    dgvEvenements.Rows[number].DefaultCellStyle.BackColor = Color.Orange;
                }

                if (echeance < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    dgvEvenements.Rows[number].DefaultCellStyle.BackColor = Color.Red;
                }

                if (echeance == Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString()))
                {
                    dgvEvenements.Rows[number].DefaultCellStyle.BackColor = Color.Yellow;
                }

                /* Vérifie si événement terminé */
                if (statut == "Terminé" || statut == "Annulé")
                {
                    dgvEvenements.Rows[number].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                    dgvEvenements.Rows[number].DefaultCellStyle.ForeColor = Color.Gray;
                    dgvEvenements.Rows[number].DefaultCellStyle.BackColor = Color.White;
                }

                /* pointe sur l'enregistrement courant */
                if (list[i].Id == idRetour)
                {
                    dgvEvenements.Rows[number].Cells[1].Selected = true;
                }
            }

           

        }

        public void RefreshData()
        {
            DateTime dateDebut = Convert.ToDateTime(DtpDebut.Value.ToShortDateString());
            DateTime dateFin = Convert.ToDateTime(DtpFin.Value.ToShortDateString());

            List<Evenement> list;
            list = evenementProvider.Search(TxtSearch.Text, CbxSearchCategorie.Text, ChkEnCours.Checked, ChkAVenir.Checked,ChkTermine.Checked,ChkAnnule.Checked, dateDebut, dateFin); // à completer avec mots cles / dates

            CreateTable(list, idRetour);

        }

        private void EvenementsListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            WindowState = FormWindowState.Maximized;
        }

        private void TslAdd_Click(object sender, EventArgs e)
        {
            NewPostIt();
        }

        private void NewPostIt()
        {
            EvenementEditForm frm = new EvenementEditForm(this, false);
            frm.ShowDialog();

        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            NewPostIt();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            UpdatePostIt();
        }

        private void UpdatePostIt()
        {
            if (dgvEvenements.RowCount > 0)
            {
                int ID = int.Parse(dgvEvenements.CurrentRow.Cells[0].Value.ToString());
                idRetour = ID;
                EvenementEditForm frm = new EvenementEditForm(this, true, ID);
                frm.ShowDialog();
            }
        }

        private void dgvEvenements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePostIt();
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            ChangeStatut("Terminé");
        }

        private void ChangeStatut(string statut)
        {
            if (dgvEvenements.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("Etes-vous certain de vouloir modifier le statut de ce post'it ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = int.Parse(dgvEvenements.CurrentRow.Cells[0].Value.ToString());
                    Evenement evenement = evenementProvider.GetEvenementById(ID);
                    evenement.Statut = statut;
                    evenementProvider.Update(evenement);
                    RefreshData();
                }
            }
                
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            ChangeStatut("Annulé");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ChkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ChkAVenir_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ChkTermine_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ChkAnnule_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CbxSearchCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFiltre();
        }

        private void ResetFiltre()
        {
            CbxSearchCategorie.Text = "";
            TxtSearch.Text = "";
            ChkEnCours.Checked = true;
            ChkAVenir.Checked = false;
            ChkAnnule.Checked = false;
            ChkTermine.Checked = false;
            DtpDebut.Value = DateTime.Now.AddMonths(-3);
            DtpFin.Value = DateTime.Now;

        }
    }
}
