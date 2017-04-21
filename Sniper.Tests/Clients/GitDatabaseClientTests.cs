﻿using System;
using NSubstitute;
using Xunit;

namespace Sniper.Tests.Clients
{
    public class GitDatabaseClientTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnsuresNonNullArguments()
            {
                Assert.Throws<ArgumentNullException>(() => new GitDatabaseClient(null));
            }

            [Fact]
            public void SetTagsClient()
            {
                var apiConnection = Substitute.For<IApiConnection>();
                var gitDatabaseClient = new GitDatabaseClient(apiConnection);
                Assert.NotNull(gitDatabaseClient.Tag);
            }

            [Fact]
            public void SetCommitsClient()
            {
                var apiConnection = Substitute.For<IApiConnection>();
                var gitDatabaseClient = new GitDatabaseClient(apiConnection);
                Assert.NotNull(gitDatabaseClient.Commit);
            }

            [Fact]
            public void SetReferencesClient()
            {
                var apiConnection = Substitute.For<IApiConnection>();
                var gitDatabaseClient = new GitDatabaseClient(apiConnection);
                Assert.NotNull(gitDatabaseClient.Reference);
            }
        }
    }
}