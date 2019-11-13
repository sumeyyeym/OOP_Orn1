using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Temizle(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.Ad = txtAd.Text;
            employee.Soyad = txtSoyad.Text;
            employee.Telefon = txtTel.Text;
            employee.Mail = txtMail.Text;

            //lbItems.Items.Add(employee.Ad);            
            //lbItems.Items.Add(employee.Soyad);            
            //lbItems.Items.Add(employee.Telefon);            
            //lbItems.Items.Add(employee.Mail);

            lbItems.Items.Add(employee); //bu şekilde yazarsak employee içine giren verilerin hepsi classın adıyla gelir
            Temizle(groupBox2);
        }

        Employees emp; //birkaç private alanda kullandığımız için globale aldık
        int index = 0;
        private void TsmDuzenle_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen eleman seçiniz!");
                return;
            }

            emp = (Employees)lbItems.SelectedItem;
            txtAd.Text = emp.Ad;
            txtSoyad.Text = emp.Soyad;
            txtTel.Text = emp.Telefon;
            txtMail.Text = emp.Mail;

            index = lbItems.SelectedIndex;
        }

        private void TsmSil_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen eleman seçiniz!");
                return;
            }
            lbItems.Items.Remove(lbItems.SelectedItem);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            emp.Ad = txtAd.Text;
            emp.Soyad = txtSoyad.Text;
            emp.Telefon = txtTel.Text;
            emp.Mail = txtMail.Text;

            //güncellediğimiz kaydın listboxta aynı yerde durmasını nasıl sağlarız
            lbItems.Items.RemoveAt(index);
            lbItems.Items.Insert(index, emp);
            Temizle(groupBox2);
            emp = null;
        }
    }
}
