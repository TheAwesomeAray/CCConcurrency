using System.Net.Sockets;
using System.Text;

namespace CCConcurrency
{
    public class MessageUtils
    {
        public static void SendMessage(TcpClient socket, string message)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            var result = socket.GetStream();
            var byteCount = encoder.GetByteCount(message);
            var bytes = new byte[byteCount];
            var encodedMesage = encoder.GetBytes(message, bytes);
            result.Write(bytes, 0, byteCount);
        }

        public static string GetMessage(NetworkStream stream)
        {
            //stream.Read();
            return "";
        }
    }
}
