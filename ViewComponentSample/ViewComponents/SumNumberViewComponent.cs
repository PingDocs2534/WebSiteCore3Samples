using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ViewComponentSample.ViewModels;

namespace ViewComponentSample.ViewComponents
{
    public class SumNumberViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int max)
        {
            return View(new SumNumberViewModel() { Result = SumNumber( max) });
        }

        private int SumNumber(int max)
        {
            int result = 0;
            for (int i = 0; i < max; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
