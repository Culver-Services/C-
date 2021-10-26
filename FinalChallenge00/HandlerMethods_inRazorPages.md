Handler Methods in Razor Pages
Handler methods in Razor Pages are methods that are automatically executed as a result of a request. The Razor Pages framework uses a naming convention to select the appropriate handler method to execute. The default convention works by matching the HTTP verb used for the request to the name of the method, which is prefixed with "On": OnGet(), OnPost(), OnPut() etc.

Handler methods also have optional asynchronous equivalents: OnPostAsync(), OnGetAsync() etc. You do not need to add the Async suffix. The option is provided for developers who prefer to use the Async suffix on methods that contain asynchronous code.

As far as the Razor Pages framework is concerned, OnGet and OnGetAsync are the same handler. You cannot have both in the same page. If you do, the framework will raise an exception:

InvalidOperationException: Multiple handlers matched. The following handlers matched route data and had all constraints satisfied:

Void OnGetAsync(), Void OnGet()

Parameters play no part in disambiguating between handlers based on the same verb, despite the fact that the compiler will allow it. Therefore the same exception will be raised even if the OnGet method takes parameters and the OnGetAsync method doesn't.

Handler methods must be public and can have any return type, although typically, they are most likely to have a return type of void (or Task if asynchronous) or an action result.

The following example illustrates basic usage in a PageModel:

public class IndexModel : PageModel
{
    public string Message { get; set; }
    public void OnGet()
    {
        Message = "Get used";
    }
    public void OnPost()
    {
        Message = "Post used";
    }
}
The content age includes a form that uses the POST method and a hyperlink, which initiates a GET request:

h3>@Message</h3>
form method="post"><button class="btn btn-default">Click to post</button></form>
p><a href="/" class="btn btn-default">Click to Get</a></p>
When the page is first navigated to, the "Get used" message is displayed because the HTTP GET verb was used for the request, firing the OnGet() handler.

When the "Click to post" button is pressed, the form is posted and the OnPost() handler fires, resulting in the "Post used" message being displayed.

Clicking the hyperlink results in the "Get used" message being displayed once more.


 
Note that HTTP is stateless. Any values initialised in the OnGet handler are not available in the OnPost handler. If you completely remove the assignment in the OnPost handler, Message will be null when the page displays. If you want to reuse a value in an OnPost handler, you must initialise it again.

The most common example of this is when you redisplay a form that contains dropdowns after an invalid submission. You populate the items from a database in OnGet, but forget to repopulate in OnPost if ModelState is not valid.

Named Handler Methods link
Razor Pages includes a feature called "named handler methods". This feature enables you to specify multiple methods that can be executed for a single verb. You might want to do this if your page features multiple forms, each one responsible for a different outcome, for example.

The following code shows a collection of named handler methods declared in a code block at the top of a Razor page (although they can also be placed in the PageModel class if you are using one):

@page 
@{
    
    @functions{
        public string Message { get; set; } = "Initial Request";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Message = "Form Posted";
        }
        public void OnPostDelete()
        {
            Message = "Delete handler fired";
        }
        public void OnPostEdit(int id)
        {
            Message = "Edit handler fired";
        }
        public void OnPostView(int id)
        {
            Message = "View handler fired";
        }
    }
}
The name of the method is appended to "OnPost" or "OnGet", depending on whether the handler should be called as a result of a POST or GET request. The next step is to associate a specific form action with a named handler. This is achieved by setting the asp-page-handler attribute value for a form tag helper:

<div class="row">
    <div class="col-lg-1">
        <form asp-page-handler="edit" method="post">
            <button class="btn btn-default">Edit</button>
        </form>
    </div>
    <div class="col-lg-1">
        <form asp-page-handler="delete" method="post">
            <button class="btn btn-default">Delete</button>
        </form>
    </div>
    <div class="col-lg-1">
        <form asp-page-handler="view" method="post">
            <button class="btn btn-default">View</button>
        </form>
    </div>
</div>
<h3 class="clearfix">@Model.Message</h3>
The code above renders as three buttons, each in their own form along with the default value for the Message property:

FormTagHelpers

The name of the handler is added to the form's action as a query string parameter: Handlers

As you click each button, the code in the handler associated with the query string value is executed, changing the message each time.

Handlers

If you prefer not to have query string values representing the handler's name in the URL, you can use routing to add an optional route value for "handler" as part of the route template in the @page directive:

@page "{handler?}"
The name of the handler is then appended to the URL:

Handler Routevalue

Parameters in Handler Methods link
Handler methods can be designed to accept parameters:

public void OnPostView(int id)
{
    Message = $"View handler fired for {id}";
}
In a POST handler, the parameter name must match a form field name for the incoming value to be automatically bound to the parameter:

<div class="col-lg-1">
    <form asp-page-handler="view" method="post">
        <button class="btn btn-default">View</button>
        <input type="hidden" name="id" value="3" />
    </form>
</div>
Handler parameters

Alternatively, you can use the form tag helper's asp-route attribute to pass parameter values as part of the URL, either as a query string value or as route data for GET requests:

<form asp-page-handler="delete" asp-route-id="10" method="post">
    <button class="btn btn-default">Delete</button>
</form>
You append the name of the parameter to the asp-route attribute (in this case "id") and then provide a value. This will result in the parameter being passed as a query string value:

Parameter as Query String

Or you can extend the route template for the page to account for an optional parameter:

@page "{handler?}/{id?}"
This results in the parameter value being added as a separate segment in the URL:

Parameter as route segment

Handling Multiple Actions For The Same Form link
Some forms need to be designed to cater for more than one possible action. Where this is the case, you can either write some conditional code to determine which action should be taken, or you can write separate named handler methods and then use the form action tag helper to specify the handler method to execute on submission of the form:

<form method="post">
    <button asp-page-handler="Register">Register Now</button>
    <button asp-page-handler="RequestInfo">Request Info</button>
</form>
The value passed to the page-handler attribute is the name of the handler method without the OnPost prefix or Async suffix:

public async Task<IActionResult> OnPostRegisterAsync()
{
    //…
    return RedirectToPage();
}
public async Task<IActionResult> OnPostRequestInfo()
{
    //…
    return RedirectToPage();
}
The NonHandler Attribute link
There may be occasions where you don't want a public method on a page to be considered as a handler method, despite its name matching the conventions for handler method discovery. You can use the NonHandler attribute to specify that the decorated method is not a page handler method:

[NonHandler]
public void OnGetFoo()
{
    ...
}
