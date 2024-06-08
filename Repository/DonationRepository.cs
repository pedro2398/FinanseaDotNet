using FinanseaAPI.Context;
using FinanseaAPI.Model;

namespace FinanseaAPI.Repository
{
    public class DonationRepository : Repository<Donation>
    {
        public DonationRepository(FinanseaContext finanseaContext) : base(finanseaContext) { }
    }
}