using Newtonsoft.Json;
using System;

public class UnixDateTimeConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
            return null;

        long ticks;
        if (long.TryParse(reader.Value.ToString(), out ticks))
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(ticks).DateTime;
        }

        throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing Unix timestamp.");
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value is DateTime)
        {
            DateTime dateTime = (DateTime)value;
            long unixTime = new DateTimeOffset(dateTime).ToUnixTimeMilliseconds();
            writer.WriteValue(unixTime);
        }
        else
        {
            throw new JsonSerializationException("Expected DateTime or Nullable<DateTime>.");
        }
    }
}
