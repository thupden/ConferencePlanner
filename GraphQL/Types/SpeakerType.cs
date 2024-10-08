﻿using ConferencePlanner.GraphQL.Data;

namespace ConferencePlanner.GraphQL.Types
{
    [ObjectType<Speaker>]
    public static partial class SpeakerType
    {
        [BindMember(nameof(Speaker.SessionSpeakers))]
        public static async Task<IEnumerable<Session>> GetSessionsAsync(
            [Parent] Speaker speaker,
            ISessionBySpeakerIdDataLoader sessionBySpeakerId,
            CancellationToken cancellationToken)
        {
            return await sessionBySpeakerId.LoadRequiredAsync(speaker.Id, cancellationToken);
        }
    }
}
