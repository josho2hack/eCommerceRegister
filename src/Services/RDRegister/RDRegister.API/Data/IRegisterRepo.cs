using RDRegister.API.Models;
using System.Collections.Generic;

namespace RDRegister.API.Data
{
    public interface IRegisterRepo
    {
        bool SaveChang();

        IEnumerable<RDTrained> GetAllTraineds();
        RDTrained GetTrainedById(string id);
        void CreateTrained(RDTrained rdt);
        void UpdateTrained(RDTrained rdt,RDTrained rdtToUpdate);
        void DeleteTrained(RDTrained rdt);
    }
}
