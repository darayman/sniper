using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.ReleaseProjects
{
    public class UpdateReleaseProjectTests
    { 
        [Fact] 
        public void ReleaseProjectThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.ReleaseProjects) 
            }; 
            var releaseProject = new ReleaseProject 
            { 
            }; 
        } 
    } 
} 
