using Microsoft.EntityFrameworkCore;
using RDRegister.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDRegister.API.Data
{
    public class SqlRegisterRepo : IRegisterRepo
    {
        private readonly RDRegisterContext _context;

        public SqlRegisterRepo(RDRegisterContext context)
        {
            _context = context;
        }

        public void CreateTrained(RDTrained rdt)
        {
            if (rdt == null)
            {
                throw new ArgumentNullException(nameof(rdt));
            }
            _context.Add(rdt);
        }

        public void DeleteTrained(RDTrained rdt)
        {
            _context.RDTraineds.Remove(rdt);
        }

        public async Task<IEnumerable<RDTrained>> GetAllTrainedsAsync()
        {
             return await _context.RDTraineds.ToListAsync();
        }

        public async Task<RDTrained> GetTrainedByIdAsync(string id)
        {
            return await _context.RDTraineds.FirstOrDefaultAsync(t => t.OfficerId == id);
        }

        public void UpdateTrained(RDTrained rdt, RDTrained rdtToUpdate)
        {
            _context.RDTraineds.Remove(rdt);
            _context.RDTraineds.Add(rdtToUpdate);
        }

        public async Task<bool> SaveChangsAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public Task<IEnumerable<RDTrained>> GetAllECommerceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RDTrained> GetECommerceByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void CreateECommerce(RDTrained rdt)
        {
            throw new NotImplementedException();
        }

        public void UpdateECommerce(RDTrained rdt, RDTrained rdtToUpdate)
        {
            throw new NotImplementedException();
        }

        public void DeleteECommerce(RDTrained rdt)
        {
            throw new NotImplementedException();
        }
    }
}
