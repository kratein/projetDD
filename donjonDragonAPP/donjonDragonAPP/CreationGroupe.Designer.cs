namespace donjonDragonAPP
{
    partial class CreationGroupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationGroupe));
            this.btValider = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.pbPerso1 = new System.Windows.Forms.PictureBox();
            this.pbPerso2 = new System.Windows.Forms.PictureBox();
            this.pbPerso3 = new System.Windows.Forms.PictureBox();
            this.pbPerso4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso4)).BeginInit();
            this.SuspendLayout();
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Location = new System.Drawing.Point(375, 270);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(122, 23);
            this.btValider.TabIndex = 0;
            this.btValider.Text = "Valider le groupe";
            this.btValider.UseVisualStyleBackColor = true;
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(12, 270);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(137, 23);
            this.btRetour.TabIndex = 1;
            this.btRetour.Text = "Retour au menu principal";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // pbPerso1
            // 
            this.pbPerso1.Image = ((System.Drawing.Image)(resources.GetObject("pbPerso1.Image")));
            this.pbPerso1.Location = new System.Drawing.Point(32, 44);
            this.pbPerso1.Name = "pbPerso1";
            this.pbPerso1.Size = new System.Drawing.Size(100, 160);
            this.pbPerso1.TabIndex = 2;
            this.pbPerso1.TabStop = false;
            this.pbPerso1.Click += new System.EventHandler(this.pbPerso1_Click);
            // 
            // pbPerso2
            // 
            this.pbPerso2.Image = ((System.Drawing.Image)(resources.GetObject("pbPerso2.Image")));
            this.pbPerso2.Location = new System.Drawing.Point(138, 44);
            this.pbPerso2.Name = "pbPerso2";
            this.pbPerso2.Size = new System.Drawing.Size(100, 160);
            this.pbPerso2.TabIndex = 3;
            this.pbPerso2.TabStop = false;
            this.pbPerso2.Click += new System.EventHandler(this.pbPerso2_Click);
            // 
            // pbPerso3
            // 
            this.pbPerso3.Image = ((System.Drawing.Image)(resources.GetObject("pbPerso3.Image")));
            this.pbPerso3.Location = new System.Drawing.Point(244, 44);
            this.pbPerso3.Name = "pbPerso3";
            this.pbPerso3.Size = new System.Drawing.Size(100, 160);
            this.pbPerso3.TabIndex = 4;
            this.pbPerso3.TabStop = false;
            this.pbPerso3.Click += new System.EventHandler(this.pbPerso3_Click);
            // 
            // pbPerso4
            // 
            this.pbPerso4.Image = ((System.Drawing.Image)(resources.GetObject("pbPerso4.Image")));
            this.pbPerso4.Location = new System.Drawing.Point(350, 44);
            this.pbPerso4.Name = "pbPerso4";
            this.pbPerso4.Size = new System.Drawing.Size(100, 160);
            this.pbPerso4.TabIndex = 5;
            this.pbPerso4.TabStop = false;
            this.pbPerso4.Click += new System.EventHandler(this.pbPerso4_Click);
            // 
            // CreationGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 309);
            this.ControlBox = false;
            this.Controls.Add(this.pbPerso4);
            this.Controls.Add(this.pbPerso3);
            this.Controls.Add(this.pbPerso2);
            this.Controls.Add(this.pbPerso1);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.btValider);
            this.Name = "CreationGroupe";
            this.Text = "CreationGroupe";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.PictureBox pbPerso1;
        private System.Windows.Forms.PictureBox pbPerso2;
        private System.Windows.Forms.PictureBox pbPerso3;
        private System.Windows.Forms.PictureBox pbPerso4;
    }
}