using RDRegister.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void DeleteTrained(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RDTrained> GetAllTraineds()
        {
             return _context.RDTraineds.ToList();
        }

        public RDTrained GetTrainedById(string id)
        {
            return _context.RDTraineds.FirstOrDefault(t => t.OfficerId == id);
        }

        public RDTrained PutTrained(RDTrained rdt)
        {
            throw new NotImplementedException();
        }

        public bool SaveChang()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
