using AutoMapper;
using CapitalPlacement.TalentManagement.Application.Helpers;
using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Application.ViewModel;

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

        [HttpGet("{id}", Name = "GetProgram")]
        public async Task<IActionResult> GetProgram(Guid id)
        {
            _logger.LogInformation("Getting program...");

            var program = await _unitOfWork.Programs.GetAsync(id);

            if (program == null)
            {
                return NotFound($"Program with id: {id} was not found");
            }

            var programResponse = _mapper.Map<ProgramResponse>(program);

            _logger.LogInformation($"Program with id: {id} retrieved successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(programResponse, "Successful", true);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetPrograms()
        {
            _logger.LogInformation("Getting programs...");

            var program = await _unitOfWork.Programs.GetAllAsync();

            var programResponse = _mapper.Map<List<ProgramResponse>>(program);

            _logger.LogInformation("Program retrieved successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(programResponse, "Successful", true);

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProgramResponse), 200)]
        public async Task<IActionResult> CreateProgram(CreateProgramRequest CreateProgramRequest)
        {
            _logger.LogInformation("Creating program...");

            var program = _mapper.Map<Domain.Program>(CreateProgramRequest);

            await _unitOfWork.Programs.AddAsync(program);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation("Program created successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(program, "Successful", true);

            return CreatedAtAction("GetProgram", new { id = program.Id }, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProgram(Guid id, UpdateProgramRequest updateProgramRequest)
        {

            if(id != updateProgramRequest.Id)
            {
                return BadRequest($"Invalid id: {id}");
            }
            _logger.LogInformation($"Updating program with id {id}...");

            var program = _mapper.Map<Domain.Program>(updateProgramRequest);

             _unitOfWork.Programs.Update(program);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation($"Program with {id} updated successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(program, "Successful", true);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgram(Guid id)
        {
            var program = await _unitOfWork.Programs.GetAsync(id);

            if (program == null)
            {
                return NotFound($"Program not found");
            }

            _logger.LogInformation($"Deleting program with id: {id}...");

            _unitOfWork.Programs.Delete(program);

            await _unitOfWork.CompleteAsync();

            _logger.LogInformation($"Program with id: {id} deleted successfully.");

            var response = ResponseModel<ProgramResponse>.CreateResponse(program, "Successful", true);

            return Ok(response);
        }
    }
}
