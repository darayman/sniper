﻿using Newtonsoft.Json;
using Sniper.Application;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// A source file included to Revision.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RevisionFiles/meta">API documentation - RevisionFile</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class RevisionFile : Entity
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.SourceControlId)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Revision Revision { get; internal set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string FileName { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public FileAction FileAction { get; set; }

    }
}