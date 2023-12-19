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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AddRolePermission
    ///
    /// ## The endpoint is going to be deprecated
    /// This endpoint will update existing permission (bitwise OR the action) if found one with same resource, otherwise it will append a new permission
    /// 
    /// Schedule contains cron string or date range (both are UTC, also in cron syntax) to indicate when a permission and action are in effect.
    /// Both schedule types accepts quartz compatible cron syntax e.g. * * * * * * *.
    /// In ranged schedule, first element will be start date, and second one will be end date
    /// If schedule is set, the scheduled action must be valid too, that is between 1 to 15, inclusive
    /// 
    /// Syntax reference
    /// Fields:
    /// - Seconds: 0-59 * / , -
    /// - Minutes: 0-59 * / , -
    /// - Hours: 0-23 * / , -
    /// - Day of month: 1-31 * / , - L W
    /// - Month: 1-12 JAN-DEC * / , -
    /// - Day of week: 0-6 SUN-SAT * / , - L #
    /// - Year: 1970-2099 * / , -
    /// 
    /// Special characters:
    /// - **: all values in the fields, e.g. * in seconds fields indicates every second
    /// - /: increments of ranges, e.g. 3-59/15 in the minute field indicate the third minute of the hour and every 15 minutes thereafter
    /// - ,: separate items of a list, e.g. MON,WED,FRI in day of week
    /// - -: range, e.g. 2010-2018 indicates every year between 2010 and 2018, inclusive
    /// - L: last, e.g. When used in the day-of-week field, it allows you to specify constructs such as "the last Friday" (5L) of a given month. In the day-of-month field, it specifies the last day of the month.
    /// - W: business day, e.g. if you were to specify 15W as the value for the day-of-month field, the meaning is: "the nearest business day to the 15th of the month."
    /// - #: must be followed by a number between one and five. It allows you to specify constructs such as "the second Friday" of a given month.
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint(update): _/iam/v3/admin/roles/{roleId}/permissions [PUT]_**
    /// - **Substitute endpoint(create): _/iam/v3/admin/roles/{roleId}/permissions [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AddRolePermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddRolePermissionBuilder Builder { get => new AddRolePermissionBuilder(); }

        public class AddRolePermissionBuilder
            : OperationBuilder<AddRolePermissionBuilder>
        {





            internal AddRolePermissionBuilder() { }

            internal AddRolePermissionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AddRolePermission Build(
                ModelUpdatePermissionScheduleRequest body,
                long action,
                string resource,
                string roleId
            )
            {
                AddRolePermission op = new AddRolePermission(this,
                    body,
                    action,
                    resource,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelUpdatePermissionScheduleRequest body,
                long action,
                string resource,
                string roleId
            )
            {
                AddRolePermission op = Build(
                    body,
                    action,
                    resource,
                    roleId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AddRolePermission(AddRolePermissionBuilder builder,
            ModelUpdatePermissionScheduleRequest body,
            long action,
            string resource,
            string roleId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddRolePermission(
            long action,
            string resource,
            string roleId,
            Model.ModelUpdatePermissionScheduleRequest body
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/permissions/{resource}/{action}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}