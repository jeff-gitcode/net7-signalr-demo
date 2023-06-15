using Microsoft.AspNetCore.SignalR;

namespace Hubs;

public interface IClock
{
    Task ShowTime(DateTime currentTime);
}

public class ClockHub : Hub<IClock>
{
    public async Task SendTimeToClients(DateTime dateTime)
    {
        await Clients.All.ShowTime(dateTime);
    }
}