using UnityEngine;

namespace MessagePack.Formatters;

public sealed class TerrainDataFormatter : IMessagePackFormatter<TerrainData>, IMessagePackFormatter
{
	public void Serialize(ref MessagePackWriter writer, TerrainData value, MessagePackSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNil();
			return;
		}
		IFormatterResolver resolver = options.Resolver;
		writer.WriteArrayHeader(10);
		writer.Write(value.terrainKeepTime);
		writer.Write(value.isPersistent);
		writer.Write(value.loopRun);
		resolver.GetFormatterWithVerify<TerrainType>().Serialize(ref writer, value.t_type, options);
		writer.Write(value.damageValue);
		writer.Write(value.isBlasting);
		writer.Write(value.m_BlastSputterATKup);
		writer.Write(value.m_BlastAttackDizzy);
		writer.Write(value.m_BlastSputterAttackDizzy);
		resolver.GetFormatterWithVerify<Vector3Int>().Serialize(ref writer, value.m_pos, options);
	}

	public TerrainData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
	{
		if (reader.TryReadNil())
		{
			return null;
		}
		options.Security.DepthStep(ref reader);
		IFormatterResolver resolver = options.Resolver;
		int num = reader.ReadArrayHeader();
		TerrainData terrainData = new TerrainData();
		for (int i = 0; i < num; i++)
		{
			switch (i)
			{
			case 0:
				terrainData.terrainKeepTime = reader.ReadInt32();
				break;
			case 1:
				terrainData.isPersistent = reader.ReadBoolean();
				break;
			case 2:
				terrainData.loopRun = reader.ReadBoolean();
				break;
			case 3:
				terrainData.t_type = resolver.GetFormatterWithVerify<TerrainType>().Deserialize(ref reader, options);
				break;
			case 4:
				terrainData.damageValue = reader.ReadSingle();
				break;
			case 5:
				terrainData.isBlasting = reader.ReadBoolean();
				break;
			case 6:
				terrainData.m_BlastSputterATKup = reader.ReadSingle();
				break;
			case 7:
				terrainData.m_BlastAttackDizzy = reader.ReadSingle();
				break;
			case 8:
				terrainData.m_BlastSputterAttackDizzy = reader.ReadSingle();
				break;
			case 9:
				terrainData.m_pos = resolver.GetFormatterWithVerify<Vector3Int>().Deserialize(ref reader, options);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.Depth--;
		return terrainData;
	}
}
