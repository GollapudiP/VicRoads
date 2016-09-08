using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VICR.Registration.Pages
{
    public class AllPages
    {
        static UvpPage _UvpPage = null;
        public static UvpPage UvpPage
        {
            get
            {
                return _UvpPage;
            }
        }

        static PermitTypePage _PermitTypePage = null;
        public static PermitTypePage PermitTypePage
        {
            get
            {
                return _PermitTypePage;
            }
        }

        static VehicleDetailsPage _VehicleDetailsPage = null;
        public static VehicleDetailsPage VehicleDetailsPage
        {
            get
            {
                return _VehicleDetailsPage;
            }
        }

        public static void Init()
        {
            if (_UvpPage == null)
                _UvpPage = PageFactory.Create<UvpPage>();

            if (_PermitTypePage == null)
                _PermitTypePage = PageFactory.Create<PermitTypePage>();

            if (_VehicleDetailsPage == null)
                _VehicleDetailsPage = PageFactory.Create<VehicleDetailsPage>();
        }

        public static void Dispose()
        {
            UvpPage.Dispose();
            PermitTypePage.Dispose();
            VehicleDetailsPage.Dispose();
        }
    }
}
