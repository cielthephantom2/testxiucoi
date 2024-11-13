namespace MessagePack.Formatters;

public sealed class SimpleKongFuDataFormatter : IMessagePackFormatter<SimpleKongFuData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimpleKongFuData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(5);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.id, options);
		writer.Write(value.lv);
		writer.Write(value.exp);
		writer.Write(value.proficiency);
		writer.Write(value.isAbolished);
	}

	public SimpleKongFuData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimpleKongFuData simpleKongFuData = new SimpleKongFuData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simpleKongFuData.id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simpleKongFuData.lv = reader.ReadInt32();
				break;
			case 2:
				simpleKongFuData.exp = reader.ReadSingle();
				break;
			case 3:
				simpleKongFuData.proficiency = reader.ReadInt32();
				break;
			case 4:
				simpleKongFuData.isAbolished = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simpleKongFuData;
	}
}
