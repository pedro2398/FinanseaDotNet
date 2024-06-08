using FinanseaAPI.Context;
using FinanseaAPI.Model;

namespace FinanseaAPI.Repository
{
    public class ProjectRepository : Repository<Project>
    {
        public ProjectRepository(FinanseaContext finanseaContext) : base(finanseaContext) { }
    }
}