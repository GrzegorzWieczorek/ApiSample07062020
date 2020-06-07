using ApiSample07062020.Controllers;
using ApiSample07062020.DTOs.Guets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample07062020.DAL
{
    public interface IServiceExample
    {
        string Test();
        ICollection<GestResponseDTO>
        //    GetGuestsCollection(string lastName);
        //string Test();

    }

}
