using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace APIXURestClient
{
    public partial class APIXURestApi
    { 
        private string GetAPIXUL10nCode(APIXUL10n i)
        {
            return L10nCodes[i.ToString()];
        }

        private Dictionary<string, string> L10nCodes = new Dictionary<string, string>()
        {
            { "Arabic", "ar" },
            { "Bengali", "bn" },
            { "Bulgarian", "bg" },
            { "ChineseSimplified", "zh" },
            { "ChineseTraditional", "zh_tw" },
            { "Czech", "cs" },
            { "Danish", "da" },
            { "Dutch", "nl" },
            { "Finnish", "fi" },
            { "French", "fr" },
            { "German", "de" },
            { "Greek", "el" },
            { "Hindi", "hi" },
            { "Hungarian", "hu" },
            { "Italian", "it" },
            { "Japanese", "ja" },
            { "Javanese", "jv" },
            { "Korean", "ko" },
            { "Mandarin", "zh_cmn" },
            { "Marathi", "mr" },
            { "Polish", "pl" },
            { "Portuguese", "pt" },
            { "Punjabi", "pa" },
            { "Romanian", "ro" },
            { "Russian", "ru" },
            { "Serbian", "sr" },
            { "Sinhalese", "si" },
            { "Slovak", "sk" },
            { "Spanish", "es" },
            { "Swedish", "sv" },
            { "Tamil", "ta" },
            { "Telugu", "te" },
            { "Turksih", "tr" },
            { "Ukrainian", "uk" },
            { "Urdu", "ur" },
            { "Vietnamese", "vi" },
            { "Wu", "zh_wuu" },
            { "Xiang", "zh_hsn" },
            { "Yue", "zh_yue" },
            { "Zulu", "zu" }
        };
    }

    public class BoolConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((bool)value) ? 1 : 0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value.ToString() == "1";
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool);
        }
    }
}