using BookServise.ServiceReference2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfServiceBooks.DAL;

namespace BookServise
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bntLogin_Click(object sender, EventArgs e)
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

                AccountClient accountClient = new AccountClient();
                User input = accountClient.Login(txtLogin.Text, txtPassword.Text);

                if (input != null)
                {
                    MessageBox.Show("Вхід успішний!");

                    //if (input.PhotoName != null)
                    //{
                    //    Form2 form2 = new Form2(accountClient.GetImage(input.PhotoName));
                    //    form2.ShowDialog();
                    //}
                    //else
                    //{
                    //    Form2 form2 = new Form2(null);
                    //    form2.ShowDialog();
                    //}

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

    [Serializable]
    internal class EmptyPasswordException : Exception
    {
        public EmptyPasswordException()
        {
        }

        public EmptyPasswordException(string message) : base(message)
        {
        }

        public EmptyPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class EmptyLoginException : Exception
    {
        public EmptyLoginException()
        {
        }

        public EmptyLoginException(string message) : base(message)
        {
        }

        public EmptyLoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyLoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
