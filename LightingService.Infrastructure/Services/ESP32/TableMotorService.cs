using LightingService.Application.Common.Interfaces;

namespace LightingService.Infrastructure.Services.ESP32
{
    public class TableMotorService : ITableMotorService
    {
        private readonly HttpClient _httpClient;

        public TableMotorService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task MoveDownAsync(int speed)
        {
            var url = $"http://192.168.1.99/motor/left?duty={speed}";

            var resp = await _httpClient.GetAsync(url);
            resp.EnsureSuccessStatusCode();
        }

        public async Task MoveUpAsync(int speed)
        {
            var url = $"http://192.168.1.99/motor/right?duty={speed}"; 

            var resp = await _httpClient.GetAsync(url);
            resp.EnsureSuccessStatusCode();
        }

        public async Task StopAsync()
        {
            var url = $"http://192.168.1.99/motor/stop";

            var resp = await _httpClient.GetAsync(url);
            resp.EnsureSuccessStatusCode();
        }
    }
}
