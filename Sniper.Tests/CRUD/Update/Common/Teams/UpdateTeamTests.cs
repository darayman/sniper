using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Teams
{
    public class UpdateTeamTests
    { 
        [Fact] 
        public void TeamThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Teams) 
            }; 
            var team = new Team 
            { 
            }; 
        } 
    } 
} 
