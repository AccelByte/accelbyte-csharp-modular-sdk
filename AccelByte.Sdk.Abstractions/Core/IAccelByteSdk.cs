// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Pipeline;
using AccelByte.Sdk.Core.Net.Http;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public interface IAccelByteSdk : IDisposable
    {
        IAccelByteConfig Configuration { get; }

        ISdkLocalData LocalData { get; }

        ISdkEvents Events { get; }

        IOperationProcessPipeline OpProcess { get; }

        string Namespace { get; }

        string FlightId { get; }

        void StopServices();

        T? GetService<T>() where T : ISdkService;

        IHttpResponse RunRequest(IOperation operation);

        Task<IHttpResponse> RunRequestAsync(IOperation operation);

        T GetApi<T>(string key) where T : ISdkApi;

        T GetApi<T>() where T : ISdkApi;

        T GetApi<T>(string key, Func<T> activatorFunc) where T : ISdkApi;

        bool ValidateToken(string accessToken);

        bool ValidateToken(string accessToken, string permission, int action);

        bool ValidateToken(string accessToken, string permission, int action, string? aNamespace, string? userId);

        Task<bool> ValidateTokenAsync(string accessToken);

        Task<bool> ValidateTokenAsync(string accessToken, string permission, int action);

        Task<bool> ValidateTokenAsync(string accessToken, string permission, int action, string? aNamespace, string? userId);

        void UpdateFlightId(string flightId);
    }
}
