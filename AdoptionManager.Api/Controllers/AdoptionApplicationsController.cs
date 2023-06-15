using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace AdoptionManager.Api.Controllers
{
    /// <summary>
    /// Controller for managing adoption applications
    /// </summary>
    [Route("api/organizations/{organizationId}/[controller]")]
    [ApiController]
    public class AdoptionApplicationsController : ControllerBase
    {
        /// <summary>
        /// Get all adoption applications for organization
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetAdoptionApplications(int organizationId)
        {
            return Ok();
        }

        /// <summary>
        /// Get single adoption application for organization
        /// </summary>
        /// <param name="adoptionApplicationId"></param>
        /// <returns>adoption application object</returns>
        [HttpGet("{adoptionApplicationId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(object))]
        public async Task<IActionResult> GetAdoptionApplication(int adoptionApplicationId)
        {
            return Ok();
        }

        /// <summary>
        /// Create adoption application
        /// </summary>
        /// <param name="application"></param>
        /// <returns>created application</returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddAdoptionApplication(int organizationId, object application)
        {
            return Ok(application);
        }
    }
}
