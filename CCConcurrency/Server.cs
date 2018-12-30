using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CConcurrency
{
    class Server
    {
        private TcpListener tcpListener;
        volatile bool keepProcessing = true;

        public Server(long ipAddress, int port, int millisecondTimeOut)
        {
            tcpListener = new TcpListener(new IPAddress(ipAddress), port);
        }

        public void Run()
        {
            Debug.WriteLine("Server Starting");
            while (keepProcessing)
            {
                Debug.WriteLine("Accepting Client");
                Socket socket = tcpListener.AcceptSocket();
                Debug.WriteLine("Got Client");
                Process(socket);
            }
        }

        private void Process(Socket socket)
        {
            if (socket == null)
                return;

            try
            {
                Debug.WriteLine("Server: Getting Message");
                //string message = Mes
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
        }
    }
}
