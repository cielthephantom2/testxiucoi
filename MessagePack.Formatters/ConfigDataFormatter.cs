using System.Collections.Generic;

namespace MessagePack.Formatters;

public sealed class ConfigDataFormatter : IMessagePackFormatter<ConfigData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, ConfigData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(26);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.saveDataList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.snapshotList, options);
		resolver.GetFormatterWithVerify<List<float>>().Serialize(ref writer, value.gameDurationList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.LastWriteTime, options);
		resolver.GetFormatterWithVerify<List<List<string>>>().Serialize(ref writer, value.FollowerIconList, options);
		writer.Write(value.lastSaveId);
		writer.Write(value.playRound);
		writer.Write(value.masterVolume);
		writer.Write(value.musicVolume);
		writer.Write(value.seVolume);
		writer.Write(value.screenmode);
		writer.Write(value.resolution);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.inheritItems, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.language, options);
		writer.Write(value.m_create_serial_id);
		writer.Write(value.isMasterMute);
		writer.Write(value.isMusicMute);
		writer.Write(value.isSEMute);
		resolver.GetFormatterWithVerify<List<List<gang_b01SkinTable.Row>>>().Serialize(ref writer, value.FollowerIconB01SkinList, options);
		writer.Write(value.gameSpeed);
		resolver.GetFormatterWithVerify<GameIconType>().Serialize(ref writer, value.gameIconType, options);
		writer.Write(value.currentAutoSaveIndex);
		writer.Write(value.InheritItemCount);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.b02append, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.b03append, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.b07append, options);
	}

	public ConfigData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		ConfigData configData = new ConfigData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				configData.saveDataList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 1:
				configData.snapshotList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 2:
				configData.gameDurationList = resolver.GetFormatterWithVerify<List<float>>().Deserialize(ref reader, options);
				break;
			case 3:
				configData.LastWriteTime = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 4:
				configData.FollowerIconList = resolver.GetFormatterWithVerify<List<List<string>>>().Deserialize(ref reader, options);
				break;
			case 5:
				configData.lastSaveId = reader.ReadInt32();
				break;
			case 6:
				configData.playRound = reader.ReadInt32();
				break;
			case 7:
				configData.masterVolume = reader.ReadSingle();
				break;
			case 8:
				configData.musicVolume = reader.ReadSingle();
				break;
			case 9:
				configData.seVolume = reader.ReadSingle();
				break;
			case 10:
				configData.screenmode = reader.ReadInt32();
				break;
			case 11:
				configData.resolution = reader.ReadInt32();
				break;
			case 12:
				configData.inheritItems = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 13:
				configData.language = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 14:
				configData.m_create_serial_id = reader.ReadInt32();
				break;
			case 15:
				configData.isMasterMute = reader.ReadBoolean();
				break;
			case 16:
				configData.isMusicMute = reader.ReadBoolean();
				break;
			case 17:
				configData.isSEMute = reader.ReadBoolean();
				break;
			case 18:
				configData.FollowerIconB01SkinList = resolver.GetFormatterWithVerify<List<List<gang_b01SkinTable.Row>>>().Deserialize(ref reader, options);
				break;
			case 19:
				configData.gameSpeed = reader.ReadInt32();
				break;
			case 20:
				configData.gameIconType = resolver.GetFormatterWithVerify<GameIconType>().Deserialize(ref reader, options);
				break;
			case 21:
				configData.currentAutoSaveIndex = reader.ReadInt32();
				break;
			case 22:
				configData.InheritItemCount = reader.ReadInt32();
				break;
			case 23:
				configData.b02append = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 24:
				configData.b03append = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 25:
				configData.b07append = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return configData;
	}
}
