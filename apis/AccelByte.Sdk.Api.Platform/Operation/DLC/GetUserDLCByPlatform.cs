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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getUserDLCByPlatform
    ///
    /// Get user dlc by platform.
    /// Other detail info:
    /// 
    ///   * Returns : user dlc
    /// </summary>
    public class GetUserDLCByPlatform : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserDLCByPlatformBuilder Builder { get => new GetUserDLCByPlatformBuilder(); }

        public class GetUserDLCByPlatformBuilder
            : OperationBuilder<GetUserDLCByPlatformBuilder>
        {





            internal GetUserDLCByPlatformBuilder() { }

            internal GetUserDLCByPlatformBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserDLCByPlatform Build(
                string namespace_,
                string userId,
                GetUserDLCByPlatformType type
            )
            {
                GetUserDLCByPlatform op = new GetUserDLCByPlatform(this,
                    namespace_,                    
                    userId,                    
                    type                    
                );

                op.SetBaseFields<GetUserDLCByPlatformBuilder>(this);
                return op;
            }

            public Model.UserDLC? Execute(
                string namespace_,
                string userId,
                string type
            )
            {
                GetUserDLCByPlatform op = Build(
                    namespace_,
                    userId,
                    type
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.UserDLC?> ExecuteAsync(
                string namespace_,
                string userId,
                string type
            )
            {
                GetUserDLCByPlatform op = Build(
                    namespace_,
                    userId,
                    type
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

        private GetUserDLCByPlatform(GetUserDLCByPlatformBuilder builder,
            string namespace_,
            string userId,
            GetUserDLCByPlatformType type
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (type is not null) QueryParams["type"] = type.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserDLCByPlatform(
            string namespace_,            
            string userId,            
            GetUserDLCByPlatformType type            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (type is not null) QueryParams["type"] = type.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/dlc";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.UserDLC? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserDLC>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserDLC>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetUserDLCByPlatformType : StringEnum<GetUserDLCByPlatformType>
    {
        public static readonly GetUserDLCByPlatformType EPICGAMES
            = new GetUserDLCByPlatformType("EPICGAMES");

        public static readonly GetUserDLCByPlatformType OCULUS
            = new GetUserDLCByPlatformType("OCULUS");

        public static readonly GetUserDLCByPlatformType PSN
            = new GetUserDLCByPlatformType("PSN");

        public static readonly GetUserDLCByPlatformType STEAM
            = new GetUserDLCByPlatformType("STEAM");

        public static readonly GetUserDLCByPlatformType XBOX
            = new GetUserDLCByPlatformType("XBOX");


        public static implicit operator GetUserDLCByPlatformType(string value)
        {
            return NewValue(value);
        }

        public GetUserDLCByPlatformType(string enumValue)
            : base(enumValue)
        {

        }
    }

}