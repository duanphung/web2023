using Microsoft.EntityFrameworkCore;

namespace testapicore6.Data
{
    public class UserStoreContext :DbContext
    {
        public UserStoreContext(DbContextOptions<UserStoreContext> options) : base(options) {
            
        
        }
        #region DbSet
        public DbSet<Test> tests { get; set; }
        #endregion
    }
}
