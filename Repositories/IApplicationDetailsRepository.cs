using SaveApplicationForm.Model;

namespace SaveApplicationForm.Repositories
{
    public interface IApplicationDetailsRepository
    {
        List<ApplicationDetail> GetApplicationDetailsList();
    }
}
