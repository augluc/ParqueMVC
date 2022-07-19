using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Exp3.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        public string Texto { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.Attributes.SetAttribute("type", "submit");

            if (string.IsNullOrEmpty(Texto))
                output.Attributes.SetAttribute("value","Confirmar");
            else
                output.Attributes.SetAttribute("value",Texto);

            output.Attributes.SetAttribute("value", Texto);
            output.Attributes.SetAttribute("class", "btn btn-success");


        }
    }
}
