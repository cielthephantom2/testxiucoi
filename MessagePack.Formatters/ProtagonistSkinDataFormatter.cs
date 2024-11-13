namespace MessagePack.Formatters;

public sealed class ProtagonistSkinDataFormatter : IMessagePackFormatter<ProtagonistSkinData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, ProtagonistSkinData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(8);
		resolver.GetFormatterWithVerify<SkinType>().Serialize(ref writer, value.SkinType, options);
		writer.Write(value.Face);
		writer.Write(value.Hair);
		writer.Write(value.Clothes);
		writer.Write(value.Hat);
		writer.Write(value.FaceMask);
		writer.Write(value.Cloak);
		writer.Write(value.Beard);
	}

	public ProtagonistSkinData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		ProtagonistSkinData protagonistSkinData = new ProtagonistSkinData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				protagonistSkinData.SkinType = resolver.GetFormatterWithVerify<SkinType>().Deserialize(ref reader, options);
				break;
			case 1:
				protagonistSkinData.Face = reader.ReadInt32();
				break;
			case 2:
				protagonistSkinData.Hair = reader.ReadInt32();
				break;
			case 3:
				protagonistSkinData.Clothes = reader.ReadInt32();
				break;
			case 4:
				protagonistSkinData.Hat = reader.ReadInt32();
				break;
			case 5:
				protagonistSkinData.FaceMask = reader.ReadInt32();
				break;
			case 6:
				protagonistSkinData.Cloak = reader.ReadInt32();
				break;
			case 7:
				protagonistSkinData.Beard = reader.ReadInt32();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return protagonistSkinData;
	}
}
