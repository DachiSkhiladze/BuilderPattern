using System.Text;

namespace Builder
{
    public class Demo
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "hello");
            Console.WriteLine(builder.ToString());
        }
    }
}