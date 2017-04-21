﻿#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    public enum ReactionType
    {
        [Parameter(Value = "+1")]
        Plus1,
        [Parameter(Value = "-1")]
        Minus1,
        Laugh,
        Confused,
        Heart,
        Hooray
    }

    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Reaction
    {
        public Reaction() { }

        public Reaction(int id, User user, ReactionType content)
        {
            Id = id;
            User = user;
            Content = content;
        }

        /// <summary>
        /// The Id for this reaction.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// Information about the user.
        /// </summary>
        public User User { get; protected set; }

        /// <summary>
        /// The reaction type for this commit comment.
        /// </summary>
        [Parameter(Key = "content")]
        public ReactionType Content { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Id: {0}, Reaction: {1}", Id, Content);
    }
}
#endif