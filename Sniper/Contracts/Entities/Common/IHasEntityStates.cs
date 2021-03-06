﻿using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEntityStates
    {
        Collection<EntityState> EntityStates { get; }
    }
}