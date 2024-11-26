using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OZON_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            textBoxSellerPassword.UseSystemPasswordChar = true;
            textBoxBuyerPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowSellerPanel();
        }

        private void ShowSellerPanel()
        {
            panelSeller.Visible = true;
            panelBuyer.Visible = false;
        }

        private void ShowBuyerPanel()
        {
            panelSeller.Visible = false;
            panelBuyer.Visible = true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonSeller_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonSeller.Checked)
            {
                ShowSellerPanel();
            }
        }

        private void radioButtonBuyer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonBuyer.Checked)
            {
                ShowBuyerPanel();
            }
        }

        private void panelBuyer_Paint(object sender, PaintEventArgs e)
        {
            panelSeller.Visible = false;
            panelBuyer.Visible = true;
        }

        private void panelSeller_Paint(object sender, PaintEventArgs e)
        {
            panelSeller.Visible = true;
            panelBuyer.Visible = false;
        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            string login, password, filePath;

            if (radioButtonSeller.Checked)
            {
                login = textBoxSellerLogin.Text;
                password = textBoxSellerPassword.Text;
                filePath = "Sellers.txt";
            }
            else
            {
                login = textBoxBuyerLogin.Text;
                password = textBoxBuyerPassword.Text;
                filePath = "Buyers.txt";
            }

            // Проверка заполнения полей
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка длины пароля
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на отсутствие пробелов
            if (password.Contains(" "))
            {
                MessageBox.Show("Пароль не должен содержать пробелов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на наличие цифр, букв разного регистра и спецсимволов
            var specialChars = "!»№;@%;?:";
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(c => specialChars.Contains(c)))
            {
                MessageBox.Show("Пароль должен содержать цифры, буквы разного регистра и хотя бы один спецсимвол (!»№;@%;?:).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка существования файла
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
            }

            string[] users;
            try
            {
                users = File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка существования логина
            if (users.Any(user =>
            {
                var parts = user.Split(' ');
                return parts.Length > 0 && parts[0].Trim() == login;
            }))
            {
                MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Сохранение данных
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{login} {password}");
                }
                MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Очистка полей ввода
            if (radioButtonSeller.Checked)
            {
                textBoxSellerLogin.Clear();
                textBoxSellerPassword.Clear();
            }
            else
            {
                textBoxBuyerLogin.Clear();
                textBoxBuyerPassword.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBuyerPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSellerPassword.UseSystemPasswordChar= !checkBox2.Checked;
        }
    }
}
