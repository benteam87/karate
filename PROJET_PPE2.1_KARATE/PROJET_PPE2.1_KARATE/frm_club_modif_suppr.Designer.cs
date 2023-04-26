
namespace PROJET_PPE2._1_KARATE
{
    partial class frm_club_modif_suppr
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
            this.Bnt_Modifier = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_RUE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_POST_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_VILLE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.TextBox();
            this.CodePostal = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bnt_Modifier
            // 
            this.Bnt_Modifier.Location = new System.Drawing.Point(168, 425);
            this.Bnt_Modifier.Name = "Bnt_Modifier";
            this.Bnt_Modifier.Size = new System.Drawing.Size(230, 46);
            this.Bnt_Modifier.TabIndex = 0;
            this.Bnt_Modifier.Text = "Modifier";
            this.Bnt_Modifier.UseVisualStyleBackColor = true;
            this.Bnt_Modifier.Click += new System.EventHandler(this.Bnt_Modifier_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(601, 425);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(230, 46);
            this.Btn_Supprimer.TabIndex = 1;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_CLUB,
            this.NOM_CLUB,
            this.ADR_RUE_CLUB,
            this.CODE_POST_CLUB,
            this.ADR_VILLE_CLUB});
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(527, 372);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 6;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 125;
            // 
            // NOM_CLUB
            // 
            this.NOM_CLUB.HeaderText = "NOM_CLUB";
            this.NOM_CLUB.MinimumWidth = 6;
            this.NOM_CLUB.Name = "NOM_CLUB";
            this.NOM_CLUB.Width = 125;
            // 
            // ADR_RUE_CLUB
            // 
            this.ADR_RUE_CLUB.HeaderText = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.MinimumWidth = 6;
            this.ADR_RUE_CLUB.Name = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.Width = 125;
            // 
            // CODE_POST_CLUB
            // 
            this.CODE_POST_CLUB.HeaderText = "CODE_POST_CLUB";
            this.CODE_POST_CLUB.MinimumWidth = 6;
            this.CODE_POST_CLUB.Name = "CODE_POST_CLUB";
            this.CODE_POST_CLUB.Width = 125;
            // 
            // ADR_VILLE_CLUB
            // 
            this.ADR_VILLE_CLUB.HeaderText = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.MinimumWidth = 6;
            this.ADR_VILLE_CLUB.Name = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.Width = 125;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(698, 96);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(263, 22);
            this.Nom.TabIndex = 3;
            // 
            // Ville
            // 
            this.Ville.Location = new System.Drawing.Point(698, 326);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(263, 22);
            this.Ville.TabIndex = 4;
            // 
            // CodePostal
            // 
            this.CodePostal.Location = new System.Drawing.Point(698, 253);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(263, 22);
            this.CodePostal.TabIndex = 5;
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(698, 177);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(263, 22);
            this.Adresse.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ville";
            // 
            // frm_club_modif_suppr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1184, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.Bnt_Modifier);
            this.Name = "frm_club_modif_suppr";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_club_modif_suppr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bnt_Modifier;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_POST_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_CLUB;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.TextBox CodePostal;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}