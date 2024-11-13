namespace MessagePack.Formatters;

public sealed class RefreshMineInfoFormatter : IMessagePackFormatter<RefreshMineInfo>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, RefreshMineInfo value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(2);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value._scenename, options);
		writer.Write(value._couldRefresh);
	}

	public RefreshMineInfo Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		RefreshMineInfo refreshMineInfo = new RefreshMineInfo();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				refreshMineInfo._scenename = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				refreshMineInfo._couldRefresh = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return refreshMineInfo;
	}
}
