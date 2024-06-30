using SaveApplicationForm.Model;
using SaveApplicationForm.Repositories;

namespace SaveApplicationForm.Services
{
    public class ApplicationDetailsService: IApplicationDetailsService
    {
        public readonly IApplicationDetailsRepository _applicationDetailsRepository;
        public ApplicationDetailsService(IApplicationDetailsRepository applicationDetailsRepository) 
        {
            _applicationDetailsRepository = applicationDetailsRepository;
        }

        public List<ApplicationDetail> GetApplicationDetailsService()
        {
            var appDetails = _applicationDetailsRepository.GetApplicationDetailsList();
            return appDetails;

        }

    }
}
