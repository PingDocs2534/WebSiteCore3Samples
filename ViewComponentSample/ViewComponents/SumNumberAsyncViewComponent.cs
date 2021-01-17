using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ViewComponentSample.ViewModels;

namespace ViewComponentSample.ViewComponents
{
    public class SumNumberAsyncViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int max)
        {
            var sum = await SumNumberAsync(max);
            return View(new SumNumberViewModel() { Result = sum });
        }

        private async Task<int> SumNumberAsync(int max)
        {
            Func<int> action = () =>
            {
                int result = 0;
                for (int i = 0; i < max; i++)
                {
                    result += i;
                }

                return result;
            };

            return await Task<int>.Run(action);
        }
    }
}
