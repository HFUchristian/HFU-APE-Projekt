using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Binding_Textboxen
{
    internal class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        { 
            Person = new Person() { Name = "Grob", Vorname = "Hans", Alter = 50 };
        }
    }
}
