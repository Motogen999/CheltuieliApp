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

namespace CheltuieliApp
{
    public partial class Form3 : Form 
    {

        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string cs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Microsoft Access Baze De Date\\Utilizatori.mdb";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand cmd = new OleDbCommand("Select Nume from Persoane", con);
            try { con.Open(); }
            catch (Exception ex) {  return; }
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
                while (rdr.Read());
            else MessageBox.Show("Nu sunt inregistrari");
            rdr.Close();
            con.Close();

            Login l = new Login();
            l.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void create_user_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
