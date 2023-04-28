
namespace WindowsFormsApp2SI
{
    partial class intervention
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
            this.listViewListI = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadermatos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAffInter = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeb = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCI = new System.Windows.Forms.Button();
            this.comboBoxMatos = new System.Windows.Forms.ComboBox();
            this.textBoxTech = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewListI
            // 
            this.listViewListI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderComment,
            this.columnHeaderTech,
            this.columnHeadermatos});
            this.listViewListI.HideSelection = false;
            this.listViewListI.Location = new System.Drawing.Point(41, 105);
            this.listViewListI.Margin = new System.Windows.Forms.Padding(2);
            this.listViewListI.Name = "listViewListI";
            this.listViewListI.Size = new System.Drawing.Size(674, 118);
            this.listViewListI.TabIndex = 10;
            this.listViewListI.UseCompatibleStateImageBehavior = false;
            this.listViewListI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 80;
            // 
            // columnHeaderComment
            // 
            this.columnHeaderComment.Text = "Commentaire";
            this.columnHeaderComment.Width = 260;
            // 
            // columnHeaderTech
            // 
            this.columnHeaderTech.Text = "Technicien";
            this.columnHeaderTech.Width = 80;
            // 
            // columnHeadermatos
            // 
            this.columnHeadermatos.Text = "Matériel";
            this.columnHeadermatos.Width = 140;
            // 
            // buttonAffInter
            // 
            this.buttonAffInter.Location = new System.Drawing.Point(359, 48);
            this.buttonAffInter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAffInter.Name = "buttonAffInter";
            this.buttonAffInter.Size = new System.Drawing.Size(344, 33);
            this.buttonAffInter.TabIndex = 9;
            this.buttonAffInter.Text = "Afficher les interventions";
            this.buttonAffInter.UseVisualStyleBackColor = true;
            this.buttonAffInter.Click += new System.EventHandler(this.buttonAffInter_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(228, 52);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // dateTimePickerDeb
            // 
            this.dateTimePickerDeb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeb.Location = new System.Drawing.Point(78, 52);
            this.dateTimePickerDeb.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDeb.Name = "dateTimePickerDeb";
            this.dateTimePickerDeb.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerDeb.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Debut";
            // 
            // buttonCI
            // 
            this.buttonCI.Location = new System.Drawing.Point(61, 374);
            this.buttonCI.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCI.Name = "buttonCI";
            this.buttonCI.Size = new System.Drawing.Size(397, 30);
            this.buttonCI.TabIndex = 8;
            this.buttonCI.Text = "Créer";
            this.buttonCI.UseVisualStyleBackColor = true;
            this.buttonCI.Click += new System.EventHandler(this.buttonCI_Click);
            // 
            // comboBoxMatos
            // 
            this.comboBoxMatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatos.FormattingEnabled = true;
            this.comboBoxMatos.Location = new System.Drawing.Point(94, 325);
            this.comboBoxMatos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMatos.Name = "comboBoxMatos";
            this.comboBoxMatos.Size = new System.Drawing.Size(382, 21);
            this.comboBoxMatos.TabIndex = 7;
            // 
            // textBoxTech
            // 
            this.textBoxTech.Location = new System.Drawing.Point(325, 285);
            this.textBoxTech.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTech.Name = "textBoxTech";
            this.textBoxTech.Size = new System.Drawing.Size(151, 20);
            this.textBoxTech.TabIndex = 6;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(496, 285);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(233, 141);
            this.textBoxComment.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Matériel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Technicien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commentaire";
            // 
            // dateTimePickerDI
            // 
            this.dateTimePickerDI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDI.Location = new System.Drawing.Point(79, 285);
            this.dateTimePickerDI.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDI.Name = "dateTimePickerDI";
            this.dateTimePickerDI.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(248, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Liste des interventions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(220, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Création d\'une intervention";
            // 
            // intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 437);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCI);
            this.Controls.Add(this.listViewListI);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.comboBoxMatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDeb);
            this.Controls.Add(this.textBoxTech);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAffInter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDI);
            this.Name = "intervention";
            this.Text = "intervention";
            this.Load += new System.EventHandler(this.intervention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewListI;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderComment;
        private System.Windows.Forms.ColumnHeader columnHeaderTech;
        private System.Windows.Forms.ColumnHeader columnHeadermatos;
        private System.Windows.Forms.Button buttonAffInter;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCI;
        private System.Windows.Forms.ComboBox comboBoxMatos;
        private System.Windows.Forms.TextBox textBoxTech;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}