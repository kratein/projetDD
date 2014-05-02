namespace donjonDragonAPP
{
    partial class Launcher
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btQuitter = new System.Windows.Forms.Button();
            this.btJouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(95, 227);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btJouer
            // 
            this.btJouer.Location = new System.Drawing.Point(95, 90);
            this.btJouer.Name = "btJouer";
            this.btJouer.Size = new System.Drawing.Size(75, 23);
            this.btJouer.TabIndex = 1;
            this.btJouer.Text = "Jouer";
            this.btJouer.UseVisualStyleBackColor = true;
            this.btJouer.Click += new System.EventHandler(this.btJouer_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btJouer);
            this.Controls.Add(this.btQuitter);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btJouer;
    }
}

