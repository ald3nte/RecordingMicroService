using Google.Protobuf;
using Grpc.Net.Client;
using GrpcServer;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RecordingClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var recordingClient = new Recording.RecordingClient(channel);

            var clientRequested = new RecordingLookupModel { RecordingId = 1 };

            var recording = await recordingClient.GetRecordingFileAsync(clientRequested);

            var fileName = recording.Name + "." + recording.Extension;

            var filePath = Path.Combine( @"C:\path", fileName);

            System.IO.File.WriteAllBytes(filePath, recording.RefordingFile.ToByteArray());


            Console.WriteLine($"{ recording.Name }");


            Console.ReadLine();
        }

    }
}
