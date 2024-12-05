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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicUpdateParty
    ///
    /// Updates party blob, this endpoint will override stored party data.
    /// 
    /// Join type can only be updated by the party's leader.
    /// To update only specified fields, please use following endpoint:
    /// method : PATCH
    /// API : /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}
    /// 
    /// Reserved attributes key:
    /// 1. preference: used to store preference of the leader and it is non-replaceable to keep the initial behavior of
    /// the session regardless the leader changes.
    /// 2. NATIVESESSIONTITLE: used for session sync, to define name of session displayed on PlayStation system UI.
    /// </summary>
    public class PublicUpdateParty : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePartyBuilder Builder { get => new PublicUpdatePartyBuilder(); }

        public class PublicUpdatePartyBuilder
            : OperationBuilder<PublicUpdatePartyBuilder>
        {





            internal PublicUpdatePartyBuilder() { }

            internal PublicUpdatePartyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateParty Build(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = new PublicUpdateParty(this,
                    body,
                    namespace_,
                    partyId
                );

                op.SetBaseFields<PublicUpdatePartyBuilder>(this);
                return op;
            }

            public PublicUpdateParty.Response Execute(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicUpdateParty.Response> ExecuteAsync(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public PublicUpdateParty.Response<T1, T2> Execute<T1, T2>(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicUpdateParty.Response<T1, T2>> ExecuteAsync<T1, T2>(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicUpdateParty(PublicUpdatePartyBuilder builder,
            ApimodelsUpdatePartyRequest body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsPartySessionResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::Party::PublicUpdateParty";
        }

        public class Response<T1, T2> : ApiResponse<Model.ApimodelsPartySessionResponse<T1, T2>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::Party::PublicUpdateParty";
        }
        #endregion

        public PublicUpdateParty(
            string namespace_,
            string partyId,
            Model.ApimodelsUpdatePartyRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicUpdateParty.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicUpdateParty.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public PublicUpdateParty.Response<T1, T2> ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicUpdateParty.Response<T1, T2>()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1, T2>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}