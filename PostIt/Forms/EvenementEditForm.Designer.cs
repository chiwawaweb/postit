﻿namespace PostIt.Forms
{
    partial class EvenementEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvenementEditForm));
            this.LblOperateur = new System.Windows.Forms.Label();
            this.CbxOperateur = new System.Windows.Forms.ComboBox();
            this.CbxCategorie = new System.Windows.Forms.ComboBox();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.TxtTiers = new System.Windows.Forms.TextBox();
            this.LblTiers = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.DtpEcheance = new System.Windows.Forms.DateTimePicker();
            this.LblEcheance = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.BtnCommentaires = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.LblTitre = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnFermer = new System.Windows.Forms.Button();
            this.LblOperateurView = new System.Windows.Forms.Label();
            this.LblCategorieView = new System.Windows.Forms.Label();
            this.LblTiersView = new System.Windows.Forms.Label();
            this.LblEcheanceView = new System.Windows.Forms.Label();
            this.BtnAvanceEcheance = new System.Windows.Forms.Button();
            this.BtnReculeEcheance = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TssDateCreation = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssDateModification = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssStatut = new System.Windows.Forms.ToolStripStatusLabel();
            this.PbxModifier = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOperateur
            // 
            this.LblOperateur.AutoSize = true;
            this.LblOperateur.Location = new System.Drawing.Point(28, 58);
            this.LblOperateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOperateur.Name = "LblOperateur";
            this.LblOperateur.Size = new System.Drawing.Size(84, 16);
            this.LblOperateur.TabIndex = 0;
            this.LblOperateur.Text = "Collaborateur";
            // 
            // CbxOperateur
            // 
            this.CbxOperateur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CbxOperateur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxOperateur.FormattingEnabled = true;
            this.CbxOperateur.Location = new System.Drawing.Point(28, 77);
            this.CbxOperateur.Margin = new System.Windows.Forms.Padding(2);
            this.CbxOperateur.Name = "CbxOperateur";
            this.CbxOperateur.Size = new System.Drawing.Size(217, 24);
            this.CbxOperateur.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(289, 77);
            this.CbxCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(208, 24);
            this.CbxCategorie.TabIndex = 1;
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(289, 58);
            this.LblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(63, 16);
            this.LblCategorie.TabIndex = 2;
            this.LblCategorie.Text = "Catégorie";
            // 
            // TxtTiers
            // 
            this.TxtTiers.Location = new System.Drawing.Point(28, 133);
            this.TxtTiers.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTiers.Name = "TxtTiers";
            this.TxtTiers.Size = new System.Drawing.Size(217, 22);
            this.TxtTiers.TabIndex = 2;
            // 
            // LblTiers
            // 
            this.LblTiers.AutoSize = true;
            this.LblTiers.Location = new System.Drawing.Point(28, 114);
            this.LblTiers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTiers.Name = "LblTiers";
            this.LblTiers.Size = new System.Drawing.Size(93, 16);
            this.LblTiers.TabIndex = 5;
            this.LblTiers.Text = "Tiers concerné";
            // 
            // TxtDescription
            // 
            this.TxtDescription.AcceptsReturn = true;
            this.TxtDescription.Location = new System.Drawing.Point(28, 185);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescription.Size = new System.Drawing.Size(469, 126);
            this.TxtDescription.TabIndex = 3;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(28, 166);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(138, 16);
            this.LblDescription.TabIndex = 8;
            this.LblDescription.Text = "Description / Message";
            // 
            // DtpEcheance
            // 
            this.DtpEcheance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEcheance.Location = new System.Drawing.Point(28, 343);
            this.DtpEcheance.Margin = new System.Windows.Forms.Padding(2);
            this.DtpEcheance.Name = "DtpEcheance";
            this.DtpEcheance.Size = new System.Drawing.Size(110, 22);
            this.DtpEcheance.TabIndex = 5;
            // 
            // LblEcheance
            // 
            this.LblEcheance.AutoSize = true;
            this.LblEcheance.Location = new System.Drawing.Point(28, 325);
            this.LblEcheance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEcheance.Name = "LblEcheance";
            this.LblEcheance.Size = new System.Drawing.Size(107, 16);
            this.LblEcheance.TabIndex = 11;
            this.LblEcheance.Text = "Echéance prévue";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(257, 405);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(107, 42);
            this.BtnAnnuler.TabIndex = 8;
            this.BtnAnnuler.TabStop = false;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Location = new System.Drawing.Point(369, 405);
            this.BtnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(129, 42);
            this.BtnEnregistrer.TabIndex = 7;
            this.BtnEnregistrer.TabStop = false;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // BtnCommentaires
            // 
            this.BtnCommentaires.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCommentaires.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommentaires.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCommentaires.Location = new System.Drawing.Point(28, 405);
            this.BtnCommentaires.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCommentaires.Name = "BtnCommentaires";
            this.BtnCommentaires.Size = new System.Drawing.Size(169, 42);
            this.BtnCommentaires.TabIndex = 12;
            this.BtnCommentaires.TabStop = false;
            this.BtnCommentaires.Text = "Nouvelle annotation";
            this.BtnCommentaires.UseVisualStyleBackColor = true;
            this.BtnCommentaires.Visible = false;
            this.BtnCommentaires.Click += new System.EventHandler(this.BtnCommentaires_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(524, 479);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rectangleShape1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(523, 43);
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LblTitre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.ForeColor = System.Drawing.Color.White;
            this.LblTitre.Location = new System.Drawing.Point(28, 15);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(142, 18);
            this.LblTitre.TabIndex = 15;
            this.LblTitre.Text = "Edition d\'un Post\'it";
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BtnFermer
            // 
            this.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("BtnFermer.Image")));
            this.BtnFermer.Location = new System.Drawing.Point(369, 405);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(129, 42);
            this.BtnFermer.TabIndex = 16;
            this.BtnFermer.TabStop = false;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Visible = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // LblOperateurView
            // 
            this.LblOperateurView.AutoSize = true;
            this.LblOperateurView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperateurView.Location = new System.Drawing.Point(28, 79);
            this.LblOperateurView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOperateurView.Name = "LblOperateurView";
            this.LblOperateurView.Size = new System.Drawing.Size(95, 16);
            this.LblOperateurView.TabIndex = 17;
            this.LblOperateurView.Text = "Collaborateur";
            this.LblOperateurView.Visible = false;
            // 
            // LblCategorieView
            // 
            this.LblCategorieView.AutoSize = true;
            this.LblCategorieView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategorieView.Location = new System.Drawing.Point(289, 79);
            this.LblCategorieView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategorieView.Name = "LblCategorieView";
            this.LblCategorieView.Size = new System.Drawing.Size(70, 16);
            this.LblCategorieView.TabIndex = 18;
            this.LblCategorieView.Text = "Categorie";
            this.LblCategorieView.Visible = false;
            // 
            // LblTiersView
            // 
            this.LblTiersView.AutoSize = true;
            this.LblTiersView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiersView.Location = new System.Drawing.Point(28, 135);
            this.LblTiersView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTiersView.Name = "LblTiersView";
            this.LblTiersView.Size = new System.Drawing.Size(39, 16);
            this.LblTiersView.TabIndex = 19;
            this.LblTiersView.Text = "Tiers";
            this.LblTiersView.Visible = false;
            // 
            // LblEcheanceView
            // 
            this.LblEcheanceView.AutoSize = true;
            this.LblEcheanceView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEcheanceView.Location = new System.Drawing.Point(28, 347);
            this.LblEcheanceView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEcheanceView.Name = "LblEcheanceView";
            this.LblEcheanceView.Size = new System.Drawing.Size(70, 16);
            this.LblEcheanceView.TabIndex = 20;
            this.LblEcheanceView.Text = "Echeance";
            this.LblEcheanceView.Visible = false;
            // 
            // BtnAvanceEcheance
            // 
            this.BtnAvanceEcheance.Image = ((System.Drawing.Image)(resources.GetObject("BtnAvanceEcheance.Image")));
            this.BtnAvanceEcheance.Location = new System.Drawing.Point(138, 343);
            this.BtnAvanceEcheance.Name = "BtnAvanceEcheance";
            this.BtnAvanceEcheance.Size = new System.Drawing.Size(29, 23);
            this.BtnAvanceEcheance.TabIndex = 21;
            this.BtnAvanceEcheance.TabStop = false;
            this.BtnAvanceEcheance.UseVisualStyleBackColor = true;
            this.BtnAvanceEcheance.Visible = false;
            this.BtnAvanceEcheance.Click += new System.EventHandler(this.BtnAvanceEcheance_Click);
            // 
            // BtnReculeEcheance
            // 
            this.BtnReculeEcheance.Image = ((System.Drawing.Image)(resources.GetObject("BtnReculeEcheance.Image")));
            this.BtnReculeEcheance.Location = new System.Drawing.Point(108, 343);
            this.BtnReculeEcheance.Name = "BtnReculeEcheance";
            this.BtnReculeEcheance.Size = new System.Drawing.Size(29, 23);
            this.BtnReculeEcheance.TabIndex = 22;
            this.BtnReculeEcheance.TabStop = false;
            this.BtnReculeEcheance.UseVisualStyleBackColor = true;
            this.BtnReculeEcheance.Visible = false;
            this.BtnReculeEcheance.Click += new System.EventHandler(this.BtnReculeEcheance_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssDateCreation,
            this.TssDateModification,
            this.TssStatut});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TssDateCreation
            // 
            this.TssDateCreation.Name = "TssDateCreation";
            this.TssDateCreation.Size = new System.Drawing.Size(12, 17);
            this.TssDateCreation.Text = "-";
            // 
            // TssDateModification
            // 
            this.TssDateModification.Name = "TssDateModification";
            this.TssDateModification.Size = new System.Drawing.Size(0, 17);
            // 
            // TssStatut
            // 
            this.TssStatut.Name = "TssStatut";
            this.TssStatut.Size = new System.Drawing.Size(497, 17);
            this.TssStatut.Spring = true;
            this.TssStatut.Text = "-";
            this.TssStatut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PbxModifier
            // 
            this.PbxModifier.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PbxModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxModifier.ErrorImage = null;
            this.PbxModifier.Image = ((System.Drawing.Image)(resources.GetObject("PbxModifier.Image")));
            this.PbxModifier.InitialImage = null;
            this.PbxModifier.Location = new System.Drawing.Point(502, 15);
            this.PbxModifier.Name = "PbxModifier";
            this.PbxModifier.Size = new System.Drawing.Size(16, 16);
            this.PbxModifier.TabIndex = 24;
            this.PbxModifier.TabStop = false;
            this.PbxModifier.Visible = false;
            this.PbxModifier.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EvenementEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnFermer;
            this.ClientSize = new System.Drawing.Size(524, 479);
            this.Controls.Add(this.PbxModifier);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnReculeEcheance);
            this.Controls.Add(this.BtnAvanceEcheance);
            this.Controls.Add(this.LblEcheanceView);
            this.Controls.Add(this.LblTiersView);
            this.Controls.Add(this.LblCategorieView);
            this.Controls.Add(this.LblOperateurView);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.LblTitre);
            this.Controls.Add(this.BtnCommentaires);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.LblEcheance);
            this.Controls.Add(this.DtpEcheance);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblTiers);
            this.Controls.Add(this.TxtTiers);
            this.Controls.Add(this.CbxCategorie);
            this.Controls.Add(this.LblCategorie);
            this.Controls.Add(this.CbxOperateur);
            this.Controls.Add(this.LblOperateur);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EvenementEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post\'it";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EvenementEditForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOperateur;
        private System.Windows.Forms.ComboBox CbxOperateur;
        private System.Windows.Forms.ComboBox CbxCategorie;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.TextBox TxtTiers;
        private System.Windows.Forms.Label LblTiers;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.DateTimePicker DtpEcheance;
        private System.Windows.Forms.Label LblEcheance;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Button BtnCommentaires;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label LblOperateurView;
        private System.Windows.Forms.Label LblCategorieView;
        private System.Windows.Forms.Label LblTiersView;
        private System.Windows.Forms.Label LblEcheanceView;
        private System.Windows.Forms.Button BtnAvanceEcheance;
        private System.Windows.Forms.Button BtnReculeEcheance;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TssDateCreation;
        private System.Windows.Forms.ToolStripStatusLabel TssDateModification;
        private System.Windows.Forms.ToolStripStatusLabel TssStatut;
        private System.Windows.Forms.PictureBox PbxModifier;
    }
}