// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/records.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RecordingMicroService {
  public static partial class Record
  {
    static readonly string __ServiceName = "Record";

    static readonly grpc::Marshaller<global::RecordingMicroService.HelloRequest> __Marshaller_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RecordingMicroService.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RecordingMicroService.HelloReply> __Marshaller_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RecordingMicroService.HelloReply.Parser.ParseFrom);

    static readonly grpc::Method<global::RecordingMicroService.HelloRequest, global::RecordingMicroService.HelloReply> __Method_GetRecordingFile = new grpc::Method<global::RecordingMicroService.HelloRequest, global::RecordingMicroService.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRecordingFile",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RecordingMicroService.RecordsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Record</summary>
    [grpc::BindServiceMethod(typeof(Record), "BindService")]
    public abstract partial class RecordBase
    {
      public virtual global::System.Threading.Tasks.Task<global::RecordingMicroService.HelloReply> GetRecordingFile(global::RecordingMicroService.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RecordBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetRecordingFile, serviceImpl.GetRecordingFile).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RecordBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetRecordingFile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecordingMicroService.HelloRequest, global::RecordingMicroService.HelloReply>(serviceImpl.GetRecordingFile));
    }

  }
}
#endregion
