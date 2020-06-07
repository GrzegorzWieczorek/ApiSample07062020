using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample07062020.DTOs.Guets
{
    public class GuestRequestDTO
    {
        public int IdGosc { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int? DiscountPercent { get; set; }
    }
}
