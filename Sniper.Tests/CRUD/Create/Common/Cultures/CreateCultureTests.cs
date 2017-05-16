using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Cultures
{
    public class CreateCultureTests
    { 
        [Fact] 
        public void CultureThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Cultures) 
            }; 
            var culture = new Culture 
            { 
            }; 
        } 
    } 
} 
