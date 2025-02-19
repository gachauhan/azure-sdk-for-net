// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Rooms
{
    internal partial class RoomsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of RoomsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoomsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2022-02-01")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateRoomRequest(Guid? repeatabilityRequestID, DateTimeOffset? repeatabilityFirstSent, DateTimeOffset? validFrom, DateTimeOffset? validUntil, RoomJoinPolicy? roomJoinPolicy, IEnumerable<RoomParticipantInternal> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (repeatabilityRequestID != null)
            {
                request.Headers.Add("Repeatability-Request-ID", repeatabilityRequestID.Value);
            }
            if (repeatabilityFirstSent != null)
            {
                request.Headers.Add("Repeatability-First-Sent", repeatabilityFirstSent.Value, "O");
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            CreateRoomRequest createRoomRequest = new CreateRoomRequest()
            {
                ValidFrom = validFrom,
                ValidUntil = validUntil,
                RoomJoinPolicy = roomJoinPolicy
            };
            if (participants != null)
            {
                foreach (var value in participants)
                {
                    createRoomRequest.Participants.Add(value);
                }
            }
            var model = createRoomRequest;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new room. </summary>
        /// <param name="repeatabilityRequestID"> If specified, the client directs that the request is repeatable; that is, that the client can make the request multiple times with the same Repeatability-Request-Id and get back an appropriate response without the server executing the request multiple times. The value of the Repeatability-Request-Id is an opaque string representing a client-generated, globally unique for all time, identifier for the request. It is recommended to use version 4 (random) UUIDs. </param>
        /// <param name="repeatabilityFirstSent"> If Repeatability-Request-ID header is specified, then Repeatability-First-Sent header must also be specified. The value should be the date and time at which the request was first created, expressed using the IMF-fixdate form of HTTP-date. </param>
        /// <param name="validFrom"> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validUntil"> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="roomJoinPolicy"> The Policy based on which Participants can join a room. </param>
        /// <param name="participants"> (Optional) Collection of participants invited to the room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<RoomModelInternal>> CreateRoomAsync(Guid? repeatabilityRequestID = null, DateTimeOffset? repeatabilityFirstSent = null, DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, RoomJoinPolicy? roomJoinPolicy = null, IEnumerable<RoomParticipantInternal> participants = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRoomRequest(repeatabilityRequestID, repeatabilityFirstSent, validFrom, validUntil, roomJoinPolicy, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoomModelInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoomModelInternal.DeserializeRoomModelInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new room. </summary>
        /// <param name="repeatabilityRequestID"> If specified, the client directs that the request is repeatable; that is, that the client can make the request multiple times with the same Repeatability-Request-Id and get back an appropriate response without the server executing the request multiple times. The value of the Repeatability-Request-Id is an opaque string representing a client-generated, globally unique for all time, identifier for the request. It is recommended to use version 4 (random) UUIDs. </param>
        /// <param name="repeatabilityFirstSent"> If Repeatability-Request-ID header is specified, then Repeatability-First-Sent header must also be specified. The value should be the date and time at which the request was first created, expressed using the IMF-fixdate form of HTTP-date. </param>
        /// <param name="validFrom"> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validUntil"> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="roomJoinPolicy"> The Policy based on which Participants can join a room. </param>
        /// <param name="participants"> (Optional) Collection of participants invited to the room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<RoomModelInternal> CreateRoom(Guid? repeatabilityRequestID = null, DateTimeOffset? repeatabilityFirstSent = null, DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, RoomJoinPolicy? roomJoinPolicy = null, IEnumerable<RoomParticipantInternal> participants = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRoomRequest(repeatabilityRequestID, repeatabilityFirstSent, validFrom, validUntil, roomJoinPolicy, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        RoomModelInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoomModelInternal.DeserializeRoomModelInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRoomRequest(string roomId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves an existing room by id. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response<RoomModelInternal>> GetRoomAsync(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateGetRoomRequest(roomId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomModelInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoomModelInternal.DeserializeRoomModelInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves an existing room by id. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response<RoomModelInternal> GetRoom(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateGetRoomRequest(roomId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomModelInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoomModelInternal.DeserializeRoomModelInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRoomRequest(string roomId, DateTimeOffset? validFrom, DateTimeOffset? validUntil, RoomJoinPolicy? roomJoinPolicy, IEnumerable<RoomParticipantInternal> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            UpdateRoomRequest updateRoomRequest = new UpdateRoomRequest()
            {
                ValidFrom = validFrom,
                ValidUntil = validUntil,
                RoomJoinPolicy = roomJoinPolicy
            };
            if (participants != null)
            {
                foreach (var value in participants)
                {
                    updateRoomRequest.Participants.Add(value);
                }
            }
            var model = updateRoomRequest;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Update a room with given changes. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="validFrom"> (Optional) The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validUntil"> (Optional) The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="roomJoinPolicy"> The Policy based on which Participants can join a room. </param>
        /// <param name="participants"> Collection of room participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response<RoomModelInternal>> UpdateRoomAsync(string roomId, DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, RoomJoinPolicy? roomJoinPolicy = null, IEnumerable<RoomParticipantInternal> participants = null, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateUpdateRoomRequest(roomId, validFrom, validUntil, roomJoinPolicy, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomModelInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoomModelInternal.DeserializeRoomModelInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update a room with given changes. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="validFrom"> (Optional) The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validUntil"> (Optional) The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="roomJoinPolicy"> The Policy based on which Participants can join a room. </param>
        /// <param name="participants"> Collection of room participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response<RoomModelInternal> UpdateRoom(string roomId, DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, RoomJoinPolicy? roomJoinPolicy = null, IEnumerable<RoomParticipantInternal> participants = null, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateUpdateRoomRequest(roomId, validFrom, validUntil, roomJoinPolicy, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomModelInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoomModelInternal.DeserializeRoomModelInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRoomRequest(string roomId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete a room. </summary>
        /// <param name="roomId"> The id of the room to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response> DeleteRoomAsync(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateDeleteRoomRequest(roomId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a room. </summary>
        /// <param name="roomId"> The id of the room to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response DeleteRoom(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateDeleteRoomRequest(roomId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetParticipantsRequest(string roomId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendPath("/participants", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get participants in a room. </summary>
        /// <param name="roomId"> The id of the room to get participants from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response<ParticipantsCollectionInternal>> GetParticipantsAsync(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateGetParticipantsRequest(roomId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get participants in a room. </summary>
        /// <param name="roomId"> The id of the room to get participants from. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response<ParticipantsCollectionInternal> GetParticipants(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateGetParticipantsRequest(roomId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddParticipantsRequest(string roomId, IEnumerable<RoomParticipantInternal> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendPath("/participants:add", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new AddParticipantsRequest(participants.ToList());
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Adds participants to a room. If participants already exist, no change occurs. </summary>
        /// <param name="roomId"> Room id to add participants. </param>
        /// <param name="participants"> Participants to add to a room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> or <paramref name="participants"/> is null. </exception>
        public async Task<Response<ParticipantsCollectionInternal>> AddParticipantsAsync(string roomId, IEnumerable<RoomParticipantInternal> participants, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateAddParticipantsRequest(roomId, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Adds participants to a room. If participants already exist, no change occurs. </summary>
        /// <param name="roomId"> Room id to add participants. </param>
        /// <param name="participants"> Participants to add to a room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> or <paramref name="participants"/> is null. </exception>
        public Response<ParticipantsCollectionInternal> AddParticipants(string roomId, IEnumerable<RoomParticipantInternal> participants, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateAddParticipantsRequest(roomId, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateParticipantsRequest(string roomId, IEnumerable<RoomParticipantInternal> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendPath("/participants:update", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new UpdateParticipantsRequest(participants.ToList());
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Update participants in a room. </summary>
        /// <param name="roomId"> The room id. </param>
        /// <param name="participants"> Participants to update in a room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> or <paramref name="participants"/> is null. </exception>
        public async Task<Response<ParticipantsCollectionInternal>> UpdateParticipantsAsync(string roomId, IEnumerable<RoomParticipantInternal> participants, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateUpdateParticipantsRequest(roomId, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update participants in a room. </summary>
        /// <param name="roomId"> The room id. </param>
        /// <param name="participants"> Participants to update in a room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> or <paramref name="participants"/> is null. </exception>
        public Response<ParticipantsCollectionInternal> UpdateParticipants(string roomId, IEnumerable<RoomParticipantInternal> participants, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateUpdateParticipantsRequest(roomId, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRemoveParticipantsRequest(string roomId, IEnumerable<RoomParticipantInternal> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendPath("/participants:remove", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new RemoveParticipantsRequest(participants.ToList());
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Remove participants from a room. </summary>
        /// <param name="roomId"> Room id to remove the participants from. </param>
        /// <param name="participants"> Participants to be removed from a room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> or <paramref name="participants"/> is null. </exception>
        public async Task<Response<ParticipantsCollectionInternal>> RemoveParticipantsAsync(string roomId, IEnumerable<RoomParticipantInternal> participants, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateRemoveParticipantsRequest(roomId, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Remove participants from a room. </summary>
        /// <param name="roomId"> Room id to remove the participants from. </param>
        /// <param name="participants"> Participants to be removed from a room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> or <paramref name="participants"/> is null. </exception>
        public Response<ParticipantsCollectionInternal> RemoveParticipants(string roomId, IEnumerable<RoomParticipantInternal> participants, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }
            if (participants == null)
            {
                throw new ArgumentNullException(nameof(participants));
            }

            using var message = CreateRemoveParticipantsRequest(roomId, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ParticipantsCollectionInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ParticipantsCollectionInternal.DeserializeParticipantsCollectionInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
