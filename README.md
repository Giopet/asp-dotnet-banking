# asp-dotnet-banking

## ASP.NET Security

- **Cross-site Scripting (XSS) - Defense: HTML Context**: <br>
Use at character('@' : @Product.Name) because this escapes all special characters in HTML and the brackets single quotes and double quotes. What we could also do is call the HTMLEncode method of HTTP utility.

- **Cross-site Scripting (XSS) - Defense: Javascript Context**: <br>
Use JavascriptStringEncode (var name = '@HttpUtility.JavascriptStringEncode(Product.Name)').
Whenever we are in a JavaScript context, so are within script tags and we have user supplied data or data a user may modify, we have to escape special character by using JavaScript string encode. HTML encode is not good enough.
However, If you try to use user supplied data in a JavaScript context, it's just not a good idea.

- **Same origin and Cross-Origin Resource Sharing (CORS)**: <br>
JavaScript does have a security concept and it's the Same-Origin Policy. <br>
There are three pieces of information that have to be the same between the HTML page that contains the JavaScript code and the resource. <br>
1. The Protocol: if we are on http//hplussport.com and try to do a Ajax call to https://hplussport.com, even if it's the same server, it's a different protocol so it's a different origin. That does not work. <br>
2. The domain name, the fully qualified domain name. So if we are on www.hplussport.com and like to call hplussport.com, even if it's exactly the same machine, from www.hplussport.com to hplussport.com the domain name doesn't match, so it's a different origin. That call doesn't work.
3. The port: hplussport.com on port 444 is not the same as no port at all. But since we are using https as the protocol by default the port is 443, therefore different ports. That call would not work, unless you do something about it -> CORS.
