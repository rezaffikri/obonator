using System;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Obonator.Library
{
    public class ObonJson
    {
        public static string JsonValidator(string json)
        {
            string errorMsg = "";
            try
            {
                JsonSerializer.Deserialize<JsonElement>(json);
            }
            catch (Exception ex)
            {
                int line = 1;
                int position = 0;
                string msg = "";
                if (ex.Message.Contains("LineNumber: "))
                {
                    line = int.Parse(ex.Message.Substring(ex.Message.IndexOf("LineNumber: ") + 12, 3).Replace("|", "").Trim());
                }
                if (ex.Message.Contains("BytePositionInLine: "))
                {
                    position = int.Parse(ex.Message.Substring(ex.Message.IndexOf("BytePositionInLine: ") + 20).Replace(".", "".Trim()));
                }
                if (ex.Message.Contains("Expected"))
                {
                    msg = ex.Message.Substring(ex.Message.IndexOf("Expected")).Replace(".", "".Trim());
                    int lengthMsg = msg.IndexOf("Path", StringComparison.Ordinal);
                    msg = msg.Substring(0, lengthMsg).Trim();
                }
                string error;
                if (json.Split('\n').Length > 1)
                {
                    error = json.Split('\n')[line];
                }
                else
                {
                    int startIndex = position - 20;
                    int lengthMsg = 40;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                        lengthMsg = json.Length;
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        int length = startIndex + lengthMsg;
                        if (length > json.Length)
                        {
                            lengthMsg -= 8;
                        }
                    }
                    error = json.Substring(startIndex, lengthMsg);
                }
                errorMsg = $@"Error in line {line + 1}, somewhere near: 
                            {Environment.NewLine} {error} {Environment.NewLine} {msg}";
            }
            return errorMsg;
        }
        public static string PrettyJson(string json)
        {
            string error = JsonValidator(json);
            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }

            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);

            return JsonSerializer.Serialize(jsonElement, options);
        }
        public static string Escape(string json)
        {
            string error = JsonValidator(json);
            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }

            JsonSerializerOptions jsonSerializerOption = new JsonSerializerOptions();
            jsonSerializerOption.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return JsonSerializer.Serialize(json, jsonSerializerOption);
        }
        public static string Unescape(string json)
        {
            string error = JsonValidator(json);
            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }

            JsonSerializerOptions jsonSerializerOption = new JsonSerializerOptions();
            jsonSerializerOption.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return JsonSerializer.Deserialize<string>(json, jsonSerializerOption);
        }
    }
}
