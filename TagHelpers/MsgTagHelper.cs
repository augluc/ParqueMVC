using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Exp3.TagHelpers
{
    public class MsgTagHelper : TagHelper
    {
        public string Texto { get; set; }
        public string Class { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                output.TagName = "div";

                if (string.IsNullOrEmpty(Class))
                    output.Attributes.SetAttribute("class", "my-3 alert alert-success");
                else
                    output.Attributes.SetAttribute("class", Class);

                output.Content.SetContent(Texto);

            }


        }

    }
}
