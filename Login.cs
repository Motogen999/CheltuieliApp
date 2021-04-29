using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace CheltuieliApp
{
    public partial class Login : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return;
            }
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Microsoft Access Baze De Date\\Utilizatori.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select ID_Utilizator,parola_utilizator from Persoane " +
            "where nume_utilizator='" + txtUtilizator.Text + "'";



            /*Zona de testare - Obtine Nume de la utilizator - santier in lucru*/
            /*
            String u = "SELECT nume FROM Persoane " +
               "WHERE nume_utilizator = '" + txtUtilizator.Text + "'";
            MessageBox.Show(u);
            /*END zona de testare - santier in lucru*/


            con.Open();

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola gresita");
                    txtParola.Focus();
                    txtParola.Text = "";
                    con.Close();
                    return;
                }
                con.Close();
                

                Form1 f = new Form1();
                f.ShowDialog();
                
                return;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return;
            }
        }
    }
}
        
    

