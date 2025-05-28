# Common Use Cases

## Achievement

Source: [AchievementTests.cs](../AccelByte.Sdk.Tests.Mod/Services/AchievementTests.cs)

### Create an achievement

```csharp
ModelsAchievementRequest newAchievement = new ModelsAchievementRequest()
{
    AchievementCode = achievement_code,
    DefaultLanguage = "en",
    Name = new Dictionary<string, string>()
    {
        {"en", achievement_name }
    },
    Description = new Dictionary<string, string>
    {
        {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
    },
    GoalValue = 1000.0,
    StatCode = achievement_code,
    Hidden = true,
    Incremental = false,
    LockedIcons = new List<ModelsIcon>()
    {
        new ModelsIcon()
        {
            Slug = "shield-locked",
            Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/50000f325ef841a6972a005779e20991.png"
        }
    },
    UnlockedIcons = new List<ModelsIcon>()
    {
        new ModelsIcon()
        {
            Slug = "shield-unlocked",
            Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/fe89fd07102f4057be202fbd3fdd9a21.png"
        }
    },
    Tags = new List<string>() { "sdk", "test", "csharp" }
};

ModelsAchievementResponse cResp = _Sdk.GetAchievementApi().Achievements.AdminCreateNewAchievementOp
    .Execute(newAchievement, _Sdk.Namespace).EnsureSuccess();
```

### Updating achievement

```csharp
ModelsAchievementUpdateRequest updateAchievement = new ModelsAchievementUpdateRequest()
{
    GoalValue = 2000.0,
    DefaultLanguage = "en",
    Name = new Dictionary<string, string>()
    {
        {"en", achievement_name }
    },
    Description = new Dictionary<string, string>
    {
        {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
    }
};

ModelsAchievementResponse uResp = _Sdk.GetAchievementApi().Achievements.AdminUpdateAchievementOp
    .Execute(updateAchievement, achievement_code, _Sdk.Namespace).EnsureSuccess();
```

### Retrieve achievement by code

```csharp
ModelsAchievementResponse rResp = _Sdk.GetAchievementApi().Achievements.AdminGetAchievementOp
    .Execute(achievement_code, _Sdk.Namespace).EnsureSuccess();
```

### Get all achievements

```csharp
ModelsPaginatedAchievementResponse gaResp = _Sdk.GetAchievementApi().Achievements.AdminListAchievementsOp
    .SetLimit(100)
    .SetOffset(0)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Delete an achievement

```csharp
_Sdk.GetAchievementApi().Achievements.AdminDeleteAchievementOp
    .Execute(achievement_code, _Sdk.Namespace)
    .EnsureSuccess();
```
## AMS

Source: [AmsTests.cs](../AccelByte.Sdk.Tests.Mod/Services/AmsTests.cs)

### Get images

```csharp
var imageList = _Sdk.GetAmsApi().Images.ImageListOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Create new fleet

```csharp
var newFleet = _Sdk.GetAmsApi().Fleets.FleetCreateOp
    .Execute(new ApiFleetParameters()
    {
        Active = false,
        Name = fleetName,
        ClaimKeys = ["beta"],
        Regions = [
           new ApiRegionConfig()
           {
               BufferSize = 10,
               Region = "us-west-1"
           }
        ],
        ImageDeploymentProfile = new ApiImageDeploymentProfile()
        {
            ImageId = imageId
        },
        DsHostConfiguration = new ApiDSHostConfigurationParameters()
        {
            InstanceId = instanceId,
            ServersPerVm = 1
        }
    }, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get fleet

```csharp
var getFleet = _Sdk.GetAmsApi().Fleets.FleetGetOp
    .Execute(fleetId, _Sdk.Namespace)
    .EnsureSuccess();
```

### Update fleet data

```csharp
_Sdk.GetAmsApi().Fleets.FleetUpdateOp
    .Execute(new ApiFleetParameters()
    {
        Name = fleetNameUpdate
    }, fleetId, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete fleet

```csharp
_Sdk.GetAmsApi().Fleets.FleetDeleteOp
    .Execute(fleetId, _Sdk.Namespace)
    .EnsureSuccess();
```
## Basic

Source: [BasicTests.cs](../AccelByte.Sdk.Tests.Mod/Services/BasicTests.cs)

### Create user's own profile info

```csharp
UserProfilePrivateCreate createProfile = new UserProfilePrivateCreate()
{
    FirstName = "Integration Test",
    LastName = "CSharp Extend SDK",
    DateOfBirth = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
    Language = "en"
};

UserProfilePrivateInfo cInfo = _Sdk.GetBasicApi().UserProfile.CreateMyProfileOp
    .SetBody(createProfile)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Get user's own profile info

```csharp
UserProfilePrivateInfo ownResp = _Sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Update user's own profile info

```csharp
UserProfileUpdate updateProfile = new UserProfileUpdate()
{
    TimeZone = "Asia/Jakarta"
};

UserProfilePrivateInfo updResp = _Sdk.GetBasicApi().UserProfile.UpdateMyProfileOp
    .SetBody(updateProfile)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Delete user's own profile info

```csharp
var delResp = _Sdk.GetBasicApi().UserProfile.DeleteUserProfileOp
    .Execute(_Sdk.Namespace, userId);
```
## Chat

Source: [ChatTests.cs](../AccelByte.Sdk.Tests.Mod/Services/ChatTests.cs)

### Register a new profanity word

```csharp
var createResult = _Sdk.GetChatApi().Profanity.AdminProfanityCreateOp
    .Execute(new ModelsDictionaryInsertRequest()
    {
        Word = profanityWord,
        WordType = "PROFANITY"
    }, _Sdk.Namespace).EnsureSuccess();
```

### Query profanity word

```csharp
var queryResults = _Sdk.GetChatApi().Profanity.AdminProfanityQueryOp
    .SetIncludeChildren(false)
    .SetWordType("PROFANITY")
    .SetStartWith(profanityWord)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Update profanity word

```csharp
var updateResponse = _Sdk.GetChatApi().Profanity.AdminProfanityUpdateOp
    .Execute(new ModelsDictionaryUpdateRequest()
    {
        WordType = "PROFANITY",
        Word = editProfanityWord
    }, word.Id!, _Sdk.Namespace);
```

### Delete profanity word

```csharp
var delResponse = _Sdk.GetChatApi().Profanity.AdminProfanityDeleteOp
    .Execute(word.Id!, _Sdk.Namespace);
delResponse.ThrowExceptionIfError();
```

### Add chat inbox category

```csharp
var insertResult = _Sdk.GetChatApi().Inbox.AdminAddInboxCategoryOp
    .Execute(new ModelsAddInboxCategoryRequest()
    {
        ExpiresIn = 3600000000,
        Name = inboxName

    }, _Sdk.Namespace).EnsureSuccess();
```

### Get chat inbox categories

```csharp
var getResult = _Sdk.GetChatApi().Inbox.AdminGetInboxCategoriesOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Update chat inbox category

```csharp
_Sdk.GetChatApi().Inbox.AdminUpdateInboxCategoryOp
    .Execute(new ModelsUpdateInboxCategoryRequest()
    {
        ExpiresIn = 1800000000
    }, inboxName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete chat inbox category

```csharp
_Sdk.GetChatApi().Inbox.AdminDeleteInboxCategoryOp
    .Execute(inboxName, _Sdk.Namespace)
    .EnsureSuccess();
```
## CloudSave

Source: [CloudSaveTests.cs](../AccelByte.Sdk.Tests.Mod/Services/CloudSaveTests.cs)

### Create new game record

```csharp
ModelsGameRecordRequestForTest gameRecord = new ModelsGameRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "foo",
    FooValue = 4893
};

_Sdk.GetCloudsaveApi().PublicGameRecord.PostGameRecordHandlerV1Op
    .Execute(gameRecord, "foo_bar_record", _Sdk.Namespace)
    .EnsureSuccess();
```

### Get game record

```csharp
ModelsGameRecordResponse? gRecord = _Sdk.GetCloudsaveApi().PublicGameRecord.GetGameRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace)
    .EnsureSuccess();
```

### Update game record

```csharp
ModelsGameRecordRequestForTest updateRecord = new ModelsGameRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "update",
    FooValue = 4893
};

_Sdk.GetCloudsaveApi().PublicGameRecord.PutGameRecordHandlerV1Op
    .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete game record

```csharp
_Sdk.GetCloudsaveApi().PublicGameRecord.DeleteGameRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace)
    .EnsureSuccess();
```

### Create new player record

```csharp
ModelsPlayerRecordRequestForTest playerRecord = new ModelsPlayerRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "foo",
    FooValue = 4893
};

_Sdk.GetCloudsaveApi().PublicPlayerRecord.PostPlayerRecordHandlerV1Op
    .Execute(playerRecord, "foo_bar_record", _Sdk.Namespace, userId)
    .EnsureSuccess();
```

### Get player record

```csharp
ModelsPlayerRecordResponse? gRecord = _Sdk.GetCloudsaveApi().PublicPlayerRecord.GetPlayerRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace, userId)
    .EnsureSuccess();
```

### Update player record

```csharp
ModelsPlayerRecordRequestForTest updateRecord = new ModelsPlayerRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "update",
    FooValue = 4893
};

_Sdk.GetCloudsaveApi().PublicPlayerRecord.PutPlayerRecordHandlerV1Op
    .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace, userId)
    .EnsureSuccess();
```

### Delete player record

```csharp
_Sdk.GetCloudsaveApi().PublicPlayerRecord.DeletePlayerRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace, userId)
    .EnsureSuccess();
```
## CSM

Source: [CsmTests.cs](../AccelByte.Sdk.Tests.Mod/Services/CsmTests.cs)

### Create an Extend app

```csharp
var createdApp = _Sdk.GetCsmApi().AppV2.CreateAppV2Op
    .Execute(new ApimodelCreateAppV2Request()
    {
        Description = "C# Extend SDK integration test app.",
        Scenario = "function-override"
    }, appName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get an Extend app

```csharp
var app = _Sdk.GetCsmApi().AppV2.GetAppV2Op
    .Execute(appName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Create new env secret entry

```csharp
var newSecret = _Sdk.GetCsmApi().ConfigurationV2.SaveSecretV2Op
    .Execute(new ApimodelSaveConfigurationV2Request()
    {
        ConfigName = envSecretKey,
        Description = "",
        Value = envSecretValue,
        Source = "plaintext",
        ApplyMask = true
    }, appName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get list of env secrets

```csharp
var getSecrets = _Sdk.GetCsmApi().ConfigurationV2.GetListOfSecretsV2Op
    .SetOffset(0)
    .SetLimit(500)
    .Execute(appName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Update env secret

```csharp
var updateSecret = _Sdk.GetCsmApi().ConfigurationV2.UpdateSecretV2Op
    .Execute(new ApimodelUpdateConfigurationV2Request()
    {
        Value = envSecretValueNew
    }, appName, secretId, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete env secret

```csharp
_Sdk.GetCsmApi().ConfigurationV2.DeleteSecretV2Op
    .Execute(appName, secretId, _Sdk.Namespace)
    .EnsureSuccess();
```

### Create new env variable entry

```csharp
var newVariable = _Sdk.GetCsmApi().ConfigurationV2.SaveVariableV2Op
    .Execute(new ApimodelSaveConfigurationV2Request()
    {
        ConfigName = envVariableKey,
        Description = "",
        Value = envVariableValue,
        Source = "plaintext"
    }, appName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get list of env variables

```csharp
var getVariables = _Sdk.GetCsmApi().ConfigurationV2.GetListOfVariablesV2Op
    .SetOffset(0)
    .SetLimit(500)
    .Execute(appName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Update env variable

```csharp
var updateVariable = _Sdk.GetCsmApi().ConfigurationV2.UpdateVariableV2Op
    .Execute(new ApimodelUpdateConfigurationV2Request()
    {
        Value = envVariableValueNew
    }, appName, variableId, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete env variable

```csharp
_Sdk.GetCsmApi().ConfigurationV2.DeleteVariableV2Op
    .Execute(appName, variableId, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete an Extend app

```csharp
_Sdk.GetCsmApi().AppV2.DeleteAppV2Op
    .SetForced("true")
    .Execute(appName, _Sdk.Namespace);
```
## GameTelemetry

Source: [GameTelemetryTests.cs](../AccelByte.Sdk.Tests.Mod/Services/GameTelemetryTests.cs)

### Save game telemetry event

```csharp
_Sdk.GetGametelemetryApi().GametelemetryOperations.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostOp
    .Execute(new List<TelemetryBody>
    {
        new TelemetryBody
        {
            EventName = "CsharpEvent",
            EventNamespace = "test",
            Payload = new Dictionary<string, object>
            {
                {"foo", "bar"}
            }
        }
    })
    .EnsureSuccess();
```
## GDPR

Source: [GdprTests.cs](../AccelByte.Sdk.Tests.Mod/Services/GdprTests.cs)

### Save e-mail configuration

```csharp
_Sdk.GetGdprApi().Configuration.SaveAdminEmailConfigurationOp
    .Execute(new List<string>
    {
        firstEmailToTest
    }, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get e-mail configuration

```csharp
List<string>? emails = _Sdk.GetGdprApi().Configuration.GetAdminEmailConfigurationOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Update e-mail configuration

```csharp
_Sdk.GetGdprApi().Configuration.UpdateAdminEmailConfigurationOp
    .Execute(new List<string>() { anotherEmailToTest }, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete e-mail configuration

```csharp
_Sdk.GetGdprApi().Configuration.DeleteAdminEmailConfigurationOp
    .Execute(_Sdk.Namespace, new List<string>() { anotherEmailToTest })
    .EnsureSuccess();
```

### Get user personal data request

```csharp
var pdRequest = _Sdk.GetGdprApi().DataRetrieval.AdminGetUserPersonalDataRequestsOp
    .SetOffset(0)
    .SetLimit(10)
    .Execute(_Sdk.Namespace, userId)
    .EnsureSuccess();
```
## Group

Source: [GroupTests.cs](../AccelByte.Sdk.Tests.Mod/Services/GroupTests.cs)

### Create group configuration

```csharp
ModelsCreateGroupConfigurationRequestV1 gcRequest = new ModelsCreateGroupConfigurationRequestV1()
{
    ConfigurationCode = configuration_code,
    Description = "CSharp SDK Test Configuration Group",
    GroupMaxMember = 50,
    Name = "CSharp SDK Test Configuration Group",
    GroupAdminRoleId = defaultAdminRoleId,
    GroupMemberRoleId = defaultMemberRoleId
};

var createResponse = _Sdk.GetGroupApi().Configuration.CreateGroupConfigurationAdminV1Op
    .Execute(gcRequest, _Sdk.Namespace);
```

### Create a group

```csharp
ModelsPublicCreateNewGroupRequestV1 createGroup = new ModelsPublicCreateNewGroupRequestV1()
{
    GroupName = groupName,
    GroupType = "PUBLIC",
    GroupDescription = "Yeah, anyone is welcome here.",
    GroupMaxMember = 100,
    GroupRegion = "us",
    ConfigurationCode = configuration_code
};

ModelsGroupResponseV1 cGroup = _Sdk.GetGroupApi().Group.CreateNewGroupPublicV1Op
    .Execute(createGroup, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get single group

```csharp
ModelsGroupResponseV1 gGroup = _Sdk.GetGroupApi().Group.GetSingleGroupPublicV1Op
    .Execute(group_id, _Sdk.Namespace)
    .EnsureSuccess();
```

### Update a group

```csharp
ModelsUpdateGroupRequestV1 updateGroup = new ModelsUpdateGroupRequestV1()
{
    GroupDescription = "Updated description."
};

ModelsGroupResponseV1 uGroup = _Sdk.GetGroupApi().Group.UpdateSingleGroupV1Op
    .Execute(updateGroup, group_id, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete a group

```csharp
_Sdk.GetGroupApi().Group.DeleteGroupPublicV1Op
    .Execute(group_id, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete group configuration

```csharp
_Sdk.GetGroupApi().Configuration.DeleteGroupConfigurationV1Op
    .Execute(configuration_code, _Sdk.Namespace)
    .EnsureSuccess();
```
## IAM

Source: [IAMTests.cs](../AccelByte.Sdk.Tests.Mod/Services/IAMTests.cs)

### Create a user (V3)

```csharp
ModelUserCreateRequestV3 newUser = new ModelUserCreateRequestV3()
{
    AuthType = "EMAILPASSWD",
    EmailAddress = user_email,
    Password = user_password,
    DisplayName = "CSharp Server SDK Test",
    Country = "ID",
    DateOfBirth = "1995-01-10",
    UniqueDisplayName = user_name
};

ModelUserCreateResponseV3 cuResp = _Sdk.GetIamApi().Users.PublicCreateUserV3Op
    .Execute(newUser, _Sdk.Namespace)
    .EnsureSuccess();
```

### Create a user

```csharp
AccountCreateUserRequestV4 newUser = new AccountCreateUserRequestV4()
{
    AuthType = "EMAILPASSWD",
    EmailAddress = user_email,
    Password = user_password,
    DisplayName = "CSharp Server SDK Test",
    Username = user_name,
    Country = "ID",
    DateOfBirth = "1995-01-10",
    UniqueDisplayName = user_name
};

AccountCreateUserResponseV4 cuResp = _Sdk.GetIamApi().UsersV4.PublicCreateUserV4Op
    .Execute(newUser, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get user data by user id

```csharp
ModelUserResponseV3 gUser = _Sdk.GetIamApi().Users.AdminGetUserByUserIdV3Op
    .Execute(_Sdk.Namespace, user_id)
    .EnsureSuccess();
```

### Update a user

```csharp
ModelUserUpdateRequestV3 updateUser = new ModelUserUpdateRequestV3()
{
    DateOfBirth = "1996-01-10"
};

ModelUserResponseV3 uuResp = _Sdk.GetIamApi().UsersV4.AdminUpdateUserV4Op
    .Execute(updateUser, _Sdk.Namespace, user_id)
    .EnsureSuccess();
```

### Delete a user

```csharp
_Sdk.GetIamApi().Users.AdminDeleteUserInformationV3Op
    .Execute(_Sdk.Namespace, user_id)
    .EnsureSuccess();
```
## Leaderboard

Source: [LeaderboardTests.cs](../AccelByte.Sdk.Tests.Mod/Services/LeaderboardTests.cs)

### Create a leaderboard

```csharp
ModelsLeaderboardConfigReq newLeaderboard = new ModelsLeaderboardConfigReq()
{
    LeaderboardCode = leaderboard_code,
    Name = leaderboard_name,
    StatCode = stat_code,
    SeasonPeriod = 36,
    Descending = false,
    StartTime = start_time,
    Daily = new ModelsDailyConfig()
    {
        ResetTime = "00:00:00"
    },
    Weekly = new ModelsWeeklyConfig()
    {
        ResetDay = 0,
        ResetTime = "00:00:00"
    },
    Monthly = new ModelsMonthlyConfig()
    {
        ResetDate = 1,
        ResetTime = "00:00:00"
    }
};

ModelsLeaderboardConfigReq cLeaderboard = _Sdk.GetLeaderboardApi().LeaderboardConfiguration.CreateLeaderboardConfigurationAdminV1Op
    .Execute(newLeaderboard, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get a leaderboard

```csharp
ModelsGetLeaderboardConfigResp gLeaderboard = _Sdk.GetLeaderboardApi().LeaderboardConfiguration.GetLeaderboardConfigurationAdminV1Op
    .Execute(leaderboard_code, _Sdk.Namespace)
    .EnsureSuccess();
```

### Update a leaderboard

```csharp
ModelsUpdateLeaderboardConfigReq updateLeaderboard = new ModelsUpdateLeaderboardConfigReq()
{
    Name = leaderboard_name,
    StatCode = stat_code,
    StartTime = start_time,
    SeasonPeriod = 40
};

ModelsGetLeaderboardConfigResp uLeaderboard = _Sdk.GetLeaderboardApi().LeaderboardConfiguration.UpdateLeaderboardConfigurationAdminV1Op
    .Execute(updateLeaderboard, leaderboard_code, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete a leaderboard

```csharp
_Sdk.GetLeaderboardApi().LeaderboardConfiguration.DeleteLeaderboardConfigurationAdminV1Op
    .Execute(leaderboard_code, _Sdk.Namespace)
    .EnsureSuccess();
```
## Legal

Source: [LegalTests.cs](../AccelByte.Sdk.Tests.Mod/Services/LegalTests.cs)

### Get all legal policies

```csharp
List<RetrieveBasePolicyResponse>? bPolicies = _Sdk.GetLegalApi().BaseLegalPolicies.RetrieveAllLegalPoliciesOp
    .Execute()
    .EnsureSuccess();
```

### Create a policy for marketing preference.

```csharp
CreateBasePolicyRequest createPolicy = new CreateBasePolicyRequest()
{
    TypeId = marketingPrefPolicyTypeId,
    BasePolicyName = basePolicyName,
    Description = "Testing CSharp Server SDK legal endpoints.",
    Namespace = _Sdk.Namespace,
    Tags = new List<string>() { "csharp", "server_sdk", "test" },
    AffectedCountries = new List<string>() { "ID" },
    AffectedClientIds = new List<string>()
};

CreateBasePolicyResponse bPolResp = _Sdk.GetLegalApi().BaseLegalPolicies.CreatePolicyOp
    .SetBody(createPolicy)
    .Execute()
    .EnsureSuccess();
```

### Get single policy by policy id

```csharp
List<RetrievePolicyVersionResponse> polVers = _Sdk.GetLegalApi().PolicyVersions.RetrieveSinglePolicyVersionOp
    .Execute(targetPolicyId)
    .EnsureSuccess();
```

### Create policy version

```csharp
CreatePolicyVersionResponse polVerResp = _Sdk.GetLegalApi().PolicyVersions.CreatePolicyVersionOp
    .SetBody(policyVersion)
    .Execute(targetPolicyId)
    .EnsureSuccess();
```

### Accepting an aggrement policy

```csharp
List<AcceptAgreementRequest> aggreementRequests = new List<AcceptAgreementRequest>()
{
    new AcceptAgreementRequest()
    {
        LocalizedPolicyVersionId = targetLocalizedPolicyId,
        PolicyVersionId = targetPolicyVersionId,
        PolicyId = targetPolicyId,
        IsAccepted = true,
        IsNeedToSendEventMarketing = false
    }
};

string userId = _Sdk.Configuration.Credential!.UserId;
_Sdk.GetLegalApi().Agreement.ChangePreferenceConsentOp
    .SetBody(aggreementRequests)
    .Execute(_Sdk.Namespace, userId)
    .EnsureSuccess();
```

### Bulk accept policy

```csharp
_Sdk.GetLegalApi().Agreement.BulkAcceptVersionedPolicyOp
    .SetBody(aggreementRequests)
    .Execute()
    .EnsureSuccess();
```

### Get aggrements

```csharp
List<RetrieveAcceptedAgreementResponse> aggrs = _Sdk.GetLegalApi().Agreement.RetrieveAgreementsPublicOp
    .Execute()
    .EnsureSuccess();
```
## Lobby

Source: [LobbyTests.cs](../AccelByte.Sdk.Tests.Mod/Services/LobbyTests.cs)

### Send free form notification

```csharp
ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
{
    Topic = "csharp_sdk_test",
    Message = "This is integration test for CSharp Extend SDK."
};

_Sdk.GetLobbyApi().Admin.FreeFormNotificationOp
    .Execute(notifBody, _Sdk.Namespace)
    .EnsureSuccess();
```

### Export config

```csharp
var exportStream = _Sdk.GetLobbyApi().Config.AdminExportConfigV1Op
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```
## MatchmakingV2

Source: [MatchV2Tests.cs](../AccelByte.Sdk.Tests.Mod/Services/MatchV2Tests.cs)

### Create a match rule set

```csharp
ApiRuleSetPayload cRuleSetBody = new ApiRuleSetPayload()
{
    Name = rulesetName,
    Data = JsonSerializer.Deserialize<Dictionary<string, object>>(@"
        {
            ""alliance"": {
                ""min_number"": 2,
                ""max_number"": 10,
                ""player_min_number"": 2,
                ""player_max_number"": 4
            },
            ""matchingRules"": [
                {
                ""attribute"": """",
                ""criteria"": ""distance"",
                ""reference"": """"
                }
            ],
            ""flexingRules"": [
                {
                ""duration"": 600,
                ""attribute"": """",
                ""criteria"": ""distance"",
                ""reference"": """"
                }
            ],
            ""match_options"": {
                ""options"": [
                {
                    ""name"": ""myopt"",
                    ""type"": ""any""
                }
                ]
            },
            ""alliance_flexing_rule"": [
                {
                ""duration"": 600,
                ""min_number"": 1,
                ""max_number"": 2,
                ""player_min_number"": 1,
                ""player_max_number"": 2
                }
            ]
        }
    ")
};

_Sdk.GetMatch2Api().RuleSets.CreateRuleSetOp
    .Execute(cRuleSetBody, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get ruleset details

```csharp
var rulesetPayload = _Sdk.GetMatch2Api().RuleSets.RuleSetDetailsOp
    .Execute(_Sdk.Namespace, rulesetName)
    .EnsureSuccess();
```

### Create a match pool

```csharp
ApiMatchPool createPoolBody = new ApiMatchPool()
{
    Name = poolName,
    MatchFunction = "basic",
    SessionTemplate = cfgTemplateName,
    BackfillTicketExpirationSeconds = 600,
    RuleSet = rulesetName,
    TicketExpirationSeconds = 600
};

_Sdk.GetMatch2Api().MatchPools.CreateMatchPoolOp
    .Execute(createPoolBody, _Sdk.Namespace)
    .EnsureSuccess();
```

### List match pools

```csharp
ApiListMatchPoolsResponse poolList = _Sdk.GetMatch2Api().MatchPools.MatchPoolListOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Get match pool detail

```csharp
ApiMatchPool matchPool = _Sdk.GetMatch2Api().MatchPools.MatchPoolDetailsOp
    .Execute(_Sdk.Namespace, poolName)
    .EnsureSuccess();
```

### User create a match ticket

```csharp
ApiMatchTicketRequest ticketRequest = new ApiMatchTicketRequest()
{
    MatchPool = poolName,
    SessionID = partyId
};

ApiMatchTicketResponse nTicketResponse = sdk.GetMatch2Api().MatchTickets.CreateMatchTicketOp
    .Execute(ticketRequest, sdk.Namespace)
    .EnsureSuccess();
```

### User delete a match ticket

```csharp
sdk.GetMatch2Api().MatchTickets.DeleteMatchTicketOp
    .Execute(sdk.Namespace, ticketId)
    .EnsureSuccess();
```

### Delete a match pool

```csharp
_Sdk.GetMatch2Api().MatchPools.DeleteMatchPoolOp
    .Execute(_Sdk.Namespace, poolName)
    .EnsureSuccess();
```

### Delete a match rule set

```csharp
_Sdk.GetMatch2Api().RuleSets.DeleteRuleSetOp
    .Execute(_Sdk.Namespace, rulesetName)
    .EnsureSuccess();
```

### List match functions

```csharp
ApiListMatchFunctionsResponse response = _Sdk.GetMatch2Api().MatchFunctions.MatchFunctionListOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```
## Platform

Source: [PlatformTests.cs](../AccelByte.Sdk.Tests.Mod/Services/PlatformTests.cs)

### Create a store

```csharp
StoreCreate createStore = new StoreCreate()
{
    Title = "CSharp SDK Store Test",
    Description = "Description for CSharp Extend SDK store service integration test.",
    DefaultLanguage = "en",
    DefaultRegion = "US",
    SupportedLanguages = new List<string>() { "en", "id" },
    SupportedRegions = new List<string>() { "US", "ID" }
};

StoreInfo cStore = _Sdk.GetPlatformApi().Store.CreateStoreOp
    .Execute(createStore, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get a store

```csharp
StoreInfo gStore = _Sdk.GetPlatformApi().Store.GetStoreOp
    .Execute(_Sdk.Namespace, store_id)
    .EnsureSuccess();
```

### Update a store

```csharp
StoreUpdate updateStore = new StoreUpdate()
{
    Description = "Updated description."
};
StoreInfo cStoreUpdate = _Sdk.GetPlatformApi().Store.UpdateStoreOp
    .Execute(updateStore, _Sdk.Namespace, store_id)
    .EnsureSuccess();
```

### Delete a store

```csharp
StoreInfo dStore = _Sdk.GetPlatformApi().Store.DeleteStoreOp
    .Execute(_Sdk.Namespace, store_id)
    .EnsureSuccess();
```

### Export a store

```csharp
ExportStoreRequest xRequest = new ExportStoreRequest();
Stream stream = _Sdk.GetPlatformApi().Store.ExportStore1Op
    .SetBody(xRequest)
    .Execute(_Sdk.Namespace, store_id)
    .EnsureSuccess();
```

### Import store

```csharp
ImportStoreResult result = _Sdk.GetPlatformApi().Store.ImportStore1Op
    .SetFile(uploadStream)
    .SetStoreId(store_id)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Export reward

```csharp
var exportStream = _Sdk.GetPlatformApi().Reward.ExportRewardsOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Import reward

```csharp
_Sdk.GetPlatformApi().Reward.ImportRewardsOp
    .SetFile(dataStream)
    .Execute(_Sdk.Namespace, true)
    .EnsureSuccess();
```
## Reporting

Source: [ReportingTests.cs](../AccelByte.Sdk.Tests.Mod/Services/ReportingTests.cs)

### Create a Reason

```csharp
RestapiCreateReasonRequest createReason = new RestapiCreateReasonRequest()
{
    Description = reasonTitle,
    GroupIds = new List<string>(),
    Title = reasonTitle,
};

RestapiAdminReasonResponse cReason = _Sdk.GetReportingApi().AdminReasons.CreateReasonOp
    .Execute(createReason, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get single Reason

```csharp
RestapiAdminReasonResponse cReason2 = _Sdk.GetReportingApi().AdminReasons.AdminGetReasonOp
    .Execute(_Sdk.Namespace, reasonId)
    .EnsureSuccess();
```

### Submit report

```csharp
var reportResponse = _Sdk.GetReportingApi().PublicReports.SubmitReportOp
.Execute(new RestapiSubmitReportRequest()
{
    UserId = player1.UserId,
    Category = RestapiSubmitReportRequestCategory.UGC,
    Reason = reasonTitle,
    AdditionalInfo = [],
    Comment = reasonTitle,
    ExtensionCategory = "UGC",
    ObjectId = Guid.NewGuid().ToString().Replace("-", ""),
    ObjectType = "file"
}, _Sdk.Namespace);
```

### Delete a reason

```csharp
_Sdk.GetReportingApi().AdminReasons.DeleteReasonOp
    .Execute(_Sdk.Namespace, reasonId)
    .EnsureSuccess();
```
## SeasonPass

Source: [SeasonPassTests.cs](../AccelByte.Sdk.Tests.Mod/Services/SeasonPassTests.cs)

### Create a season

```csharp
Dictionary<string, Api.Seasonpass.Model.Localization> sLocalizations = new Dictionary<string, Api.Seasonpass.Model.Localization>()
{
    {"en", new Api.Seasonpass.Model.Localization()
        {
            Title = "English",
            Description = "English"
        }}
};

SeasonCreate cSeasonBody = new SeasonCreate()
{
    Name = nameSeason,
    Start = startTime,
    End = endTime,
    DefaultRequiredExp = 3,
    DraftStoreId = defaultDraftStoreId,
    TierItemId = defaultTierItemId,
    Localizations = sLocalizations
};

SeasonInfo cSeason = _Sdk.GetSeasonpassApi().Season.CreateSeasonOp
    .SetBody(cSeasonBody)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Get a season

```csharp
SeasonInfo gSeason = _Sdk.GetSeasonpassApi().Season.GetSeasonOp
    .Execute(_Sdk.Namespace, cSeasonId)
    .EnsureSuccess();
```

### Update a season

```csharp
SeasonUpdate uSeasonBody = new SeasonUpdate()
{
    Name = "CSharpServerSDKTestSeasonUpdate",
    Start = startTime,
    End = endTime,
    DefaultRequiredExp = 3,
    DraftStoreId = defaultDraftStoreId,
    TierItemId = defaultTierItemId,
    Localizations = sLocalizations
};

SeasonInfo uSeason = _Sdk.GetSeasonpassApi().Season.UpdateSeasonOp
    .SetBody(uSeasonBody)
    .Execute(_Sdk.Namespace, cSeasonId)
    .EnsureSuccess();
```

## Session

Source: [SessionTests.cs](../AccelByte.Sdk.Tests.Mod/Services/SessionTests.cs)

### Create session configuration template

```csharp
ApimodelsCreateConfigurationTemplateRequest cTemplateBody = new ApimodelsCreateConfigurationTemplateRequest()
{
    Name = cfgTemplateName,
    Type = "P2P",
    MinPlayers = 2,
    MaxPlayers = 2,
    InviteTimeout = 60,
    InactiveTimeout = 60,
    Joinability = "OPEN",
    ClientVersion = "1.0.0",
    RequestedRegions = new List<string>()
    {
        "us-west-2"
    }
};

_Sdk.GetSessionApi().ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
    .Execute(cTemplateBody, _Sdk.Namespace)
    .EnsureSuccess();

ApimodelsConfigurationTemplateResponse cfgTemplate = _Sdk.GetSessionApi().ConfigurationTemplate.AdminGetConfigurationTemplateV1Op
    .Execute(cfgTemplateName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Update session configuration template

```csharp
ApimodelsUpdateConfigurationTemplateRequest uTemplateBody = new ApimodelsUpdateConfigurationTemplateRequest()
{
    Name = cfgTemplateName,
    Type = "P2P",
    Joinability = "OPEN",
    MaxPlayers = 4
};

ApimodelsConfigurationTemplateResponse uptTemplate = _Sdk.GetSessionApi().ConfigurationTemplate.AdminUpdateConfigurationTemplateV1Op
    .Execute(uTemplateBody, cfgTemplateName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Delete session configuration template

```csharp
_Sdk.GetSessionApi().ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
    .Execute(cfgTemplateName, _Sdk.Namespace)
    .EnsureSuccess();
```

### Create a game session

```csharp
ApimodelsCreateGameSessionRequest newGSRequest = new ApimodelsCreateGameSessionRequest()
{
    ConfigurationName = cfgTemplateName,
};

ApimodelsGameSessionResponse newGSResponse = sdk.GetSessionApi().GameSession.CreateGameSessionOp
    .Execute(newGSRequest, sdk.Namespace)
    .EnsureSuccess();
```

### Join a game session

```csharp
ApimodelsGameSessionResponse p2GsJoin = sdk.GetSessionApi().GameSession.JoinGameSessionOp
    .Execute(sdk.Namespace, gameSessionId)
    .EnsureSuccess();
```

### Leave a game session

```csharp
sdk.GetSessionApi().GameSession.LeaveGameSessionOp
    .Execute(sdk.Namespace, gameSessionId)
    .EnsureSuccess();
```

### Delete a game session

```csharp
sdk.GetSessionApi().GameSession.DeleteGameSessionOp
    .Execute(sdk.Namespace, gameSessionId)
    .EnsureSuccess();
```

### Admin delete bulk game session

```csharp
var deleteResponse = _Sdk.GetSessionApi().GameSession.AdminDeleteBulkGameSessionsOp
    .Execute(new ApimodelsDeleteBulkGameSessionRequest()
    {
        Ids = [newGameSessionId]
    }, _Sdk.Namespace)
    .EnsureSuccess();
```

### Query game sessions

```csharp
var response = _Sdk.GetSessionApi().GameSession.PublicQueryGameSessionsByAttributesOp
    .Execute(new Dictionary<string, object>() { }, _Sdk.Namespace)
    .EnsureSuccess();
```

### User create a party

```csharp
ApimodelsCreatePartyRequest partyRequest = new ApimodelsCreatePartyRequest()
{
    ConfigurationName = cfgTemplateName,
    Members = new List<ApimodelsRequestMember>()
    {
        new ApimodelsRequestMember()
        {
            ID = player.UserId
        }
    }
};

ApimodelsPartySessionResponse partyResponse = sdk.GetSessionApi().Party.PublicCreatePartyOp
    .Execute(partyRequest, sdk.Namespace)
    .EnsureSuccess();
```

### User join a party with code

```csharp
ApimodelsJoinByCodeRequest joinRequest = new ApimodelsJoinByCodeRequest()
{
    Code = joinCode
};

ApimodelsPartySessionResponse joinResponse = sdk.GetSessionApi().Party.PublicPartyJoinCodeOp
    .Execute(joinRequest, sdk.Namespace)
    .EnsureSuccess();
```

### Get party detail

```csharp
ApimodelsPartySessionResponse partyData = _Sdk.GetSessionApi().Party.PublicGetPartyOp
    .Execute(_Sdk.Namespace, partyId)
    .EnsureSuccess();
```

### Admin query parties

```csharp
var adminPartyData = _Sdk.GetSessionApi().Party.AdminQueryPartiesOp
    .SetOffset(0)
    .SetLimit(10)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### User leave a party

```csharp
sdk.GetSessionApi().Party.PublicPartyLeaveOp
    .Execute(sdk.Namespace, partyId)
    .EnsureSuccess();
```
## Social

Source: [SocialTests.cs](../AccelByte.Sdk.Tests.Mod/Services/SocialTests.cs)

### Create a stat

```csharp
StatCreate createStat = new StatCreate()
{
    Name = "CSharp Server SDK Test Stat",
    Description = "CSharp server sdk integration test.",
    StatCode = stat_code,
    SetBy = "SERVER",
    Minimum = 0.0,
    Maximum = 100.0,
    DefaultValue = 50.0,
    IncrementOnly = true,
    SetAsGlobal = false,
    Tags = new List<string>() { "csharp", "server_sdk", "test" }
};

StatInfo cStat = _Sdk.GetSocialApi().StatConfiguration.CreateStatOp
    .Execute(createStat, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get a stat

```csharp
StatInfo gStat = _Sdk.GetSocialApi().StatConfiguration.GetStatOp
    .Execute(_Sdk.Namespace, stat_code)
    .EnsureSuccess();
```

### Update a stat

```csharp
StatUpdate updateStat = new StatUpdate()
{
    Description = "Updated description."
};

StatInfo uStat = _Sdk.GetSocialApi().StatConfiguration.UpdateStatOp
    .Execute(updateStat, _Sdk.Namespace, stat_code)
    .EnsureSuccess();
```

### Delete a stat

```csharp
_Sdk.GetSocialApi().StatConfiguration.DeleteStatOp
    .Execute(_Sdk.Namespace, stat_code)
    .EnsureSuccess();
```

### Create stat config

```csharp
var newStat = _Sdk.GetSocialApi().StatConfiguration.CreateStatOp
    .Execute(new StatCreate()
    {
        Name = "CSharp Extend SDK Test Stat",
        Description = "CSharp Extend Sdk integration test.",
        StatCode = stat_code,
        SetBy = "SERVER",
        Minimum = 0.0,
        Maximum = 100.0,
        DefaultValue = 50.0,
        IncrementOnly = true,
        SetAsGlobal = false,
        IsPublic = false,
        Tags = new List<string>() { "csharp", "extend_sdk", "test" }
    }, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get Stats

```csharp
var statData = _Sdk.GetSocialApi().StatConfiguration.GetStatsOp
    .SetOffset(0)
    .SetLimit(50)
    .SetIsGlobal(false)
    .SetIsPublic(false)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Export stat config

```csharp
var exportStream = _Sdk.GetSocialApi().StatConfiguration.ExportStatsOp
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Delete a stat config

```csharp
_Sdk.GetSocialApi().StatConfiguration.DeleteStatOp
    .Execute(_Sdk.Namespace, stat_code);
```

### Query Stats

```csharp
statData = _Sdk.GetSocialApi().StatConfiguration.QueryStatsOp
    .Execute(_Sdk.Namespace, "csharp")
    .EnsureSuccess();
```
## UGC

Source: [UgcTests.cs](../AccelByte.Sdk.Tests.Mod/Services/UgcTests.cs)

### Create a tag

```csharp
ModelsCreateTagRequest createTag = new ModelsCreateTagRequest()
{
    Tag = tag_name
};
ModelsCreateTagResponse cTag = _Sdk.GetUgcApi().AdminTag.AdminCreateTagOp
    .Execute(createTag, _Sdk.Namespace)
    .EnsureSuccess();
```

### Get tags

```csharp
ModelsPaginatedGetTagResponse gTag = _Sdk.GetUgcApi().AdminTag.AdminGetTagOp
    .SetOffset(0)
    .SetLimit(10)
    .Execute(_Sdk.Namespace)
    .EnsureSuccess();
```

### Update a tag

```csharp
ModelsCreateTagRequest updateTag = new ModelsCreateTagRequest()
{
    Tag = tag_name_u
};
ModelsCreateTagResponse uTag = _Sdk.GetUgcApi().AdminTag.AdminUpdateTagOp
    .Execute(updateTag, _Sdk.Namespace, tag_id)
    .EnsureSuccess();
```

### Delete a tag

```csharp
_Sdk.GetUgcApi().AdminTag.AdminDeleteTagOp
    .Execute(_Sdk.Namespace, tag_id)
    .EnsureSuccess();
```