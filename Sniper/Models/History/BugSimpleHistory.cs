﻿using Sniper.Common;
using Sniper.Contracts;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/BugSimpleHistories/meta">API documentation - BugSimpleHistory</a>
    /// </remarks>
    public class BugSimpleHistory : SimpleHistoryExtendedBase, IHasBug
    {
        public Bug Bug { get; set; }
    }
}