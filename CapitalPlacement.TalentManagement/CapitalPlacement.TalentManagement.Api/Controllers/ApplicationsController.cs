using AutoMapper;
using CapitalPlacement.TalentManagement.Application.Helpers;
using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacement.TalentManagement.Api.Controllers
{
    [Route("api/applications")]
    public class ApplicationsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ApplicationsController> _logger;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor for ApplicationsController.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="logger">The logger.</param>
        ///  /// <param name="mapper">The logger.</param>
        public ApplicationsController(IUnitOfWork unitOfWork, ILogger<ApplicationsController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetApplication")]
        public async Task<IActionResult> GetApplication(Guid id)
        {
            _logger.LogInformation("Getting application...");

            var application = await _unitOfWork.Applications.GetAsync(id);

            if (application == null)
            {
                return NotFound($"Application with id {id} was not found");
            }

            var applicationResponse = _mapper.Map<ApplicationResponse>(application);

            _logger.LogInformation($"Application with id {id} retrieved successfully.");

            var response = ResponseModel<ApplicationResponse>.CreateResponse(applicationResponse, "Successful", true);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetApplications()
        {
            _logger.LogInformation("Getting applications...");

            var application = await _unitOfWork.Applications.GetAllAsync();

            var applicationResponse = _mapper.Map<List<ApplicationResponse>>(application);

            _logger.LogInformation("Program retrieved successfully.");

            var response = ResponseModel<ApplicationResponse>.CreateResponse(applicationResponse, "Successful", true);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateApplication(CreateApplicationRequest createApplicationRequest)
        {
            _logger.LogInformation("Creating application...");

            var application = _mapper.Map<Domain.ApplicationInformation>(createApplicationRequest);

            await _unitOfWork.Applications.AddAsync(application);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation("Application created successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(application, "Successful", true);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApplication(Guid id, UpdateApplicationRequest updateApplicationRequest)
        {

            if (id != updateApplicationRequest.Id)
            {
                return BadRequest($"Invalid id {id}");
            }
            _logger.LogInformation($"Updating application with id: {id}...");

            var program = _mapper.Map<Domain.ApplicationInformation>(updateApplicationRequest);

            _unitOfWork.Applications.Update(program);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation($"Application with id {id} updated successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(program, "Successful", true);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgram(Guid id)
        {
            var application = await _unitOfWork.Applications.GetAsync(id);

            if (application == null)
            {
                return NotFound($"Application with id: {id} not found");
            }

            _logger.LogInformation("Deleting application...");

            _unitOfWork.Applications.Delete(application);

            await _unitOfWork.CompleteAsync();

            _logger.LogInformation($"Application with id: {id} deleted successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(application, "Successful", true);

            return Ok(response);
        }
    }
}
