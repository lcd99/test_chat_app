#pragma checksum "D:\TEST\test_chat_app\ChatApp\ChatApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f862a177270c167e572b166c2da88f524bcb87ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChatApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ChatApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\TEST\test_chat_app\ChatApp\ChatApp\Pages\_ViewImports.cshtml"
using ChatApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f862a177270c167e572b166c2da88f524bcb87ed", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f166fed5047959f7cf05e10889926e8372f8fc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3 needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-send-message1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-send-message2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-send-message3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-send-private-mgs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\TEST\test_chat_app\ChatApp\ChatApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #group1,
    #group2,
    #group3 {
        display: none;
    }

    #entrance {
        display: flex;
        align-items: center;
    }

    #nick {
        width: 250px;
    }

    .list-online, .content-chat {
        border-right: 1px solid #000;
    }

    .boxed-chat {
        display: none;
    }

    .name-user:hover {
        background: #00ffff;
        cursor: pointer;
    }
</style>

<div id=""entrance"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f862a177270c167e572b166c2da88f524bcb87ed5742", async() => {
                WriteLiteral(@"
        <label for=""nick"">Enter your nickname:</label>
        <input type=""text"" id=""nick"" class=""form-control"" placeholder=""Username"" aria-label=""Username"" aria-describedby=""basic-addon1"" required>
        <button type=""button"" class=""btn btn-primary"" onclick=""continueToChat()"">Continue</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<h6 id=""spn-nick-top""></h6>
<h6 id=""spn-nick"" hidden></h6>

<div class=""boxed-chat"">
    <div class=""list-online pr-3"">
        <ul id=""list-online"">
            <li>User Online</li>
        </ul>
    </div>

    <div class=""content-chat ml-3 pr-3"">
        <div class=""container-chat"">
            <div class=""btn-group group-button-room"" role=""group"" aria-label=""Basic example"">
                <button type=""button"" id=""room1"" class=""btn btn-danger"" onclick=""joinGroupChat(1)"">Room 1</button>
                <button type=""button"" id=""room2"" class=""btn btn-warning"" onclick=""joinGroupChat(2)"">Room 2</button>
                <button type=""button"" id=""room3"" class=""btn btn-success"" onclick=""joinGroupChat(3)"">Room 3</button>
            </div>

            <div class=""form-group"" id=""group1"">
                <h6>You stay in room 1</h6>
                <div id=""chat1"" style=""display: none"">
                    <h6 id=""spn-nick1""></h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f862a177270c167e572b166c2da88f524bcb87ed8740", async() => {
                WriteLiteral("\r\n                        <label for=\"message\">Message:</label>\r\n                        <input type=\"text\" id=\"message1\" />\r\n                        <input type=\"submit\" id=\"send1\" value=\"Send\" class=\"send\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""clear"">
                    </div>
                    <ul id=""messages1""></ul>
                </div>
            </div>

            <div class=""form-group"" id=""group2"">
                <h6>You stay in room 2</h6>
                <div id=""chat2"" style=""display: none"">
                    <h6 id=""spn-nick2""></h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f862a177270c167e572b166c2da88f524bcb87ed10778", async() => {
                WriteLiteral("\r\n                        <label for=\"message\">Message:</label>\r\n                        <input type=\"text\" id=\"message2\" />\r\n                        <input type=\"submit\" id=\"send2\" value=\"Send\" class=\"send\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""clear"">
                    </div>
                    <ul id=""messages2""></ul>
                </div>
            </div>

            <div class=""form-group"" id=""group3"">
                <h6>You stay in room 3</h6>
                <div id=""chat3"" style=""display: none"">
                    <h6 id=""spn-nick3""></h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f862a177270c167e572b166c2da88f524bcb87ed12817", async() => {
                WriteLiteral("\r\n                        <label for=\"message\">Message:</label>\r\n                        <input type=\"text\" id=\"message3\" />\r\n                        <input type=\"submit\" id=\"send3\" value=\"Send\" class=\"send\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""clear"">
                    </div>
                    <ul id=""messages3""></ul>
                </div>
            </div>
        </div>

        <div class=""form-group"">
        </div>

    </div>

    <div class=""form-group ml-3"" id=""private-mgs"">
        <h6>Private mesage</h6>
        <div id=""chat-private-mgs"" style=""display: none"">
            <h6>Chat with <span id=""name-private-mgs""></span></h6>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f862a177270c167e572b166c2da88f524bcb87ed14947", async() => {
                WriteLiteral("\r\n                <label for=\"message\">Message:</label>\r\n                <input type=\"text\" id=\"input-private-mgs\" />\r\n                <input type=\"submit\" id=\"sumit-private-mgs\" value=\"Send\" class=\"send\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""clear"">
            </div>
            <ul id=""list-private-mgs""></ul>

            <div id=""connectionId"" style=""display: none;""></div>
            <div id=""user-name-private-msg"" style=""display: none;""></div>
        </div>
    </div>
</div>


<script src=""js/signalr/dist//browser/signalr.min.js""></script>

<script>
    const connection = new signalR.HubConnectionBuilder()
        .withUrl(""/ChatHub"")
        .configureLogging(signalR.LogLevel.Information)
        .build();


    async function start() {
        try {
            await connection.start();
            console.log(""SignalR Connected."");
        } catch (err) {
            console.log(err);
            setTimeout(start, 5000);
        }
    };

    connection.onclose(async () => {
        await start();
    });

    // Start the connection.
    start();

    const connectionString = """";
    var listOnline = [];

    connection.on('OnConnectedAsync', (message, connectionString) =");
            WriteLiteral(@"> {
        console.log(message)
        connectionString = connectionString;
    });

    connection.on('Send', (username, lstConnection) => {
        appendLineListOnline(lstConnection)
    });

    connection.on('JoinGroup', (message) => {
        console.log(message)
    });

    connection.on('LeaveGroup', (message) => {
        console.log(message)
    });

    connection.on('SendToGroup', (groupName, username, message) => {
        appendLine(groupName, username, message);
    });

    connection.on('SendToConnection', (connectionId, username, message) => {
        console.log(connectionId, username, message)
        appendLinPrivateMgs(username, message)
    });

    async function continueToChat() {
        $('#spn-nick-top').text(""Hello: "" + $('#nick').val());
        $('#spn-nick').text($('#nick').val());
        $('#entrance').hide();
        $('.boxed-chat').show();
        $('.boxed-chat').css(""display"", ""flex"");

        await connection.invoke(""Send"", $('#nick'");
            WriteLiteral(@").val());
    }

    //----------------------------------------

    const group1 = ""group1"";
    const group2 = ""group2"";
    const group3 = ""group3"";

    var nameGroup = """";

    async function joinGroupChat(roomId) {
        console.log(""joinGroupChat"");

        await connection.invoke(""LeaveGroup"", nameGroup);

        switch (roomId) {
            case 1:
                $('#group1').show();
                $('#group2').hide();
                $('#group3').hide();
                $('#chat1').show();

                nameGroup = group1;
                await connection.invoke(""JoinGroup"", group1);

                break;
            case 2:
                $('#group1').hide();
                $('#group2').show();
                $('#group3').hide();
                $('#chat2').show();

                nameGroup = group2;
                await connection.invoke(""JoinGroup"", group2);

                break;
            case 3:
                $('#group1').hide();
   ");
            WriteLiteral(@"             $('#group2').hide();
                $('#group3').show();
                $('#chat3').show();

                nameGroup = group3;
                await connection.invoke(""JoinGroup"", group3);

                break;
            default:
            // code block
        }
    }

    document.getElementById('frm-send-message1').addEventListener('submit', event => {
        let message = $('#message1').val();
        let username = $('#spn-nick').text();

        $('#message1').val('');

        connection.invoke('SendToGroup', group1, username, message);
        event.preventDefault();
    });

    document.getElementById('frm-send-message2').addEventListener('submit', event => {
        let message = $('#message2').val();
        let username = $('#spn-nick').text();

        $('#message2').val('');

        connection.invoke('SendToGroup', group2, username, message);
        event.preventDefault();
    });

    document.getElementById('frm-send-message3').addEve");
            WriteLiteral(@"ntListener('submit', event => {
        let message = $('#message3').val();
        let username = $('#spn-nick').text();

        $('#message3').val('');

        connection.invoke('SendToGroup', group3, username, message);
        event.preventDefault();
    });

    function appendLine(groupName, username, message) {
        let nameElement = document.createElement('strong');
        nameElement.innerText = `${username}:`;

        let msgElement = document.createElement('em');
        msgElement.innerText = ` ${message}`;

        let li = document.createElement('li');
        li.appendChild(nameElement);
        li.appendChild(msgElement);

        if (groupName == group1)
            $('#messages1').append(li);
        if (groupName == group2)
            $('#messages2').append(li);
        if (groupName == group3)
            $('#messages3').append(li);
    };

    function appendLinPrivateMgs(username, message) {
        let nameElement = document.createElement('strong');");
            WriteLiteral(@"
        nameElement.innerText = `${username}:`;

        let msgElement = document.createElement('em');
        msgElement.innerText = ` ${message}`;

        let li = document.createElement('li');
        li.appendChild(nameElement);
        li.appendChild(msgElement);

        $('#list-private-mgs').append(li);
    };

    function appendLineListOnline(lstConnection) {
        console.log(lstConnection);
        $(""#list-online .name-user"").remove();
        lstConnection.forEach(element => {
            if (element.connectionId !== connectionString)
                $(""#list-online"").append(`<li class=""name-user"" id=""${element.connectionId}"" ondblclick=""onPrivateMsg('${element.connectionId}', '${element.username}')"">${element.username}</li>`);
        });
    };

    function onPrivateMsg(connectionId, username) {
        console.log(""onPrivateMsg"", connectionId, username);

        $('#chat-private-mgs').show();
        $('#name-private-mgs').text(username);
        $('#connecti");
            WriteLiteral(@"onId').text(connectionId);
        $('#user-name-private-msg').text(username);
    }

    document.getElementById('frm-send-private-mgs').addEventListener('submit', event => {
        let message = $('#input-private-mgs').val();
        let connectionId = $('#connectionId').text();
        let username = $('#user-name-private-msg').text();

        $('#input-private-mgs').val('');

        connection.invoke('SendToConnection', connectionId, username, message);
        event.preventDefault();
    });
    //-----------------------------------



</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591