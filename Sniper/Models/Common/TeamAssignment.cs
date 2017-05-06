﻿using Sniper.Contracts.Entities.Common;
using System;

namespace Sniper.Common
{
    ///<summary>
    /// Assignment of the Team with a specific State on Assignable. Known as TeamState.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamAssignments/meta">API documentation - TeamAssignment</a>
    /// </remarks>
    public class TeamAssignment : Entity, IHasDateRange, IHasAssignable, IHasEntityState, IHasTeam
    {
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }

        public Assignable Assignable { get; set; }
        public EntityState EntityState { get; set; }
        public Team Team { get; set; }
    }
}