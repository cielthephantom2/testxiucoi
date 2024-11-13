namespace MessagePack.Formatters;

public sealed class SimpleShopGoodFormatter : IMessagePackFormatter<SimpleShopGood>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimpleShopGood value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(2);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.id, options);
		writer.Write(value.hold);
	}

	public SimpleShopGood Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimpleShopGood simpleShopGood = new SimpleShopGood();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simpleShopGood.id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simpleShopGood.hold = reader.ReadInt32();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simpleShopGood;
	}
}
