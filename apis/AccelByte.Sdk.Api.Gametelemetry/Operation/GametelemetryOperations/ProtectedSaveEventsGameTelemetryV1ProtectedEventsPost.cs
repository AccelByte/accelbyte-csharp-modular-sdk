// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Gametelemetry.Model;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    /// <summary>
    /// protected_save_events_game_telemetry_v1_protected_events_post
    ///
    /// This endpoint requires valid JWT token.
    /// This endpoint does not require permission.
    /// 
    /// This endpoint send events into designated streaming pipeline and each request can contain single or multiple events.
    /// 
    /// 
    /// Format of the event:
    /// 
    /// - **EventNamespace (required)**: Namespace of the relevant game with domain name format.
    /// 
    /// 
    /// Only accept input with valid characters. Allowed characters: Aa-Zz0-9_.-
    /// 
    /// 
    /// 
    /// 
    /// It is encouraged to use alphanumeric only characters. _.- will be deprecated soon
    /// 
    /// 
    /// 
    /// 
    /// Example: accelbyte
    /// 
    /// 
    /// 
    /// - **EventName (required)**: Name of the event.
    /// 
    /// 
    /// Only accept input with valid characters. Allowed characters: Aa-Zz0-9_.-
    /// 
    /// 
    /// 
    /// 
    /// It is encouraged to use alphanumeric only characters. _.- will be deprecated soon
    /// 
    /// 
    /// 
    /// 
    /// Example: player_killed, mission_accomplished
    /// 
    /// 
    /// 
    /// - **Payload (required)**: An arbitrary json with the payload of the said event.
    /// 
    /// 
    /// Default maximum payload size is 1MB
    /// 
    /// 
    /// 
    /// - **ClientTimestamp (optional)**: Timestamp of the event captured by the client SDK.
    /// 
    /// - **DeviceType (optional)**: The device type of the user.
    /// </summary>
    public class ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder Builder { get => new ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder(); }

        public class ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder
            : OperationBuilder<ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder>
        {





            internal ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder() { }

            internal ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost Build(
                List<TelemetryBody> body
            )
            {
                ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost op = new ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(this,
                    body                    

                );

                op.SetBaseFields<ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder>(this);
                return op;
            }

            public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.Response Execute(
                List<TelemetryBody> body

            )
            {
                ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost op = Build(
                    body
                    
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.Response> ExecuteAsync(
                List<TelemetryBody> body

            )
            {
                ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost op = Build(
                    body
                    
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder builder,
            List<TelemetryBody> body
            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public BaseErrorResponse? Error422 { get; set; } = null;

            public BaseErrorResponse? Error500 { get; set; } = null;

            public BaseErrorResponse? Error507 { get; set; } = null;


            protected override string GetFullOperationId() => "Gametelemetry::GametelemetryOperations::ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost";
        }

        #endregion

        public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(
            List<Model.TelemetryBody> body,            
            string accessToken
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }

        public override string Path => "/game-telemetry/v1/protected/events";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)422)
            
            {
                response.Error422 = JsonSerializer.Deserialize<BaseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<BaseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)507)
            
            {
                response.Error507 = JsonSerializer.Deserialize<BaseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error507!.TranslateToApiError();
            }

            return response;
        }
    }

}