namespace MessagePack.Formatters;

public sealed class UnlockAtlasItemFormatter : IMessagePackFormatter<UnlockAtlasItem>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, UnlockAtlasItem value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(3);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.ID, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.tableName, options);
		writer.Write(value.isRead);
	}

	public UnlockAtlasItem Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		UnlockAtlasItem unlockAtlasItem = new UnlockAtlasItem();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				unlockAtlasItem.ID = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				unlockAtlasItem.tableName = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				unlockAtlasItem.isRead = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return unlockAtlasItem;
	}
}
