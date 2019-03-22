using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksServise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text == "")
                {
                    throw new EmptyLoginException("Введіть логін!");
                }
                if (txtPassword.Text == "")
                {
                    throw new EmptyPasswordException("Введіть пароль!");
                }

                BooksServise accountClient = new AccountClient();
                User input = accountClient.Login(textBox6.Text, textBox7.Text);

                if (input != null)
                {
                    MessageBox.Show("Вхід успішний!");

                    if (input.PhotoName != null)
                    {
                        Form2 form2 = new Form2(accountClient.GetImage(input.PhotoName));
                        form2.ShowDialog();
                    }
                    else
                    {
                        Form2 form2 = new Form2(null);
                        form2.ShowDialog();
                    }

                }
                if (input == null)
                {
                    MessageBox.Show("Ви НЕ ввійшли в особистий кабінет! \n Перевірте логін і пароль!");
                }

                accountClient.Close();
            }
            catch (EmptyLoginException emptyLoginException)
            {
                MessageBox.Show(emptyLoginException.Message);
            }
            catch (EmptyPasswordException emptyPasswordException)
            {
                MessageBox.Show(emptyPasswordException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
