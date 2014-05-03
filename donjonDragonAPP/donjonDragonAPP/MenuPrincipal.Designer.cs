namespace donjonDragonAPP
{
    partial class MenuPrincipal
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
            this.btContinuer = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btCharger = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btContinuer
            // 
            this.btContinuer.Location = new System.Drawing.Point(91, 92);
            this.btContinuer.Name = "btContinuer";
            this.btContinuer.Size = new System.Drawing.Size(75, 23);
            this.btContinuer.TabIndex = 0;
            this.btContinuer.Text = "Continuer";
            this.btContinuer.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(77, 45);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(104, 23);
            this.btNew.TabIndex = 1;
            this.btNew.Text = "Nouvelle partie";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btCharger
            // 
            this.btCharger.Location = new System.Drawing.Point(91, 130);
            this.btCharger.Name = "btCharger";
            this.btCharger.Size = new System.Drawing.Size(75, 23);
            this.btCharger.TabIndex = 2;
            this.btCharger.Text = "Charger";
            this.btCharger.UseVisualStyleBackColor = true;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(91, 227);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 3;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btCharger);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btContinuer);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btContinuer;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btCharger;
        private System.Windows.Forms.Button btQuitter;
    }
}