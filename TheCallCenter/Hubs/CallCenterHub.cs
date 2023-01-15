using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using TheCallCenter.Data.Entities;

namespace TheCallCenter.Hubs
{
	public class CallCenterHub:Hub<ICallCenterHub>
	{
		public async Task NewCallReceived(Call NewCall)
		{
            await Clients.Group("CallCenters").NewCallReceived(NewCall);
            //await Clients.All.NewCallReceived(NewCall);
			//await Clients.All.SendAsync("NewCallReceived", NewCall); //When not using repository pattern
		}

		public async Task JoinCallCenters()
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, "CallCenters");
		}
	}
}

