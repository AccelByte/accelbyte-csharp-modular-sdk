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
    /// ArtifactGet
    ///
    /// Get all artifacts matching the provided search criteria. When criteria is not specified the data returned won't have been filtered on those parameters
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:AMS:ARTIFACT [READ]
    /// </summary>
    public class ArtifactGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ArtifactGetBuilder Builder { get => new ArtifactGetBuilder(); }

        public class ArtifactGetBuilder
            : OperationBuilder<ArtifactGetBuilder>
        {

            public string? ArtifactType { get; set; }

            public long? Count { get; set; }

            public string? EndDate { get; set; }

            public string? FleetID { get; set; }

            public string? ImageID { get; set; }

            public long? MaxSize { get; set; }

            public long? MinSize { get; set; }

            public long? Offset { get; set; }

            public string? Region { get; set; }

            public string? ServerId { get; set; }

            public string? StartDate { get; set; }

            public string? Status { get; set; }





            internal ArtifactGetBuilder() { }

            internal ArtifactGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ArtifactGetBuilder SetArtifactType(string _artifactType)
            {
                ArtifactType = _artifactType;
                return this;
            }

            public ArtifactGetBuilder SetCount(long _count)
            {
                Count = _count;
                return this;
            }

            public ArtifactGetBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public ArtifactGetBuilder SetFleetID(string _fleetID)
            {
                FleetID = _fleetID;
                return this;
            }

            public ArtifactGetBuilder SetImageID(string _imageID)
            {
                ImageID = _imageID;
                return this;
            }

            public ArtifactGetBuilder SetMaxSize(long _maxSize)
            {
                MaxSize = _maxSize;
                return this;
            }

            public ArtifactGetBuilder SetMinSize(long _minSize)
            {
                MinSize = _minSize;
                return this;
            }

            public ArtifactGetBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ArtifactGetBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public ArtifactGetBuilder SetServerId(string _serverId)
            {
                ServerId = _serverId;
                return this;
            }

            public ArtifactGetBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public ArtifactGetBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public ArtifactGet Build(
                string namespace_
            )
            {
                ArtifactGet op = new ArtifactGet(this,
                    namespace_                    
                );

                op.SetBaseFields<ArtifactGetBuilder>(this);
                return op;
            }

            public Model.ApiArtifactListResponse? Execute(
                string namespace_
            )
            {
                ArtifactGet op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ApiArtifactListResponse?> ExecuteAsync(
                string namespace_
            )
            {
                ArtifactGet op = Build(
                    namespace_
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

        private ArtifactGet(ArtifactGetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ArtifactType is not null) QueryParams["artifactType"] = builder.ArtifactType;
            if (builder.Count != null) QueryParams["count"] = Convert.ToString(builder.Count)!;
            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.FleetID is not null) QueryParams["fleetID"] = builder.FleetID;
            if (builder.ImageID is not null) QueryParams["imageID"] = builder.ImageID;
            if (builder.MaxSize != null) QueryParams["maxSize"] = Convert.ToString(builder.MaxSize)!;
            if (builder.MinSize != null) QueryParams["minSize"] = Convert.ToString(builder.MinSize)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.ServerId is not null) QueryParams["serverId"] = builder.ServerId;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ArtifactGet(
            string namespace_,            
            string? artifactType,            
            long? count,            
            string? endDate,            
            string? fleetID,            
            string? imageID,            
            long? maxSize,            
            long? minSize,            
            long? offset,            
            string? region,            
            string? serverId,            
            string? startDate,            
            string? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (artifactType is not null) QueryParams["artifactType"] = artifactType;
            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (fleetID is not null) QueryParams["fleetID"] = fleetID;
            if (imageID is not null) QueryParams["imageID"] = imageID;
            if (maxSize != null) QueryParams["maxSize"] = Convert.ToString(maxSize)!;
            if (minSize != null) QueryParams["minSize"] = Convert.ToString(minSize)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region is not null) QueryParams["region"] = region;
            if (serverId is not null) QueryParams["serverId"] = serverId;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (status is not null) QueryParams["status"] = status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/artifacts";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiArtifactListResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiArtifactListResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiArtifactListResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}