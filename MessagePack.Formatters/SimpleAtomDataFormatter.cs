namespace MessagePack.Formatters;

public sealed class SimpleAtomDataFormatter : IMessagePackFormatter<SimpleAtomData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimpleAtomData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(12);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.id, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.stringValue, options);
		writer.Write(value.bornValue);
		writer.Write(value.alterValue);
		writer.Write(value.equipValue);
		writer.Write(value.wugongValue);
		writer.Write(value.skillValue);
		writer.Write(value.fightValue);
		writer.Write(value.rollValue);
		writer.Write(value.juqingValue);
		writer.Write(value.levelupValue);
		writer.Write(value.talentValue);
	}

	public SimpleAtomData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimpleAtomData simpleAtomData = new SimpleAtomData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simpleAtomData.id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simpleAtomData.stringValue = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				simpleAtomData.bornValue = reader.ReadSingle();
				break;
			case 3:
				simpleAtomData.alterValue = reader.ReadSingle();
				break;
			case 4:
				simpleAtomData.equipValue = reader.ReadSingle();
				break;
			case 5:
				simpleAtomData.wugongValue = reader.ReadSingle();
				break;
			case 6:
				simpleAtomData.skillValue = reader.ReadSingle();
				break;
			case 7:
				simpleAtomData.fightValue = reader.ReadSingle();
				break;
			case 8:
				simpleAtomData.rollValue = reader.ReadSingle();
				break;
			case 9:
				simpleAtomData.juqingValue = reader.ReadSingle();
				break;
			case 10:
				simpleAtomData.levelupValue = reader.ReadSingle();
				break;
			case 11:
				simpleAtomData.talentValue = reader.ReadSingle();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simpleAtomData;
	}
}
