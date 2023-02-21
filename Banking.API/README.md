
## Get started

### Visual Studio

Use Template ASP.NET Core Web API with this configuration: 

  ![image](https://user-images.githubusercontent.com/53083156/219965325-5c0d7e3b-7f07-411f-8d61-c3c0c1294c91.png)

Enable OpenAPI suppert to have swagger as an API UI.

### Visual Studio Code

Steps:
- Go to *View*
- Open *terminal* (In that case is Powershell). We can use that and .NET CLI to create a project or an exetrnal Powershell.
- Write a command using the CLI to get a list of all of the installed templates .NET came with: 
	```console
	> cd .\Projects\
	> dotnet new --list
	 ```
- Write a command to show a list of all the options of a template:
	```console
	> dotnet new webapi -h
	```
- Write a command to create the template webapi and provide the name of your project:
	```console
	> dotnet new webapi -o Banking.API
	```
- Write a command to launch VSCode in the current folder:
	```console
	> cd \Banking.API\
	> code .
	```
	Or go to File->Open Folder (Ctrl+K Ctrl O)
- Write a command to run the project:
	```console
	> dotnet run
	```
	Or watch instead of run if you want to refresh every time that something is changed.
	Or Run -> Run Without Debugging

## Why an API?

We have certain pieces of information, certain data and would like to share that and provide it to very different types of clients, such as web applications, mobile applications, native applications, maybe even desktop applications and all of those clients should use a uniform contract, the same format, to communicate with the API.

API stands between our server, our assets, and all the various clients that use one uniform way of communicating with us.

## What is used?

- .NET 6
- C#
- HTTP
- ASP.NET Core Web API

## Notes

- Uri of default controller (7170 is a random port): *localhost/7170/weatherforecast*  . 
-- If the page here comes at as blank. So if you don't see anything. Maybe, just maybe you were just using HTTPS local host and then ran a port number but not the /weatherforecast at the end. It's an API, we don't have a root page or an empty page that's just showing us information about the API. And the UI we had automatically created for our API. It's also not available as the root document. So it's using a different URL. So if that is the case, just check whether you have the correct URL.
