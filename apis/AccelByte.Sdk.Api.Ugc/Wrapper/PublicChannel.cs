// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicChannel
    {
        private readonly IAccelByteSdk _sdk;

        public PublicChannel(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetChannels.GetChannelsBuilder GetChannelsOp
        {
            get { return new Operation.GetChannels.GetChannelsBuilder(_sdk); }
        }
        public PublicCreateChannel.PublicCreateChannelBuilder PublicCreateChannelOp
        {
            get { return new Operation.PublicCreateChannel.PublicCreateChannelBuilder(_sdk); }
        }
        public UpdateChannel.UpdateChannelBuilder UpdateChannelOp
        {
            get { return new Operation.UpdateChannel.UpdateChannelBuilder(_sdk); }
        }
        public DeleteChannel.DeleteChannelBuilder DeleteChannelOp
        {
            get { return new Operation.DeleteChannel.DeleteChannelBuilder(_sdk); }
        }
        #endregion
        
        public Model.ModelsPaginatedGetChannelResponse? GetChannels(GetChannels input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? PublicCreateChannel(PublicCreateChannel input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? UpdateChannel(UpdateChannel input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteChannel(DeleteChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}