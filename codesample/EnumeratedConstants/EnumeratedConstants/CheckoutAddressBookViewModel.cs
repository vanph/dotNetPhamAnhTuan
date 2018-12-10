using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstants
{
   public class CheckoutAddressBookViewModel
    {
        public AddressBookInputModel Input { get; set; }

        public static string PostCodeModelBinding => $"{nameof(Input)}.{nameof(AddressBookInputModel.Address)}.{nameof(AddressInputModel.PostalCode)}";
    }

    public class AddressBookInputModel
    {
        public AddressInputModel Address { get; set; }

    }
}
