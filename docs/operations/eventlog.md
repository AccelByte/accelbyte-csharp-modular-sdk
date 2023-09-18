# Eventlog Service Index

&nbsp;

## Operations

### Event Descriptions Wrapper:  [EventDescriptions](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/EventDescriptions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/event/descriptions/agentType` | GET | AgentTypeDescriptionHandler | [AgentTypeDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/AgentTypeDescriptionHandler.cs) | [AgentTypeDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/AgentTypeDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/agentType/listByAgentTypes` | GET | SpecificAgentTypeDescriptionHandler | [SpecificAgentTypeDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/SpecificAgentTypeDescriptionHandler.cs) | [SpecificAgentTypeDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificAgentTypeDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/eventId` | GET | EventIDDescriptionHandler | [EventIDDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/EventIDDescriptionHandler.cs) | [EventIDDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/EventIDDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/eventId/listByEventIds` | GET | SpecificEventIDDescriptionHandler | [SpecificEventIDDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/SpecificEventIDDescriptionHandler.cs) | [SpecificEventIDDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificEventIDDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/eventLevel` | GET | EventLevelDescriptionHandler | [EventLevelDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/EventLevelDescriptionHandler.cs) | [EventLevelDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/EventLevelDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/eventLevel/listByEventLevels` | GET | SpecificEventLevelDescriptionHandler | [SpecificEventLevelDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/SpecificEventLevelDescriptionHandler.cs) | [SpecificEventLevelDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificEventLevelDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/eventType` | GET | EventTypeDescriptionHandler | [EventTypeDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/EventTypeDescriptionHandler.cs) | [EventTypeDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/EventTypeDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/eventType/listByEventTypes` | GET | SpecificEventTypeDescriptionHandler | [SpecificEventTypeDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/SpecificEventTypeDescriptionHandler.cs) | [SpecificEventTypeDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificEventTypeDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/ux` | GET | UXNameDescriptionHandler | [UXNameDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/UXNameDescriptionHandler.cs) | [UXNameDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/UXNameDescriptionHandler.cs) |
| [DEPRECATED] `/event/descriptions/ux/listByUx` | GET | SpecificUXDescriptionHandler | [SpecificUXDescriptionHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventDescriptions/SpecificUXDescriptionHandler.cs) | [SpecificUXDescriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventDescriptions/SpecificUXDescriptionHandler.cs) |

### Event Wrapper:  [Event](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/Event.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/event/namespaces/{namespace}` | GET | GetEventByNamespaceHandler | [GetEventByNamespaceHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByNamespaceHandler.cs) | [GetEventByNamespaceHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByNamespaceHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}` | POST | PostEventHandler | [PostEventHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/PostEventHandler.cs) | [PostEventHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/PostEventHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/eventId/{eventId}` | GET | GetEventByEventIDHandler | [GetEventByEventIDHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByEventIDHandler.cs) | [GetEventByEventIDHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByEventIDHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/eventType/{eventType}` | GET | GetEventByEventTypeHandler | [GetEventByEventTypeHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByEventTypeHandler.cs) | [GetEventByEventTypeHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByEventTypeHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/eventType/{eventType}/eventId/{eventId}` | GET | GetEventByEventTypeAndEventIDHandler | [GetEventByEventTypeAndEventIDHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByEventTypeAndEventIDHandler.cs) | [GetEventByEventTypeAndEventIDHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByEventTypeAndEventIDHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/users/{userId}` | GET | GetEventByUserIDHandler | [GetEventByUserIDHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByUserIDHandler.cs) | [GetEventByUserIDHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserIDHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/users/{userId}/eventId/{eventId}` | GET | GetEventByUserIDAndEventIDHandler | [GetEventByUserIDAndEventIDHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByUserIDAndEventIDHandler.cs) | [GetEventByUserIDAndEventIDHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserIDAndEventIDHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/users/{userId}/eventType/{eventType}` | GET | GetEventByUserIDAndEventTypeHandler | [GetEventByUserIDAndEventTypeHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByUserIDAndEventTypeHandler.cs) | [GetEventByUserIDAndEventTypeHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserIDAndEventTypeHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/users/{userId}/eventType/{eventType}/eventId/{eventId}` | GET | GetEventByUserEventIDAndEventTypeHandler | [GetEventByUserEventIDAndEventTypeHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/Event/GetEventByUserEventIDAndEventTypeHandler.cs) | [GetEventByUserEventIDAndEventTypeHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/Event/GetEventByUserEventIDAndEventTypeHandler.cs) |

### User Information Wrapper:  [UserInformation](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/UserInformation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/event/namespaces/{namespace}/users/{userId}/activities` | GET | GetUserActivitiesHandler | [GetUserActivitiesHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/UserInformation/GetUserActivitiesHandler.cs) | [GetUserActivitiesHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/UserInformation/GetUserActivitiesHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/users/{userId}/activities` | DELETE | DeleteUserActivitiesHandler | [DeleteUserActivitiesHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/UserInformation/DeleteUserActivitiesHandler.cs) | [DeleteUserActivitiesHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/UserInformation/DeleteUserActivitiesHandler.cs) |
| [DEPRECATED] `/event/namespaces/{namespace}/users/{userId}/lastActivityTime` | GET | LastUserActivityTimeHandler | [LastUserActivityTimeHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/UserInformation/LastUserActivityTimeHandler.cs) | [LastUserActivityTimeHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/UserInformation/LastUserActivityTimeHandler.cs) |

### Event Registry Wrapper:  [EventRegistry](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/EventRegistry.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/event/registry/eventIds` | GET | GetRegisteredEventsHandler | [GetRegisteredEventsHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventRegistry/GetRegisteredEventsHandler.cs) | [GetRegisteredEventsHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/GetRegisteredEventsHandler.cs) |
| [DEPRECATED] `/event/registry/eventIds` | POST | RegisterEventHandler | [RegisterEventHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventRegistry/RegisterEventHandler.cs) | [RegisterEventHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/RegisterEventHandler.cs) |
| [DEPRECATED] `/event/registry/eventIds/{eventId}` | GET | GetRegisteredEventIDHandler | [GetRegisteredEventIDHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventRegistry/GetRegisteredEventIDHandler.cs) | [GetRegisteredEventIDHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/GetRegisteredEventIDHandler.cs) |
| [DEPRECATED] `/event/registry/eventIds/{eventId}` | POST | UpdateEventRegistryHandler | [UpdateEventRegistryHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventRegistry/UpdateEventRegistryHandler.cs) | [UpdateEventRegistryHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/UpdateEventRegistryHandler.cs) |
| [DEPRECATED] `/event/registry/eventIds/{eventId}` | DELETE | UnregisterEventIDHandler | [UnregisterEventIDHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventRegistry/UnregisterEventIDHandler.cs) | [UnregisterEventIDHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/UnregisterEventIDHandler.cs) |
| [DEPRECATED] `/event/registry/eventTypes/{eventType}` | GET | GetRegisteredEventsByEventTypeHandler | [GetRegisteredEventsByEventTypeHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventRegistry/GetRegisteredEventsByEventTypeHandler.cs) | [GetRegisteredEventsByEventTypeHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventRegistry/GetRegisteredEventsByEventTypeHandler.cs) |

### Event V2 Wrapper:  [EventV2](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/EventV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/event/v2/admin/namespaces/{namespace}/query` | POST | QueryEventStreamHandler | [QueryEventStreamHandler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventV2/QueryEventStreamHandler.cs) | [QueryEventStreamHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/QueryEventStreamHandler.cs) |
| `/event/v2/admin/namespaces/{namespace}/users/{userId}/event` | GET | GetEventSpecificUserV2Handler | [GetEventSpecificUserV2Handler](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventV2/GetEventSpecificUserV2Handler.cs) | [GetEventSpecificUserV2Handler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/GetEventSpecificUserV2Handler.cs) |
| `/event/v2/public/namespaces/{namespace}/users/{userId}/edithistory` | GET | GetPublicEditHistory | [GetPublicEditHistory](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventV2/GetPublicEditHistory.cs) | [GetPublicEditHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/GetPublicEditHistory.cs) |
| `/event/v2/public/namespaces/{namespace}/users/{userId}/event` | GET | GetUserEventsV2Public | [GetUserEventsV2Public](../../apis/AccelByte.Sdk.Api.Eventlog/Operation/EventV2/GetUserEventsV2Public.cs) | [GetUserEventsV2Public](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Eventlog/EventV2/GetUserEventsV2Public.cs) |


&nbsp;

## Operations with Generic Response

### Event Descriptions Wrapper:  [EventDescriptions](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/EventDescriptions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Event Wrapper:  [Event](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/Event.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### User Information Wrapper:  [UserInformation](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/UserInformation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Event Registry Wrapper:  [EventRegistry](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/EventRegistry.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Event V2 Wrapper:  [EventV2](../../apis/AccelByte.Sdk.Api.Eventlog/Wrapper/EventV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `models.AgentType` | [ModelsAgentType](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsAgentType.cs) |
| `models.Event` | [ModelsEvent](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEvent.cs) |
| `models.EventID` | [ModelsEventID](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEventID.cs) |
| `models.EventLevel` | [ModelsEventLevel](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEventLevel.cs) |
| `models.EventRegistry` | [ModelsEventRegistry](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEventRegistry.cs) |
| `models.EventResponse` | [ModelsEventResponse](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEventResponse.cs) |
| `models.EventResponseV2` | [ModelsEventResponseV2](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEventResponseV2.cs) |
| `models.EventType` | [ModelsEventType](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEventType.cs) |
| `models.EventV2` | [ModelsEventV2](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsEventV2.cs) |
| `models.GenericQueryPayload` | [ModelsGenericQueryPayload](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsGenericQueryPayload.cs) |
| `models.MultipleAgentType` | [ModelsMultipleAgentType](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsMultipleAgentType.cs) |
| `models.MultipleEventID` | [ModelsMultipleEventID](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsMultipleEventID.cs) |
| `models.MultipleEventLevel` | [ModelsMultipleEventLevel](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsMultipleEventLevel.cs) |
| `models.MultipleEventType` | [ModelsMultipleEventType](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsMultipleEventType.cs) |
| `models.MultipleUX` | [ModelsMultipleUX](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsMultipleUX.cs) |
| `models.Pagination` | [ModelsPagination](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsPagination.cs) |
| `models.Paging` | [ModelsPaging](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsPaging.cs) |
| `models.UX` | [ModelsUX](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsUX.cs) |
| `models.UserLastActivity` | [ModelsUserLastActivity](../../apis/AccelByte.Sdk.Api.Eventlog/Model/ModelsUserLastActivity.cs) |
