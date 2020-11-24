using Google.Protobuf;
using Grpc.Core;
using GrpcServer;
using Microsoft.Extensions.Logging;
using RecordingMicroService.DbAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RecordingMicroService.Services
{
    public class RecordingService :Recording.RecordingBase
    {

        private readonly ILogger<RecordingService> _logger;
        private readonly AppDbContext _appDbContext;

        public RecordingService(ILogger<RecordingService> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public override Task<RecordingModel> GetRecordingFile (RecordingLookupModel request, ServerCallContext context)
        {
            RecordingModel output = new RecordingModel();

            var Recording = _appDbContext.Recordings.FirstOrDefault(r => r.Id == request.RecordingId);

            if (Recording == null)
            {
                throw new Exception("Brak wpisu w bazie");
            }
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\recordings", Recording.RecordingPath);
                
                using(var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] RecordingData = System.IO.File.ReadAllBytes(filePath);
                    
                    fileStream.Read(RecordingData, 0, System.Convert.ToInt32(fileStream.Length));
                    output.RefordingFile = ByteString.CopyFrom(RecordingData);
                }

                output.Id = Recording.Id;
                output.Name = Recording.Name;

                return Task.FromResult(output);
            
           
        }

    }

        
}
