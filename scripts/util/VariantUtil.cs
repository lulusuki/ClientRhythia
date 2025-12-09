using Godot;
using Newtonsoft.Json.Linq;

public class VariantUtil
{
    public static T TryCast<T>(Variant variant)
    {
        if (variant is T type)
        {
            return type;
        }
        else
        {
            return default;
        }
    }
}
