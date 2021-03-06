﻿using System;

using Translation.Common.Helpers;
using Translation.Common.Models.Base;

namespace Translation.Common.Models.Requests.Admin
{
    public class AdminInviteValidateRequest : BaseRequest
    {
        public Guid Token { get; }
        public string Email { get; }

        public AdminInviteValidateRequest(Guid token, string email)
        {
            if (token.IsEmptyGuid())
            {
                ThrowArgumentException(nameof(token), token);
            }

            if (email.IsNotEmail())
            {
                ThrowArgumentException(nameof(email), email);
            }

            Token = token;
            Email = email;
        }
    }
}