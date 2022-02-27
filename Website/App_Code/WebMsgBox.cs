using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for WebMsgBox
/// </summary>
public class WebMsgBox
{
    protected static Hashtable handlerPages = new Hashtable();
    private WebMsgBox()
    {

    }
    public static void Show(string Message)
    {
        if (!(handlerPages.Contains(HttpContext.Current.Handler)))
        {
            Page currentPage = (Page)HttpContext.Current.Handler;
            if (!(currentPage == null))
            {
                Queue messageQueue = new Queue();
                messageQueue.Enqueue(Message);
                handlerPages.Add(HttpContext.Current.Handler, messageQueue);
                currentPage.Unload += new EventHandler(CurrentPageUnload);
            }
        }
        else
        {
            Queue queue = ((Queue)(handlerPages[HttpContext.Current.Handler]));
            queue.Enqueue(Message);
        }
    }

    private static void CurrentPageUnload(object sender, EventArgs e)
    {
        Queue queue = ((Queue)(handlerPages[HttpContext.Current.Handler]));
        if (queue != null)
        {
            StringBuilder builder = new StringBuilder();
            int iMsgCount = queue.Count;
            builder.Append("<script language='javascript'>");
            string sMgs;
            while ((iMsgCount > 0))
            {
                iMsgCount = iMsgCount - 1;
                sMgs = System.Convert.ToString(queue.Dequeue());
                sMgs = sMgs.Replace("\"", "'");
                builder.Append("alert(\"" + sMgs + "\");");
            }
            builder.Append("</script>");
            handlerPages.Remove(HttpContext.Current.Handler);
            HttpContext.Current.Response.Write(builder.ToString());
        }
    }
}