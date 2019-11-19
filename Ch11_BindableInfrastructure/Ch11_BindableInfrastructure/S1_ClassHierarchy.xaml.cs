using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch11_BindableInfrastructure
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class S1_ClassHierarchy : ContentPage
    {
        public S1_ClassHierarchy()
        {
            InitializeComponent();

            List<TypeInfoPlus> clsList = new List<TypeInfoPlus>();

            // Get types in Xamarin.Forms.Core assembly
            GetPublicTypes(typeof(View).GetTypeInfo().Assembly, clsList);
            // Get types in Xamarin.Forms.Xaml assembly
            GetPublicTypes(typeof(Extensions).GetTypeInfo().Assembly, clsList);

            //Ensure all classes have a base type....
            int index = 0;

            do
            {
                var cType = clsList[index];

                if (cType.Type != typeof(Object))
                {
                    bool hasBaseType = false;

                    foreach (var pType in clsList)
                    {
                        if (cType.IsDerivedDirectlyFrom(pType.Type))
                        {
                            hasBaseType = true;
                        }
                    }

                    //If no base type add
                    if (!hasBaseType && cType.BaseType != typeof(Object))
                    {
                        clsList.Add(new TypeInfoPlus(cType.BaseType, false));
                    }
                }

            } while (index < clsList.Count);

            // Sort list!
            clsList.Sort((t1, t2) => string.CompareOrdinal(t1.Type.Name, t2.Type.Name));

            // Start the display with System.Object...
            var rClass = new ClassAndSubclass(typeof(Object), false);

            // Recursive method to build the hierarchy tree
            AddChildrenToParent(rClass, clsList);

            // Recursive method to add items to StackLayout.
            AddItemsTosL2(rClass, 0);

        }

        private void GetPublicTypes(Assembly assembly, List<TypeInfoPlus> clsList)
        {
            foreach (var type in assembly.ExportedTypes)
            {
                var tInfo = type.GetTypeInfo();

                if (tInfo.IsPublic && !tInfo.IsInterface)
                {
                    clsList.Add(new TypeInfoPlus(type, true));
                }
            }
        }

        private void AddChildrenToParent(ClassAndSubclass pClass, List<TypeInfoPlus> clsList)
        {
            foreach (var tIp in clsList)
            {
                if (tIp.IsDerivedDirectlyFrom(pClass.Type))
                {
                    var subClass = new ClassAndSubclass(tIp.Type, tIp.IsXamarinForm);
                    pClass.Subclass.Add(subClass);
                    AddChildrenToParent(subClass, clsList);
                }
            }
        }

        private void AddItemsTosL2(ClassAndSubclass rClass, int i)
        {
            throw new NotImplementedException();
        }


    }
}