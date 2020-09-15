using System;
using UnitTestsDemo.Pages.PageGroups;

namespace UnitTestsDemo.Interfaces
{
    public interface IHomePage
    {
        void CloseAscentPopUp();
        Navigation Navigation { get; }
        
        Footer Footer { get; }
    }
}
