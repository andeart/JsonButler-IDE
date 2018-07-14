using System;
using System.Reflection;



namespace Andeart.JsonButler.Utilities
{

    internal static class ReflectionUtilities
    {
        public static object CreateObjectWithBestConstructor<T> (Type type, Assembly rootCallingAssembly) where T : Attribute
        {
            // Handle external objects first.
            if (type.Assembly != rootCallingAssembly)
            {
                return CreateUnknownObject (type);
            }

            // Handle custom Value-types.
            // If a JsonConstructor constructor exists, call that. Else, just create a new instance.
            ConstructorInfo constructor = GetBestConstructor<T> (type.GetConstructors ());
            if (type.IsValueType && constructor == null)
            {
                return Activator.CreateInstance (type);
            }

            return CreateObjectWithConstructor<T> (type, rootCallingAssembly, constructor);
        }

        private static ConstructorInfo GetBestConstructor<T> (ConstructorInfo[] constructors) where T : Attribute
        {
            if (constructors == null || constructors.Length == 0)
            {
                return null;
            }

            for (int i = 0; i < constructors.Length; i++)
            {
                ConstructorInfo constructor = constructors[i];
                if (constructor.GetCustomAttribute<T> (true) != null)
                {
                    return constructor;
                }
            }

            return constructors[0];
        }

        private static object CreateUnknownObject (Type type)
        {
            if (type.IsValueType || type.IsPrimitive)
            {
                return Activator.CreateInstance (type);
            }

            return type.IsArray ? new object[0] : null;
        }

        private static object CreateObjectWithConstructor<T> (Type type, Assembly rootCallingAssembly, ConstructorInfo constructor) where T : Attribute
        {
            ParameterInfo[] parameterInfos = constructor.GetParameters ();
            if (parameterInfos.Length == 0)
            {
                return Activator.CreateInstance (type);
            }

            object[] parameterObjects = new object[parameterInfos.Length];
            for (int i = 0; i < parameterInfos.Length; i++)
            {
                Type parameterType = parameterInfos[i].ParameterType;
                parameterObjects[i] = CreateObjectWithBestConstructor<T> (parameterType, rootCallingAssembly);
            }

            return Activator.CreateInstance (type, parameterObjects);
        }
    }

}