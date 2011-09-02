using FluentHtml5.Behaviors;
using MvcContrib.FluentHtml;

namespace FluentHtml5.ViewPages
{
    public class FluentHtml5ViewPage<T> : ModelViewPage<T> where T : class 
    {
        public FluentHtml5ViewPage()
            : base(new RegularExpressionBehavior(), new RangeBehavior(), new RequiredBehavior()){}
    }
}