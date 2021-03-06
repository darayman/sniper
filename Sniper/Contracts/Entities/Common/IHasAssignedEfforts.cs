﻿using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasAssignedEfforts
    {
        Collection<AssignedEffort> AssignedEfforts { get; }
    }
}