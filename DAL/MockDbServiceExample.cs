using ApiSample07062020.DTOs.Guets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample07062020.DAL
{
    public class MockDbServiceExample : IServiceExample
    {
        private readonly List<Gosc> Guests;

        public MockDbServiceExample()
        {
            Guests = new List<Gosc>
            {
                new Gosc()
                {
                    IdGosc = 1,
                    Imie = "Marcin",
                    Nazwisko = "Niewiński",
                    ProcentRabatu = 30
                },
                new Gosc()
                {
                    IdGosc = 2,
                    Imie = "Jan",
                    Nazwisko = "Kowalski"
                }
            };
        }
        public ICollection<GestResponseDTO> GetGuestsCollection(string lastName)
        {
            var listReturn = Guests.Select(x => x.LastName == lastName).toList();
            else return listReturn;
        }
            public string Test()
            {
                throw new NotImplementedException();
            }
        
        private class Gosc
        {
            public int IdGosc { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int ProcentRabatu { get; set; }
        }
    }
}
