namespace MessagePack.Formatters;

public sealed class ProtagonistSkinDataNewFormatter : IMessagePackFormatter<ProtagonistSkinDataNew>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, ProtagonistSkinDataNew value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(13);
		resolver.GetFormatterWithVerify<SkinType>().Serialize(ref writer, value.SkinType, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Clothes, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Eyes, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Hat, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Nose, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Facemask, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Mouth, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Beard, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HairFront, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Cloak, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HairBack, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.WeaponBack, options);
		writer.Write(value.isCustom);
	}

	public ProtagonistSkinDataNew Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		ProtagonistSkinDataNew protagonistSkinDataNew = new ProtagonistSkinDataNew();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				protagonistSkinDataNew.SkinType = resolver.GetFormatterWithVerify<SkinType>().Deserialize(ref reader, options);
				break;
			case 1:
				protagonistSkinDataNew.Clothes = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				protagonistSkinDataNew.Eyes = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				protagonistSkinDataNew.Hat = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				protagonistSkinDataNew.Nose = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 5:
				protagonistSkinDataNew.Facemask = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 6:
				protagonistSkinDataNew.Mouth = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 7:
				protagonistSkinDataNew.Beard = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 8:
				protagonistSkinDataNew.HairFront = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 9:
				protagonistSkinDataNew.Cloak = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 10:
				protagonistSkinDataNew.HairBack = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 11:
				protagonistSkinDataNew.WeaponBack = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 12:
				protagonistSkinDataNew.isCustom = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return protagonistSkinDataNew;
	}
}
