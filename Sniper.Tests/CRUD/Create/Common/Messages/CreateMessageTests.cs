using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Messages 
{ 
    public class MessageTests 
     { 
        [Fact] 
        public void MessageThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Messages) 
            }; 
            var message = new Message 
            { 
            }; 
        } 
    } 
} 
