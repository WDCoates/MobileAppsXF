﻿using System;
using System.Reflection;

namespace Ch11_BindableInfrastructure
{
    class TypeInfoPlus
    {
        
        private readonly bool _isBaseGenType;
        private readonly Type _baseGenTypeDef;

        public Type Type { private set; get; }
        public Type BaseType { private set; get; }
        public bool IsXamarinForm { private set; get;}

        public TypeInfoPlus(Type type, bool isXamarinForm)
        {
            Type = type;
            IsXamarinForm = isXamarinForm;
            TypeInfo typeInfo = type.GetTypeInfo();
            BaseType = typeInfo.BaseType;

            if (BaseType != null)
            {
                TypeInfo baseTypeInfo = BaseType.GetTypeInfo();
                _isBaseGenType = baseTypeInfo.IsGenericType;

                if (_isBaseGenType)
                {
                    _baseGenTypeDef = baseTypeInfo.GetGenericTypeDefinition();
                }
            }
        }

        public bool IsDerivedDirectlyFrom(Type pType)
        {
            if (BaseType != null && _isBaseGenType)
            {
                if (_baseGenTypeDef == pType)
                {
                    return true;
                }
            }
            else if (BaseType == pType)
            {
                return true;
            }

            return false;
        }
    }
}
