using AutoMapper;
using CapitalPlacement.TalentManagement.Application.Helpers;
using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Application.ViewModel;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public async Task<IActionResult> CreateApplication(CreateApplicationRequest createApplicationRequest)
        {
            _logger.LogInformation("Creating application...");

            var application = _mapper.Map<Domain.ApplicationInformation>(createApplicationRequest);

            await _unitOfWork.Applications.AddAsync(application);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation("Application created successfully.");

            var response = ResponseModel<CreateProgramResponse>.CreateResponse(application, "Successful", true);

            return Ok(response);
        }
    }
}
