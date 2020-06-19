using Microsoft.EntityFrameworkCore;
using RDRegister.API.Models;

namespace RDRegister.API.Data
{
    public class RDRegisterContext : DbContext
    {
        public RDRegisterContext(DbContextOptions<RDRegisterContext> opt) : base(opt)
        {

        }

        public DbSet<RDTrained> RDRegisters { get; set; }
    }
}
