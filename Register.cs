using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CheltuieliApp
{
    public partial class Register : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            String ccv = "123";

            if(textBoxNume.Text == "" && textBoxPrenume.Text == "" && textBoxUsername.Text == "" && textBoxParola.Text == "" && textBoxCodCheieValidare.Text == ""){
                MessageBox.Show("Pentru a putea inregistra un utilizator trebuie sa introduceti datele acestuia . ");
                return;
            }

            if (textBoxNume.Text == "")
            {
                MessageBox.Show("Completati numele !");
                textBoxNume.Focus();
                return;
            }

            if(textBoxPrenume.Text == "")
            {
                MessageBox.Show("Completati prenumele !");
                textBoxPrenume.Focus();
                return;
            }

            if(textBoxUsername.Text == "")
            {
                MessageBox.Show("Completati numele de utilizator !");
                textBoxUsername.Focus();
                return;
            }

            if (textBoxParola.Text == "")
            {
                MessageBox.Show("Completati Parola !");
                textBoxParola.Focus();
                return;
            }

            if (textBoxCodCheieValidare.Text == "")
            {
                MessageBox.Show("Completati Codul Pentru Validare !");
                textBoxCodCheieValidare.Focus();
                return;
            }

            if(textBoxCodCheieValidare.Text != ccv)
            {
                MessageBox.Show("Cod Validare Gresit", "Eroare !", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBoxCodCheieValidare.Focus();
                return;
            }


            string sqlQueryForRegister = "INSERT INTO Persoane(Nume , Prenume , nume_utilizator , parola_utilizator) values (?,?,?,?)";
            using (OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\Microsoft Access Baze De Date\\Utilizatori.mdb"))
            using (OleDbCommand cmd = new OleDbCommand(sqlQueryForRegister, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Nume", this.textBoxNume.Text);
                cmd.Parameters.AddWithValue("@Prenume", this.textBoxPrenume.Text);
                cmd.Parameters.AddWithValue("@nume_utilizator", this.textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@parola_utilizator", this.textBoxParola.Text);
                try { 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Utilizator inregistrat - Bun venit ,"+this.textBoxPrenume.Text+" !", "Inregistrat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Eroare ! ", "Eroare !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
