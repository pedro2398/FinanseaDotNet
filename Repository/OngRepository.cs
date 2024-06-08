using FinanseaAPI.Context;
using FinanseaAPI.Model;

namespace FinanseaAPI.Repository
{
    public class OngRepository : Repository<Ong>
    {
        public OngRepository(FinanseaContext finanseaContext) : base(finanseaContext) { }
    }
}