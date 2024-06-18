using AutoMapper;
using CapitalPlacement.TalentManagement.Application.Helpers;
using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacement.TalentManagement.Api.Controllers
{
    [Route("api/programs")]
    public class ProgramsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ProgramsController> _logger;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor for ProgramsController.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="logger">The logger.</param>
        ///  /// <param name="mapper">The logger.</param>
        public ProgramsController(IUnitOfWork unitOfWork, ILogger<ProgramsController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProgram(CreateProgramRequest CreateProgramRequest)
        {
            _logger.LogInformation("Creating program...");

            var program = _mapper.Map<Domain.Program>(CreateProgramRequest);

            await _unitOfWork.Programs.AddAsync(program);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation("Program created successfully.");

            var response = ResponseModel<CreateProgramResponse>.CreateResponse(program, "Successful", true);

            return Ok(response);
        }
    }
}
