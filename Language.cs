namespace paradigm_shift_csharp
{
    internal class Language
    {
        public const string selectedLanguage = "en";
        private static Dictionary<string, string> EnToDe = new Dictionary<string, string>() { { "Valid tests", "Gültige tests" }, { "Invalid tests", "Ungültige tests" }, 
            { "Expected true, but got false", "Erwartet wahr, aber erhalten falsch" }, { "Expected false, but got true", "Falsch erwartet, aber wahr bekommen" },
            { "Temperature is out of range!", "Die Temperatur liegt außerhalb des zulässigen Bereichs!"}, { "State of Charge is out of range!", "Ladezustand liegt außerhalb des zulässigen Bereichs!"},
            { "Charge Rate is out of range!", "Laderate liegt außerhalb des zulässigen Bereichs!"}, {"LOW_TEMPERATURE_WARNING", "WARNUNG: NIEDRIGER TEMPERATUR"},
            { "LOW_SoC_WARNING", "WARNUNG: NIEDRIGER SoC"}, {"LOW_CHARGE_RATE_WARNING","WARNUNG: NIEDRIGER LADERATE" }, {"HIGH_TEMPERATURE_WARNING", "WARNUNG: HOHER TEMPERATUR"},
            { "HIGH_SoC_WARNING", "WARNUNG: HOHER SOC"}, {"HIGH_CHARGE_RATE_WARNING", "WARNUNG: HOHER LADERATE"}, {"LOW_TEMPERATURE_BREACH" , "NIEDRIGE TEMPERATURBRUCH"},
            { "LOW_SoC_BREACH", "NIEDRIGER SoC-BRUCH"}, {"LOW_CHARGE_RATE_BREACH", "VERLETZUNG DER NIEDRIGEN LADEKARTE"}, {"HIGH_TEMPERATURE_BREACH" , "HOHER TEMPERATURBRUCH"},
            { "HIGH_SoC_BREACH", "HOHER SoC-BRUCH"}, {"HIGH_CHARGE_RATE_BREACH", "VERLETZUNG DER HOHER LADEKARTE"}};
        public static string Translator(string text, string language)
        {
            if ("de" == language)
            {
                return EnglishToGerman(text);
            }
            return text;
        }

        public static string EnglishToGerman(string text)
        {
            if (EnToDe.ContainsKey(text))
            {
                return EnToDe[text];
            }
            return "Nicht verfügbar";
        }

    }
}
