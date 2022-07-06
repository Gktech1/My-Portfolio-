using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Profile.Infastructure
{
    public class FolioDbContext : IdentityDbContext
    {
        public FolioDbContext(DbContextOptions<FolioDbContext> options) : base(options)
        {

        }
    }
}
