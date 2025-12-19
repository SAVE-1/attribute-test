using attribute_testing.attributes;
using System.Linq;
using System.Reflection;

namespace attribute_testing
{
    public static class Helper
    {
        public static List<string> GetControllers()
        {
            var test = from cont in Assembly.GetExecutingAssembly().GetTypes()
                           where cont.IsClass && cont.Namespace == Helper.GetProgramBaseNamespaceFormatted() + ".controllers"
                           select cont;

            List<string> s = new List<string>();

            foreach (Type w in test)
            {
                s.Add(w.Name);
            }

            return s;
        }

        public static List<string> GetControllersWithCorrectAttributes()
        {
            var test = from cont in Assembly.GetExecutingAssembly().GetTypes()
                           where 
                           cont.IsClass && 
                           cont.Namespace == Helper.GetProgramBaseNamespaceFormatted() + ".controllers" &&
                           cont.IsDefined(typeof(MyApiControllerAttribute))
                           select cont;

            List<string> s = new List<string>();

            foreach (Type w in test)
            {
                s.Add(w.Name);
            }

            return s;
        }

        public static string GetProgramBaseNamespaceFormatted()
        {
            Type t = typeof(Program);
            Assembly assem = Assembly.GetAssembly(t);
            return assem.GetName().Name.Replace('-', '_');
        }
    }
}
