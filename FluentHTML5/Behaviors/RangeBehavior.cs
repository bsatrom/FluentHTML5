using System.ComponentModel.DataAnnotations;
using MvcContrib.FluentHtml.Behaviors;
using MvcContrib.FluentHtml.Elements;
using MvcContrib.FluentHtml.Html;

namespace FluentHtml5.Behaviors
{
    public class RangeBehavior : IBehavior<IMemberElement>
    {
        public void Execute(IMemberElement element)
        {
            var attribute = element.GetAttribute<RangeAttribute>();
            if (attribute != null)
            {
                element.SetAttr(HtmlAttribute.Min, attribute.Minimum);
                element.SetAttr(HtmlAttribute.Max, attribute.Maximum);
            }
        }
    }
}