using FinanseaAPI.Context;
using FinanseaAPI.Model;

namespace FinanseaAPI.Repository
{
    public class FinancierRepository : Repository<Publication>
    {
        public FinancierRepository(FinanseaContext finanseaContext) : base(finanseaContext) { }
    }
}