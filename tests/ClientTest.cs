using Backend.Application.Interfaces;
using Moq;
using Backend.Apllication.DTO;
using Backend.tests.Base;

namespace Backend.Tests
{
    public class ClientTest : IClassFixture<InjectionFixture>
    {
        private readonly IClientService _service;
        private readonly Mock<IClientService> _mockService;

        public ClientTest(InjectionFixture fixture)
        {
            _mockService = fixture.GetMockClientService();
            _service = _mockService.Object;
        }

        [Fact]
        public void GetClients_ShouldReturnListOfClients()
        {
            // Arrange
            var expectedClients = new List<ClientDTO>
            {
                new ClientDTO { Id = "1", Name = "Client1" },
                new ClientDTO { Id = "2", Name = "Client2" }
            };
            _mockService.Setup(service => service.GetClients()).Returns(expectedClients);

            // Act
            var result = _service.GetClients();

            // Assert
            Assert.IsType<List<ClientDTO>>(result);
            Assert.Equal(expectedClients.Count, result.Count);
        }

        [Fact]
        public void GetById_ValidId_ShouldReturnClient()
        {
            // Arrange
            var clientId = "1";
            var expectedClient = new ClientDTO { Id = clientId, Name = "Client1" };
            _mockService.Setup(service => service.GetById(clientId)).Returns(expectedClient);

            // Act
            var result = _service.GetById(clientId);

            // Assert
            Assert.IsType<ClientDTO>(result);
            Assert.Equal(expectedClient.Id, result.Id);
            Assert.Equal(expectedClient.Name, result.Name);
        }

        [Fact]
        public void GetById_InvalidId_ShouldReturnNull()
        {
            // Arrange
            var invalidClientId = "999";
            _mockService.Setup(service => service.GetById(invalidClientId)).Returns((ClientDTO)null);

            // Act
            var result = _service.GetById(invalidClientId);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void VerifyRegister_ValidData_ShouldReturnTrue()
        {
            // Arrange
            var verifyData = new VerifyClientDTO { Field = "email", Value = "client@example.com" };
            _mockService.Setup(service => service.VerifyRegister(verifyData)).Returns(true);

            // Act
            var result = _service.VerifyRegister(verifyData);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyRegister_InvalidData_ShouldReturnFalse()
        {
            // Arrange
            var verifyData = new VerifyClientDTO { Field = "email", Value = "invalid@example.com" };
            _mockService.Setup(service => service.VerifyRegister(verifyData)).Returns(false);

            // Act
            var result = _service.VerifyRegister(verifyData);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CreateClient_ShouldAddClient()
        {
            // Arrange
            var newClient = new ClientDTO { Id = "3", Name = "Client3" };
            _mockService.Setup(service => service.CreateClient(newClient)).Verifiable();

            // Act
            _service.CreateClient(newClient);

            // Assert
            _mockService.Verify(service => service.CreateClient(newClient), Times.Once);
        }

        [Fact]
        public void UpdateClient_ValidData_ShouldUpdateClient()
        {
            // Arrange
            var clientId = "1";
            var updatedClient = new ClientDTO { Id = clientId, Name = "UpdatedClient" };
            _mockService.Setup(service => service.UpdateClient(clientId, updatedClient)).Verifiable();

            // Act
            _service.UpdateClient(clientId, updatedClient);

            // Assert
            _mockService.Verify(service => service.UpdateClient(clientId, updatedClient), Times.Once);
        }
    }
}
