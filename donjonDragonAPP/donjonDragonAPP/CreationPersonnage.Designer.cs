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
            this.btValider.Location = new System.Drawing.Point(401, 275);
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
            // 
            // lbCarac
            // 
            this.lbCarac.AutoSize = true;
            this.lbCarac.Location = new System.Drawing.Point(334, 33);
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
            "Mage",
            "Voleur"});
            this.listbClasse.Location = new System.Drawing.Point(56, 70);
            this.listbClasse.Name = "listbClasse";
            this.listbClasse.Size = new System.Drawing.Size(120, 30);
            this.listbClasse.TabIndex = 24;
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
            this.lbPoints.Location = new System.Drawing.Point(319, 58);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(85, 13);
            this.lbPoints.TabIndex = 27;
            this.lbPoints.Text = "Points restants : ";
            // 
            // lbNbPts
            // 
            this.lbNbPts.AutoSize = true;
            this.lbNbPts.Location = new System.Drawing.Point(404, 58);
            this.lbNbPts.Name = "lbNbPts";
            this.lbNbPts.Size = new System.Drawing.Size(19, 13);
            this.lbNbPts.TabIndex = 28;
            this.lbNbPts.Text = "22";
            // 
            // CreationPersonnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 310);
            this.ControlBox = false;
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
    }
}