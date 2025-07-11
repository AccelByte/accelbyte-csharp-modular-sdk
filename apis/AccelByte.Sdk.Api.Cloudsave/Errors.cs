// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

/*
serviceName: Cloudsave

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Api.Cloudsave
{
    public static class CloudsaveErrors
    {
        public static readonly ApiError Error18001 = new ApiError("18001", "unable to get record");
        public static readonly ApiError Error18003 = new ApiError("18003", "record not found");
        public static readonly ApiError Error18004 = new ApiError("18004", "unable to retrieve list of key records");
        public static readonly ApiError Error18005 = new ApiError("18005", "unable to decode record");
        public static readonly ApiError Error18006 = new ApiError("18006", "unable to decode record");
        public static readonly ApiError Error18011 = new ApiError("18011", "invalid request body");
        public static readonly ApiError Error18012 = new ApiError("18012", "unable to marshal request body");
        public static readonly ApiError Error18013 = new ApiError("18013", "unable to save record");
        public static readonly ApiError Error18015 = new ApiError("18015", "invalid request body: size of the request body must be less than [%d]MB");
        public static readonly ApiError Error18020 = new ApiError("18020", "unable to get record");
        public static readonly ApiError Error18022 = new ApiError("18022", "record not found");
        public static readonly ApiError Error18023 = new ApiError("18023", "get action is forbidden on other user's record");
        public static readonly ApiError Error18030 = new ApiError("18030", "invalid request body");
        public static readonly ApiError Error18033 = new ApiError("18033", "unable to save record");
        public static readonly ApiError Error18035 = new ApiError("18035", "post action is forbidden on other user's record");
        public static readonly ApiError Error18040 = new ApiError("18040", "unable to delete record");
        public static readonly ApiError Error18050 = new ApiError("18050", "invalid request body");
        public static readonly ApiError Error18051 = new ApiError("18051", "unable to marshal request body");
        public static readonly ApiError Error18052 = new ApiError("18052", "invalid request body: size of the request body must be less than [%d]MB");
        public static readonly ApiError Error18053 = new ApiError("18053", "unable to update record");
        public static readonly ApiError Error18056 = new ApiError("18056", "precondition failed: record has changed");
        public static readonly ApiError Error18060 = new ApiError("18060", "invalid request body");
        public static readonly ApiError Error18061 = new ApiError("18061", "unable to update record");
        public static readonly ApiError Error18063 = new ApiError("18063", "put action is forbidden on other user's record");
        public static readonly ApiError Error18064 = new ApiError("18064", "validation error");
        public static readonly ApiError Error18065 = new ApiError("18065", "unable to update record");
        public static readonly ApiError Error18066 = new ApiError("18066", "precondition failed: record has changed");
        public static readonly ApiError Error18070 = new ApiError("18070", "unable to delete record");
        public static readonly ApiError Error18072 = new ApiError("18072", "delete action is forbidden on other user's record");
        public static readonly ApiError Error18080 = new ApiError("18080", "unable to get record");
        public static readonly ApiError Error18081 = new ApiError("18081", "record not found");
        public static readonly ApiError Error18083 = new ApiError("18083", "invalid request body");
        public static readonly ApiError Error18084 = new ApiError("18084", "unable to get record");
        public static readonly ApiError Error18090 = new ApiError("18090", "invalid request body");
        public static readonly ApiError Error18091 = new ApiError("18091", "unable to save record");
        public static readonly ApiError Error18100 = new ApiError("18100", "invalid request body");
        public static readonly ApiError Error18101 = new ApiError("18101", "unable to update record");
        public static readonly ApiError Error18102 = new ApiError("18102", "validation error");
        public static readonly ApiError Error18103 = new ApiError("18103", "precondition failed: record has changed");
        public static readonly ApiError Error18113 = new ApiError("18113", "invalid request body");
        public static readonly ApiError Error18114 = new ApiError("18114", "unable to retrieve list of key records");
        public static readonly ApiError Error18120 = new ApiError("18120", "unable to delete record");
        public static readonly ApiError Error18122 = new ApiError("18122", "record not found");
        public static readonly ApiError Error18124 = new ApiError("18124", "unable to get record");
        public static readonly ApiError Error18125 = new ApiError("18125", "invalid request body");
        public static readonly ApiError Error18126 = new ApiError("18126", "request record keys list exceed max size [%d]");
        public static readonly ApiError Error18128 = new ApiError("18128", "invalid request body");
        public static readonly ApiError Error18129 = new ApiError("18129", "request record keys list exceed max size [%d]");
        public static readonly ApiError Error18130 = new ApiError("18130", "unable to get record");
        public static readonly ApiError Error18131 = new ApiError("18131", "unable to decode record");
        public static readonly ApiError Error18133 = new ApiError("18133", "record not found");
        public static readonly ApiError Error18134 = new ApiError("18134", "invalid request body");
        public static readonly ApiError Error18135 = new ApiError("18135", "unable to marshal request body");
        public static readonly ApiError Error18136 = new ApiError("18136", "invalid request body: size of the request body must be less than [%d]MB");
        public static readonly ApiError Error18138 = new ApiError("18138", "unable to decode record");
        public static readonly ApiError Error18139 = new ApiError("18139", "unable to get record");
        public static readonly ApiError Error18140 = new ApiError("18140", "record not found");
        public static readonly ApiError Error18142 = new ApiError("18142", "unable to delete record");
        public static readonly ApiError Error18144 = new ApiError("18144", "invalid request body");
        public static readonly ApiError Error18145 = new ApiError("18145", "unable to marshal request body");
        public static readonly ApiError Error18146 = new ApiError("18146", "invalid request body: size of the request body must be less than [%d]MB");
        public static readonly ApiError Error18147 = new ApiError("18147", "unable to update record");
        public static readonly ApiError Error18149 = new ApiError("18149", "invalid request body");
        public static readonly ApiError Error18150 = new ApiError("18150", "invalid request body");
        public static readonly ApiError Error18151 = new ApiError("18151", "unable to get record");
        public static readonly ApiError Error18152 = new ApiError("18152", "record not found");
        public static readonly ApiError Error18154 = new ApiError("18154", "unable to delete record");
        public static readonly ApiError Error18156 = new ApiError("18156", "invalid request body");
        public static readonly ApiError Error18157 = new ApiError("18157", "unable to decode record");
        public static readonly ApiError Error18159 = new ApiError("18159", "invalid request body");
        public static readonly ApiError Error18160 = new ApiError("18160", "unable to retrieve list of key records");
        public static readonly ApiError Error18162 = new ApiError("18162", "unable to decode record");
        public static readonly ApiError Error18163 = new ApiError("18163", "unable to decode record");
        public static readonly ApiError Error18164 = new ApiError("18164", "unable to decode record");
        public static readonly ApiError Error18165 = new ApiError("18165", "unable to decode record");
        public static readonly ApiError Error18167 = new ApiError("18167", "record not found");
        public static readonly ApiError Error18168 = new ApiError("18168", "invalid request body");
        public static readonly ApiError Error18169 = new ApiError("18169", "request record keys list exceed max size [%d]");
        public static readonly ApiError Error18170 = new ApiError("18170", "unable to get record");
        public static readonly ApiError Error18171 = new ApiError("18171", "record not found");
        public static readonly ApiError Error18172 = new ApiError("18172", "unable to decode record");
        public static readonly ApiError Error18174 = new ApiError("18174", "invalid request body");
        public static readonly ApiError Error18175 = new ApiError("18175", "request record keys list exceed max size [%d]");
        public static readonly ApiError Error18176 = new ApiError("18176", "unable to get record");
        public static readonly ApiError Error18177 = new ApiError("18177", "record not found");
        public static readonly ApiError Error18178 = new ApiError("18178", "unable to decode record");
        public static readonly ApiError Error18180 = new ApiError("18180", "precondition failed: record has changed");
        public static readonly ApiError Error18181 = new ApiError("18181", "validation error");
        public static readonly ApiError Error18182 = new ApiError("18182", "unable to update record");
        public static readonly ApiError Error18183 = new ApiError("18183", "precondition failed: record has changed");
        public static readonly ApiError Error18184 = new ApiError("18184", "invalid request body");
        public static readonly ApiError Error18185 = new ApiError("18185", "unable to get record");
        public static readonly ApiError Error18186 = new ApiError("18186", "record not found");
        public static readonly ApiError Error18187 = new ApiError("18187", "unable to decode record");
        public static readonly ApiError Error18201 = new ApiError("18201", "invalid record operator, expect [%s] but actual [%s]");
        public static readonly ApiError Error18301 = new ApiError("18301", "unable to get record");
        public static readonly ApiError Error18303 = new ApiError("18303", "record not found");
        public static readonly ApiError Error18304 = new ApiError("18304", "invalid request body");
        public static readonly ApiError Error18305 = new ApiError("18305", "invalid request body");
        public static readonly ApiError Error18307 = new ApiError("18307", "unable to save record");
        public static readonly ApiError Error18309 = new ApiError("18309", "key already exists");
        public static readonly ApiError Error18310 = new ApiError("18310", "unable to get presigned URL");
        public static readonly ApiError Error18311 = new ApiError("18311", "invalid request body");
        public static readonly ApiError Error18312 = new ApiError("18312", "unable to get record");
        public static readonly ApiError Error18313 = new ApiError("18313", "record not found");
        public static readonly ApiError Error18314 = new ApiError("18314", "unable to get presigned URL");
        public static readonly ApiError Error18316 = new ApiError("18316", "invalid request body");
        public static readonly ApiError Error18317 = new ApiError("18317", "record not found");
        public static readonly ApiError Error18318 = new ApiError("18318", "unable to update record");
        public static readonly ApiError Error18320 = new ApiError("18320", "unable to delete record");
        public static readonly ApiError Error18322 = new ApiError("18322", "record not found");
        public static readonly ApiError Error18323 = new ApiError("18323", "unable to get record");
        public static readonly ApiError Error18325 = new ApiError("18325", "record not found");
        public static readonly ApiError Error18326 = new ApiError("18326", "invalid request body");
        public static readonly ApiError Error18327 = new ApiError("18327", "invalid request body");
        public static readonly ApiError Error18328 = new ApiError("18328", "unable to save record");
        public static readonly ApiError Error18330 = new ApiError("18330", "key already exists");
        public static readonly ApiError Error18331 = new ApiError("18331", "unable to get presigned URL");
        public static readonly ApiError Error18332 = new ApiError("18332", "invalid request body");
        public static readonly ApiError Error18333 = new ApiError("18333", "record not found");
        public static readonly ApiError Error18334 = new ApiError("18334", "unable to update record");
        public static readonly ApiError Error18336 = new ApiError("18336", "unable to delete record");
        public static readonly ApiError Error18338 = new ApiError("18338", "record not found");
        public static readonly ApiError Error18339 = new ApiError("18339", "unable to get record");
        public static readonly ApiError Error18340 = new ApiError("18340", "record not found");
        public static readonly ApiError Error18342 = new ApiError("18342", "invalid request body");
        public static readonly ApiError Error18343 = new ApiError("18343", "unable to get record");
        public static readonly ApiError Error18345 = new ApiError("18345", "unable to retrieve list of key records");
        public static readonly ApiError Error18347 = new ApiError("18347", "invalid request body");
        public static readonly ApiError Error18349 = new ApiError("18349", "unable to get record");
        public static readonly ApiError Error18350 = new ApiError("18350", "invalid request body");
        public static readonly ApiError Error18351 = new ApiError("18351", "request record keys list exceed max size [%d]");
        public static readonly ApiError Error18353 = new ApiError("18353", "invalid request body");
        public static readonly ApiError Error18354 = new ApiError("18354", "records amount exceeded max limit");
        public static readonly ApiError Error18355 = new ApiError("18355", "unable to marshal request body");
        public static readonly ApiError Error18356 = new ApiError("18356", "invalid request body: size of the request body must be less than [%d]MB");
        public static readonly ApiError Error18401 = new ApiError("18401", "invalid request body");
        public static readonly ApiError Error18402 = new ApiError("18402", "plugins already configured");
        public static readonly ApiError Error18404 = new ApiError("18404", "plugins not found");
        public static readonly ApiError Error18406 = new ApiError("18406", "plugins config not found");
        public static readonly ApiError Error18408 = new ApiError("18408", "invalid request body");
        public static readonly ApiError Error18409 = new ApiError("18409", "plugins config not found");
        public static readonly ApiError Error18502 = new ApiError("18502", "unable to list tags");
        public static readonly ApiError Error18503 = new ApiError("18503", "unable to list tags");
        public static readonly ApiError Error18505 = new ApiError("18505", "invalid request body");
        public static readonly ApiError Error18506 = new ApiError("18506", "tag already exists");
        public static readonly ApiError Error18507 = new ApiError("18507", "unable to create tag");
        public static readonly ApiError Error18509 = new ApiError("18509", "unable to delete tag");
        public static readonly ApiError Error18510 = new ApiError("18510", "tag not found");
        public static readonly ApiError Error20000 = new ApiError("20000", "internal server error");
        public static readonly ApiError Error20001 = new ApiError("20001", "unauthorized access");
        public static readonly ApiError Error20002 = new ApiError("20002", "validation error");
        public static readonly ApiError Error20013 = new ApiError("20013", "insufficient permission");
    }

    public class ModelsResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }


        public ApiError TranslateToApiError()
        {
            string errorCode = 
                ErrorCode != null ? ErrorCode.Value.ToString() :
                "";
            
            string errorMessage = 
                ErrorMessage != null ? ErrorMessage.ToString() :                
                "";
            
            return new ApiError(errorCode, errorMessage);
        }
    }

}