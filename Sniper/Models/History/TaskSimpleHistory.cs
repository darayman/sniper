﻿using Newtonsoft.Json;
using Sniper.Common;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.History
{
    ///<summary>
    /// A change of an entity
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TaskSimpleHistories/meta">API documentation - TaskSimpleHistory</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class TaskSimpleHistory : SimpleHistoryExtendedBase, IHasTask
    {
        [JsonProperty(Required = Required.Default)]
        public Task Task { get; internal set; }
    }
}