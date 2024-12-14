using NorthwindManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindManagementApp
{
    public partial class frm_YonetimPaneli : Form
    {
        public frm_YonetimPaneli()
        {
            InitializeComponent();
        }

        private void frm_YonetimPaneli_Load(object sender, EventArgs e)
        {
            frm_YoneticiGiris frm = new frm_YoneticiGiris();
            frm.ShowDialog();

            TSMI_Kategori.Text = "Kullanıcı = " + LoginUser.user.FullName;
        }

        private void TSMI_Kategori_Click(object sender, EventArgs e)
        {
            
        }
    }
}
