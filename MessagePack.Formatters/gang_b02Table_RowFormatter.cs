namespace MessagePack.Formatters;

public sealed class gang_b02Table_RowFormatter : IMessagePackFormatter<gang_b02Table.Row>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, gang_b02Table.Row value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(24);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.ID, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name_EN, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Style, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Limit1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Logic, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Limitvalue, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Role, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.add1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Attribute1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.add2, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Attribute2, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.add3, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Attribute3, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.add4, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Attribute4, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.add5, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Attribute5, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skills1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skills1Ec, options);
		writer.Write(value.Enhance);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.isAtlas, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name_Trans, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.atlasType, options);
	}

	public gang_b02Table.Row Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		gang_b02Table.Row row = new gang_b02Table.Row();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				row.ID = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				row.Name = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				row.Name_EN = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				row.Style = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				row.Limit1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 5:
				row.Logic = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 6:
				row.Limitvalue = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 7:
				row.Role = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 8:
				row.add1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 9:
				row.Attribute1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 10:
				row.add2 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 11:
				row.Attribute2 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 12:
				row.add3 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 13:
				row.Attribute3 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 14:
				row.add4 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 15:
				row.Attribute4 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 16:
				row.add5 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 17:
				row.Attribute5 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 18:
				row.Skills1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 19:
				row.Skills1Ec = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 20:
				row.Enhance = reader.ReadInt32();
				break;
			case 21:
				row.isAtlas = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 22:
				resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 23:
				row.atlasType = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return row;
	}
}
