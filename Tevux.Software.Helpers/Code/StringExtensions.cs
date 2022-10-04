namespace Tevux.Software.Helpers;

public static class StringExtensions {
    public static bool IsNonEmpty(this string? value) {
        return !string.IsNullOrEmpty(value);
    }
    public static bool IsEmpty(this string? value) {
        return string.IsNullOrEmpty(value);
    }
}
