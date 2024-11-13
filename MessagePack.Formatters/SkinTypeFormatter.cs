namespace MessagePack.Formatters;

public sealed class SkinTypeFormatter : IMessagePackFormatter<SkinType>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SkinType value, MessagePackSerializerOptions options)
	{
		writer.Write((int)value);
	}

	public SkinType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		return (SkinType)reader.ReadInt32();
	}
}
