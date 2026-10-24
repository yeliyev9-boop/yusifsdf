using System;
using System.Windows.Forms;

namespace yusifmuasirsdf
{
    public partial class Form1 : Form
    {
        private EmployeeServiceBase service = new EmployeeService();

        public Form1()
        {
            InitializeComponent();
        }

        // 1. İşçi Əlavə et
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                !int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Xahiş olunur bütün xanaları tam doldurun və yaşı rəqəmlə yazın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee emp = new Employee(txtCode.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim(), age);

            if (service.AddEmployee(emp))
            {
                MessageBox.Show("İşçi uğurla əlavə olundu!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
            }
            else
            {
                MessageBox.Show("Bu koda malik işçi artıq sistemdə mövcuddur!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Ödəniş Yaz
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPayEmpCode.Text) ||
                string.IsNullOrWhiteSpace(txtPayTitle.Text) ||
                !double.TryParse(txtPayAmount.Text, out double amount))
            {
                MessageBox.Show("Xahiş olunur ödəniş məlumatlarını düzgün doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (service.AddPayment(txtPayEmpCode.Text.Trim(), txtPayTitle.Text.Trim(), amount))
            {
                MessageBox.Show("Ödəniş uğurla qeydə alındı!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPayEmpCode.Clear();
                txtPayTitle.Clear();
                txtPayAmount.Clear();
            }
            else
            {
                MessageBox.Show("Daxil edilən koda uyğun işçi tapılmadı və ya məbləğ düzgün deyil!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Axtarış
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearchCode.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Axtarış üçün işçi kodunu daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee emp = service.FindEmployee(code);

            if (emp == null)
            {
                MessageBox.Show("Bu koda malik işçi tapılmadı!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEmpInfo.Text = "";
                dgvPayments.DataSource = null;
                return;
            }

            lblEmpInfo.Text = $"Kod: {emp.Code} | Ad: {emp.FirstName} | Soyad: {emp.LastName} | Yaş: {emp.Age}";
            dgvPayments.DataSource = null;
            dgvPayments.DataSource = service.GetEmployeePayments(code);
        }

        // 4. Çıxış
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proqramdan çıxmaq istədiyinizə əminsiniz?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}