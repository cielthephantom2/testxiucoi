namespace MessagePack.Formatters;

public sealed class GameIconTypeFormatter : IMessagePackFormatter<GameIconType>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, GameIconType value, MessagePackSerializerOptions options)
	{
		writer.Write((int)value);
	}

	public GameIconType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		return (GameIconType)reader.ReadInt32();
	}
}
