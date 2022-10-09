using AlekonTest.Model;
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

namespace AlekonTest.View
{
    /// <summary>
    /// Логика взаимодействия для AuthView.xaml
    /// </summary>
    public partial class AuthView : Page
    {
        public AuthView()
        {
            InitializeComponent();
            DataContext = this;
        }

        private LoginModel _model;

        public LoginModel Model 
        {
            get 
            {
                if (_model == null)
                {
                    _model = new LoginModel();
                }
                return _model;
            }
            set 
            {
                _model = value;
            }
        }

        private void OnLoginButtonClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Model.Login) || string.IsNullOrEmpty(Model.Pass))
            {
                MessageBox.Show("Заполните пустые поля");
            }
            else
            {
                Helper.NavFrame.Navigate(new ProfileView(Model));
            }
        }
    }
}
