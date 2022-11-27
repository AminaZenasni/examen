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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace EXAM
{
    public partial class UserControl2 : UserControl
    {
        static string chaine = @"Data Source=DESKTOP-JOF72QM;Initial Catalog=GL_EXAM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public UserControl2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void confirmer_Click(object sender, EventArgs e)
        {
           
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into EXAM values('" + numexam.Text + "','" + nom.Text + "','" + durée.Text + "','" + nbrques.Text + "','" + this.dateTimePicker1.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
            numexam.Clear();
            nom.Clear();
            durée.Clear();
            nbrques.Clear();





        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void numexam_TextChanged(object sender, EventArgs e)
        {

        }

        private void durée_TextChanged(object sender, EventArgs e)
        {

        }

        private void nbrques_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void afficher_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from EXAM";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                numexam.Text = row.Cells["num"].Value.ToString();
                nom.Text = row.Cells["nom"].Value.ToString();
                durée.Text = row.Cells["durée"].Value.ToString();
                nbrques.Text = row.Cells["nbQues"].Value.ToString();
                dateTimePicker1.Text = row.Cells["ladate"].Value.ToString();



            }

        }
    }
}
