using Microsoft.AspNetCore.Mvc;

namespace AdoptionManager.Api.Controllers
{
    /// <summary>
    /// HealthChecks Controller
    /// </summary>
    [Route("api/hc")]
    [ApiController]
    public class HealthChecksController : ControllerBase
    {
        /// <summary>
        /// Simple HealthCheck
        /// </summary>
        /// <returns>string</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Healthy";
        }
    }
}
