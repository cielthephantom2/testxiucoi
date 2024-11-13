namespace MessagePack.Formatters;

public sealed class gang_b03Table_RowFormatter : IMessagePackFormatter<gang_b03Table.Row>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, gang_b03Table.Row value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(54);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.ID, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Star, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name_EN, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Icon, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.BookIcon, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Origin, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.LV, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Style, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Damage, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Damageadd, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Expend, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Expendadd, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.EXP, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.EXPadd, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Attckstyle, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Area, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Range, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Space, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Decreaserate, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.DelayedattackType, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.DelayedattackTime, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Effect, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Sound, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Site, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Beat, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Dart, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Crit, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Critadd, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Crit1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Crit1add, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Combo, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Comboadd, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill1EC, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill2, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill2EC, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill3, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill3EC, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill4, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill4EC, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill5, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Skill5EC, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Limit1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Limit2, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Limit3, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Paraplus1, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Paraplus2, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Paraplus3, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Paraplus4, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.AppendTraits, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.atlasType, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.isAtlas, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name_Trans, options);
	}

	public gang_b03Table.Row Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		gang_b03Table.Row row = new gang_b03Table.Row();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				row.ID = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				row.Star = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				row.Name = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				row.Name_EN = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				row.Icon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 5:
				row.BookIcon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 6:
				row.Origin = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 7:
				row.LV = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 8:
				row.Style = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 9:
				row.Damage = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 10:
				row.Damageadd = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 11:
				row.Expend = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 12:
				row.Expendadd = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 13:
				row.EXP = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 14:
				row.EXPadd = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 15:
				row.Attckstyle = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 16:
				row.Area = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 17:
				row.Range = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 18:
				row.Space = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 19:
				row.Decreaserate = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 20:
				row.DelayedattackType = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 21:
				row.DelayedattackTime = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 22:
				row.Effect = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 23:
				row.Sound = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 24:
				row.Site = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 25:
				row.Beat = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 26:
				row.Dart = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 27:
				row.Crit = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 28:
				row.Critadd = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 29:
				row.Crit1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 30:
				row.Crit1add = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 31:
				row.Combo = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 32:
				row.Comboadd = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 33:
				row.Skill1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 34:
				row.Skill1EC = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 35:
				row.Skill2 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 36:
				row.Skill2EC = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 37:
				row.Skill3 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 38:
				row.Skill3EC = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 39:
				row.Skill4 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 40:
				row.Skill4EC = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 41:
				row.Skill5 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 42:
				row.Skill5EC = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 43:
				row.Limit1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 44:
				row.Limit2 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 45:
				row.Limit3 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 46:
				row.Paraplus1 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 47:
				row.Paraplus2 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 48:
				row.Paraplus3 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 49:
				row.Paraplus4 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 50:
				row.AppendTraits = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 51:
				row.atlasType = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 52:
				row.isAtlas = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 53:
				resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
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
