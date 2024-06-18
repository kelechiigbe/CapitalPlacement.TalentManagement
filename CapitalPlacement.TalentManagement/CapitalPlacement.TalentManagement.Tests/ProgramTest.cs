
using AutoMapper;
using CapitalPlacement.TalentManagement.Api.Controllers;
using CapitalPlacement.TalentManagement.Application.Helpers;
using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Application.ViewModel;
using CapitalPlacement.TalentManagement.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace CapitalPlacement.TalentManagement.Tests
{
    public class ProgramTest
    {
        private readonly Mock<ILogger<ProgramsController>> _loggerMock = new Mock<ILogger<ProgramsController>>();
        private readonly Mock<IUnitOfWork> _unitOfWorkMock = new Mock<IUnitOfWork>();

        [Fact]
        public async Task GetProgram_ReturnsOkResponseWithApplication()
        {
            // Arrange
            var id = Guid.NewGuid();
            var program = new Program { Id = id, FirstName = new LabelInfoMetaData { Label = "First Name" } };
            var mapperMock = new Mock<IMapper>();
            _unitOfWorkMock.Setup(u => u.Programs.GetAsync(id)).ReturnsAsync(program);
            mapperMock.Setup(m => m.Map<ProgramResponse>(program)).Returns(new ProgramResponse { Id = id, FirstName = new LabelInfoMetaData { Label = "First Name" } });
            var controller = new ProgramsController(_unitOfWorkMock.Object, _loggerMock.Object, mapperMock.Object);

            // Act
            var result = await controller.GetProgram(id);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<ResponseModel<ProgramResponse>>(okResult.Value);
            Assert.Equal("Successful", response.Message);
            Assert.True(response.IsSuccess);
            Assert.Equal(id, response.Data.Id);
        }

        [Fact]
        public async Task ProgramsController_Constructor_ValidParameters_Success()
        {
            var mapperMock = new Mock<IMapper>();

            var controller = new ProgramsController(_unitOfWorkMock.Object, _loggerMock.Object, mapperMock.Object);

            // Assert
            Assert.NotNull(controller);
        }

    }
}
