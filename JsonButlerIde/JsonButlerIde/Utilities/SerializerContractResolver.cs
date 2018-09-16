using System;
using Andeart.CaseConversion;
using Andeart.JsonButlerIde.Options;
using Newtonsoft.Json.Serialization;



namespace Andeart.JsonButlerIde.Utilities
{

    internal class SerializerContractResolver : DefaultContractResolver
    {
        public PropertySerializationType SerializationType { get; set; }

        protected override string ResolvePropertyName (string propertyName)
        {
            return ConvertViaCurrentSerializationType (propertyName);
        }

        private string ConvertViaCurrentSerializationType (string propertyName)
        {
            switch (SerializationType)
            {
                case PropertySerializationType.CamelCase:
                    propertyName = propertyName.ToCamelCase ();
                    break;
                case PropertySerializationType.LowerSnakeCase:
                    propertyName = propertyName.ToLowerSnakeCase ();
                    break;
                case PropertySerializationType.PascalCase:
                    propertyName = propertyName.ToPascalCase ();
                    break;
                case PropertySerializationType.UnderscoreCamelCase:
                    propertyName = propertyName.ToUnderscoreCamelCase ();
                    break;
                default:
                    throw new ArgumentOutOfRangeException ();
            }

            return propertyName;
        }
    }

}