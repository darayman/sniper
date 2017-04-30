﻿using Sniper.Application;
using Sniper.Contracts;
using Sniper.Contracts.History;
using Sniper.History;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A statement of end user requirements in a couple of sentences. User Story can be assigned to Iteration or Release.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/UserStorys/meta">API documentation - UserStory</a>
    /// </remarks>
    public class UserStory : Assignable, IHasInitialEstimate, IHasFeature, IHasBugs, IHasTasks, IHasUserHistory
    {
        #region Required
        [RequiredForCreate]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public override Project Project { get; set; }

        #endregion

        public decimal InitialEstimate { get; set; }

        public Feature Feature { get; set; }

        public Collection<Bug> Bugs { get; set; }
        public Collection<UserStorySimpleHistory> History { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<TestCase> UserStoryTestCases { get; set; }
        public Collection<TestPlan> UserStoryTestPlans { get; set; }
    }
}