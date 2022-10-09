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
    /// Логика взаимодействия для ProfileView.xaml
    /// </summary>
    public partial class ProfileView : Page
    {
        public ProfileView()
        {
            InitializeComponent();
            DataContext = this;
        }

        public ProfileView(LoginModel model) : this()
        {
            Model = model;
        }

        public LoginModel Model { get; }
        private SliderModel _sliderModel;
        public SliderModel SliderModel 
        {
            get => _sliderModel == null ? _sliderModel = new SliderModel() : _sliderModel;

            set => _sliderModel = value;
        }
    }
}
