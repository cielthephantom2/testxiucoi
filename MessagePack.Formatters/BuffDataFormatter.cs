namespace MessagePack.Formatters;

public sealed class BuffDataFormatter : IMessagePackFormatter<BuffData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, BuffData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(5);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.source, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.name, options);
		writer.Write(value.value);
		writer.Write(value.turn);
		writer.Write(value.drunk);
	}

	public BuffData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		BuffData buffData = new BuffData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				buffData.source = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				buffData.name = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				buffData.value = reader.ReadSingle();
				break;
			case 3:
				buffData.turn = reader.ReadInt32();
				break;
			case 4:
				buffData.drunk = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return buffData;
	}
}
