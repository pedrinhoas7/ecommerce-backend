using Backend.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Moq;

namespace Backend.tests.Base
{
    public class InjectionFixture : IDisposable
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public InjectionFixture()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        public Mock<IClientService> GetMockClientService()
        {
            var mockService = new Mock<IClientService>();

            return mockService;
        }


        public IServiceProvider ServiceProvider => server.Host.Services;

        public IClientService GetClientService() => ServiceProvider.GetRequiredService<IClientService>();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                server.Dispose();
                client.Dispose();
            }
        }
    }
}
