using UnityEngine;

namespace MessagePack.Formatters;

public sealed class MineInfoFormatter : IMessagePackFormatter<MineInfo>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, MineInfo value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(5);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value._scenename, options);
		resolver.GetFormatterWithVerify<Vector3Int>().Serialize(ref writer, value._grid, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value._tileObjName, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value._c04ID, options);
		writer.Write(value._isDigged);
	}

	public MineInfo Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		MineInfo mineInfo = new MineInfo();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				mineInfo._scenename = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				mineInfo._grid = resolver.GetFormatterWithVerify<Vector3Int>().Deserialize(ref reader, options);
				break;
			case 2:
				mineInfo._tileObjName = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				mineInfo._c04ID = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				mineInfo._isDigged = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return mineInfo;
	}
}
