using Microsoft.AspNetCore.SignalR;

namespace MySignalR.Hubs
{
    public class ChatHub : Hub
    {
        public ChatHub()
        {
        }

        public void Send( string user, string message )
        {
            Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
