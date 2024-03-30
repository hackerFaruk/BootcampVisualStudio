using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{


    interface IUiPresenter
    {
        /// <summary>
        /// Displays information about given object.
        /// Does not includes console.clear() so multiple 
        /// can be combined to create a page
        /// </summary>
        void UiPresenter();

    }


    public class InterfaceManager
    {
       



    }
}
