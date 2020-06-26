using RDRegister.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RDRegister.API.Data
{
    public interface IRegisterRepo
    {
        Task<bool> SaveChangsAsync();

        Task<IEnumerable<RDTrained>> GetAllTrainedsAsync();
        Task<RDTrained> GetTrainedByIdAsync(string id);
        void CreateTrained(RDTrained rdt);
        void UpdateTrained(RDTrained rdt,RDTrained rdtToUpdate);
        void DeleteTrained(RDTrained rdt);

        Task<IEnumerable<RDTrained>> GetAllECommerceAsync();
        Task<RDTrained> GetECommerceByIdAsync(string id);
        void CreateECommerce(RDTrained rdt);
        void UpdateECommerce(RDTrained rdt, RDTrained rdtToUpdate);
        void DeleteECommerce(RDTrained rdt);

    }
}
