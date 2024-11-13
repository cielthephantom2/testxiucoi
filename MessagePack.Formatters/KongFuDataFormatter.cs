using System.Collections.Generic;
using UnityEngine;

namespace MessagePack.Formatters;

public sealed class KongFuDataFormatter : IMessagePackFormatter<KongFuData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, KongFuData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(17);
		writer.WriteNil();
		resolver.GetFormatterWithVerify<gang_b03Table.Row>().Serialize(ref writer, value.kf, options);
		writer.Write(value.lv);
		writer.Write(value.exp);
		writer.Write(value.proficiency);
		resolver.GetFormatterWithVerify<Vector3Int>().Serialize(ref writer, value.runtime_atk_pos, options);
		writer.Write(value.runtime_combo_rate);
		writer.Write(value.runtime_style_damage);
		writer.Write(value.newlv);
		writer.Write(value.isSummonSkill);
		writer.Write(value.isSwapPosSkill);
		writer.Write(value.isAttackSkill);
		writer.Write(value.isHealHpSkill);
		writer.Write(value.isHealNegativeBuffSkill);
		writer.Write(value.isBuffSkill);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.BuffSkillList, options);
		writer.Write(value.isAbolished);
	}

	public KongFuData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		KongFuData kongFuData = new KongFuData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 1:
				kongFuData.kf = resolver.GetFormatterWithVerify<gang_b03Table.Row>().Deserialize(ref reader, options);
				break;
			case 2:
				kongFuData.lv = reader.ReadInt32();
				break;
			case 3:
				kongFuData.exp = reader.ReadSingle();
				break;
			case 4:
				kongFuData.proficiency = reader.ReadInt32();
				break;
			case 5:
				kongFuData.runtime_atk_pos = resolver.GetFormatterWithVerify<Vector3Int>().Deserialize(ref reader, options);
				break;
			case 6:
				kongFuData.runtime_combo_rate = reader.ReadSingle();
				break;
			case 7:
				kongFuData.runtime_style_damage = reader.ReadSingle();
				break;
			case 8:
				kongFuData.newlv = reader.ReadInt32();
				break;
			case 9:
				kongFuData.isSummonSkill = reader.ReadBoolean();
				break;
			case 10:
				kongFuData.isSwapPosSkill = reader.ReadBoolean();
				break;
			case 11:
				kongFuData.isAttackSkill = reader.ReadBoolean();
				break;
			case 12:
				kongFuData.isHealHpSkill = reader.ReadBoolean();
				break;
			case 13:
				kongFuData.isHealNegativeBuffSkill = reader.ReadBoolean();
				break;
			case 14:
				kongFuData.isBuffSkill = reader.ReadBoolean();
				break;
			case 15:
				kongFuData.BuffSkillList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 16:
				kongFuData.isAbolished = reader.ReadBoolean();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return kongFuData;
	}
}
