using System;
using System.Collections.Generic;
using MessagePack.Formatters;

namespace MessagePack.Resolvers;

internal static class GeneratedResolverGetFormatterHelper
{
	private static readonly Dictionary<Type, int> lookup;

	static GeneratedResolverGetFormatterHelper()
	{
		lookup = new Dictionary<Type, int>(49)
		{
			{
				typeof(Dictionary<string, AtomData>),
				0
			},
			{
				typeof(List<float>),
				1
			},
			{
				typeof(List<BuffData>),
				2
			},
			{
				typeof(List<gang_b01SkinTable.Row>),
				3
			},
			{
				typeof(List<KongFuData>),
				4
			},
			{
				typeof(List<MineInfo>),
				5
			},
			{
				typeof(List<RefreshMineInfo>),
				6
			},
			{
				typeof(List<SimpleAtomData>),
				7
			},
			{
				typeof(List<SimpleCharaData>),
				8
			},
			{
				typeof(List<SimpleEventRecord>),
				9
			},
			{
				typeof(List<SimpleFlagData>),
				10
			},
			{
				typeof(List<SimpleKongFuData>),
				11
			},
			{
				typeof(List<SimpleMapUnit>),
				12
			},
			{
				typeof(List<SimplePackItem>),
				13
			},
			{
				typeof(List<SimpleShopGood>),
				14
			},
			{
				typeof(List<StatsAndAchievementsData>),
				15
			},
			{
				typeof(List<List<gang_b01SkinTable.Row>>),
				16
			},
			{
				typeof(List<List<string>>),
				17
			},
			{
				typeof(List<UnlockAtlasItem>),
				18
			},
			{
				typeof(List<string>),
				19
			},
			{
				typeof(GameIconType),
				20
			},
			{
				typeof(SkinType),
				21
			},
			{
				typeof(TerrainType),
				22
			},
			{
				typeof(AtomData),
				23
			},
			{
				typeof(BuffData),
				24
			},
			{
				typeof(CharaDataBasic),
				25
			},
			{
				typeof(ConfigData),
				26
			},
			{
				typeof(GameData),
				27
			},
			{
				typeof(gang_b01SkinTable.Row),
				28
			},
			{
				typeof(gang_b02Table.Row),
				29
			},
			{
				typeof(gang_b03Table.Row),
				30
			},
			{
				typeof(HSLData),
				31
			},
			{
				typeof(KongFuData),
				32
			},
			{
				typeof(MineInfo),
				33
			},
			{
				typeof(ProtagonistSkinData),
				34
			},
			{
				typeof(ProtagonistSkinDataNew),
				35
			},
			{
				typeof(RefreshMineInfo),
				36
			},
			{
				typeof(SimpleAtomData),
				37
			},
			{
				typeof(SimpleCharaData),
				38
			},
			{
				typeof(SimpleEventRecord),
				39
			},
			{
				typeof(SimpleFlagData),
				40
			},
			{
				typeof(SimpleKongFuData),
				41
			},
			{
				typeof(SimpleMapUnit),
				42
			},
			{
				typeof(SimplePackItem),
				43
			},
			{
				typeof(SimpleShopGood),
				44
			},
			{
				typeof(StatsAchievementAtlas),
				45
			},
			{
				typeof(StatsAndAchievementsData),
				46
			},
			{
				typeof(TerrainData),
				47
			},
			{
				typeof(UnlockAtlasItem),
				48
			}
		};
	}

	internal static object GetFormatter(Type t)
	{
		if (!lookup.TryGetValue(t, out var value))
		{
			return null;
		}
		return value switch
		{
			0 => new DictionaryFormatter<string, AtomData>(), 
			1 => new ListFormatter<float>(), 
			2 => new ListFormatter<BuffData>(), 
			3 => new ListFormatter<gang_b01SkinTable.Row>(), 
			4 => new ListFormatter<KongFuData>(), 
			5 => new ListFormatter<MineInfo>(), 
			6 => new ListFormatter<RefreshMineInfo>(), 
			7 => new ListFormatter<SimpleAtomData>(), 
			8 => new ListFormatter<SimpleCharaData>(), 
			9 => new ListFormatter<SimpleEventRecord>(), 
			10 => new ListFormatter<SimpleFlagData>(), 
			11 => new ListFormatter<SimpleKongFuData>(), 
			12 => new ListFormatter<SimpleMapUnit>(), 
			13 => new ListFormatter<SimplePackItem>(), 
			14 => new ListFormatter<SimpleShopGood>(), 
			15 => new ListFormatter<StatsAndAchievementsData>(), 
			16 => new ListFormatter<List<gang_b01SkinTable.Row>>(), 
			17 => new ListFormatter<List<string>>(), 
			18 => new ListFormatter<UnlockAtlasItem>(), 
			19 => new ListFormatter<string>(), 
			20 => new GameIconTypeFormatter(), 
			21 => new SkinTypeFormatter(), 
			22 => new TerrainTypeFormatter(), 
			23 => new AtomDataFormatter(), 
			24 => new BuffDataFormatter(), 
			25 => new CharaDataBasicFormatter(), 
			26 => new ConfigDataFormatter(), 
			27 => new GameDataFormatter(), 
			28 => new gang_b01SkinTable_RowFormatter(), 
			29 => new gang_b02Table_RowFormatter(), 
			30 => new gang_b03Table_RowFormatter(), 
			31 => new HSLDataFormatter(), 
			32 => new KongFuDataFormatter(), 
			33 => new MineInfoFormatter(), 
			34 => new ProtagonistSkinDataFormatter(), 
			35 => new ProtagonistSkinDataNewFormatter(), 
			36 => new RefreshMineInfoFormatter(), 
			37 => new SimpleAtomDataFormatter(), 
			38 => new SimpleCharaDataFormatter(), 
			39 => new SimpleEventRecordFormatter(), 
			40 => new SimpleFlagDataFormatter(), 
			41 => new SimpleKongFuDataFormatter(), 
			42 => new SimpleMapUnitFormatter(), 
			43 => new SimplePackItemFormatter(), 
			44 => new SimpleShopGoodFormatter(), 
			45 => new StatsAchievementAtlasFormatter(), 
			46 => new StatsAndAchievementsDataFormatter(), 
			47 => new TerrainDataFormatter(), 
			48 => new UnlockAtlasItemFormatter(), 
			_ => null, 
		};
	}
}
