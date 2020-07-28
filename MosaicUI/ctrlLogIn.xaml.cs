using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MosaicUI
{
    /// <summary>
    /// Interaction logic for ctrlLogIn.xaml
    /// </summary>
    public partial class ctrlLogIn : UserControl
    {
        public string PlaceholderText { get; set; }
        public ContentControl m_ContentBody { get; set; }

        public ctrlLogIn(ContentControl _contentBody)
        {
            try
            {
                InitializeComponent();

                m_ContentBody = _contentBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogIn_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string _userName = txtUserName.c2tTBoxtext.Text.ToString();
                string _password = txtPassword.c2tPassword.ToString();

                //m_ContentBody.Content = new ctrlInputForm();

                if (_userName == "admin" && _password == "1020304050")
                {
                    //MessageBox.Show("Log In");
                    m_ContentBody.Content = new ctrlInputForm();
                }
                else
                {
                    //MessageBox.Show("UserName & Password Incorrect!!!");
                    m_ContentBody.Content = new ctrlInputForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
