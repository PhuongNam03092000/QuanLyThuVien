using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Persistence.Repositories
{
    public class AccountRepository : EFRepository<AppUser>, IAccountRepository
    {
        public AccountRepository(QLTVContext context) : base(context)
        {
        }
    }
}