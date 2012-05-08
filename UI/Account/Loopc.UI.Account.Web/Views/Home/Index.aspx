<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<HomeViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Index</title>
    <% Html.Css("~/content/css/global.css"); %>
</head>
<body>
    <div>
        <%= Model.Host %>
    </div>
    <% Html.Javascript("~/scripts/jquery-1.4.1.min.js"); %>
</body>
</html>
