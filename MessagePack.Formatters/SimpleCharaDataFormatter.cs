using System.Collections.Generic;

namespace MessagePack.Formatters;

public sealed class SimpleCharaDataFormatter : IMessagePackFormatter<SimpleCharaData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, SimpleCharaData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(29);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_Table, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_Id, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_Prefab, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_BattleIcon, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_DefaultPrefab, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_DefaultBattleIcon, options);
		writer.Write(value.m_Hp);
		writer.Write(value.m_Mp);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_Training_Id, options);
		writer.Write(value.m_Level);
		writer.Write(value.m_Exp);
		writer.Write(value.m_Relationship);
		writer.Write(value.m_Ranking);
		writer.Write(value.m_Talent);
		resolver.GetFormatterWithVerify<List<SimpleKongFuData>>().Serialize(ref writer, value.m_KongFuData, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.sz_KongFuData, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_KongFuListInBattle, options);
		resolver.GetFormatterWithVerify<List<SimpleAtomData>>().Serialize(ref writer, value.m_AtomData, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.sz_AtomData, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_TraitList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_EquipSlot, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_NicknameList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_EquipTraitList, options);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_titleExpList, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_currentTitleID, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_NickName, options);
		resolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.m_Guild, options);
		writer.WriteNil();
		writer.Write(value.totalTalentCost);
	}

	public SimpleCharaData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		SimpleCharaData simpleCharaData = new SimpleCharaData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				simpleCharaData.m_Table = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 1:
				simpleCharaData.m_Id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 2:
				simpleCharaData.m_Prefab = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 3:
				simpleCharaData.m_BattleIcon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 4:
				simpleCharaData.m_DefaultPrefab = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 5:
				simpleCharaData.m_DefaultBattleIcon = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 6:
				simpleCharaData.m_Hp = reader.ReadSingle();
				break;
			case 7:
				simpleCharaData.m_Mp = reader.ReadSingle();
				break;
			case 8:
				simpleCharaData.m_Training_Id = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 9:
				simpleCharaData.m_Level = reader.ReadInt32();
				break;
			case 10:
				simpleCharaData.m_Exp = reader.ReadInt32();
				break;
			case 11:
				simpleCharaData.m_Relationship = reader.ReadInt32();
				break;
			case 12:
				simpleCharaData.m_Ranking = reader.ReadInt32();
				break;
			case 13:
				simpleCharaData.m_Talent = reader.ReadInt32();
				break;
			case 14:
				simpleCharaData.m_KongFuData = resolver.GetFormatterWithVerify<List<SimpleKongFuData>>().Deserialize(ref reader, options);
				break;
			case 15:
				simpleCharaData.sz_KongFuData = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 16:
				simpleCharaData.m_KongFuListInBattle = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 17:
				simpleCharaData.m_AtomData = resolver.GetFormatterWithVerify<List<SimpleAtomData>>().Deserialize(ref reader, options);
				break;
			case 18:
				simpleCharaData.sz_AtomData = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 19:
				simpleCharaData.m_TraitList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 20:
				simpleCharaData.m_EquipSlot = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 21:
				simpleCharaData.m_NicknameList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 22:
				simpleCharaData.m_EquipTraitList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 23:
				simpleCharaData.m_titleExpList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 24:
				simpleCharaData.m_currentTitleID = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 25:
				simpleCharaData.m_NickName = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 26:
				simpleCharaData.m_Guild = resolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
				break;
			case 28:
				simpleCharaData.totalTalentCost = reader.ReadInt32();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return simpleCharaData;
	}
}
