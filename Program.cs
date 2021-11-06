using Newtonsoft.Json;
using System;

namespace NewMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("CNFLKT", "hello im here", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);

            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"CNFLKT","MessageText":"hello im here","TimeStamp":"2021-11-06T19:20:35.8920818Z"}
            //CNFLKT < 06.11.2021 19:20:35 >: hello im here
        }
    }
}
