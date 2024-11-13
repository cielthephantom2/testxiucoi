namespace MessagePack.Formatters;

public sealed class HSLDataFormatter : IMessagePackFormatter<HSLData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, HSLData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		writer.WriteArrayHeader(3);
		writer.Write(value.hueValue);
		writer.Write(value.saturationValue);
		writer.Write(value.lightnessValue);
	}

	public HSLData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		int num = reader.ReadArrayHeader();
		HSLData hSLData = new HSLData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				hSLData.hueValue = reader.ReadSingle();
				break;
			case 1:
				hSLData.saturationValue = reader.ReadSingle();
				break;
			case 2:
				hSLData.lightnessValue = reader.ReadSingle();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return hSLData;
	}
}
