namespace EXAM
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numexam = new System.Windows.Forms.TextBox();
            this.nbrques = new System.Windows.Forms.TextBox();
            this.durée = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmer = new System.Windows.Forms.Button();
            this.afficher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXAM";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(384, 87);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(192, 22);
            this.nom.TabIndex = 1;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numexam
            // 
            this.numexam.Location = new System.Drawing.Point(78, 133);
            this.numexam.Name = "numexam";
            this.numexam.Size = new System.Drawing.Size(200, 22);
            this.numexam.TabIndex = 3;
            this.numexam.TextChanged += new System.EventHandler(this.numexam_TextChanged);
            // 
            // nbrques
            // 
            this.nbrques.Location = new System.Drawing.Point(126, 180);
            this.nbrques.Name = "nbrques";
            this.nbrques.Size = new System.Drawing.Size(152, 22);
            this.nbrques.TabIndex = 4;
            this.nbrques.TextChanged += new System.EventHandler(this.nbrques_TextChanged);
            // 
            // durée
            // 
            this.durée.Location = new System.Drawing.Point(418, 136);
            this.durée.Name = "durée";
            this.durée.Size = new System.Drawing.Size(184, 22);
            this.durée.TabIndex = 5;
            this.durée.TextChanged += new System.EventHandler(this.durée_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "nombre questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "numExam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "durée";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "la date";
            // 
            // confirmer
            // 
            this.confirmer.Location = new System.Drawing.Point(199, 227);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(97, 37);
            this.confirmer.TabIndex = 12;
            this.confirmer.Text = "Confirmer";
            this.confirmer.UseVisualStyleBackColor = true;
            this.confirmer.Click += new System.EventHandler(this.confirmer_Click);
            // 
            // afficher
            // 
            this.afficher.Location = new System.Drawing.Point(302, 227);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(97, 37);
            this.afficher.TabIndex = 13;
            this.afficher.Text = "afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.confirmer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.durée);
            this.Controls.Add(this.nbrques);
            this.Controls.Add(this.numexam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(616, 445);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox numexam;
        private System.Windows.Forms.TextBox nbrques;
        private System.Windows.Forms.TextBox durée;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button confirmer;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
