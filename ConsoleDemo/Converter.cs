using System.Globalization;

namespace ConsoleDemo;

public static class Converter
{
    public static object IntToBool(object src, Type msgType, object container)
    {
        if (src == null) return false;

        if (src is int val)
        {
            return val == 0 ? false : true;
        }

        return false;
    }

    public static object Gender(object src, Type msgType, object container)
    {
        if (src is string str && !string.IsNullOrEmpty(str))
        {
            return str.EndsWith("F", StringComparison.OrdinalIgnoreCase) ? "Ж" : "Ч";
        }

        return src;
    }

    public static object PassportTypeAsStr(object src, Type msgType, object container)
    {
        if (src != null && src is int typeId)
        {
            if (msgType == typeof(YellowCard))
            {
                return "One";
            }
            else
            {
                return "Two";
            }
        }

        return string.Empty;
    }

    public static object StrToDate(object source, Type msgType, object container)
    {
        var src = source as string;
        if (string.IsNullOrWhiteSpace(src))
            return null;

        DateTime res;
        if (DateTime.TryParseExact(src!, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out res))
        {
            return res;
        }
        else if (DateTime.TryParseExact(src!, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out res))
        {
            return res;
        }

        return null;
    }

    public static object StrToInt(object source, Type msgType, object container)
    {
        var src = source as string;
        if (string.IsNullOrWhiteSpace(src)) return null;

        if (int.TryParse(src!, out var val))
        {
            return val;
        }

        return null;
    }
}
