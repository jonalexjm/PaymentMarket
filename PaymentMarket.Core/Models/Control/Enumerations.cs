using System;
using System.Reflection;

namespace PaymentMarket.Core.Models.Control
{
    public class Enumerations
    {
        public enum ResponseMessage
        {
            [EnumToString("OK")]
            Ok,
            [EnumToString("La estructura Json no es valida para realizar la petición.")]
            BadRequest,
            [EnumToString("No se encontraron Datos.")]
            NotFound,
            [EnumToString("El servicio no se encuentra disponible. Por favor intente mas tarde")]
            ServiceNotAvailable,
        }
        public static string EnumToString(Enum @enum)
        {
            var type = @enum.GetType();
            MemberInfo[] memberInfo = type.GetMember(@enum.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(EnumToStringAttribute), false);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((EnumToStringAttribute)attrs[0]).Value;
                }

            }
            return Enum.GetName(@enum.GetType(), @enum);
        }
       
        
    }
}