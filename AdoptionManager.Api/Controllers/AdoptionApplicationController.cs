using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace AdoptionManager.Api.Controllers
{
    /// <summary>
    /// Controller for managing adoption applications
    /// </summary>
    [Route("api/organizations/{organizationId}/[controller]")]
    [ApiController]
    public class AdoptionApplicationController : ControllerBase
    {
        /// <summary>
        /// Get all adoption applications for organization
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetAdoptionApplications(int organizationId)
        {
            return Ok();
        }

        /// <summary>
        /// Create adoption application
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddAdoptionApplication(int organizationId, object application)
        {
            return Ok();
        }
    }
}
