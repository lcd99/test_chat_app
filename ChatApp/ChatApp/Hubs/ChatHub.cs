using ChatApp.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ChatHub : Hub
    {
        public static HashSet<Users> connectionList = new HashSet<Users>();

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("OnConnectedAsync", $"{Context.ConnectionId} joined", Context.ConnectionId);
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.Others.SendAsync("OnDisconnectedAsync", $"{Context.ConnectionId} left");
        }

        public Task Send(string message)
        {
            Users us = new()
            {
                ConnectionId = Context.ConnectionId,
                Username = message
            };
            connectionList.Add(us);
            return Clients.All.SendAsync("Send", message, connectionList);
        }

        public Task SendToOthers(string message)
        {
            return Clients.Others.SendAsync("SendToOthers", message, connectionList, Context.ConnectionId);
        }

        public Task SendToConnection(string connectionId, string username, string message)
        {
            return Clients.Client(connectionId).SendAsync("SendToConnection", Context.ConnectionId, username, message);
        }

        public Task SendToGroup(string groupName, string username, string message)
        {
            return Clients.Group(groupName).SendAsync("SendToGroup", groupName, username, message);
            //return Clients.Group(groupName).SendAsync("SendToGroup", $"{Context.ConnectionId}@{groupName}: {message}");
        }

        public Task SendToOthersInGroup(string groupName, string message)
        {
            return Clients.OthersInGroup(groupName).SendAsync("SendToOthersInGroup", $"{Context.ConnectionId}@{groupName}: {message}");
        }

        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            await Clients.Group(groupName).SendAsync("JoinGroup", $"{Context.ConnectionId} joined {groupName}");
        }

        public async Task LeaveGroup(string groupName)
        {
            await Clients.Group(groupName).SendAsync("LeaveGroup", $"{Context.ConnectionId} left {groupName}");

            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }

        public Task Echo(string message)
        {
            return Clients.Caller.SendAsync("Echo", $"{Context.ConnectionId}: {message}");
        }
    }
}
