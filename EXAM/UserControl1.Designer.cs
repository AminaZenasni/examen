namespace EXAM
{
    partial class UserControl1
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
            this.QCM = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.b = new System.Windows.Forms.MaskedTextBox();
            this.c = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.MaskedTextBox();
            this.quesqcm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reponse = new System.Windows.Forms.TextBox();
            this.quesdirect = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Ann = new System.Windows.Forms.Button();
            this.supp = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.enre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.quesvraifaux = new System.Windows.Forms.TextBox();
            this.faux = new System.Windows.Forms.CheckBox();
            this.vrai = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // QCM
            // 
            this.QCM.AutoSize = true;
            this.QCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QCM.Location = new System.Drawing.Point(11, 43);
            this.QCM.Name = "QCM";
            this.QCM.Size = new System.Drawing.Size(69, 22);
            this.QCM.TabIndex = 2;
            this.QCM.Text = "QCM";
            this.QCM.UseVisualStyleBackColor = true;
            this.QCM.CheckedChanged += new System.EventHandler(this.QCM_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "question direct";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(489, 41);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(90, 22);
            this.b.TabIndex = 13;
            this.b.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.b_MaskInputRejected);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(588, 41);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(93, 22);
            this.c.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(489, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(585, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(362, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Questtion";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(363, 41);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(111, 22);
            this.a.TabIndex = 4;
            this.a.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // quesqcm
            // 
            this.quesqcm.Location = new System.Drawing.Point(200, 41);
            this.quesqcm.Name = "quesqcm";
            this.quesqcm.Size = new System.Drawing.Size(140, 22);
            this.quesqcm.TabIndex = 3;
            this.quesqcm.TextChanged += new System.EventHandler(this.quesqcm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(383, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "reponse";
            // 
            // reponse
            // 
            this.reponse.Location = new System.Drawing.Point(492, 147);
            this.reponse.Name = "reponse";
            this.reponse.Size = new System.Drawing.Size(129, 22);
            this.reponse.TabIndex = 6;
            // 
            // quesdirect
            // 
            this.quesdirect.Location = new System.Drawing.Point(263, 149);
            this.quesdirect.Name = "quesdirect";
            this.quesdirect.Size = new System.Drawing.Size(140, 22);
            this.quesdirect.TabIndex = 7;
            this.quesdirect.TextChanged += new System.EventHandler(this.quesdirect_TextChanged);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(66, 290);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(91, 66);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Ann
            // 
            this.Ann.Location = new System.Drawing.Point(163, 289);
            this.Ann.Name = "Ann";
            this.Ann.Size = new System.Drawing.Size(94, 67);
            this.Ann.TabIndex = 10;
            this.Ann.Text = "Annuler";
            this.Ann.UseVisualStyleBackColor = true;
            this.Ann.Click += new System.EventHandler(this.Ann_Click);
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(263, 290);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(94, 66);
            this.supp.TabIndex = 11;
            this.supp.Text = "Supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(363, 291);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(91, 65);
            this.mod.TabIndex = 12;
            this.mod.Text = "modifier";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // enre
            // 
            this.enre.Location = new System.Drawing.Point(460, 290);
            this.enre.Name = "enre";
            this.enre.Size = new System.Drawing.Size(91, 66);
            this.enre.TabIndex = 13;
            this.enre.Text = "Enregistrer";
            this.enre.UseVisualStyleBackColor = true;
            this.enre.Click += new System.EventHandler(this.enre_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 218);
            this.dataGridView1.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(11, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 22);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Vrai /Faux";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // quesvraifaux
            // 
            this.quesvraifaux.Location = new System.Drawing.Point(237, 93);
            this.quesvraifaux.Name = "quesvraifaux";
            this.quesvraifaux.Size = new System.Drawing.Size(140, 22);
            this.quesvraifaux.TabIndex = 9;
            this.quesvraifaux.TextChanged += new System.EventHandler(this.quesvraifaux_TextChanged);
            // 
            // faux
            // 
            this.faux.AutoSize = true;
            this.faux.Location = new System.Drawing.Point(521, 95);
            this.faux.Name = "faux";
            this.faux.Size = new System.Drawing.Size(58, 20);
            this.faux.TabIndex = 10;
            this.faux.Text = "Faux";
            this.faux.UseVisualStyleBackColor = true;
            // 
            // vrai
            // 
            this.vrai.AutoSize = true;
            this.vrai.Location = new System.Drawing.Point(464, 95);
            this.vrai.Name = "vrai";
            this.vrai.Size = new System.Drawing.Size(51, 20);
            this.vrai.TabIndex = 11;
            this.vrai.Text = "vrai";
            this.vrai.UseVisualStyleBackColor = true;
            this.vrai.CheckedChanged += new System.EventHandler(this.vrai_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "reponse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Questtion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Question";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reponse);
            this.Controls.Add(this.vrai);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quesqcm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quesdirect);
            this.Controls.Add(this.faux);
            this.Controls.Add(this.QCM);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.enre);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.quesvraifaux);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Ann);
            this.Controls.Add(this.Ajouter);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(728, 619);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox QCM;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox b;
        private System.Windows.Forms.MaskedTextBox c;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox a;
        private System.Windows.Forms.TextBox quesqcm;
        private System.Windows.Forms.TextBox reponse;
        private System.Windows.Forms.TextBox quesdirect;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Ann;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox quesvraifaux;
        private System.Windows.Forms.CheckBox faux;
        private System.Windows.Forms.CheckBox vrai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}
