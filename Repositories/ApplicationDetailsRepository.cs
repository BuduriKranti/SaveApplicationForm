using SaveApplicationForm.Model;

namespace SaveApplicationForm.Repositories
{
    public class ApplicationDetailsRepository : IApplicationDetailsRepository
    {
        private readonly masterContext _dbContext;

        public ApplicationDetailsRepository(masterContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ApplicationDetail> GetApplicationDetailsList()
        {
            
            return _dbContext.ApplicationDetails.ToList();
        }
    }
}
