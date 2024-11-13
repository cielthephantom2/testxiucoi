namespace MessagePack.Formatters;

public sealed class SimpleFlagDataFormatter : IMessagePackFormatter<SimpleFlagData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimpleFlagData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(2);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.flag, options);
		writer.Write(value.value);
	}

	public SimpleFlagData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimpleFlagData simpleFlagData = new SimpleFlagData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simpleFlagData.flag = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simpleFlagData.value = reader.ReadInt32();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simpleFlagData;
	}
}
