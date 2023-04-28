namespace WindowsFormsApp2SI
{
    partial class Form2SI
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonmatériels = new System.Windows.Forms.Button();
            this.buttonclien = new System.Windows.Forms.Button();
            this.buttonintervention = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelgene = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.panelMenu.Controls.Add(this.buttonmatériels);
            this.panelMenu.Controls.Add(this.buttonclien);
            this.panelMenu.Controls.Add(this.buttonintervention);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 580);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // buttonmatériels
            // 
            this.buttonmatériels.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonmatériels.FlatAppearance.BorderSize = 0;
            this.buttonmatériels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmatériels.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.buttonmatériels.ForeColor = System.Drawing.Color.White;
            this.buttonmatériels.Location = new System.Drawing.Point(0, 354);
            this.buttonmatériels.Name = "buttonmatériels";
            this.buttonmatériels.Size = new System.Drawing.Size(220, 137);
            this.buttonmatériels.TabIndex = 3;
            this.buttonmatériels.Text = "Matériels";
            this.buttonmatériels.UseVisualStyleBackColor = true;
            this.buttonmatériels.Click += new System.EventHandler(this.buttonmatériels_Click);
            // 
            // buttonclien
            // 
            this.buttonclien.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonclien.FlatAppearance.BorderSize = 0;
            this.buttonclien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclien.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.buttonclien.ForeColor = System.Drawing.Color.White;
            this.buttonclien.Location = new System.Drawing.Point(0, 217);
            this.buttonclien.Name = "buttonclien";
            this.buttonclien.Size = new System.Drawing.Size(220, 137);
            this.buttonclien.TabIndex = 2;
            this.buttonclien.Text = "Client";
            this.buttonclien.UseVisualStyleBackColor = true;
            this.buttonclien.Click += new System.EventHandler(this.buttonclien_Click);
            // 
            // buttonintervention
            // 
            this.buttonintervention.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonintervention.FlatAppearance.BorderSize = 0;
            this.buttonintervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonintervention.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.buttonintervention.ForeColor = System.Drawing.Color.Transparent;
            this.buttonintervention.Location = new System.Drawing.Point(0, 80);
            this.buttonintervention.Name = "buttonintervention";
            this.buttonintervention.Size = new System.Drawing.Size(220, 137);
            this.buttonintervention.TabIndex = 1;
            this.buttonintervention.Text = "Intervention";
            this.buttonintervention.UseVisualStyleBackColor = true;
            this.buttonintervention.Click += new System.EventHandler(this.buttonintervention_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.panellogo.Controls.Add(this.label7);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 80);
            this.panellogo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(58, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vivacom";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(756, 80);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2SI.Properties.Resources.fermet;
            this.pictureBox1.Location = new System.Drawing.Point(717, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelgene
            // 
            this.panelgene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgene.Location = new System.Drawing.Point(220, 80);
            this.panelgene.Name = "panelgene";
            this.panelgene.Size = new System.Drawing.Size(756, 500);
            this.panelgene.TabIndex = 5;
            this.panelgene.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgene_Paint);
            this.panelgene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelgene_MouseDown);
            // 
            // Form2SI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 580);
            this.Controls.Add(this.panelgene);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2SI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vivacom";
            this.Load += new System.EventHandler(this.Form2SI_Load);
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonmatériels;
        private System.Windows.Forms.Button buttonclien;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonintervention;
        private System.Windows.Forms.Panel panelgene;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

