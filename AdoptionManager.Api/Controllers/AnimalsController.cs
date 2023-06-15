using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace AdoptionManager.Api.Controllers
{
    /// <summary>
    /// Controller for managing animals
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        /// <summary>
        /// Get list of animals
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetAnimals()
        {
            return Ok();
        }

        /// <summary>
        /// Get single animal
        /// </summary>
        /// <param name="animalId"></param>
        /// <returns></returns>
        [HttpGet("{animalId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetAdoptionApplication(int animalId)
        {
            return Ok();
        }

        /// <summary>
        /// Create new animal object
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>Created animal</returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddAnimal(object animal)
        {
            return Ok(animal);
        }

        /// <summary>
        /// Update animal by Id
        /// </summary>
        /// <param name="animalId"></param>
        /// <param name="animal"></param>
        /// <returns></returns>
        [HttpPut("{animalId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateAnimal(int animalId, object animal)
        {
            return Ok();
        }

        /// <summary>
        /// Delete animal by Id
        /// </summary>
        /// <param name="animalId"></param>
        /// <returns></returns>
        [HttpDelete("{animalId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAnimal(int animalId)
        {
            return Ok();
        }
    }
}
