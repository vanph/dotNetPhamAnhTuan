using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test enum
            var value = 2;

            AddressRenderingType enumType = ToEnum<AddressRenderingType>(value, AddressRenderingType.None);

            Console.WriteLine(enumType);

            //Test name of
            var path = CheckoutAddressBookViewModel.PostCodeModelBinding;
            Console.WriteLine(path);

            Console.ReadLine();
        }

        private static TEnum ToEnum<TEnum>(int value, TEnum fallback)
        {
            if (Enum.IsDefined(typeof(TEnum), value))
            {
                TEnum enumType =
                    (TEnum)Enum.ToObject(typeof(TEnum), value);
                return enumType;
            }

            return fallback;
        }
    }
}
