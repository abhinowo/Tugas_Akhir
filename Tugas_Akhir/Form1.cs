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

namespace Tugas_Akhir
{
    public partial class Form1 : Form
    {
        string koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\users\\taspen\\documents\\visual studio 2015\\Projects\\Tugas_Akhir\\Tugas_Akhir\\minat.mdb";
        public Form1()
        {
            InitializeComponent();
        }
        void load()
        {
            // TODO: This line of code loads data into the 'minatDataSet.minat' table. You can move, or remove it, as needed.
            this.minatTableAdapter.Fill(this.minatDataSet1.minat);
            string sql = "SELECT * FROM minat";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "minat");
            con.Close();
            dataGridView1.DataSource = ds.Tables["minat"].DefaultView;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minatDataSet1.minat' table. You can move, or remove it, as needed.
            this.minatTableAdapter.Fill(this.minatDataSet1.minat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into minat (Nim,Nama,TLahir,JK,AD) VALUES('{0}','{1}','{2}','{3}','{4}')", textNim.Text, textNama.Text, textTLahir.Text, textJK.Text, textAD.Text);
                OleDbConnection conn = new OleDbConnection(koneksi);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                load();
                MessageBox.Show("Data Sudah Disimpan");

                textNim.Clear();
                textNama.Clear();
                textTLahir.Clear();
                textJK.Clear();
                textAD.Clear();
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete*from minat where Nim='" + textNim.Text + "'");
                OleDbConnection conn = new OleDbConnection(koneksi);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                load();
                MessageBox.Show("Data Telah Dihapus");

                textNim.Clear();
                textNama.Clear();
                textTLahir.Clear();
                textJK.Clear();
                textAD.Clear();
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("update minat set Nama='" + textNama.Text + textTLahir.Text + textJK.Text + textAD.Text + "' where Nim='" + textNim.Text + "'");
                OleDbConnection conn = new OleDbConnection(koneksi);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                load();
                MessageBox.Show("Perubahan Data Sudah Disimpan");

                textNim.Clear();
                textNama.Clear();
                textTLahir.Clear();
                textJK.Clear();
                textAD.Clear();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbDataReader rdr = null;
            try
            {
                string sql = string.Format("select*from minat where Nim='" + textNim.Text + "'");
                OleDbConnection conn = new OleDbConnection(koneksi);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    textNama.Text = rdr["Nama"].ToString();

                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void textNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTLahir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
