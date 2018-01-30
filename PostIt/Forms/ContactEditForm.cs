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
    public partial class ContactEditForm : Form
    {
        string type, societe, nom, prenom, adresse1, adresse2, cp, ville, pays, tel, fax, gsm, email;
        string formTitle;
        bool contactUpdateMode;
        int _id;
        DateTime createdAt, updatedAt;

        Utils utils = new Utils();

        ContactsListForm _owner;

        ContactProvider contactProvider = new ContactProvider();


        public ContactEditForm(ContactsListForm owner, bool update, int id = 0)
        {
            _owner = owner;
            _id = id;
            contactUpdateMode = update;
            FormClosed += new FormClosedEventHandler(ContactEditForm_FormClosed);

            InitializeComponent();

            /* Combobox Catégories */
            var dsCategorie = new List<CategorieContact>();
            CategorieContact categorieVide = new CategorieContact();
            categorieVide.Nom = "";
            dsCategorie.Add(categorieVide);
            foreach (CategorieContact categorie in utils.AllCategoriesContactsActives())
            {
                if (categorie.Actif == true)
                {
                    dsCategorie.Add(categorie);
                }
            }
            CbxType.DataSource = dsCategorie;
            CbxType.DisplayMember = "FullName";
            CbxType.ValueMember = "FullName";

            /* Combobox Pays */
            var dsPays = new List<Pays>();
            Pays paysVide = new Pays();
            paysVide.Nom = "";
            dsPays.Add(paysVide);
            foreach (Pays pays in utils.AllPaysActives())
            {
                if (pays.Actif == true)
                {
                    dsPays.Add(pays);
                }
            }
            CbxPays.DataSource = dsPays;
            CbxPays.DisplayMember = "FullName";
            CbxPays.ValueMember = "FullName";

            switch (contactUpdateMode)
            {
                /* Mode création */
                case false:
                    NewContact();
                    break;

                /* Mode mise à jour */
                case true:
                    LoadContact();
                    break;
            }

            /* Titre du formulaire */
            this.Text = formTitle;
        }

        private void NewContact()
        {
            formTitle = "Création d'un contact";
        }

        private void LoadContact()
        {
            formTitle = "Consultation d'un contact";

            /* Modification des boutons */


            /* Récupération des données */
            type = contactProvider.GetContactById(_id).Type;
            societe = contactProvider.GetContactById(_id).Societe;
            nom = contactProvider.GetContactById(_id).Nom;
            prenom = contactProvider.GetContactById(_id).Prenom;
            adresse1 = contactProvider.GetContactById(_id).Adresse1;
            adresse2 = contactProvider.GetContactById(_id).Adresse2;
            cp = contactProvider.GetContactById(_id).CodePostal;
            ville = contactProvider.GetContactById(_id).Ville;
            pays = contactProvider.GetContactById(_id).Pays;
            tel = contactProvider.GetContactById(_id).Tel;
            fax = contactProvider.GetContactById(_id).Fax;
            gsm = contactProvider.GetContactById(_id).Mob;
            email = contactProvider.GetContactById(_id).Email;

            /* Affichage des données */
            CbxType.Text = type;
            TxtSociete.Text = societe;
            TxtNom.Text = nom;
            TxtPrenom.Text = prenom;
            TxtAdresse1.Text = adresse1;
            TxtAdresse2.Text = adresse2;
            TxtCp.Text = cp;
            TxtVille.Text = ville;
            CbxPays.Text = pays;
            TxtTel.Text = tel;
            TxtFax.Text = fax;
            TxtGsm.Text = gsm;
            TxtEmail.Text = email;
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveContact();
        }

        private void SaveContact()
        {
            /* Récupération des données */
            type = CbxType.Text.Trim();
            societe = TxtSociete.Text.Trim().ToUpper();
            nom = TxtNom.Text.Trim().ToUpper();
            prenom = TxtPrenom.Text.Trim().ToUpper();
            adresse1 = TxtAdresse1.Text.Trim().ToUpper();
            adresse2 = TxtAdresse2.Text.Trim().ToUpper();
            cp = TxtCp.Text.Trim().ToUpper();
            ville = TxtVille.Text.Trim().ToUpper();
            pays = CbxPays.Text.Trim().ToUpper();
            tel = TxtTel.Text.Trim();
            fax = TxtFax.Text.Trim();
            gsm = TxtGsm.Text.Trim();
            email = TxtEmail.Text.ToLower();

            /* Vérification des données */
            bool erreurs = false;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            if (type.Length<2)
            {
                erreurs = true;
                errMsg += "- Catégorie non spécifiée\n";
            }

            string nomComplet = societe + nom + prenom;
            if (nomComplet.Length<2)
            {
                erreurs = true;
                errMsg += "- Société, nom ou prénom non spécifié\n";
            }

            if (erreurs == true)
            {
                MessageBox.Show(errMsg, "Erreurs dans la saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* Aucune erreur, on continue */
                using (Context context = new Context())
                {
                    if (contactUpdateMode == true)
                    {
                        UpdateDatabase();
                    }
                    else
                    {
                        AddDatabase();
                    }
                    Close();
                }
            }



        }

        private void UpdateDatabase()
        {
            
        }

        private void AddDatabase()
        {
            Contact contact = new Contact();

            contact.Type = type;
            contact.Societe = societe;
            contact.Nom = nom;
            contact.Prenom = prenom;
            contact.Adresse1 = adresse1;
            contact.Adresse2 = adresse2;
            contact.CodePostal = cp;
            contact.Ville = ville;
            contact.Pays = pays;
            contact.Tel = tel;
            contact.Mob = gsm;
            contact.Fax = fax;
            contact.Email = email;
            contact.CreatedAt = DateTime.Now;

            contactProvider.Create(contact);
        }

        private void ContactEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }
    }
}
