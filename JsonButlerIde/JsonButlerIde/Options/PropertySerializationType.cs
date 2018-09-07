using System.Collections.Generic;
using Andeart.JsonButlerIde.Utilities;



namespace Andeart.JsonButlerIde.Options
{

    internal enum PropertySerializationType
    {
        CamelCase,
        LowerSnakeCase,
        PascalCase,
        UnderscoreCamelCase
    }


    internal class PropertySerializationTypeConverter
    {
        private static readonly TwoWayDictionary<PropertySerializationType, string> _serializationTypesStringMap;

        static PropertySerializationTypeConverter ()
        {
            _serializationTypesStringMap = new TwoWayDictionary<PropertySerializationType, string> ();
            _serializationTypesStringMap.Add (PropertySerializationType.CamelCase, "camelCase");
            _serializationTypesStringMap.Add (PropertySerializationType.LowerSnakeCase, "lower_snake_case");
            _serializationTypesStringMap.Add (PropertySerializationType.PascalCase, "PascalCase");
            _serializationTypesStringMap.Add (PropertySerializationType.UnderscoreCamelCase, "_underscoreCamelCase");
        }

        public static IEnumerable<string> GetAllSerializationTypeStrings ()
        {
            List<string> mappedStrings = new List<string> ();
            foreach (KeyValuePair<PropertySerializationType, string> mappedStringInfo in _serializationTypesStringMap)
            {
                mappedStrings.Add (mappedStringInfo.Value);
            }

            return mappedStrings;
        }

        public static object[] GetAllSerializationTypeStringsAsObjects ()
        {
            object[] objectArray = new object[_serializationTypesStringMap.Count];
            for (int i = 0; i < objectArray.Length; i++)
            {
                objectArray[i] = _serializationTypesStringMap.GetValue ((PropertySerializationType) i);
            }

            return objectArray;
        }

        public static string GetString (PropertySerializationType serializationType)
        {
            return _serializationTypesStringMap.GetValue (serializationType);
        }

        public static PropertySerializationType GetSerializationType (string stringValue)
        {
            return _serializationTypesStringMap.GetKey (stringValue);
        }
    }

}