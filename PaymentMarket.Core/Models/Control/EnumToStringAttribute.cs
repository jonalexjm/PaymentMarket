using System;

namespace PaymentMarket.Core.Models.Control
{
    public class EnumToStringAttribute : Attribute
    {
        // Asignar valor de cadena a variable Enum
        public EnumToStringAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}