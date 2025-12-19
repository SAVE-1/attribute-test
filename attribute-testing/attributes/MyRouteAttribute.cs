namespace attribute_testing.attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)
    ]
    public class MyRouteAttribute : System.Attribute
    {
        string route;
        public MyRouteAttribute(string Route)
        {
            route = Route;
        }
    }
}
