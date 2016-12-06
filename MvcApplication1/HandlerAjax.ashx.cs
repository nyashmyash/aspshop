using MvcApplication1.Models;
using MvcApplication1.SqlAcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1
{
    /// <summary>
    /// Summary description for HandlerAjax
    /// </summary>
    public class HandlerAjax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;

            response.ContentType = "text/plain";
            String str = context.Request.QueryString["idshop"];
            int i = Convert.ToInt32(str);
            List<ItemProduct> list = ProductAcessor.SelProducts(i);
            response.Write("<table>");
            response.Write("<tr><th>Название</th><th>Описание</th></tr>");
            foreach (var p in list)
            {
                response.Write("<tr>");
                response.Write("<th>"+p.Name+"</th>");
                response.Write("<th>" + p.Note+"</th>");
                response.Write("</tr>");  
            }
            response.Write("</table>");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}