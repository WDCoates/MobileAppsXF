using System;
using System.Collections.Generic;

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
