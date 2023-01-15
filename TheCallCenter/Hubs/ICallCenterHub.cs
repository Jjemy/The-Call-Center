using System;
using System.Threading.Tasks;
using TheCallCenter.Data.Entities;

namespace TheCallCenter.Hubs
{
	public interface ICallCenterHub
	{
		Task NewCallReceived(Call NewCall);
		Task JoinCallCenters();
	}
}

