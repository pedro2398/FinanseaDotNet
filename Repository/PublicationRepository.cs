using FinanseaAPI.Context;
using FinanseaAPI.Model;

namespace FinanseaAPI.Repository
{
    public class PublicationRepository : Repository<Publication>
    {
        public PublicationRepository(FinanseaContext finanseaContext) : base(finanseaContext) { }
    }
}