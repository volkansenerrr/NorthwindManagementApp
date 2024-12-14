using NorthwindManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindManagementApp
{
    public partial class frm_YoneticiGiris : Form
    {
        bool isLogin = false;
        public frm_YoneticiGiris()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_KullaniciAdi.Text) && !string.IsNullOrEmpty(tb_Sifre.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=true"))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT  EmployeeID,FirstName,LastName FROM Employees WHERE UserName = @un AND Password = @pss";
                    cmd.Parameters.AddWithValue("@un", tb_KullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@pss", tb_Sifre.Text);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    User u = null;
                    while (reader.Read())
                    {
                        u = new User();
                        u.ID = reader.GetInt32(0);
                        u.Name = reader.GetString(1);
                        u.Surname = reader.GetString(2);
                        u.FullName = u.Name + " " + u.Surname;
                    }
                    if (u != null)
                    {
                        LoginUser.user = u;
                        //isLogin = true;
                        frm_YonetimPaneli yonetimPaneli = new frm_YonetimPaneli();
                        yonetimPaneli.Show();
                        //frm_YoneticiGiris yoneticiGiris = new frm_YoneticiGiris();
                        //yoneticiGiris.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin == false)
            {
                Application.Exit();
            }
        }
    }
}
