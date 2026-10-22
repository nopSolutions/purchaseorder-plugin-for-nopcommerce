using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Payments.PurchaseOrder.Models;
using Nop.Web.Framework.Components;
using System.Net;

namespace Nop.Plugin.Payments.PurchaseOrder.Components;

public class PaymentPurchaseOrderViewComponent : NopViewComponent
{
    public IViewComponentResult Invoke()
    {
        var model = new PaymentInfoModel();
        //set postback values (we cannot access "Form" with "GET" requests)
        if (Request.Method != WebRequestMethods.Http.Get)
        {
            model.PurchaseOrderNumber = HttpContext.Request.Form["PurchaseOrderNumber"];
        }

        return View("~/Plugins/Payments.PurchaseOrder/Views/PaymentInfo.cshtml", model);
    }
}
