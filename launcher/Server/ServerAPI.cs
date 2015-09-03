using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace launcher.Server
{
    public class ServerApi
        {

        public TcpListener Listener;

        private string _apIreq;

        public void Start()
        {
            Listener = new TcpListener(IPAddress.Any, 50505);
            Listener.Start();
            Listener.BeginAcceptTcpClient(HandleAcceptTcpClient, Listener);
        }

        public void ApiUpdate()
        {
            if (_apIreq == "CLIENT_EXIT") { _apIreq = "CLIENT_RUN"; }
            var status = Main.Instance._APIupdate(_apIreq);
            
            _apIreq = status;
        }

        public void Stop()
        {
            Listener?.Stop();
        }

        public void HandleAcceptTcpClient(IAsyncResult result)
        {
            string header;
            var client = Listener.EndAcceptTcpClient(result);
            Listener.BeginAcceptTcpClient(HandleAcceptTcpClient, Listener);

            var stream = client.GetStream();

            client.NoDelay = true;
            //client.Client.NoDelay = true;

            using (var writer = new StreamWriter(stream))
            using (var reader = new StreamReader(stream))
            {

                ApiUpdate();
                header = SendHeader(_apIreq);
 
                writer.WriteLine(header);
                writer.WriteLine(_apIreq);
                writer.Flush();
                client.Close();


            }
        }

        public string SendHeader(string bContent)
        {
            var bHeader =
                    "HTTP/1.1 200 OK\r\n"
                  + "Server: Launcher API\r\n"
                  + "Content-Length: " + bContent.Length + "\r\n"

                  + "Access-Control-Allow-Origin: *\r\n"
                  + "Content-Type: text/plain; charset=UTF-8\r\n"
                  + "Connection: keep-alive\r\n";
            return bHeader;
        }

    }
}

