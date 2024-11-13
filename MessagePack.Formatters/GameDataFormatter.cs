using System.Collections.Generic;

namespace MessagePack.Formatters;

public sealed class GameDataFormatter : IMessagePackFormatter<GameData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, GameData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(54);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.key, options);
		writer.Write(value.timeStamp);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.saveDataTime, options);
		resolver.GetFormatterWithVerify<List<SimpleCharaData>>().Serialize(ref writer, value.simpleCharaDatas, options);
		resolver.GetFormatterWithVerify<List<SimpleMapUnit>>().Serialize(ref writer, value.simpleMapUnits, options);
		resolver.GetFormatterWithVerify<List<SimpleEventRecord>>().Serialize(ref writer, value.simpleEventRecords, options);
		resolver.GetFormatterWithVerify<List<SimpleFlagData>>().Serialize(ref writer, value.simpleFlagDatas, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.strFlagDatas, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.bornid, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.playerid, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.SceneBefore, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.SceneBefore4Camp, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.SpawnPoint, options);
		writer.Write(value.playercamctrl);
		writer.Write(value.m_Money);
		writer.Write(value.m_Epiphany);
		writer.Write(value.m_PlayRound);
		writer.Write(value.m_FieldMoveSpeedRate);
		writer.Write(value.playerdirection);
		resolver.GetFormatterWithVerify<List<SimplePackItem>>().Serialize(ref writer, value.simplePackItems, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.FullTeam, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.FollowList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.Mesg_News, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.Mesg_Tecs, options);
		writer.Write(value.Game_Mode);
		writer.Write(value.m_ArenaWinCount);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_Arena_Rewards_JunShan, options);
		resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Serialize(ref writer, value.simpleShopGoods, options);
		resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Serialize(ref writer, value.simpleLoanedItems, options);
		resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Serialize(ref writer, value.simpleHoriMonos, options);
		resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Serialize(ref writer, value.simpleWantedInfos, options);
		writer.Write(value.m_MineRefreshWalkStep);
		writer.Write(value.m_MineRefreshChangeFieldNum);
		writer.Write(value.m_ShovelDurable);
		resolver.GetFormatterWithVerify<List<MineInfo>>().Serialize(ref writer, value.mapMineList, options);
		resolver.GetFormatterWithVerify<List<RefreshMineInfo>>().Serialize(ref writer, value.mapMineCouldRefreshList, options);
		writer.Write(value.m_DaTianWangSiLevel);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_Arena_Rewards_DaTianWangSi, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_DongShuFactionMember, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_UnLockMapIconList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.b02append, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.b03append, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.b07append, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_SpecialWantedList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.lastSelectBattleIdList, options);
		writer.Write(value.isChooseBattle);
		writer.WriteNil();
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_JinWuFactionMember, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_XiBoFactionMember, options);
		resolver.GetFormatterWithVerify<gang_b01SkinTable.Row>().Serialize(ref writer, value.protagonistSkinB01SkinTable, options);
		resolver.GetFormatterWithVerify<ProtagonistSkinDataNew>().Serialize(ref writer, value.protagonistSkinDataNew, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.gameDateVersion, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_BeiGuFactionMember, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_NewItemList, options);
	}

	public GameData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		GameData gameData = new GameData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				gameData.key = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				gameData.timeStamp = reader.ReadInt64();
				break;
			case 2:
				gameData.saveDataTime = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				gameData.simpleCharaDatas = resolver.GetFormatterWithVerify<List<SimpleCharaData>>().Deserialize(ref reader, options);
				break;
			case 4:
				gameData.simpleMapUnits = resolver.GetFormatterWithVerify<List<SimpleMapUnit>>().Deserialize(ref reader, options);
				break;
			case 5:
				gameData.simpleEventRecords = resolver.GetFormatterWithVerify<List<SimpleEventRecord>>().Deserialize(ref reader, options);
				break;
			case 6:
				gameData.simpleFlagDatas = resolver.GetFormatterWithVerify<List<SimpleFlagData>>().Deserialize(ref reader, options);
				break;
			case 7:
				gameData.strFlagDatas = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 8:
				gameData.bornid = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 9:
				gameData.playerid = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 10:
				gameData.SceneBefore = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 11:
				gameData.SceneBefore4Camp = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 12:
				gameData.SpawnPoint = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 13:
				gameData.playercamctrl = reader.ReadBoolean();
				break;
			case 14:
				gameData.m_Money = reader.ReadInt32();
				break;
			case 15:
				gameData.m_Epiphany = reader.ReadInt32();
				break;
			case 16:
				gameData.m_PlayRound = reader.ReadInt32();
				break;
			case 17:
				gameData.m_FieldMoveSpeedRate = reader.ReadSingle();
				break;
			case 18:
				gameData.playerdirection = reader.ReadInt32();
				break;
			case 19:
				gameData.simplePackItems = resolver.GetFormatterWithVerify<List<SimplePackItem>>().Deserialize(ref reader, options);
				break;
			case 20:
				gameData.FullTeam = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 21:
				gameData.FollowList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 22:
				gameData.Mesg_News = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 23:
				gameData.Mesg_Tecs = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 24:
				gameData.Game_Mode = reader.ReadInt32();
				break;
			case 25:
				gameData.m_ArenaWinCount = reader.ReadInt32();
				break;
			case 26:
				gameData.m_Arena_Rewards_JunShan = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 27:
				gameData.simpleShopGoods = resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Deserialize(ref reader, options);
				break;
			case 28:
				gameData.simpleLoanedItems = resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Deserialize(ref reader, options);
				break;
			case 29:
				gameData.simpleHoriMonos = resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Deserialize(ref reader, options);
				break;
			case 30:
				gameData.simpleWantedInfos = resolver.GetFormatterWithVerify<List<SimpleShopGood>>().Deserialize(ref reader, options);
				break;
			case 31:
				gameData.m_MineRefreshWalkStep = reader.ReadInt32();
				break;
			case 32:
				gameData.m_MineRefreshChangeFieldNum = reader.ReadInt32();
				break;
			case 33:
				gameData.m_ShovelDurable = reader.ReadInt32();
				break;
			case 34:
				gameData.mapMineList = resolver.GetFormatterWithVerify<List<MineInfo>>().Deserialize(ref reader, options);
				break;
			case 35:
				gameData.mapMineCouldRefreshList = resolver.GetFormatterWithVerify<List<RefreshMineInfo>>().Deserialize(ref reader, options);
				break;
			case 36:
				gameData.m_DaTianWangSiLevel = reader.ReadInt32();
				break;
			case 37:
				gameData.m_Arena_Rewards_DaTianWangSi = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 38:
				gameData.m_DongShuFactionMember = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 39:
				gameData.m_UnLockMapIconList = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 40:
				gameData.b02append = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 41:
				gameData.b03append = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 42:
				gameData.b07append = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 43:
				gameData.m_SpecialWantedList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 44:
				gameData.lastSelectBattleIdList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 45:
				gameData.isChooseBattle = reader.ReadBoolean();
				break;
			case 47:
				gameData.m_JinWuFactionMember = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 48:
				gameData.m_XiBoFactionMember = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 49:
				gameData.protagonistSkinB01SkinTable = resolver.GetFormatterWithVerify<gang_b01SkinTable.Row>().Deserialize(ref reader, options);
				break;
			case 50:
				gameData.protagonistSkinDataNew = resolver.GetFormatterWithVerify<ProtagonistSkinDataNew>().Deserialize(ref reader, options);
				break;
			case 51:
				gameData.gameDateVersion = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 52:
				gameData.m_BeiGuFactionMember = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 53:
				gameData.m_NewItemList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return gameData;
	}
}
