using System.IO;
using System.Text;

namespace NetworkingCore.Utils
{
    public class StreamUtils
    {
        public byte[] StringToByteArray(string message)
        {
            byte[] messageBytes = new byte[]{ };
            if(!string.IsNullOrEmpty(message))
                messageBytes = Encoding.UTF8.GetBytes(message);
            return messageBytes;
        }

        public Stream StringToStream(string message)
        {
            byte[] messageBytes = StringToByteArray(message);
            using (Stream stream = new MemoryStream(messageBytes))
                return stream;
        }

        public string StreamToString(Stream stream)
        {
            string text = string.Empty;
            if (stream != null) { 
                using (StreamReader reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                    return text;
                }
            }
            return text;
        }
    }
}
