using Microsoft.EntityFrameworkCore;

namespace agentapi.Models
{
    public class AgentContext : DbContext
    {
        public AgentContext(DbContextOptions<AgentContext> options)
            : base(options)
        {
        }

        public DbSet<Agent> TodoItems { get; set; }
    }
}