using UnityEngine;

namespace MessagePack.Formatters;

public sealed class SimpleMapUnitFormatter : IMessagePackFormatter<SimpleMapUnit>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimpleMapUnit value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(2);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.map_id, options);
		resolver.GetFormatterWithVerify<Vector3Int>().Serialize(ref writer, value.unit_pos, options);
	}

	public SimpleMapUnit Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimpleMapUnit simpleMapUnit = new SimpleMapUnit();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simpleMapUnit.map_id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simpleMapUnit.unit_pos = resolver.GetFormatterWithVerify<Vector3Int>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simpleMapUnit;
	}
}
