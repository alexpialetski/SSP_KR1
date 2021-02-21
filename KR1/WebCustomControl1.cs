using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControl1 {
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:WelcomeLabel runat=server></{0}:WelcomeLabel>")]
    public class WelcomeLabel : Label {
        [
        Bindable(true),
        Category("Appearance"),
        DefaultValue(""),
        Description("The text to display when the user is not logged in."),
        Localizable(true)
        ]
        public String result = "0";

        protected override void RenderContents(HtmlTextWriter writer) {
            writer.WriteEncodedText(Text);
            writer.WriteEncodedText("Fibonacci Result: ");
            writer.WriteEncodedText(result);
        }
    }
}