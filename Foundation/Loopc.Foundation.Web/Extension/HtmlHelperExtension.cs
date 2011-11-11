namespace System.Web.Mvc
{
    public static class HtmlHelperExtension
    {
        public static void Javascript(this HtmlHelper htmlHelper, string src)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
            var element = string.Format("<script src=\"{0}\" type=\"text/javascript\"></script>", urlHelper.Content(src));
            htmlHelper.ViewContext.Writer.Write(element);
        }

        public static void Css(this HtmlHelper htmlHelper, string href)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
            var element = string.Format("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", urlHelper.Content(href));
            htmlHelper.ViewContext.Writer.Write(element);
        }
    }
}
