using System;
using System.Globalization;

namespace MyApp.Services;

class Greeter
{
    public string Greet(string name)
    {
        var culture = CultureInfo.CurrentCulture;
        return $"Hello, {name}! Culture: {culture.Name}";
    }
}                                                                                                                                                                 