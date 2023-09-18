# Gametelemetry Service Index

&nbsp;

## Operations

### telemetry Wrapper:  [Telemetry](../../apis/AccelByte.Sdk.Api.Gametelemetry/Wrapper/Telemetry.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/game-telemetry/v1/admin/namespaces/{namespace}/events` | GET | GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet | [GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet](../../apis/AccelByte.Sdk.Api.Gametelemetry/Operation/Telemetry/GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.cs) | [GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/Telemetry/GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.cs) |

### Gametelemetry Operations Wrapper:  [GametelemetryOperations](../../apis/AccelByte.Sdk.Api.Gametelemetry/Wrapper/GametelemetryOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/game-telemetry/v1/protected/events` | POST | ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost | [ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost](../../apis/AccelByte.Sdk.Api.Gametelemetry/Operation/GametelemetryOperations/ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.cs) | [ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.cs) |
| `/game-telemetry/v1/protected/steamIds/{steamId}/playtime` | GET | ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet | [ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet](../../apis/AccelByte.Sdk.Api.Gametelemetry/Operation/GametelemetryOperations/ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.cs) | [ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.cs) |
| `/game-telemetry/v1/protected/steamIds/{steamId}/playtime/{playtime}` | PUT | ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut | [ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut](../../apis/AccelByte.Sdk.Api.Gametelemetry/Operation/GametelemetryOperations/ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.cs) | [ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.cs) |


&nbsp;

## Operations with Generic Response

### telemetry Wrapper:  [Telemetry](../../apis/AccelByte.Sdk.Api.Gametelemetry/Wrapper/Telemetry.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Gametelemetry Operations Wrapper:  [GametelemetryOperations](../../apis/AccelByte.Sdk.Api.Gametelemetry/Wrapper/GametelemetryOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `HTTPValidationError` | [HTTPValidationError](../../apis/AccelByte.Sdk.Api.Gametelemetry/Model/HTTPValidationError.cs) |
| `TelemetryBody` | [TelemetryBody](../../apis/AccelByte.Sdk.Api.Gametelemetry/Model/TelemetryBody.cs) |
| `ValidationError` | [ValidationError](../../apis/AccelByte.Sdk.Api.Gametelemetry/Model/ValidationError.cs) |