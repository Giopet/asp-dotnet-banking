# asp-dotnet-banking

## ASP.NET Security

- **Cross-site Scripting (XSS) - Defense: HTML Context**:
Use at character('@' : @Product.Name) because this escapes all special characters in HTML and the brackets single quotes and double quotes. What we could also do is call the HTMLEncode method of HTTP utility.
