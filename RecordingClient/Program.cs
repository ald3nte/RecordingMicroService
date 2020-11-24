using Grpc.Net.Client;
using GrpcServer;
using System;
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

            Console.WriteLine($"{ recording.Name }");


            Console.ReadLine();
        }

    }
}
