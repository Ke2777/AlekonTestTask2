using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlekonTest.Model
{
    public class SliderModel : BindableBase
    {
        private int _value;
        public int Value { get => _value; set => SetProperty(ref _value, value); }
    }
}
