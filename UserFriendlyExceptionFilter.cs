using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Azimzada.MVC.UserFriendlyException;

public class UserFriendlyExceptionFilter : IExceptionFilter
{
    private readonly ITempDataDictionaryFactory _tempDataFactory;

    public UserFriendlyExceptionFilter(ITempDataDictionaryFactory tempDataFactory)
    {
        _tempDataFactory = tempDataFactory;
    }

    public void OnException(ExceptionContext context)
    {
        if (context.Exception is UserFriendlyException userFriendlyException)
        {
            context.Result = new ViewResult();
            context.ExceptionHandled = true;

            var tempData = _tempDataFactory.GetTempData(context.HttpContext);
            tempData["UserFriendlyError"] = userFriendlyException.Message;
        }
    }
}
