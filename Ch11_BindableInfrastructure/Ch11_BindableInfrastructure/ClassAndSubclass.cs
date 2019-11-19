using System;
using System.Collections.Generic;
using System.Text;

namespace Ch11_BindableInfrastructure
{
    class ClassAndSubclass
    {
        public Type Type { private set; get;}
        public bool IsXamarinForm { get; private set; }
        public List<ClassAndSubclass> Subclass { private set; get;}

        public ClassAndSubclass(Type par, bool isXamarinForm)
        {
            Type = par;
            IsXamarinForm = isXamarinForm;
            Subclass = new List<ClassAndSubclass>();
        }
    }
}
