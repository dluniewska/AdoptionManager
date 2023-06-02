using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace AdoptionManager.Api.Controllers
{
    /// <summary>
    /// Controller for managing site users
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SiteUsersController : ControllerBase
    {
        /// <summary>
        /// Get list of site users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetSiteUsers()
        {
            return Ok();
        }

        /// <summary>
        /// Create new site user object
        /// </summary>
        /// <param name="siteUser"></param>
        /// <returns>Created site user</returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddSiteUser(object siteUser)
        {
            return Ok(siteUser);
        }

        /// <summary>
        /// Update site users by Id
        /// </summary>
        /// <param name="siteUserId"></param>
        /// <param name="siteUser"></param>
        /// <returns></returns>
        [HttpPut("{siteUserId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateSiteUser(int siteUserId, object siteUser)
        {
            return Ok();
        }

        /// <summary>
        /// Delete site user by Id
        /// </summary>
        /// <param name="siteUserId"></param>
        /// <returns></returns>
        [HttpDelete("{siteUserId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteSiteUser(int siteUserId)
        {
            return Ok();
        }
    }
}
