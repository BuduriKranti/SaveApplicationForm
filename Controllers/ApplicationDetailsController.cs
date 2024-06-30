using Microsoft.AspNetCore.Mvc;
using SaveApplicationForm.Model;
using SaveApplicationForm.Services;

namespace SaveApplicationForm.Controllers
{
    [Route("api/[Controller]")]
    public class ApplicationDetailsController: ControllerBase
    {
        public readonly IApplicationDetailsService _applicationDetailsService;
        
        public ApplicationDetailsController(IApplicationDetailsService applicationDetailsService)
        {
            _applicationDetailsService = applicationDetailsService;
        }
        [HttpGet]
        [Route("GetDetails")]
        public ActionResult<List<ApplicationDetail>> GetApplicationDetails()
        {
            var appDetails = _applicationDetailsService.GetApplicationDetailsService();
            return Ok(appDetails);
        }
    }
}
