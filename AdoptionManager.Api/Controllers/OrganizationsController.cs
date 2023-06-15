using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace AdoptionManager.Api.Controllers
{
    /// <summary>
    /// Controller for managing organization
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        /// <summary>
        /// Get list of organizations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetOrganizations()
        {
            return Ok();
        }

        /// <summary>
        /// Get single organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        [HttpGet("{organizationId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetAdoptionApplication(int organizationId)
        {
            return Ok();
        }

        /// <summary>
        /// Create new organization object
        /// </summary>
        /// <param name="organization"></param>
        /// <returns>Created organization</returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddOrganization(object organization)
        {
            return Ok(organization);
        }

        /// <summary>
        /// Update organization by Id
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="organization"></param>
        /// <returns></returns>
        [HttpPut("{organizationId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateOrganization(int organizationId, object organization)
        {
            return Ok();
        }

        /// <summary>
        /// Delete organization by Id
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        [HttpDelete("{organizationId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteOrganization(int organizationId)
        {
            return Ok();
        }
    }
}
