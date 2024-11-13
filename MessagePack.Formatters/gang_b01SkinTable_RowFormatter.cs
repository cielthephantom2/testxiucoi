namespace MessagePack.Formatters;

public sealed class gang_b01SkinTable_RowFormatter : IMessagePackFormatter<gang_b01SkinTable.Row>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, gang_b01SkinTable.Row value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(32);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.ID, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name_Id, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.model, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Clothes, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Head, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HeadOther, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Eyes, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HandLeft, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HandRight, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.SleeveLeft, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.SleeveRight, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.LegLeft, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.LegRight, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.CloakBack, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.CloakFront, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.EyesBeHit, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HairBack, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HairFront, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Hat, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HandLeftItem, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HandLeftWeapon, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HandRightItem, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.HandRightWeapon, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.WeaponBack, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.WeaponBack2, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.BackPack, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.weapon_sword, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.weapon_knife, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.weapon_stick, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.FaceMask, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Bread, options);
	}

	public gang_b01SkinTable.Row Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		gang_b01SkinTable.Row row = new gang_b01SkinTable.Row();
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
				row.Name_Id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				row.model = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				row.Clothes = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 5:
				row.Head = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 6:
				row.HeadOther = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 7:
				row.Eyes = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 8:
				row.HandLeft = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 9:
				row.HandRight = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 10:
				row.SleeveLeft = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 11:
				row.SleeveRight = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 12:
				row.LegLeft = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 13:
				row.LegRight = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 14:
				row.CloakBack = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 15:
				row.CloakFront = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 16:
				row.EyesBeHit = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 17:
				row.HairBack = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 18:
				row.HairFront = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 19:
				row.Hat = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 20:
				row.HandLeftItem = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 21:
				row.HandLeftWeapon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 22:
				row.HandRightItem = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 23:
				row.HandRightWeapon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 24:
				row.WeaponBack = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 25:
				row.WeaponBack2 = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 26:
				row.BackPack = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 27:
				row.weapon_sword = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 28:
				row.weapon_knife = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 29:
				row.weapon_stick = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 30:
				row.FaceMask = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 31:
				row.Bread = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
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
