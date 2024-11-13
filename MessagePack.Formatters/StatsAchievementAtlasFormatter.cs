using System.Collections.Generic;

namespace MessagePack.Formatters;

public sealed class StatsAchievementAtlasFormatter : IMessagePackFormatter<StatsAchievementAtlas>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, StatsAchievementAtlas value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(2);
		resolver.GetFormatterWithVerify<List<StatsAndAchievementsData>>().Serialize(ref writer, value.statsAndAchievementsDataList, options);
		resolver.GetFormatterWithVerify<List<UnlockAtlasItem>>().Serialize(ref writer, value.UnlockAtlasList, options);
	}

	public StatsAchievementAtlas Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		StatsAchievementAtlas statsAchievementAtlas = new StatsAchievementAtlas();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				statsAchievementAtlas.statsAndAchievementsDataList = resolver.GetFormatterWithVerify<List<StatsAndAchievementsData>>().Deserialize(ref reader, options);
				break;
			case 1:
				statsAchievementAtlas.UnlockAtlasList = resolver.GetFormatterWithVerify<List<UnlockAtlasItem>>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return statsAchievementAtlas;
	}
}
