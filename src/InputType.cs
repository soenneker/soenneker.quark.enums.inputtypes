using Intellenum;

namespace Soenneker.Quark.Enums.InputTypes;

/// <summary>
/// Common html input types in enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class InputType
{
    public static readonly InputType Text = new("text");

    public static readonly InputType Email = new("email");

    public static readonly InputType Password = new("password");

    public static readonly InputType Search = new("search");

    public static readonly InputType Url = new("url");

    public static readonly InputType Tel = new("tel");

    public static readonly InputType Number = new("number");

    public static readonly InputType Date = new("date");

    public static readonly InputType Time = new("time");

    public static readonly InputType DateTimeLocal = new("datetime-local");

    public static readonly InputType Month = new("month");

    public static readonly InputType Week = new("week");

    public static readonly InputType Color = new("color");

    public static readonly InputType File = new("file");

    public static readonly InputType Hidden = new("hidden");

    public static readonly InputType Range = new("range");
}