using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck.Handlers;
using Fleck;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebSocket_Server
{
    public class ChatServer
    {
        private readonly string IAM_REGEX = @"^IAM:(?<username>[a-zA-Z]{3,})$";
        private readonly string MESSAGE_REGEX = @"^(?<username>[a-zA-Z]{3,})->(?<message>.+)$";
        private Dictionary<string, IWebSocketConnection> allSockets = new Dictionary<string, IWebSocketConnection>();
        public void StartServer()
        {
            
            var server = new WebSocketServer("ws://localhost:8181");

            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    Console.WriteLine("User connected!");
                    socket.Send("WhoAreYou?");
                };
                socket.OnClose = () =>
                {
                    Console.WriteLine("User disconnected!");
                    foreach (var user in allSockets.Keys)
                    {
                        if (allSockets[user] == socket)
                        {
                            allSockets.Remove(user);
                            return;
                        }
                    }
                };
                socket.OnMessage = message =>
                {
                    Console.WriteLine("Message received : {0}", message);
                    Regex loginRE = new Regex(IAM_REGEX);

                    var match = loginRE.Match(message);
                    if (match.Length > 0)
                    {
                        string username = match.Groups["username"].Value.ToString();
                        allSockets.Add(username, socket);
                        Console.WriteLine("Username : {0}", username);
                        socket.Send("WELCOME!");
                        return;
                    }
                    Regex messageRE = new Regex(MESSAGE_REGEX);
                    match = messageRE.Match(message);
                    if (match.Length > 0)
                    {
                        string to = match.Groups["username"].Value;
                        string msg = match.Groups["message"].Value;

                        foreach(var user in allSockets.Keys)
                        {
                            if(allSockets[user] == socket)
                            {
                                Console.WriteLine("sending...");
                                allSockets[to].Send(string.Format("{0}->{1}",user,msg));
                                return;
                            }
                        }
                    }

                };
            });

            Timer t = new Timer(SendUsers, null, 0, 1000);
            Console.Read();
        }
        private void SendUsers(object o)
        {
            var allUserNames = "USERS:"+string.Join(";",allSockets.Keys);
            allSockets.Values.ToList().ForEach(s => s.Send(allUserNames));
        }
    }
}
