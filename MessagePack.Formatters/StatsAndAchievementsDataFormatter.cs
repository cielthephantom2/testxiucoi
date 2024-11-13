namespace MessagePack.Formatters;

public sealed class StatsAndAchievementsDataFormatter : IMessagePackFormatter<StatsAndAchievementsData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, StatsAndAchievementsData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(13);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.ID, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Achieved, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Hidden, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.GetWay, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.UnAchievedIcon, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.AchievedIcon, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Type, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.TotalValue, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.CurValue, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Name_EN, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Describe, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Describe_EN, options);
	}

	public StatsAndAchievementsData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		StatsAndAchievementsData statsAndAchievementsData = new StatsAndAchievementsData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				statsAndAchievementsData.ID = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				statsAndAchievementsData.Achieved = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				statsAndAchievementsData.Hidden = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				statsAndAchievementsData.GetWay = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				statsAndAchievementsData.UnAchievedIcon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 5:
				statsAndAchievementsData.AchievedIcon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 6:
				statsAndAchievementsData.Type = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 7:
				statsAndAchievementsData.TotalValue = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 8:
				statsAndAchievementsData.CurValue = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 9:
				statsAndAchievementsData.Name = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 10:
				statsAndAchievementsData.Name_EN = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 11:
				statsAndAchievementsData.Describe = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 12:
				statsAndAchievementsData.Describe_EN = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return statsAndAchievementsData;
	}
}
