using ContactHub.BusinessLayer.IBusiness;
using ContactHub.BusinessLayer.BusinessFacade;

namespace ContactHubAPI.BusinessService
{
    class BusinessServiceFacade<T>
        where T : class
    {
        public static IBusinessUser<T> BusinessUserManager;
        static BusinessServiceFacade()
        {
            BusinessUserManager = new BusinessUserFacade<T>();
        }
    }
}