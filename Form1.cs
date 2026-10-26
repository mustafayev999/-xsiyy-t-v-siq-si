using System;
using System.Drawing;
using System.Windows.Forms;

namespace IDCardApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Şəkil seçin";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxID.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Bütün mətn qutularını təmizlə
            txtSerialNumber.Clear();
            txtFIN.Clear();
            txtSurname.Clear();
            txtName.Clear();
            txtPatronymic.Clear();
            txtGender.Clear();
            txtBirthDate.Clear();
            txtBirthPlace.Clear();
            txtMaritalStatus.Clear();
            txtIssueDate.Clear();
            txtExpiryDate.Clear();
            txtIssuer.Clear();

            // Şəkli sil
            pictureBoxID.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Məlumatların daxil edildiyini yoxlayaq (nümunə üçün yalnız Ad və Soyad)
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Zəhmət olmasa ən azı ad və soyad daxil edin.", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Burada məlumatları bazaya və ya fayla yazmaq olar
            MessageBox.Show("Məlumatlar uğurla yadda saxlanıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
