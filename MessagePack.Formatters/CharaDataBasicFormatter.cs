using System.Collections.Generic;

namespace MessagePack.Formatters;

public sealed class CharaDataBasicFormatter : IMessagePackFormatter<CharaDataBasic>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, CharaDataBasic value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(11);
		writer.Write(value.m_Hp);
		writer.Write(value.m_Mp);
		resolver.GetFormatterWithVerify<Dictionary<string, AtomData>>().Serialize(ref writer, value.Indexs_Name, options);
		resolver.GetFormatterWithVerify<List<BuffData>>().Serialize(ref writer, value.m_Buffs, options);
		writer.Write(value.m_Exp);
		writer.Write(value.m_Money);
		writer.Write(value.m_Level);
		resolver.GetFormatterWithVerify<List<KongFuData>>().Serialize(ref writer, value.m_KongFuList, options);
		writer.Write(value.m_Talent);
		resolver.GetFormatterWithVerify<List<string>>().Serialize(ref writer, value.m_TraitList, options);
		resolver.GetFormatterWithVerify<List<KongFuData>>().Serialize(ref writer, value.m_AbolishedKongFuList, options);
	}

	public CharaDataBasic Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		CharaDataBasic charaDataBasic = new CharaDataBasic();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				charaDataBasic.m_Hp = reader.ReadSingle();
				break;
			case 1:
				charaDataBasic.m_Mp = reader.ReadSingle();
				break;
			case 2:
				charaDataBasic.Indexs_Name = resolver.GetFormatterWithVerify<Dictionary<string, AtomData>>().Deserialize(ref reader, options);
				break;
			case 3:
				charaDataBasic.m_Buffs = resolver.GetFormatterWithVerify<List<BuffData>>().Deserialize(ref reader, options);
				break;
			case 4:
				charaDataBasic.m_Exp = reader.ReadInt32();
				break;
			case 5:
				charaDataBasic.m_Money = reader.ReadInt32();
				break;
			case 6:
				charaDataBasic.m_Level = reader.ReadInt32();
				break;
			case 7:
				charaDataBasic.m_KongFuList = resolver.GetFormatterWithVerify<List<KongFuData>>().Deserialize(ref reader, options);
				break;
			case 8:
				charaDataBasic.m_Talent = reader.ReadInt32();
				break;
			case 9:
				charaDataBasic.m_TraitList = resolver.GetFormatterWithVerify<List<string>>().Deserialize(ref reader, options);
				break;
			case 10:
				charaDataBasic.m_AbolishedKongFuList = resolver.GetFormatterWithVerify<List<KongFuData>>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return charaDataBasic;
	}
}
