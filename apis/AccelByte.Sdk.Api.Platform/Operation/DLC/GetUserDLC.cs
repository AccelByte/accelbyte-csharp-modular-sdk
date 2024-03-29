// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getUserDLC
    ///
    /// Get user dlc records.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:IAP", action=2 (READ)
    ///   *  Returns : user dlc
    /// </summary>
    public class GetUserDLC : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserDLCBuilder Builder { get => new GetUserDLCBuilder(); }

        public class GetUserDLCBuilder
            : OperationBuilder<GetUserDLCBuilder>
        {

            public GetUserDLCType? Type { get; set; }





            internal GetUserDLCBuilder() { }

            internal GetUserDLCBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserDLCBuilder SetType(GetUserDLCType _type)
            {
                Type = _type;
                return this;
            }





            public GetUserDLC Build(
                string namespace_,
                string userId
            )
            {
                GetUserDLC op = new GetUserDLC(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserDLCBuilder>(this);
                return op;
            }

            public List<Model.UserDLCRecord>? Execute(
                string namespace_,
                string userId
            )
            {
                GetUserDLC op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.UserDLCRecord<T1>>? Execute<T1>(
                string namespace_,
                string userId
            )
            {
                GetUserDLC op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetUserDLC(GetUserDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Type is not null) QueryParams["type"] = builder.Type.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserDLC(
            string namespace_,
            string userId,
            GetUserDLCType? type
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (type is not null) QueryParams["type"] = type.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/dlc/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.UserDLCRecord>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserDLCRecord>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserDLCRecord>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.UserDLCRecord<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserDLCRecord<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserDLCRecord<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetUserDLCType : StringEnum<GetUserDLCType>
    {
        public static readonly GetUserDLCType EPICGAMES
            = new GetUserDLCType("EPICGAMES");

        public static readonly GetUserDLCType OCULUS
            = new GetUserDLCType("OCULUS");

        public static readonly GetUserDLCType PSN
            = new GetUserDLCType("PSN");

        public static readonly GetUserDLCType STEAM
            = new GetUserDLCType("STEAM");

        public static readonly GetUserDLCType XBOX
            = new GetUserDLCType("XBOX");


        public static implicit operator GetUserDLCType(string value)
        {
            return NewValue(value);
        }

        public GetUserDLCType(string enumValue)
            : base(enumValue)
        {

        }
    }

}