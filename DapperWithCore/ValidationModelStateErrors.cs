using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace DapperWithCore
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class ValidationModelStateErrors : ActionFilterAttribute
    {
        private string _url;

        public ValidationModelStateErrors(string url)
        {
            _url = url;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new RedirectResult(_url);
            }

            base.OnActionExecuting(context);
        }
    }
}