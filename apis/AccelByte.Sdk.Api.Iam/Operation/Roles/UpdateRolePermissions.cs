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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// UpdateRolePermissions
    ///
    /// ## The endpoint is going to be deprecated
    /// This endpoint will REPLACE role's permissions with the ones defined in body
    /// 
    /// Schedule contains cron string or date range (both are UTC, also in cron syntax) to indicate when a permission and action are in effect.
    /// Both schedule types accepts quartz compatible cron syntax e.g. * * * * * * *.
    /// In ranged schedule, first element will be start date, and second one will be end date
    /// If schedule is set, the scheduled action must be valid too, that is between 1 to 15, inclusive
    /// 
    /// Syntax reference
    /// Fields:
    /// 1. Seconds: 0-59 * / , -
    /// 2. Minutes: 0-59 * / , -
    /// 3. Hours: 0-23 * / , -
    /// 4. Day of month: 1-31 * / , - L W
    /// 5. Month: 1-12 JAN-DEC * / , -
    /// 6. Day of week: 0-6 SUN-SAT * / , - L #
    /// 7. Year: 1970-2099 * / , -
    /// 
    /// Special characters:
    /// 1. *: all values in the fields, e.g. * in seconds fields indicates every second
    /// 2. /: increments of ranges, e.g. 3-59/15 in the minute field indicate the third minute of the hour and every 15 minutes thereafter
    /// 3. ,: separate items of a list, e.g. MON,WED,FRI in day of week
    /// 4. -: range, e.g. 2010-2018 indicates every year between 2010 and 2018, inclusive
    /// 5. L: last, e.g. When used in the day-of-week field, it allows you to specify constructs such as "the last Friday" (5L) of a given month. In the day-of-month field, it specifies the last day of the month.
    /// 6. W: business day, e.g. if you were to specify 15W as the value for the day-of-month field, the meaning is: "the nearest business day to the 15th of the month."
    /// 7. #: must be followed by a number between one and five. It allows you to specify constructs such as "the second Friday" of a given month.
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/roles/{roleId}/permissions [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UpdateRolePermissions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRolePermissionsBuilder Builder { get => new UpdateRolePermissionsBuilder(); }

        public class UpdateRolePermissionsBuilder
            : OperationBuilder<UpdateRolePermissionsBuilder>
        {





            internal UpdateRolePermissionsBuilder() { }

            internal UpdateRolePermissionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateRolePermissions Build(
                AccountcommonPermissions body,
                string roleId
            )
            {
                UpdateRolePermissions op = new UpdateRolePermissions(this,
                    body,                    
                    roleId                    
                );

                op.SetBaseFields<UpdateRolePermissionsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public UpdateRolePermissions.Response Execute(
                AccountcommonPermissions body,
                string roleId
            )
            {
                UpdateRolePermissions op = Build(
                    body,
                    roleId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateRolePermissions.Response> ExecuteAsync(
                AccountcommonPermissions body,
                string roleId
            )
            {
                UpdateRolePermissions op = Build(
                    body,
                    roleId
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

        private UpdateRolePermissions(UpdateRolePermissionsBuilder builder,
            AccountcommonPermissions body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error404 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Roles::UpdateRolePermissions";
        }

        #endregion

        public UpdateRolePermissions(
            string roleId,            
            Model.AccountcommonPermissions body            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/permissions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateRolePermissions.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateRolePermissions.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }

            return response;
        }
    }

}