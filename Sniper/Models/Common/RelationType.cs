﻿using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Type of relation between Entities.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RelationTypes/meta">API documentation - RelationType</a>
    /// </remarks>
    public class RelationType : Entity, IHasName
    {
        public string Name { get; set; }
        public Collection<Relation> Relations { get; set; }
    }
}