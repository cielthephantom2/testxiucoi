namespace MessagePack.Formatters;

public sealed class SimplePackItemFormatter : IMessagePackFormatter<SimplePackItem>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimplePackItem value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(2);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.id, options);
		writer.Write(value.amount);
	}

	public SimplePackItem Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimplePackItem simplePackItem = new SimplePackItem();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simplePackItem.id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simplePackItem.amount = reader.ReadInt32();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simplePackItem;
	}
}
