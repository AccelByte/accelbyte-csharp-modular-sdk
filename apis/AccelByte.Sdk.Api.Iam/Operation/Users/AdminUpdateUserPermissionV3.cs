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
    /// AdminUpdateUserPermissionV3
    ///
    /// This endpoint will REPLACE user's permissions with the ones defined in body
    /// Schedule contains cron string or date range (both are UTC, also in cron syntax) to indicate when a permission and action are in effect.
    /// Both schedule types accepts quartz compatible cron syntax e.g. * * * * * * *.
    /// In ranged schedule, first element will be start date, and second one will be end date
    /// If schedule is set, the scheduled action must be valid too, that is between 1 to 15, inclusive
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
    /// </summary>
    public class AdminUpdateUserPermissionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserPermissionV3Builder Builder { get => new AdminUpdateUserPermissionV3Builder(); }

        public class AdminUpdateUserPermissionV3Builder
            : OperationBuilder<AdminUpdateUserPermissionV3Builder>
        {





            internal AdminUpdateUserPermissionV3Builder() { }

            internal AdminUpdateUserPermissionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateUserPermissionV3 Build(
                AccountcommonPermissions body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserPermissionV3 op = new AdminUpdateUserPermissionV3(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminUpdateUserPermissionV3Builder>(this);
                return op;
            }

            public void Execute(
                AccountcommonPermissions body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserPermissionV3 op = Build(
                    body,
                    namespace_,
                    userId
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
                AccountcommonPermissions body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserPermissionV3 op = Build(
                    body,
                    namespace_,
                    userId
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

        private AdminUpdateUserPermissionV3(AdminUpdateUserPermissionV3Builder builder,
            AccountcommonPermissions body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateUserPermissionV3(
            string namespace_,
            string userId,
            Model.AccountcommonPermissions body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions";

        public override HttpMethod Method => HttpMethod.Put;

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