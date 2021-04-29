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
using System.Configuration;
using System.Drawing.Text;
using CheltuieliApp.DataSet2TableAdapters;
using CheltuieliApp.DataSet1TableAdapters;

namespace CheltuieliApp
{
    public partial class Form1 : Form
    {
        OleDbConnection con1;
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int aidi = 0;
        DateTime current_time = DateTime.Now;

       

        public Form1()
        {
            InitializeComponent();
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Microsoft Access Baze De Date\\Utilizatori.mdb";
            con1 = new OleDbConnection(str);
            string strr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Microsoft Access Baze De Date\\Cheltuieli.mdb";
            con = new OleDbConnection(strr);
        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;

            btnActualizare.Enabled = v;
            BtnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;

        }

        void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.cheltuieliTableAdapter.Fill(this.dataSet1.Cheltuieli);
            config(true);
            refresh();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie pentru gestionarea cheltuielilor . \n" +
                "Pasul 1 : Dupa logare , apasati `Actualizare` pentru a putea avea acces la baza de date \n" +
                "Pasul 2 : Dupa modificare (stergere , actualizare , adaugare) apasati `Salvare` pentru ca informatia sa fie inregistrata in baza de date ", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.cheltuieliTableAdapter.Fill(this.dataSet1.Cheltuieli);
        }

        private void refresh()
        {
            cheltuieliTableAdapter.Fill(dataSet1.Cheltuieli);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //buton actualizare
            /*
            AddCheltuieli a = new AddCheltuieli();
            a.ShowDialog();
            */
            config(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            current_time = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cheltuieliBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
           
        }

        

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;

        }

        private void BtnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                //CheltuieliTableAdapter.Update(dataSet1.Cheltuieli);
                cheltuieliTableAdapter.Update(dataSet1.Cheltuieli);
                config(true);
                refresh();
            
            }
            catch(Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("valori dublate") > 0)
                    MessageBox.Show("Data a mai fost introdusa !");

                
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Formar eronat !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
