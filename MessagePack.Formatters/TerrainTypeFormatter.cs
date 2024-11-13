namespace MessagePack.Formatters;

public sealed class TerrainTypeFormatter : IMessagePackFormatter<TerrainType>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, TerrainType value, MessagePackSerializerOptions options)
	{
		writer.Write((int)value);
	}

	public TerrainType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		return (TerrainType)reader.ReadInt32();
	}
}
