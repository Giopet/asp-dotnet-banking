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
  3. The port: hplussport.com on port 444 is not the same as no port at all. But since we are using https as the protocol by default the port is 443, therefore different ports. That call would not work, unless you do something about it -> CORS. <br>

By default when you do an http request from JavaScript (GET) send it to a server with a different origin, so a cross-domain request or a cross-origin request, that request has been made, the server returns something but JavaScript can't see what the server is sending.
That's a built in security mechanism, but CORS can grant JavaScript access to that information and that's how it works. When you send such a cross-origin, or cross-domain http request from JavaScript all modern browsers automatically add an additional http header to that request.
The origin header, and the value of that header is the current origin. So the origin of the website that is currently loaded in the browser. This is sent to the server. If the server chooses to ignore that header, all is good. If the server is just returning some data, the information goes back to the client but JavaScript can't read that. However, if the server chooses to be callable from other origins, or other servers, then the server can choose to send the Access-Control-Allow-Origin http header. http header needs to contain the origin of the caller, so the value of that origin header that just came in. Now this header is being sent back to the client, including the regular information. So the actual return data from the server. The client then sees this header, checks whether the value of that header matches the current origin, is now available to JavaScript. And therefore, if we have any of those requests to that server that mechanism really allows us to call any endpoint. Again, with GET it's simple. With POST it's a bit more complicated, the browser first checks whether those headers are being sent correctly and then issues the POST request. For GET the request automatically gets the origin header and return values checked.
![image](https://github.com/Giopet/asp-dotnet-banking/assets/53083156/93770a7c-083c-4f3e-98d2-bdb5613f36ae) <br>

- **Enabling CORS in ASP.NET**: <br>
Old way: <br>
[EnableCors(origins: "https://hplussport.com")] . Put this attribute on a controller level or on an action level method to allow Access-Control-Allow-Origin. <br>
The opposite is [DisableCors()] . <br>
To put it globally you can send headers in web.config, meaning you send Access-Control-Allow-Origin HTTP header with each HTTP response. <br>

- **SQL Injection**: <br>
Avoid execution of raw SQL:
  1. DbSet.SqlQuery()
  2. DbContext.Database.SqlQuery()
  3. DbContext.Database.ExecuteSqlCommand()  <br>
  
  Check the parameters these methods receive. Are there strings that are concatenated with user input? Then the application is suspectable of SQL injection. 

