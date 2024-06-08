using FinanseaAPI.Context;
using FinanseaAPI.Model;

namespace FinanseaAPI.Repository
{
    public class BankAccountRepository : Repository<BankAccount>
    {
        public BankAccountRepository(FinanseaContext finanseaContext) : base(finanseaContext) { }
    }
}