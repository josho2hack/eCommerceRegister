using RDRegister.API.Models;
using System.Collections.Generic;

namespace RDRegister.API.Data
{
    public interface IRegisterRepo
    {
        bool SaveChang();

        IEnumerable<RDTrained> GetAllTrained();
        RDTrained GetTrainedById(int id);

        void CreateTrained(RDTrained rdt);
        RDTrained PutTrained(RDTrained rdt);
        void DeleteTrained(int id);
    }
}
