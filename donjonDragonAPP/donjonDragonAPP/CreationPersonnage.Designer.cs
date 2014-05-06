namespace donjonDragonAPP
{
    partial class CreationPersonnage
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
            this.btRetour = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbClasse = new System.Windows.Forms.Label();
            this.lbRace = new System.Windows.Forms.Label();
            this.lbSexe = new System.Windows.Forms.Label();
            this.nudFor = new System.Windows.Forms.NumericUpDown();
            this.lbCarac = new System.Windows.Forms.Label();
            this.lbForce = new System.Windows.Forms.Label();
            this.lbCon = new System.Windows.Forms.Label();
            this.nudCon = new System.Windows.Forms.NumericUpDown();
            this.lbDex = new System.Windows.Forms.Label();
            this.nudDex = new System.Windows.Forms.NumericUpDown();
            this.nudInt = new System.Windows.Forms.NumericUpDown();
            this.lbInt = new System.Windows.Forms.Label();
            this.nudSag = new System.Windows.Forms.NumericUpDown();
            this.nudCha = new System.Windows.Forms.NumericUpDown();
            this.lbSag = new System.Windows.Forms.Label();
            this.lbCha = new System.Windows.Forms.Label();
            this.listbClasse = new System.Windows.Forms.ListBox();
            this.listbRace = new System.Windows.Forms.ListBox();
            this.listbSexe = new System.Windows.Forms.ListBox();
            this.lbPoints = new System.Windows.Forms.Label();
            this.lbNbPts = new System.Windows.Forms.Label();
            this.lbBonusF = new System.Windows.Forms.Label();
            this.lbBonusC = new System.Windows.Forms.Label();
            this.lbBonusD = new System.Windows.Forms.Label();
            this.lbBonusI = new System.Windows.Forms.Label();
            this.lbBonusCha = new System.Windows.Forms.Label();
            this.lbBonusS = new System.Windows.Forms.Label();
            this.lbBonus = new System.Windows.Forms.Label();
            this.lbDefense = new System.Windows.Forms.Label();
            this.lbVolonte = new System.Windows.Forms.Label();
            this.lbReflexe = new System.Windows.Forms.Label();
            this.lbVigueur = new System.Windows.Forms.Label();
            this.lbClasseArmure = new System.Windows.Forms.Label();
            this.lbBonusClasse = new System.Windows.Forms.Label();
            this.lbVol = new System.Windows.Forms.Label();
            this.lbRef = new System.Windows.Forms.Label();
            this.lbVig = new System.Windows.Forms.Label();
            this.lbCa = new System.Windows.Forms.Label();
            this.lbNbCa = new System.Windows.Forms.Label();
            this.lbNbVig = new System.Windows.Forms.Label();
            this.lbNbRef = new System.Windows.Forms.Label();
            this.lbNbVol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).BeginInit();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(13, 275);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 0;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(630, 275);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 1;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(194, 12);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 3;
            this.tbNom.Validated += new System.EventHandler(this.tbNom_Validated);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(58, 15);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(130, 13);
            this.lbNom.TabIndex = 4;
            this.lbNom.Text = "Nom de votre personnage";
            // 
            // lbClasse
            // 
            this.lbClasse.AutoSize = true;
            this.lbClasse.Location = new System.Drawing.Point(12, 83);
            this.lbClasse.Name = "lbClasse";
            this.lbClasse.Size = new System.Drawing.Size(38, 13);
            this.lbClasse.TabIndex = 5;
            this.lbClasse.Text = "Classe";
            // 
            // lbRace
            // 
            this.lbRace.AutoSize = true;
            this.lbRace.Location = new System.Drawing.Point(12, 114);
            this.lbRace.Name = "lbRace";
            this.lbRace.Size = new System.Drawing.Size(33, 13);
            this.lbRace.TabIndex = 6;
            this.lbRace.Text = "Race";
            // 
            // lbSexe
            // 
            this.lbSexe.AutoSize = true;
            this.lbSexe.Location = new System.Drawing.Point(12, 152);
            this.lbSexe.Name = "lbSexe";
            this.lbSexe.Size = new System.Drawing.Size(31, 13);
            this.lbSexe.TabIndex = 9;
            this.lbSexe.Text = "Sexe";
            // 
            // nudFor
            // 
            this.nudFor.Enabled = false;
            this.nudFor.Location = new System.Drawing.Point(434, 85);
            this.nudFor.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudFor.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFor.Name = "nudFor";
            this.nudFor.ReadOnly = true;
            this.nudFor.Size = new System.Drawing.Size(42, 20);
            this.nudFor.TabIndex = 10;
            this.nudFor.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFor.ValueChanged += new System.EventHandler(this.nudFor_ValueChanged);
            // 
            // lbCarac
            // 
            this.lbCarac.AutoSize = true;
            this.lbCarac.Location = new System.Drawing.Point(354, 12);
            this.lbCarac.Name = "lbCarac";
            this.lbCarac.Size = new System.Drawing.Size(85, 13);
            this.lbCarac.TabIndex = 11;
            this.lbCarac.Text = "Caratéristiques : ";
            // 
            // lbForce
            // 
            this.lbForce.AutoSize = true;
            this.lbForce.Location = new System.Drawing.Point(366, 88);
            this.lbForce.Name = "lbForce";
            this.lbForce.Size = new System.Drawing.Size(34, 13);
            this.lbForce.TabIndex = 12;
            this.lbForce.Text = "Force";
            // 
            // lbCon
            // 
            this.lbCon.AutoSize = true;
            this.lbCon.Location = new System.Drawing.Point(366, 110);
            this.lbCon.Name = "lbCon";
            this.lbCon.Size = new System.Drawing.Size(62, 13);
            this.lbCon.TabIndex = 13;
            this.lbCon.Text = "Constitution";
            // 
            // nudCon
            // 
            this.nudCon.Enabled = false;
            this.nudCon.Location = new System.Drawing.Point(434, 108);
            this.nudCon.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudCon.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCon.Name = "nudCon";
            this.nudCon.ReadOnly = true;
            this.nudCon.Size = new System.Drawing.Size(42, 20);
            this.nudCon.TabIndex = 14;
            this.nudCon.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbDex
            // 
            this.lbDex.AutoSize = true;
            this.lbDex.Location = new System.Drawing.Point(366, 132);
            this.lbDex.Name = "lbDex";
            this.lbDex.Size = new System.Drawing.Size(55, 13);
            this.lbDex.TabIndex = 15;
            this.lbDex.Text = "Déxetérité";
            // 
            // nudDex
            // 
            this.nudDex.Enabled = false;
            this.nudDex.Location = new System.Drawing.Point(434, 130);
            this.nudDex.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudDex.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudDex.Name = "nudDex";
            this.nudDex.ReadOnly = true;
            this.nudDex.Size = new System.Drawing.Size(42, 20);
            this.nudDex.TabIndex = 16;
            this.nudDex.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nudInt
            // 
            this.nudInt.Enabled = false;
            this.nudInt.Location = new System.Drawing.Point(434, 153);
            this.nudInt.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudInt.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudInt.Name = "nudInt";
            this.nudInt.ReadOnly = true;
            this.nudInt.Size = new System.Drawing.Size(42, 20);
            this.nudInt.TabIndex = 17;
            this.nudInt.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(366, 155);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(61, 13);
            this.lbInt.TabIndex = 18;
            this.lbInt.Text = "Intelligence";
            // 
            // nudSag
            // 
            this.nudSag.Enabled = false;
            this.nudSag.Location = new System.Drawing.Point(434, 175);
            this.nudSag.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudSag.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSag.Name = "nudSag";
            this.nudSag.ReadOnly = true;
            this.nudSag.Size = new System.Drawing.Size(42, 20);
            this.nudSag.TabIndex = 19;
            this.nudSag.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nudCha
            // 
            this.nudCha.Enabled = false;
            this.nudCha.Location = new System.Drawing.Point(434, 198);
            this.nudCha.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudCha.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCha.Name = "nudCha";
            this.nudCha.ReadOnly = true;
            this.nudCha.Size = new System.Drawing.Size(42, 20);
            this.nudCha.TabIndex = 20;
            this.nudCha.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbSag
            // 
            this.lbSag.AutoSize = true;
            this.lbSag.Location = new System.Drawing.Point(366, 177);
            this.lbSag.Name = "lbSag";
            this.lbSag.Size = new System.Drawing.Size(48, 13);
            this.lbSag.TabIndex = 21;
            this.lbSag.Text = "Sagesse";
            // 
            // lbCha
            // 
            this.lbCha.AutoSize = true;
            this.lbCha.Location = new System.Drawing.Point(366, 200);
            this.lbCha.Name = "lbCha";
            this.lbCha.Size = new System.Drawing.Size(50, 13);
            this.lbCha.TabIndex = 22;
            this.lbCha.Text = "Charisme";
            // 
            // listbClasse
            // 
            this.listbClasse.FormattingEnabled = true;
            this.listbClasse.Items.AddRange(new object[] {
            "Guerrier",
            "Magicien",
            "Voleur"});
            this.listbClasse.Location = new System.Drawing.Point(56, 70);
            this.listbClasse.Name = "listbClasse";
            this.listbClasse.Size = new System.Drawing.Size(120, 30);
            this.listbClasse.TabIndex = 24;
            this.listbClasse.SelectedValueChanged += new System.EventHandler(this.listbClasse_SelectedValueChanged);
            // 
            // listbRace
            // 
            this.listbRace.FormattingEnabled = true;
            this.listbRace.Items.AddRange(new object[] {
            "Humain",
            "Drakéide",
            "Nain"});
            this.listbRace.Location = new System.Drawing.Point(56, 106);
            this.listbRace.Name = "listbRace";
            this.listbRace.Size = new System.Drawing.Size(120, 30);
            this.listbRace.TabIndex = 25;
            this.listbRace.SelectedValueChanged += new System.EventHandler(this.listbRace_SelectedValueChanged);
            // 
            // listbSexe
            // 
            this.listbSexe.FormattingEnabled = true;
            this.listbSexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.listbSexe.Location = new System.Drawing.Point(56, 142);
            this.listbSexe.Name = "listbSexe";
            this.listbSexe.Size = new System.Drawing.Size(120, 30);
            this.listbSexe.TabIndex = 26;
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Location = new System.Drawing.Point(366, 44);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(85, 13);
            this.lbPoints.TabIndex = 27;
            this.lbPoints.Text = "Points restants : ";
            // 
            // lbNbPts
            // 
            this.lbNbPts.AutoSize = true;
            this.lbNbPts.Location = new System.Drawing.Point(451, 44);
            this.lbNbPts.Name = "lbNbPts";
            this.lbNbPts.Size = new System.Drawing.Size(19, 13);
            this.lbNbPts.TabIndex = 28;
            this.lbNbPts.Text = "22";
            // 
            // lbBonusF
            // 
            this.lbBonusF.AutoSize = true;
            this.lbBonusF.Location = new System.Drawing.Point(325, 87);
            this.lbBonusF.Name = "lbBonusF";
            this.lbBonusF.Size = new System.Drawing.Size(35, 13);
            this.lbBonusF.TabIndex = 29;
            this.lbBonusF.Text = "label1";
            this.lbBonusF.Visible = false;
            // 
            // lbBonusC
            // 
            this.lbBonusC.AutoSize = true;
            this.lbBonusC.Location = new System.Drawing.Point(325, 110);
            this.lbBonusC.Name = "lbBonusC";
            this.lbBonusC.Size = new System.Drawing.Size(35, 13);
            this.lbBonusC.TabIndex = 30;
            this.lbBonusC.Text = "label1";
            this.lbBonusC.Visible = false;
            // 
            // lbBonusD
            // 
            this.lbBonusD.AutoSize = true;
            this.lbBonusD.Location = new System.Drawing.Point(325, 132);
            this.lbBonusD.Name = "lbBonusD";
            this.lbBonusD.Size = new System.Drawing.Size(35, 13);
            this.lbBonusD.TabIndex = 31;
            this.lbBonusD.Text = "label1";
            this.lbBonusD.Visible = false;
            // 
            // lbBonusI
            // 
            this.lbBonusI.AutoSize = true;
            this.lbBonusI.Location = new System.Drawing.Point(325, 155);
            this.lbBonusI.Name = "lbBonusI";
            this.lbBonusI.Size = new System.Drawing.Size(35, 13);
            this.lbBonusI.TabIndex = 32;
            this.lbBonusI.Text = "label1";
            this.lbBonusI.Visible = false;
            // 
            // lbBonusCha
            // 
            this.lbBonusCha.AutoSize = true;
            this.lbBonusCha.Location = new System.Drawing.Point(325, 200);
            this.lbBonusCha.Name = "lbBonusCha";
            this.lbBonusCha.Size = new System.Drawing.Size(35, 13);
            this.lbBonusCha.TabIndex = 33;
            this.lbBonusCha.Text = "label1";
            this.lbBonusCha.Visible = false;
            // 
            // lbBonusS
            // 
            this.lbBonusS.AutoSize = true;
            this.lbBonusS.Location = new System.Drawing.Point(325, 177);
            this.lbBonusS.Name = "lbBonusS";
            this.lbBonusS.Size = new System.Drawing.Size(35, 13);
            this.lbBonusS.TabIndex = 34;
            this.lbBonusS.Text = "label1";
            this.lbBonusS.Visible = false;
            // 
            // lbBonus
            // 
            this.lbBonus.AutoSize = true;
            this.lbBonus.Location = new System.Drawing.Point(284, 61);
            this.lbBonus.Name = "lbBonus";
            this.lbBonus.Size = new System.Drawing.Size(82, 13);
            this.lbBonus.TabIndex = 35;
            this.lbBonus.Text = "Bonus de race :";
            this.lbBonus.Visible = false;
            // 
            // lbDefense
            // 
            this.lbDefense.AutoSize = true;
            this.lbDefense.Location = new System.Drawing.Point(609, 65);
            this.lbDefense.Name = "lbDefense";
            this.lbDefense.Size = new System.Drawing.Size(58, 13);
            this.lbDefense.TabIndex = 36;
            this.lbDefense.Text = "Défenses :";
            // 
            // lbVolonte
            // 
            this.lbVolonte.AutoSize = true;
            this.lbVolonte.Location = new System.Drawing.Point(577, 167);
            this.lbVolonte.Name = "lbVolonte";
            this.lbVolonte.Size = new System.Drawing.Size(43, 13);
            this.lbVolonte.TabIndex = 44;
            this.lbVolonte.Text = "Volonté";
            // 
            // lbReflexe
            // 
            this.lbReflexe.AutoSize = true;
            this.lbReflexe.Location = new System.Drawing.Point(577, 144);
            this.lbReflexe.Name = "lbReflexe";
            this.lbReflexe.Size = new System.Drawing.Size(43, 13);
            this.lbReflexe.TabIndex = 41;
            this.lbReflexe.Text = "Réflexe";
            // 
            // lbVigueur
            // 
            this.lbVigueur.AutoSize = true;
            this.lbVigueur.Location = new System.Drawing.Point(577, 122);
            this.lbVigueur.Name = "lbVigueur";
            this.lbVigueur.Size = new System.Drawing.Size(43, 13);
            this.lbVigueur.TabIndex = 39;
            this.lbVigueur.Text = "Vigueur";
            // 
            // lbClasseArmure
            // 
            this.lbClasseArmure.AutoSize = true;
            this.lbClasseArmure.Location = new System.Drawing.Point(577, 100);
            this.lbClasseArmure.Name = "lbClasseArmure";
            this.lbClasseArmure.Size = new System.Drawing.Size(24, 13);
            this.lbClasseArmure.TabIndex = 38;
            this.lbClasseArmure.Text = "CA ";
            // 
            // lbBonusClasse
            // 
            this.lbBonusClasse.AutoSize = true;
            this.lbBonusClasse.Location = new System.Drawing.Point(495, 74);
            this.lbBonusClasse.Name = "lbBonusClasse";
            this.lbBonusClasse.Size = new System.Drawing.Size(91, 13);
            this.lbBonusClasse.TabIndex = 49;
            this.lbBonusClasse.Text = "Bonus de classe :";
            this.lbBonusClasse.Visible = false;
            // 
            // lbVol
            // 
            this.lbVol.AutoSize = true;
            this.lbVol.Location = new System.Drawing.Point(536, 168);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(35, 13);
            this.lbVol.TabIndex = 48;
            this.lbVol.Text = "label1";
            this.lbVol.Visible = false;
            // 
            // lbRef
            // 
            this.lbRef.AutoSize = true;
            this.lbRef.Location = new System.Drawing.Point(536, 145);
            this.lbRef.Name = "lbRef";
            this.lbRef.Size = new System.Drawing.Size(35, 13);
            this.lbRef.TabIndex = 47;
            this.lbRef.Text = "label1";
            this.lbRef.Visible = false;
            // 
            // lbVig
            // 
            this.lbVig.AutoSize = true;
            this.lbVig.Location = new System.Drawing.Point(536, 123);
            this.lbVig.Name = "lbVig";
            this.lbVig.Size = new System.Drawing.Size(35, 13);
            this.lbVig.TabIndex = 46;
            this.lbVig.Text = "label1";
            this.lbVig.Visible = false;
            // 
            // lbCa
            // 
            this.lbCa.AutoSize = true;
            this.lbCa.Location = new System.Drawing.Point(536, 100);
            this.lbCa.Name = "lbCa";
            this.lbCa.Size = new System.Drawing.Size(35, 13);
            this.lbCa.TabIndex = 45;
            this.lbCa.Text = "label1";
            this.lbCa.Visible = false;
            // 
            // lbNbCa
            // 
            this.lbNbCa.AutoSize = true;
            this.lbNbCa.Location = new System.Drawing.Point(630, 99);
            this.lbNbCa.Name = "lbNbCa";
            this.lbNbCa.Size = new System.Drawing.Size(13, 13);
            this.lbNbCa.TabIndex = 50;
            this.lbNbCa.Text = "0";
            // 
            // lbNbVig
            // 
            this.lbNbVig.AutoSize = true;
            this.lbNbVig.Location = new System.Drawing.Point(630, 122);
            this.lbNbVig.Name = "lbNbVig";
            this.lbNbVig.Size = new System.Drawing.Size(13, 13);
            this.lbNbVig.TabIndex = 51;
            this.lbNbVig.Text = "0";
            // 
            // lbNbRef
            // 
            this.lbNbRef.AutoSize = true;
            this.lbNbRef.Location = new System.Drawing.Point(630, 145);
            this.lbNbRef.Name = "lbNbRef";
            this.lbNbRef.Size = new System.Drawing.Size(13, 13);
            this.lbNbRef.TabIndex = 52;
            this.lbNbRef.Text = "0";
            // 
            // lbNbVol
            // 
            this.lbNbVol.AutoSize = true;
            this.lbNbVol.Location = new System.Drawing.Point(630, 167);
            this.lbNbVol.Name = "lbNbVol";
            this.lbNbVol.Size = new System.Drawing.Size(13, 13);
            this.lbNbVol.TabIndex = 53;
            this.lbNbVol.Text = "0";
            // 
            // CreationPersonnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 310);
            this.ControlBox = false;
            this.Controls.Add(this.lbNbVol);
            this.Controls.Add(this.lbNbRef);
            this.Controls.Add(this.lbNbVig);
            this.Controls.Add(this.lbNbCa);
            this.Controls.Add(this.lbBonusClasse);
            this.Controls.Add(this.lbVol);
            this.Controls.Add(this.lbRef);
            this.Controls.Add(this.lbVig);
            this.Controls.Add(this.lbCa);
            this.Controls.Add(this.lbVolonte);
            this.Controls.Add(this.lbReflexe);
            this.Controls.Add(this.lbVigueur);
            this.Controls.Add(this.lbClasseArmure);
            this.Controls.Add(this.lbDefense);
            this.Controls.Add(this.lbBonus);
            this.Controls.Add(this.lbBonusS);
            this.Controls.Add(this.lbBonusCha);
            this.Controls.Add(this.lbBonusI);
            this.Controls.Add(this.lbBonusD);
            this.Controls.Add(this.lbBonusC);
            this.Controls.Add(this.lbBonusF);
            this.Controls.Add(this.lbNbPts);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.listbSexe);
            this.Controls.Add(this.listbRace);
            this.Controls.Add(this.listbClasse);
            this.Controls.Add(this.lbCha);
            this.Controls.Add(this.lbSag);
            this.Controls.Add(this.nudCha);
            this.Controls.Add(this.nudSag);
            this.Controls.Add(this.lbInt);
            this.Controls.Add(this.nudInt);
            this.Controls.Add(this.nudDex);
            this.Controls.Add(this.lbDex);
            this.Controls.Add(this.nudCon);
            this.Controls.Add(this.lbCon);
            this.Controls.Add(this.lbForce);
            this.Controls.Add(this.lbCarac);
            this.Controls.Add(this.nudFor);
            this.Controls.Add(this.lbSexe);
            this.Controls.Add(this.lbRace);
            this.Controls.Add(this.lbClasse);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btRetour);
            this.Name = "CreationPersonnage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creation Personnage";
            ((System.ComponentModel.ISupportInitialize)(this.nudFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbClasse;
        private System.Windows.Forms.Label lbRace;
        private System.Windows.Forms.Label lbSexe;
        private System.Windows.Forms.NumericUpDown nudFor;
        private System.Windows.Forms.Label lbCarac;
        private System.Windows.Forms.Label lbForce;
        private System.Windows.Forms.Label lbCon;
        private System.Windows.Forms.NumericUpDown nudCon;
        private System.Windows.Forms.Label lbDex;
        private System.Windows.Forms.NumericUpDown nudDex;
        private System.Windows.Forms.NumericUpDown nudInt;
        private System.Windows.Forms.Label lbInt;
        private System.Windows.Forms.NumericUpDown nudSag;
        private System.Windows.Forms.NumericUpDown nudCha;
        private System.Windows.Forms.Label lbSag;
        private System.Windows.Forms.Label lbCha;
        private System.Windows.Forms.ListBox listbClasse;
        private System.Windows.Forms.ListBox listbRace;
        private System.Windows.Forms.ListBox listbSexe;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label lbNbPts;
        private System.Windows.Forms.Label lbBonusF;
        private System.Windows.Forms.Label lbBonusC;
        private System.Windows.Forms.Label lbBonusD;
        private System.Windows.Forms.Label lbBonusI;
        private System.Windows.Forms.Label lbBonusCha;
        private System.Windows.Forms.Label lbBonusS;
        private System.Windows.Forms.Label lbBonus;
        private System.Windows.Forms.Label lbDefense;
        private System.Windows.Forms.Label lbVolonte;
        private System.Windows.Forms.Label lbReflexe;
        private System.Windows.Forms.Label lbVigueur;
        private System.Windows.Forms.Label lbClasseArmure;
        private System.Windows.Forms.Label lbBonusClasse;
        private System.Windows.Forms.Label lbVol;
        private System.Windows.Forms.Label lbRef;
        private System.Windows.Forms.Label lbVig;
        private System.Windows.Forms.Label lbCa;
        private System.Windows.Forms.Label lbNbCa;
        private System.Windows.Forms.Label lbNbVig;
        private System.Windows.Forms.Label lbNbRef;
        private System.Windows.Forms.Label lbNbVol;
    }
}