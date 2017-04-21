﻿#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    /// <summary>
    /// Represents a Signature Verification Object in Git Data Commit Payload.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Verification
    {
        /// <summary>
        /// Does GitHub consider the signature in this commit to be verified?
        /// </summary>
        public bool Verified { get; protected set; }

        /// <summary>
        /// The reason for verified value.
        /// </summary>
        [Parameter(Key = "reason")]
        public VerificationReason Reason { get; protected set; }

        /// <summary>
        /// The signature that was extracted from the commit.
        /// </summary>
        public string Signature { get; protected set; }

        /// <summary>
        /// The value that was signed.
        /// </summary>
        public string Payload { get; protected set; }

        internal string DebuggerDisplay => string.Format(
            CultureInfo.InvariantCulture,
            "Verification: {0} Verified: {1} Reason: {2} Signature: {3} Payload",
            Verified,
            Reason.ToString(),
            Signature,
            Payload);
    }

    public enum VerificationReason
    {
        [Parameter(Value = "expired_key")]
        ExpiredKey,

        [Parameter(Value = "not_signing_key")]
        NotSigningKey,

        [Parameter(Value = "unsigned")]
        Unsigned,

        [Parameter(Value = "unknown_signature_type")]
        UnknownSignatureType,

        [Parameter(Value = "no_user")]
        NoUser,

        [Parameter(Value = "unverified_email")]
        UnverifiedEmail,

        [Parameter(Value = "bad_email")]
        BadEmail,

        [Parameter(Value = "unknown_key")]
        UnknownKey,

        [Parameter(Value = "malformed_signature")]
        MalformedSignature,

        [Parameter(Value = "inavlid")]
        Invalid,

        [Parameter(Value = "valid")]
        Valid
    }
}
#endif