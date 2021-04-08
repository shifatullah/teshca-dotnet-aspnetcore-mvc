using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Teshca.DotNet.AspNetCore.Mvc.CustomTagHelpers
{
    [HtmlTargetElement("my-tag", Attributes = "asp-my-attribute")]
    public class MyTagTagHelper : TagHelper
    {

        public MyTagTagHelper(IHtmlHelper htmlHelper)
        {

        }

        [HtmlAttributeName("asp-my-attribute")]
        public string MyAttribute { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Attributes.Add("data-my-attribute", MyAttribute);
            output.PreElement.SetHtmlContent("<div>");
            output.PostElement.SetHtmlContent("</div>");
            output.Content.SetContent("This is custom tag helper");
        }
    }
}
