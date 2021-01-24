using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CoorporateCustomer: Customer //inheritance
        // tüzel müşteri şirketler
    {   //özellik tutan bir sınıftır
        
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
