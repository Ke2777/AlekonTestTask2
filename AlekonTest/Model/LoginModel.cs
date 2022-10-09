using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlekonTest.Model
{
    public class LoginModel : BindableBase
    {
        private string login;
        private string pass;

        public string Login { get => login; set => SetProperty(ref login, value); }
        public string Pass { get => pass; set => SetProperty(ref pass, value); }
    }
}
