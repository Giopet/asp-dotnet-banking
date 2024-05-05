# asp-dotnet-banking

## ASP.NET Security

- **Cross-site Scripting (XSS) - Defense: HTML Context**:
Use at character('@' : @Product.Name) because this escapes all special characters in HTML and the brackets single quotes and double quotes. What we could also do is call the HTMLEncode method of HTTP utility.

- **Cross-site Scripting (XSS) - Defense: Javascript Context**:
Use JavascriptStringEncode (var name = '@HttpUtility.JavascriptStringEncode(Product.Name)').
Whenever we are in a JavaScript context, so are within script tags and we have user supplied data or data a user may modify, we have to escape special character by using JavaScript string encode. HTML encode is not good enough.
However, If you try to use user supplied data in a JavaScript context, it's just not a good idea. 
