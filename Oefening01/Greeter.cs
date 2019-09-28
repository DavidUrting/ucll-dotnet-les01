using System.Text;

namespace Oefening01
{
    public class Greeter
    {
        public string Greet(string who)
        {
            // return "Hello " + who;
            // return string.Format("Hello {0}", who);
            //StringBuilder sb = new StringBuilder("Hello ");
            //sb.Append(who);
            //return sb.ToString();

            return $"Hello {who}";
        }
    }
}
