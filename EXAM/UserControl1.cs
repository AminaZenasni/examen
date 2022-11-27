using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAM
{
    public partial class UserControl1 : UserControl
    {
        static string chaine = @"Data Source=DESKTOP-JOF72QM;Initial Catalog=GL_EXAM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // QCM 
            QCM.Enabled = true;
            quesqcm.Enabled = true;
            b.Enabled = true;
            a.Enabled = true;
            c.Enabled = true;
            //VRAIFAUX
            quesvraifaux.Enabled = true;
            vrai.Enabled = true;
            faux.Enabled = true;
            checkBox2.Enabled = true;
            //question direct
            checkBox1.Enabled = true;
            quesdirect.Enabled = true;
            reponse.Enabled = true;
            // button
            Ann.Enabled= false;
            supp.Enabled = false;
            enre.Enabled = false;
            mod.Enabled = false;

        }

        private void QCM_CheckedChanged(object sender, EventArgs e)
        {
            // QCM 
            QCM.Enabled = true;
            quesqcm.Enabled = true;
            b.Enabled = true;
            a.Enabled = true;
            c.Enabled = true;
            //VRAIFAUX
            quesvraifaux.Enabled = false;
            vrai.Enabled = false;
            faux.Enabled = false;
            checkBox2.Enabled = false;
            //question direct
            checkBox1.Enabled = false;
            quesdirect.Enabled = false;
            reponse.Enabled = false;
        }

        private void quesqcm_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // QCM 
            QCM.Enabled = false;
            quesqcm.Enabled = false;
            b.Enabled = false;
            a.Enabled = false;
            c.Enabled = false;
            //VRAIFAUX
            quesvraifaux.Enabled = false;
            vrai.Enabled = false;
            faux.Enabled = false;
            checkBox2.Enabled = false;
            //question direct
            checkBox1.Enabled = true;
            quesdirect.Enabled = true;
            reponse.Enabled = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // QCM 
            QCM.Enabled = false;
            quesqcm.Enabled = false;
            b.Enabled = false;
            a.Enabled = false;
            c.Enabled = false;
            //VRAIFAUX
            quesvraifaux.Enabled = true;
            vrai.Enabled = true;
            faux.Enabled = true;
            checkBox2.Enabled = true;
            //question direct
            checkBox1.Enabled = false;
            quesdirect.Enabled = false;
            reponse.Enabled = false;
        }

        private void Ann_Click(object sender, EventArgs e)
        {
            // QCM 
            QCM.Enabled = true;
            quesqcm.Enabled = true;
            b.Enabled = true;
            a.Enabled = true;
            c.Enabled = true;
            //VRAIFAUX
            quesvraifaux.Enabled = true;
            vrai.Enabled = true;
            faux.Enabled = true;
            checkBox2.Enabled = true;
            //question direct
            checkBox1.Enabled = true;
            quesdirect.Enabled = true;
            reponse.Enabled = true;
            // QCM 
           
            quesqcm.Clear();
            b.Clear(); a.Clear(); c.Clear();
            
            //VRAIFAUX
            quesvraifaux.Clear();
            vrai.Checked = false;
            faux.Checked= false;
            
            //question direct
            
            quesdirect.Clear();
            reponse.Clear();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {

          
            cmd.Connection = cnx;
            cnx.Open();
            if (QCM.Checked) {

                cmd.CommandText = "insert into QCM values('" + quesqcm.Text + "','" + a.Text + "','" + b.Text + "','" + c.Text + "') ";
                cmd.ExecuteNonQuery();
                quesqcm.Clear();
                b.Clear(); a.Clear(); c.Clear();
            }
            if (checkBox2.Checked)
            {

                cmd.CommandText = "insert into Vrai/Faux values('" + quesvraifaux.Text + "','" + vrai.Text + "','" + faux.Text + "') ";
                cmd.ExecuteNonQuery();
            }
            if (checkBox1.Checked)
            {

                cmd.CommandText = "insert into question_direct values('" + quesdirect.Text + "','" + reponse.Text + "' )";
                cmd.ExecuteNonQuery();
                //question direct

                quesdirect.Clear();
                reponse.Clear();
            }

            cnx.Close();

            // button
            Ann.Enabled = true;
            supp.Enabled = true;
            enre.Enabled = true;
            mod.Enabled = true;
        }

        private void supp_Click(object sender, EventArgs e)
        {
            string box_msg = "confirmer la suppression";

            string box_title = "confiramtion";



            if (MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

                cnx.Open();
                if (QCM.Checked)
                {
                    cnx.Open();
                    cmd.Connection = cnx;
                    cmd.CommandText = "delete from fortest where nom='" + quesqcm.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
                if (checkBox2.Checked)
                {
                    cnx.Open();
                    cmd.Connection = cnx;
                    cmd.CommandText = "delete from fortest where nom='" + quesvraifaux.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
                if (checkBox1.Checked)
                {
                    cnx.Open();
                    cmd.Connection = cnx;
                    cmd.CommandText = "delete from fortest where nom='" + quesdirect.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }

            }
            Ann.Enabled = false;
            enre.Enabled = false;
            mod.Enabled = false;
            Ajouter.Enabled = true;
            supp.Enabled = false;

        }

        private void mod_Click(object sender, EventArgs e)
        {
            Ann.Enabled = false;
            enre.Enabled = true;
            mod.Enabled = false;
            Ajouter.Enabled = true;
            supp.Enabled = false;

        }

        private void enre_Click(object sender, EventArgs e)
        {
            if (QCM.Checked)
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select * from QCM";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnx.Close();
            }
            if (checkBox2.Checked)
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select * from Vrai/Faux";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnx.Close();
            }
            if (checkBox1.Checked)
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select * from question_direct";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnx.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void quesvraifaux_TextChanged(object sender, EventArgs e)
        {

        }

        private void vrai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void quesdirect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
