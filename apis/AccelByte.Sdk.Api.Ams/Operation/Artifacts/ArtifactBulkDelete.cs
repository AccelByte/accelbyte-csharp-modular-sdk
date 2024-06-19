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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// ArtifactBulkDelete
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA [DELETE]
    /// </summary>
    public class ArtifactBulkDelete : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ArtifactBulkDeleteBuilder Builder { get => new ArtifactBulkDeleteBuilder(); }

        public class ArtifactBulkDeleteBuilder
            : OperationBuilder<ArtifactBulkDeleteBuilder>
        {

            public string? ArtifactType { get; set; }

            public string? FleetId { get; set; }

            public DateTime? UploadedBefore { get; set; }





            internal ArtifactBulkDeleteBuilder() { }

            internal ArtifactBulkDeleteBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ArtifactBulkDeleteBuilder SetArtifactType(string _artifactType)
            {
                ArtifactType = _artifactType;
                return this;
            }

            public ArtifactBulkDeleteBuilder SetFleetId(string _fleetId)
            {
                FleetId = _fleetId;
                return this;
            }

            public ArtifactBulkDeleteBuilder SetUploadedBefore(DateTime _uploadedBefore)
            {
                UploadedBefore = _uploadedBefore;
                return this;
            }





            public ArtifactBulkDelete Build(
                string namespace_
            )
            {
                ArtifactBulkDelete op = new ArtifactBulkDelete(this,
                    namespace_
                );

                op.SetBaseFields<ArtifactBulkDeleteBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                ArtifactBulkDelete op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string namespace_
            )
            {
                ArtifactBulkDelete op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private ArtifactBulkDelete(ArtifactBulkDeleteBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ArtifactType is not null) QueryParams["artifactType"] = builder.ArtifactType;
            if (builder.FleetId is not null) QueryParams["fleetId"] = builder.FleetId;
            if (builder.UploadedBefore != null) QueryParams["uploadedBefore"] = Convert.ToString(builder.UploadedBefore)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ArtifactBulkDelete(
            string namespace_,
            string? artifactType,
            string? fleetId,
            DateTime? uploadedBefore
        )
        {
            PathParams["namespace"] = namespace_;

            if (artifactType is not null) QueryParams["artifactType"] = artifactType;
            if (fleetId is not null) QueryParams["fleetId"] = fleetId;
            if (uploadedBefore != null) QueryParams["uploadedBefore"] = Convert.ToString(uploadedBefore)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/artifacts";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}