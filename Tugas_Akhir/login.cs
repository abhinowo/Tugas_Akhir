using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir
{
    public partial class login : Form
    {
        public static string id1,id2;
        public login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "abhin" && pw.Text == "123" || id.Text == "aryo" && pw.Text == "1" || id.Text == "admin" && pw.Text == "admin")
            {
                MessageBox.Show("Berhasil Masuk.");
                Form1 main = new Form1();
                id1 = id.Text;
                setid(id1);
                getid();
                main.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Gagal Masuk.");
                id.Text = "";
                pw.Text = "";
            }
        }
        public void setid(string id2)
        {
            login.id2 = id1;
        }
        public string getid()
        { 
            return id2;
        }

        private void pw_TextChanged(object sender, EventArgs e)
        {
            pw.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {
            id1 = id.Text;
        }
    }
}
