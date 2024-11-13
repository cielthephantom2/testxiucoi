namespace MessagePack.Formatters;

public sealed class SimpleEventRecordFormatter : IMessagePackFormatter<SimpleEventRecord>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimpleEventRecord value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(8);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.map_id, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.originevdata_flag, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.evdata_flag, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.display, options);
		writer.Write(value.flow);
		writer.Write(value.elseroute);
		writer.Write(value.objdirection);
		writer.Write(value.objcamarectrl);
	}

	public SimpleEventRecord Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimpleEventRecord simpleEventRecord = new SimpleEventRecord();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simpleEventRecord.map_id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simpleEventRecord.originevdata_flag = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				simpleEventRecord.evdata_flag = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				simpleEventRecord.display = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				simpleEventRecord.flow = reader.ReadInt32();
				break;
			case 5:
				simpleEventRecord.elseroute = reader.ReadBoolean();
				break;
			case 6:
				simpleEventRecord.objdirection = reader.ReadInt32();
				break;
			case 7:
				simpleEventRecord.objcamarectrl = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simpleEventRecord;
	}
}
