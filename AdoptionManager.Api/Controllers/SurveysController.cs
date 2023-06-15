using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace AdoptionManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        /// <summary>
        /// Get surveys for organization
        /// </summary>
        /// <returns></returns>
        [HttpGet("{organizationId}/surveys")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetSurveys(int organizationId)
        {
            return Ok();
        }

        /// <summary>
        /// Get single survey for organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="surveyId"></param>
        /// <returns>survey object</returns>
        [HttpGet("{organizationId}/surveys/{surveyId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<object>))]
        public async Task<IActionResult> GetSurvey(int organizationId, int surveyId)
        {
            return Ok();
        }

        /// <summary>
        /// Create survey for organization
        /// </summary>
        /// <param name="survey"></param>
        /// <returns></returns>
        [HttpPost("{organizationId}/surveys")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddSurvey(int organizationId, object survey)
        {
            return Ok(survey);
        }

        /// <summary>
        /// Update survey
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="surveyId"></param>
        /// <param name="survey"></param>
        /// <returns></returns>
        [HttpPut("{organizationId}/surveys/{surveyId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdateSurvey(int organizationId, int surveyId, object survey)
        {
            return Ok();
        }

        /// <summary>
        /// Add new question to survey
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="surveyId"></param>
        /// <param name="question"></param>
        /// <returns></returns>
        [HttpPost("{organizationId}/surveys/{surveyId}/questions")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddQuestion(int organizationId, int surveyId, object question)
        {
            return Ok();
        }

        /// <summary>
        /// Update question in survey
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="surveyId"></param>
        /// <param name="questionId"></param>
        /// <param name="question"></param>
        /// <returns></returns>
        [HttpPut("{organizationId}/surveys/{surveyId}/questions/{questionId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateQuestion(int organizationId, int surveyId, int questionId, object question)
        {
            return Ok();
        }

        /// <summary>
        /// Delete question in survey
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="surveyId"></param>
        /// <param name="questionId"></param>
        /// <returns></returns>
        [HttpDelete("{organizationId}/surveys/{surveyId}/questions/{questionId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteQuestion(int organizationId, int surveyId, int questionId)
        {
            return Ok();
        }
    }
}
