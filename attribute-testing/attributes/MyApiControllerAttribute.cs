namespace attribute_testing.attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)
    ]
    public class MyApiControllerAttribute : System.Attribute
    {
        public MyApiControllerAttribute()
        {
        }
    }
}
