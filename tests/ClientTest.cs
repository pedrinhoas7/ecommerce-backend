using Backend.Application.Interfaces;
using Backend.tests.Base;
using Xunit;

namespace tests
{
    public class ClientTest : IClassFixture<InjectionFixture>
    {
        private readonly IClientService _service;

        public ClientTest(InjectionFixture fixture)
        {
            _service = fixture.GetClientService(); // Obtém o serviço do fixture
        }

        [Fact]
        public void GetClients()
        {
            var result = _service.GetClients();
            Assert.True(result);
        }
    }
}
