﻿using System;

using Translation.Common.Helpers;
using Translation.Common.Models.Base;

namespace Translation.Common.Models.Requests.Integration.Token
{
    public class IntegrationActiveTokenReadListRequest : BaseAuthenticatedPagedRequest
    {
        public Guid IntegrationUid { get; }

        public IntegrationActiveTokenReadListRequest(long currentUserId, Guid integrationUid) : base(currentUserId)
        {
            if (integrationUid.IsEmptyGuid())
            {
                ThrowArgumentException(nameof(integrationUid), integrationUid);
            }

            IntegrationUid = integrationUid;
        }
    }
}