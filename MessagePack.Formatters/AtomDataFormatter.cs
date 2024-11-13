namespace MessagePack.Formatters;

public sealed class AtomDataFormatter : IMessagePackFormatter<AtomData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, AtomData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(12);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.a01Name, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.a01ID, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.stringValue, options);
		writer.Write(value.bornValue);
		writer.Write(value.alterValue);
		writer.WriteNil();
		writer.Write(value.fightValue);
		writer.Write(value.drunkbuffValue);
		writer.Write(value.rollValue);
		writer.Write(value.juqingValue);
		writer.Write(value.levelupValue);
		writer.Write(value.talentValue);
	}

	public AtomData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		AtomData atomData = new AtomData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				atomData.a01Name = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				atomData.a01ID = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				atomData.stringValue = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				atomData.bornValue = reader.ReadSingle();
				break;
			case 4:
				atomData.alterValue = reader.ReadSingle();
				break;
			case 6:
				atomData.fightValue = reader.ReadSingle();
				break;
			case 7:
				atomData.drunkbuffValue = reader.ReadSingle();
				break;
			case 8:
				atomData.rollValue = reader.ReadSingle();
				break;
			case 9:
				atomData.juqingValue = reader.ReadSingle();
				break;
			case 10:
				atomData.levelupValue = reader.ReadSingle();
				break;
			case 11:
				atomData.talentValue = reader.ReadSingle();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return atomData;
	}
}
