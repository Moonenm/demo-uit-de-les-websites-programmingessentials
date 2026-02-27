using System.Globalization;

public static class Locale
{
    public static void SetLocale()
    {
        CultureInfo ci = new CultureInfo("en-GB");
        Thread.CurrentThread.CurrentCulture = ci;
        Thread.CurrentThread.CurrentUICulture = ci;
    }
}