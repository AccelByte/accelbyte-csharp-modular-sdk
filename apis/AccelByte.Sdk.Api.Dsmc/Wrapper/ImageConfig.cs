// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class ImageConfig
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public ImageConfig(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public ImageConfig(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public UpdateImage.UpdateImageBuilder UpdateImageOp
        {
            get
            {
                var opBuilder = new Operation.UpdateImage.UpdateImageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateImage.CreateImageBuilder CreateImageOp
        {
            get
            {
                var opBuilder = new Operation.CreateImage.CreateImageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateImagePatch.CreateImagePatchBuilder CreateImagePatchOp
        {
            get
            {
                var opBuilder = new Operation.CreateImagePatch.CreateImagePatchBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListImages.ListImagesBuilder ListImagesOp
        {
            get
            {
                var opBuilder = new Operation.ListImages.ListImagesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteImage.DeleteImageBuilder DeleteImageOp
        {
            get
            {
                var opBuilder = new Operation.DeleteImage.DeleteImageBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetImageLimit.GetImageLimitBuilder GetImageLimitOp
        {
            get
            {
                var opBuilder = new Operation.GetImageLimit.GetImageLimitBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteImagePatch.DeleteImagePatchBuilder DeleteImagePatchOp
        {
            get
            {
                var opBuilder = new Operation.DeleteImagePatch.DeleteImagePatchBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetImageDetail.GetImageDetailBuilder GetImageDetailOp
        {
            get
            {
                var opBuilder = new Operation.GetImageDetail.GetImageDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetImagePatches.GetImagePatchesBuilder GetImagePatchesOp
        {
            get
            {
                var opBuilder = new Operation.GetImagePatches.GetImagePatchesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetImagePatchDetail.GetImagePatchDetailBuilder GetImagePatchDetailOp
        {
            get
            {
                var opBuilder = new Operation.GetImagePatchDetail.GetImagePatchDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetRepository.GetRepositoryBuilder GetRepositoryOp
        {
            get
            {
                var opBuilder = new Operation.GetRepository.GetRepositoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateRepository.CreateRepositoryBuilder CreateRepositoryOp
        {
            get
            {
                var opBuilder = new Operation.CreateRepository.CreateRepositoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListImagesClient.ListImagesClientBuilder ListImagesClientOp
        {
            get
            {
                var opBuilder = new Operation.ListImagesClient.ListImagesClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ImageLimitClient.ImageLimitClientBuilder ImageLimitClientOp
        {
            get
            {
                var opBuilder = new Operation.ImageLimitClient.ImageLimitClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ImageDetailClient.ImageDetailClientBuilder ImageDetailClientOp
        {
            get
            {
                var opBuilder = new Operation.ImageDetailClient.ImageDetailClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public UpdateImage.Response UpdateImage(UpdateImage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateImage.Response> UpdateImageAsync(UpdateImage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateImage.Response CreateImage(CreateImage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateImage.Response> CreateImageAsync(CreateImage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateImagePatch.Response CreateImagePatch(CreateImagePatch input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateImagePatch.Response> CreateImagePatchAsync(CreateImagePatch input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ListImages.Response ListImages(ListImages input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ListImages.Response> ListImagesAsync(ListImages input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteImage.Response DeleteImage(DeleteImage input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteImage.Response> DeleteImageAsync(DeleteImage input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetImageLimit.Response GetImageLimit(GetImageLimit input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetImageLimit.Response> GetImageLimitAsync(GetImageLimit input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteImagePatch.Response DeleteImagePatch(DeleteImagePatch input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteImagePatch.Response> DeleteImagePatchAsync(DeleteImagePatch input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetImageDetail.Response GetImageDetail(GetImageDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetImageDetail.Response> GetImageDetailAsync(GetImageDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetImagePatches.Response GetImagePatches(GetImagePatches input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetImagePatches.Response> GetImagePatchesAsync(GetImagePatches input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetImagePatchDetail.Response GetImagePatchDetail(GetImagePatchDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetImagePatchDetail.Response> GetImagePatchDetailAsync(GetImagePatchDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetRepository.Response GetRepository(GetRepository input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetRepository.Response> GetRepositoryAsync(GetRepository input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateRepository.Response CreateRepository(CreateRepository input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateRepository.Response> CreateRepositoryAsync(CreateRepository input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ListImagesClient.Response ListImagesClient(ListImagesClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ListImagesClient.Response> ListImagesClientAsync(ListImagesClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ImageLimitClient.Response ImageLimitClient(ImageLimitClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ImageLimitClient.Response> ImageLimitClientAsync(ImageLimitClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ImageDetailClient.Response ImageDetailClient(ImageDetailClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ImageDetailClient.Response> ImageDetailClientAsync(ImageDetailClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}