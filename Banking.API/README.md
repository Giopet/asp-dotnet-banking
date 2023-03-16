
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

### HTTP

- HTTP is an application-level protocol.
- It is generic and stateless, which means it can't remember anything. 
- There are ways to remember something, you could use cookies or sessions based on cookies or other mechanisms but HTTP doesn't really help you there. Cookies are not part of the specification, and instead cookies are a separate specification that was created much later than HTTP itself.
- HTTP is a protocol that is on the application level for hypermedia information. Hypermedia basically means you have HTML with links, more or less. It doesn't necessarily has to be HTML but you have to have links. 
- We have a generic protocol, which is actually text-based and there are several features that are part of the HTTP protocol. One that's pretty interesting is the negotiation of data representation. So data is being transferred via HTTP but the representation of the data can be negotiated. So imagine you have a list of products and you would like to use HTTP to get the list of products, then you can tell the server in which format you would like to have those products, because that's still the same data no matter, whether it's JSON or XML or something else but you can negotiate the data representation.
- There are HTTP methods, eight of them in HTTP/1.1, later versions have more and we will use them for our APIs. 
- There are status codes, which are part of the HTTP response, and we'll also need them. 
- There are some specific headers which are used throughout the specification and we'll also use some of those headers.
- One feature that is supported by those headers or enabled by those headers is content negotiation which was mentioned.
- HTTP is very for usage within APIs, clients readily support it, and most use cases for APIs can be done very easily with what HTTP has to offer. 
- We'll use some of the aspects of that specification and we will use a concept called REST.

#### Representational State Transfer (REST)

- REST isn't a technology. It's a design concept. It's a programming paradigm and the idea is that REST is using existing infrastructure. 
- REST is built on top of HTTP because HTTP comes with many features that are really useful including for APIs.
- The basic idea is that we are using URIs, Uniform Resource Identificators, to access resources.
- URIs provide access to some kind of resource and another aspect is, in which form would I like to have the information about that resource? Or what do I want to do with that resource? Read it, write it, et cetera. 
- It uses HTTP verbs for operations. It will not be part of URI, we will use other measures for instance, HTTP headers or HTTP methods to give you an example for operations like retrieving information, writing information, updating information, specific HTTP methods will be used. 
- Rest Constraints:
	- RESTful APIs need to have a uniform interface. So we just need to have one URI per resource and the interface has to have a uniform look. There are several approaches how to achieve this. And one thing Fielding recommended was something which is spelled H-A-T-E-O-A-S, an acronym for Hypermedia as the Engine of Application State.  It comes with a couple of extra demands including that the representation of each resource should contain specific links pointing to let's say things that you can do with that resource. For instance, if you have a category of items, and each category of items contains a list of items, the representation of the category could contain a link to the list of the items in that category.
	- Client-server. It means client-server architecture, with the client and the server being independent from each other. A client may evolve, a server may evolve, but that should not render the API useless. That is something that can be insured by having a contract between client and server and that contract is adhered to. 
	- The API should be stateless.  If you consider where Fielding is coming from, HTTP is stateless so APIs should be stateless as well. 
	- The API or the data retrieved from the API should be cacheable, retrieving a list of items for instance, is something that could be cached, changing an item or adding a new item to something that should not be cached. And HTTP has support for caching.
	-  A layered system architecture is something that REST needs to support. We have several layers in a typical web application.
	- Code on demand. This is optional, but the idea here is that when you return data you could also return code that then can be executed by the client.  JavaScript is something that actually does that in the web. 

## Notes

- Uri of default controller (7170 is a random port): *localhost/7170/weatherforecast*  .
If the page here comes at as blank. So if you don't see anything. Maybe, just maybe you were just using HTTPS local host and then ran a port number but not the /weatherforecast at the end. It's an API, we don't have a root page or an empty page that's just showing us information about the API. And the UI we had automatically created for our API. It's also not available as the root document. So it's using a different URL. So if that is the case, just check whether you have the correct URL.

## Routing with Attributes

| Attribute                  | Description                                            |  Note |
|----------------------------|--------------------------------------------------------|--------------|
| [Route("/accounts")]       | URL to call the API                                    | If we have the route attribute and we use it like this then basically we say use /accounts, so local host port one, two, three /accounts to call this very specific method, for instance, to retrieve all accounts. |
| [Route("/accounts/{id}")]  | Controller action parameter is taken from URL          | If you would like to have parameters as part of the URL, and there'll be more on that later, we could use this syntax. So /accounts/42 means that id has the value of 42, and that ID is then a parameter for the action method. So we would have maybe an action method called get product and then in parentheses int id or string id, depending on the data type, and that would be filled automatically with the data from the URL. |
| [Route("/accounts/{id?}")] | Optional controller action parameter is taken from URL | The data type and the action method is not say int, but instead nullable int.|
| [Route("/[controller]")]   | Use controller name in URL                             | The most common in use. That's not the name of the class, it's the name of the controller, which is the class name minus controller. |

## EnityFramework Core

- Tools -> NuGet Package Manager -> Package Manager Console
  	```console
  	> Install-Package Microsoft.EntityFrameworkCore
  	> Install-Package Microsoft.EntityFrameworkCore.InMemory
  	```
## Accept Data from HTTP requests

1. [FromBody] : Data from the body of the HTTP request, mostly POST/PUT.
2. [FromRoute] : Data from the route template.
3. [FromQuery] : Data from the URL.

## More to Explore

- Advanced data retrieval
- Versioning APIs
- Securring APIs
- API Design
- ASP .NET Core Security

## DApp Back-End

Solidity is a language that was created specifically for writing smart contracts. It's a pretty young language, having been first proposed in late 2014 and then later integrated into the Ethereum project. It's ECMAScript based and very similar to JavaScript in syntax. It's influenced by C++ and Python as well. It works by running in the Ethereum virtual machine.

When you compile it, it will be saved to an address on some Ethereum network, either to local testing network or one of the public testing networks or the Ethereum mainnet, depending on where you want to save it.

Your DApp, you're going to be calling most likely, on these contracts from JavaScript. So you can hide that from the user for the most part. They won't actually see which contract you're pulling from. However, it will be technically a different contract. So if you change the NFT contract, it will actually be a different NFT, right? So because of this, it's very important that your code is well thought out and well tested before you publish to the main net. It's also common, even though the bytecode is all that gets published to the network. It's often quite common to publish the source code as well along with it and there's a place to do that.

Solidity is statically typed and supports inheritance. It's very object oriented. It has a lot of built in functionality to support elements of the blockchain and abstract a lot of the cryptography that happens behind the scene. So you don't have to actually learn how that all works. The docs can be found at soliditylang.org.

Any function that writes to the blockchain is going to cost gas, right? So if I read, no problem. That is free externally. But if anything happens, it will be processed and gas is processed in wei, W, E, I. And wei is the smallest unit of Ethereum that you can have, down to the last decimal point, basically, in eth. So oftentimes you'll see numbers are written in those sort of forms, and you'll have to decode how many eth that is by figuring out how many decimal points to add.

There are a number of key concepts to remember. Storage, blockchain versus memory, right? Remember, things will be stored on the blockchain. They'll exist in memory very shortly, but they'll eventually be saved in the blockchain. A lot of the things that will be stored within your smart contract can be accessed.

### IDE

[Remix](https://remix.ethereum.org/#lang=en&optimize=false&runs=200&evmVersion=null&version=soljson-v0.8.18+commit.87f61d96.js):
Exists both online and in a desktop application.

### Testing

HardHat
