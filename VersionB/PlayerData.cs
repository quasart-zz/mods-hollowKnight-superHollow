﻿using System;
using System.Collections.Generic;
using System.Reflection;
using GlobalEnums;
using UnityEngine;

// Token: 0x02000379 RID: 889
[Serializable]
public class PlayerData
{
	// Token: 0x0600143D RID: 5181 RVA: 0x0007B144 File Offset: 0x00079344
	private Dictionary<string, PlayerData.MapBools> InitMapBools()
	{
		return new Dictionary<string, PlayerData.MapBools>
		{
			{
				"Town",
				PlayerData.MapBools.MapDirtmouth
			},
			{
				"Tutorial_01",
				PlayerData.MapBools.MapDirtmouth
			},
			{
				"Abyss_03",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_04",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_05",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_06_Core",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_06_Core_b",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_08",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_09",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_10",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_12",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_16",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_17",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_18",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_18_b",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_19",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_20",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_21",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Abyss_22",
				PlayerData.MapBools.MapAbyss
			},
			{
				"Crossroads_49b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_01",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_02",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_03",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_04",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_05",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_05b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_05c",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_06",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_09",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_17",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_18",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_18_b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_23",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_24",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_25",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_27",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_28",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_29",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_30",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_31",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_31b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_31_top",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_31_top_2",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins1_32",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_01",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_01_b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_03",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_03b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_04",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_05",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_06",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_07",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_07_left",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_07_right",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_08",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_09",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_10_b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_11",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_11_b",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins2_Watcher_Room",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins_Bathhouse",
				PlayerData.MapBools.MapCity
			},
			{
				"Ruins_Elevator",
				PlayerData.MapBools.MapCity
			},
			{
				"Cliffs_01",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Cliffs_01_b",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Cliffs_02",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Cliffs_02_b",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Cliffs_04",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Cliffs_05",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Cliffs_06",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Cliffs_06_b",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Fungus1_28",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Fungus1_28_b",
				PlayerData.MapBools.MapCliffs
			},
			{
				"Crossroads_01",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_02",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_03",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_04",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_05",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_06",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_07",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_08",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_09",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_10",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_11_alt",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_12",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_13",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_14",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_15",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_16",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_18",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_19",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_21",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_22",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_25",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_27",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_30",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_31",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_33",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_35",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_36",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_37",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_38",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_39",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_40",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_42",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_43",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_45",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_46",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_47",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_48",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_49",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Crossroads_52",
				PlayerData.MapBools.MapCrossroads
			},
			{
				"Mines_01",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_02",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_03",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_04",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_05",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_06",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_07",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_10",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_11",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_13",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_16",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_17",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_18",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_19",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_20",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_20_b",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_23",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_24",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_25",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_28",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_28_b",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_29",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_30",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_31",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_32",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_34",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_36",
				PlayerData.MapBools.MapMines
			},
			{
				"Mines_37",
				PlayerData.MapBools.MapMines
			},
			{
				"Abyss_03_b",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_01b",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_02",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_03",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_09",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_10",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_14",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_16",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_17",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_26",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_26b",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_30",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_30_b",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_31",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_32",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_33",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_34",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_35",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_36",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_37",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_38",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_39",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_40",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_41",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_41_b",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_42",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_44",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Deepnest_44_b",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Fungus2_25",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Room_Mask_maker",
				PlayerData.MapBools.MapDeepnest
			},
			{
				"Fungus3_01",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_02",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_03",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_24",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_25",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_25b",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_26",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_27",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_28",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_30",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_35",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_44",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Fungus3_47",
				PlayerData.MapBools.MapFogCanyon
			},
			{
				"Deepnest_01",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_01",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_02",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_03",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_04",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_05",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_06",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_07",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_08",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_09",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_10",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_11",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_12",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_13",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_14",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_14_b",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_14_c",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_15",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_17",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_18",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_19",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_20",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_21",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_23",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_26",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_28",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_29",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_30",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_31",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_32",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_29_b",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_33",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus2_34",
				PlayerData.MapBools.MapFungalWastes
			},
			{
				"Fungus1_01",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_01b",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_02",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_03",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_04",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_05",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_06",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_07",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_08",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_09",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_09_b",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_10",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_11",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_12",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_13",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_14",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_14_b",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_15",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_16_alt",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_17",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_19",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_20_v02",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_21",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_22",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_25",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_26",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_29",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_30",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_31",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_32",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_34",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_37",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Fungus1_Slug",
				PlayerData.MapBools.MapGreenpath
			},
			{
				"Abyss_03_c",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_01",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_02",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_02b",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_03",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_04",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_06",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_07",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_08",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_09",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_09_b",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_10",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_11",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_12",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_13",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_14",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_15",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_16",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_18",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_Hornet",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_East_Hornet_b",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_01",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_02",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_03",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_03_b",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_03_c",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_04",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_04_b",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Hive_05",
				PlayerData.MapBools.MapOutskirts
			},
			{
				"Deepnest_43",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Deepnest_43_b",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus1_23",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus1_24",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_04",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_05",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_08",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_10",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_11",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_13",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_21",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_22",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_22_b",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_23",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_23_b",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_34",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_39",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_40",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_48",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_48_bot",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_48_left",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_48_top",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_49",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Fungus3_50",
				PlayerData.MapBools.MapRoyalGardens
			},
			{
				"Crossroads_46b",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"Crossroads_50",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_02",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_04",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_05",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_06",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_08",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_09",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_10_b",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_10_c",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_10_d",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_12",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_17",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"Ruins2_10",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"RestingGrounds_10",
				PlayerData.MapBools.MapRestingGrounds
			},
			{
				"Abyss_01",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Abyss_02",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_01",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_02",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_02b",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_03",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_04",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_04_part_b",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_04b",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_05",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_06",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_07",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_08",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_09",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_12",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_13",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_14",
				PlayerData.MapBools.MapWaterways
			},
			{
				"Waterways_15",
				PlayerData.MapBools.MapWaterways
			}
		};
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x0007C164 File Offset: 0x0007A364
	private bool HasMapForScene(string sceneName)
	{
		if (this.mapZoneBools == null)
		{
			this.mapZoneBools = this.InitMapBools();
		}
		if (!this.mapZoneBools.ContainsKey(sceneName))
		{
			return true;
		}
		switch (this.mapZoneBools[sceneName])
		{
		case PlayerData.MapBools.MapDirtmouth:
			return this.mapDirtmouth;
		case PlayerData.MapBools.MapCrossroads:
			return this.mapCrossroads;
		case PlayerData.MapBools.MapGreenpath:
			return this.mapGreenpath;
		case PlayerData.MapBools.MapFogCanyon:
			return this.mapFogCanyon;
		case PlayerData.MapBools.MapRoyalGardens:
			return this.mapRoyalGardens;
		case PlayerData.MapBools.MapFungalWastes:
			return this.mapFungalWastes;
		case PlayerData.MapBools.MapCity:
			return this.mapCity;
		case PlayerData.MapBools.MapWaterways:
			return this.mapWaterways;
		case PlayerData.MapBools.MapMines:
			return this.mapMines;
		case PlayerData.MapBools.MapDeepnest:
			return this.mapDeepnest;
		case PlayerData.MapBools.MapCliffs:
			return this.mapCliffs;
		case PlayerData.MapBools.MapOutskirts:
			return this.mapOutskirts;
		case PlayerData.MapBools.MapRestingGrounds:
			return this.mapRestingGrounds;
		case PlayerData.MapBools.MapAbyss:
			return this.mapAbyss;
		default:
			return false;
		}
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x0600143F RID: 5183 RVA: 0x0000E49F File Offset: 0x0000C69F
	public int CurrentMaxHealth
	{
		get
		{
			if (BossSequenceController.BoundShell)
			{
				return Mathf.Min(this.maxHealth, BossSequenceController.BoundMaxHealth);
			}
			return this.maxHealth;
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x06001440 RID: 5184 RVA: 0x0000E4BF File Offset: 0x0000C6BF
	// (set) Token: 0x06001441 RID: 5185 RVA: 0x0000E4D7 File Offset: 0x0000C6D7
	public static PlayerData instance
	{
		get
		{
			if (PlayerData._instance == null)
			{
				PlayerData._instance = new PlayerData();
			}
			return PlayerData._instance;
		}
		set
		{
			PlayerData._instance = value;
		}
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x0000E4DF File Offset: 0x0000C6DF
	protected PlayerData()
	{
		this.SetupNewPlayerData();
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x0000E4ED File Offset: 0x0000C6ED
	public void PrintStory()
	{
		Debug.Log("combining player story");
		this.playerStoryOutput = string.Join(",", this.playerStory.ToArray());
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x0000E514 File Offset: 0x0000C714
	public void Reset()
	{
		this.SetupNewPlayerData();
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x0007C248 File Offset: 0x0007A448
	public bool UpdateGameMap()
	{
		bool result = false;
		if (this.hasQuill)
		{
			foreach (string text in this.scenesVisited)
			{
				if (!this.scenesMapped.Contains(text) && this.HasMapForScene(text))
				{
					this.scenesMapped.Add(text);
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x0007C2C4 File Offset: 0x0007A4C4
	public void CheckAllMaps()
	{
		if (this.mapCrossroads && this.mapGreenpath && this.mapFogCanyon && this.mapRoyalGardens && this.mapFungalWastes && this.mapCity && this.mapWaterways && this.mapMines && this.mapDeepnest && this.mapCliffs && this.mapOutskirts && this.mapRestingGrounds && this.mapAbyss)
		{
			this.corniferAtHome = true;
		}
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x0007C340 File Offset: 0x0007A540
	public void SetBool(string boolName, bool value)
	{
		FieldInfo field = base.GetType().GetField(boolName);
		if (field != null)
		{
			field.SetValue(PlayerData.instance, value);
			return;
		}
		Debug.Log("PlayerData: Could not find field named " + boolName + ", check variable name exists and FSM variable string is correct.");
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x0007C38C File Offset: 0x0007A58C
	public void SetInt(string intName, int value)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			field.SetValue(PlayerData.instance, value);
			return;
		}
		Debug.Log("PlayerData: Could not find field named " + intName + ", check variable name exists and FSM variable string is correct.");
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x0007C3D8 File Offset: 0x0007A5D8
	public void IncrementInt(string intName)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			int num = (int)field.GetValue(PlayerData.instance);
			field.SetValue(PlayerData.instance, num + 1);
			return;
		}
		Debug.Log("PlayerData: Could not find field named " + intName + ", check variable name exists and FSM variable string is correct.");
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x0007C438 File Offset: 0x0007A638
	public void IntAdd(string intName, int amount)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			int num = (int)field.GetValue(PlayerData.instance);
			field.SetValue(PlayerData.instance, num + amount);
			return;
		}
		Debug.Log("PlayerData: Could not find field named " + intName + ", check variable name exists and FSM variable string is correct.");
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x0007C498 File Offset: 0x0007A698
	public void SetFloat(string floatName, float value)
	{
		FieldInfo field = base.GetType().GetField(floatName);
		if (field != null)
		{
			field.SetValue(PlayerData.instance, value);
			return;
		}
		Debug.Log("PlayerData: Could not find field named " + floatName + ", check variable name exists and FSM variable string is correct.");
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x0007C4E4 File Offset: 0x0007A6E4
	public void DecrementInt(string intName)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			int num = (int)field.GetValue(PlayerData.instance);
			field.SetValue(PlayerData.instance, num - 1);
		}
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x0007C52C File Offset: 0x0007A72C
	public bool GetBool(string boolName)
	{
		if (string.IsNullOrEmpty(boolName))
		{
			return false;
		}
		FieldInfo field = base.GetType().GetField(boolName);
		if (field != null)
		{
			return (bool)field.GetValue(PlayerData.instance);
		}
		Debug.Log("PlayerData: Could not find bool named " + boolName + " in PlayerData");
		return false;
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x0007C580 File Offset: 0x0007A780
	public int GetInt(string intName)
	{
		if (string.IsNullOrEmpty(intName))
		{
			Debug.LogError("PlayerData: Int with an EMPTY name requested.");
			return -9999;
		}
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			return (int)field.GetValue(PlayerData.instance);
		}
		Debug.LogError("PlayerData: Could not find int named " + intName + " in PlayerData");
		return -9999;
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x0007C5E8 File Offset: 0x0007A7E8
	public float GetFloat(string floatName)
	{
		if (string.IsNullOrEmpty(floatName))
		{
			Debug.LogError("PlayerData: Float with an EMPTY name requested.");
			return -9999f;
		}
		FieldInfo field = base.GetType().GetField(floatName);
		if (field != null)
		{
			return (float)field.GetValue(PlayerData.instance);
		}
		Debug.LogError("PlayerData: Could not find int named " + floatName + " in PlayerData");
		return -9999f;
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x0007C650 File Offset: 0x0007A850
	public string GetString(string stringName)
	{
		if (string.IsNullOrEmpty(stringName))
		{
			Debug.LogError("PlayerData: String with an EMPTY name requested.");
			return " ";
		}
		FieldInfo field = base.GetType().GetField(stringName);
		if (field != null)
		{
			return (string)field.GetValue(PlayerData.instance);
		}
		Debug.LogError("PlayerData: Could not find string named " + stringName + " in PlayerData");
		return " ";
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x0007C6B8 File Offset: 0x0007A8B8
	public void SetString(string stringName, string value)
	{
		FieldInfo field = base.GetType().GetField(stringName);
		if (field != null)
		{
			field.SetValue(PlayerData.instance, value);
			return;
		}
		Debug.Log("PlayerData: Could not find field named " + stringName + ", check variable name exists and FSM variable string is correct.");
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x0007C700 File Offset: 0x0007A900
	public void SetVector3(string vectorName, Vector3 value)
	{
		FieldInfo field = base.GetType().GetField(vectorName);
		if (field != null)
		{
			field.SetValue(PlayerData.instance, value);
			return;
		}
		Debug.Log("PlayerData: Could not find field named " + vectorName + ", check variable name exists and FSM variable string is correct.");
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x0007C74C File Offset: 0x0007A94C
	public Vector3 GetVector3(string vectorName)
	{
		FieldInfo field = base.GetType().GetField(vectorName);
		if (field != null)
		{
			return (Vector3)field.GetValue(PlayerData.instance);
		}
		Debug.LogError("PlayerData: Could not find string named " + vectorName + " in PlayerData");
		return Vector3.zero;
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x0007C79C File Offset: 0x0007A99C
	public void SetVariable<T>(string fieldName, T value)
	{
		FieldInfo field = base.GetType().GetField(fieldName);
		if (!(field != null))
		{
			Debug.LogError(string.Format("PlayerData field: {0} does not exist!", fieldName));
			return;
		}
		if (field.FieldType == typeof(T))
		{
			field.SetValue(this, value);
			return;
		}
		Debug.LogError(string.Format("PlayerData field: {0}, type {1} does not match type: {2}", fieldName, field.FieldType, typeof(T).ToString()));
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x0007C81C File Offset: 0x0007AA1C
	public T GetVariable<T>(string fieldName)
	{
		FieldInfo field = base.GetType().GetField(fieldName);
		if (field != null)
		{
			if (field.FieldType == typeof(T))
			{
				return (T)((object)field.GetValue(this));
			}
			Debug.LogError(string.Format("PlayerData field: {0}, type {1} does not match type: {2}", fieldName, field.FieldType, typeof(T).ToString()));
		}
		else
		{
			Debug.LogError(string.Format("PlayerData field: {0} does not exist!", fieldName));
		}
		return default(T);
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x0007C8A4 File Offset: 0x0007AAA4
	public void AddHealth(int amount)
	{
		if (this.health + amount >= this.maxHealth)
		{
			this.health = this.maxHealth;
		}
		else
		{
			this.health += amount;
		}
		if (this.health >= this.CurrentMaxHealth)
		{
			this.health = this.maxHealth;
		}
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
	public void TakeHealth(int amount)
	{
		if (amount > 0 && this.health == this.maxHealth && this.health != this.CurrentMaxHealth)
		{
			this.health = this.CurrentMaxHealth;
		}
		if (this.healthBlue > 0)
		{
			int num = amount - this.healthBlue;
			this.damagedBlue = true;
			this.healthBlue -= amount;
			if (this.healthBlue < 0)
			{
				this.healthBlue = 0;
			}
			if (num > 0)
			{
				this.TakeHealth(num);
				return;
			}
		}
		else
		{
			this.damagedBlue = false;
			if (this.health - amount <= 0)
			{
				this.health = 0;
				return;
			}
			this.health -= amount;
		}
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x0000E51C File Offset: 0x0000C71C
	public void MaxHealth()
	{
		this.prevHealth = this.health;
		this.health = this.CurrentMaxHealth;
		this.blockerHits = 4;
		this.UpdateBlueHealth();
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x0007C99C File Offset: 0x0007AB9C
	public void ActivateTestingCheats()
	{
		this.rancidEggs += 3;
		this.simpleKeys += 3;
		this.ore += 6;
		this.AddGeo(50000);
		this.openedTownBuilding = true;
		this.openedCrossroads = true;
		this.openedGreenpath = true;
		this.openedFungalWastes = true;
		this.openedRuins1 = true;
		this.openedRuins2 = true;
		this.openedRoyalGardens = true;
		this.openedRestingGrounds = true;
		this.openedDeepnest = true;
		this.openedStagNest = true;
		this.openedHiddenStation = true;
		this.dreamOrbs = 9999;
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x0007CA38 File Offset: 0x0007AC38
	public void GetAllPowerups()
	{
		this.canDash = true;
		this.hasDash = true;
		this.hasWalljump = true;
		this.canWallJump = true;
		this.hasSuperDash = true;
		this.hasDreamNail = true;
		this.hasShadowDash = true;
		this.canShadowDash = true;
		this.dreamNailUpgraded = true;
		this.hasDoubleJump = true;
		this.hasLantern = true;
		this.hasAcidArmour = true;
		this.hasTramPass = true;
		this.hasSpell = true;
		if (this.fireballLevel == 0)
		{
			this.fireballLevel = 1;
		}
		if (this.quakeLevel == 0)
		{
			this.quakeLevel = 1;
		}
		if (this.screamLevel == 0)
		{
			this.screamLevel = 1;
		}
		this.hasLoveKey = true;
		this.hasWhiteKey = true;
		this.hasKingsBrand = true;
		this.hasNailArt = true;
		this.hasDashSlash = true;
		this.hasCyclone = true;
		this.hasUpwardSlash = true;
		this.hasCharm = true;
		this.gotCharm_1 = true;
		this.gotCharm_2 = true;
		this.gotCharm_3 = true;
		this.gotCharm_4 = true;
		this.gotCharm_5 = true;
		this.gotCharm_6 = true;
		this.gotCharm_7 = true;
		this.gotCharm_8 = true;
		this.gotCharm_9 = true;
		this.gotCharm_10 = true;
		this.gotCharm_11 = true;
		this.gotCharm_12 = true;
		this.gotCharm_13 = true;
		this.gotCharm_14 = true;
		this.gotCharm_15 = true;
		this.gotCharm_16 = true;
		this.gotCharm_17 = true;
		this.gotCharm_18 = true;
		this.gotCharm_19 = true;
		this.gotCharm_20 = true;
		this.gotCharm_21 = true;
		this.gotCharm_22 = true;
		this.gotCharm_23 = true;
		this.gotCharm_24 = true;
		this.gotCharm_25 = true;
		this.gotCharm_26 = true;
		this.gotCharm_27 = true;
		this.gotCharm_28 = true;
		this.gotCharm_29 = true;
		this.gotCharm_30 = true;
		this.gotCharm_31 = true;
		this.gotCharm_32 = true;
		this.gotCharm_33 = true;
		this.gotCharm_34 = true;
		this.gotCharm_35 = true;
		this.gotCharm_37 = true;
		this.gotCharm_38 = true;
		this.gotCharm_39 = true;
		this.charmSlots = 50;
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x0007CC20 File Offset: 0x0007AE20
	public void AddToMaxHealth(int amount)
	{
		this.maxHealthBase += amount;
		if (!this.equippedCharm_27)
		{
			this.maxHealth += amount;
		}
		this.prevHealth = this.health;
		this.health = this.maxHealth;
		if (this.maxHealthBase == this.maxHealthCap)
		{
			this.heartPieceMax = true;
		}
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x0000E543 File Offset: 0x0000C743
	public void UpdateBlueHealth()
	{
		this.healthBlue = 0;
		if (this.equippedCharm_8)
		{
			this.healthBlue += 2;
		}
		if (this.equippedCharm_9)
		{
			this.healthBlue += 4;
		}
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x0000E578 File Offset: 0x0000C778
	public void AddGeo(int amount)
	{
		this.geo += amount;
		if (this.geo > 9999999)
		{
			this.geo = 9999999;
		}
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
	public void TakeGeo(int amount)
	{
		this.geo -= amount;
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
	public bool WouldDie(int damage)
	{
		return this.health - damage <= 0;
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x0007CC80 File Offset: 0x0007AE80
	public bool AddMPCharge(int amount)
	{
		bool result = false;
		if (this.soulLimited && this.maxMP != 66)
		{
			this.maxMP = 66;
		}
		if (!this.soulLimited && this.maxMP != 99)
		{
			this.maxMP = 99;
		}
		if (BossSequenceController.BoundSoul && this.maxMP != 33)
		{
			this.maxMP = 33;
		}
		if (this.MPCharge + amount > this.maxMP)
		{
			if (this.MPReserve < this.MPReserveMax && !BossSequenceController.BoundSoul)
			{
				this.MPReserve += amount - (this.maxMP - this.MPCharge);
				result = true;
				if (this.MPReserve > this.MPReserveMax)
				{
					this.MPReserve = this.MPReserveMax;
				}
			}
			this.MPCharge = this.maxMP;
		}
		else
		{
			this.MPCharge += amount;
			result = true;
		}
		return result;
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
	public void TakeMP(int amount)
	{
		if (amount <= this.MPCharge)
		{
			this.MPCharge -= amount;
			if (this.MPCharge < 0)
			{
				this.MPCharge = 0;
				return;
			}
		}
		else
		{
			this.MPCharge = 0;
		}
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x0000E5F1 File Offset: 0x0000C7F1
	public void TakeReserveMP(int amount)
	{
		this.MPReserve -= amount;
		if (this.MPReserve < 0)
		{
			this.MPReserve = 0;
		}
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x0000E611 File Offset: 0x0000C811
	public void ClearMP()
	{
		this.MPCharge = 0;
		this.MPReserve = 0;
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x0000E621 File Offset: 0x0000C821
	public void AddToMaxMPReserve(int amount)
	{
		this.MPReserveMax += amount;
		if (this.MPReserveMax == this.MPReserveCap)
		{
			this.vesselFragmentMax = true;
		}
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x0000E646 File Offset: 0x0000C846
	public void StartSoulLimiter()
	{
		this.soulLimited = true;
		this.maxMP = 66;
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x0000E657 File Offset: 0x0000C857
	public void EndSoulLimiter()
	{
		this.soulLimited = false;
		this.maxMP = 99;
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x0000E668 File Offset: 0x0000C868
	public void EquipCharm(int charmNum)
	{
		this.equippedCharms.Add(charmNum);
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x0000E676 File Offset: 0x0000C876
	public void UnequipCharm(int charmNum)
	{
		this.equippedCharms.Remove(charmNum);
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x0007CD58 File Offset: 0x0007AF58
	public void CalculateNotchesUsed()
	{
		int num = 0;
		if (this.equippedCharm_1)
		{
			num += this.charmCost_1;
		}
		if (this.equippedCharm_2)
		{
			num += this.charmCost_2;
		}
		if (this.equippedCharm_3)
		{
			num += this.charmCost_3;
		}
		if (this.equippedCharm_4)
		{
			num += this.charmCost_4;
		}
		if (this.equippedCharm_5)
		{
			num += this.charmCost_5;
		}
		if (this.equippedCharm_6)
		{
			num += this.charmCost_6;
		}
		if (this.equippedCharm_7)
		{
			num += this.charmCost_7;
		}
		if (this.equippedCharm_8)
		{
			num += this.charmCost_8;
		}
		if (this.equippedCharm_9)
		{
			num += this.charmCost_9;
		}
		if (this.equippedCharm_10)
		{
			num += this.charmCost_10;
		}
		if (this.equippedCharm_11)
		{
			num += this.charmCost_11;
		}
		if (this.equippedCharm_12)
		{
			num += this.charmCost_12;
		}
		if (this.equippedCharm_13)
		{
			num += this.charmCost_13;
		}
		if (this.equippedCharm_14)
		{
			num += this.charmCost_14;
		}
		if (this.equippedCharm_15)
		{
			num += this.charmCost_15;
		}
		if (this.equippedCharm_16)
		{
			num += this.charmCost_16;
		}
		if (this.equippedCharm_17)
		{
			num += this.charmCost_17;
		}
		if (this.equippedCharm_18)
		{
			num += this.charmCost_18;
		}
		if (this.equippedCharm_19)
		{
			num += this.charmCost_19;
		}
		if (this.equippedCharm_20)
		{
			num += this.charmCost_20;
		}
		if (this.equippedCharm_21)
		{
			num += this.charmCost_21;
		}
		if (this.equippedCharm_22)
		{
			num += this.charmCost_22;
		}
		if (this.equippedCharm_23)
		{
			num += this.charmCost_23;
		}
		if (this.equippedCharm_24)
		{
			num += this.charmCost_24;
		}
		if (this.equippedCharm_25)
		{
			num += this.charmCost_25;
		}
		if (this.equippedCharm_26)
		{
			num += this.charmCost_26;
		}
		if (this.equippedCharm_27)
		{
			num += this.charmCost_27;
		}
		if (this.equippedCharm_28)
		{
			num += this.charmCost_28;
		}
		if (this.equippedCharm_29)
		{
			num += this.charmCost_29;
		}
		if (this.equippedCharm_30)
		{
			num += this.charmCost_30;
		}
		if (this.equippedCharm_31)
		{
			num += this.charmCost_31;
		}
		if (this.equippedCharm_32)
		{
			num += this.charmCost_32;
		}
		if (this.equippedCharm_33)
		{
			num += this.charmCost_33;
		}
		if (this.equippedCharm_34)
		{
			num += this.charmCost_34;
		}
		if (this.equippedCharm_35)
		{
			num += this.charmCost_35;
		}
		if (this.equippedCharm_36)
		{
			num += this.charmCost_36;
		}
		if (this.equippedCharm_37)
		{
			num += this.charmCost_37;
		}
		if (this.equippedCharm_38)
		{
			num += this.charmCost_38;
		}
		if (this.equippedCharm_39)
		{
			num += this.charmCost_39;
		}
		if (this.equippedCharm_40)
		{
			num += this.charmCost_40;
		}
		this.charmSlotsFilled = num;
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x0000E685 File Offset: 0x0000C885
	public void SetBenchRespawn(RespawnMarker spawnMarker, string sceneName, int spawnType)
	{
		this.respawnMarkerName = spawnMarker.name;
		this.respawnScene = sceneName;
		this.respawnType = spawnType;
		this.respawnFacingRight = spawnMarker.respawnFacingRight;
		GameManager.instance.SetCurrentMapZoneAsRespawn();
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x0000E6B7 File Offset: 0x0000C8B7
	public void SetBenchRespawn(string spawnMarker, string sceneName, bool facingRight)
	{
		this.respawnMarkerName = spawnMarker;
		this.respawnScene = sceneName;
		this.respawnFacingRight = facingRight;
		GameManager.instance.SetCurrentMapZoneAsRespawn();
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
	public void SetBenchRespawn(string spawnMarker, string sceneName, int spawnType, bool facingRight)
	{
		this.respawnMarkerName = spawnMarker;
		this.respawnScene = sceneName;
		this.respawnType = spawnType;
		this.respawnFacingRight = facingRight;
		GameManager.instance.SetCurrentMapZoneAsRespawn();
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x0000E701 File Offset: 0x0000C901
	public void SetHazardRespawn(HazardRespawnMarker location)
	{
		this.hazardRespawnLocation = location.transform.position;
		this.hazardRespawnFacingRight = location.respawnFacingRight;
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x0000E720 File Offset: 0x0000C920
	public void SetHazardRespawn(Vector3 position, bool facingRight)
	{
		this.hazardRespawnLocation = position;
		this.hazardRespawnFacingRight = facingRight;
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x0007D018 File Offset: 0x0007B218
	public void CountGameCompletion()
	{
		this.completionPercentage = 0f;
		this.CountCharms();
		this.completionPercentage += (float)this.charmsOwned;
		if (this.killedFalseKnight)
		{
			this.completionPercentage += 1f;
		}
		if (this.hornet1Defeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.hornetOutskirtsDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMantisLord)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMageLord)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedDungDefender)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedBlackKnight)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedInfectedKnight)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMimicSpider)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMegaJellyfish)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedTraitorLord)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedJarCollector)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedBigFly)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMawlek)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedHiveKnight)
		{
			this.completionPercentage += 1f;
		}
		if (this.colosseumBronzeCompleted)
		{
			this.completionPercentage += 1f;
		}
		if (this.colosseumSilverCompleted)
		{
			this.completionPercentage += 1f;
		}
		if (this.colosseumGoldCompleted)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostAladar)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostHu)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostXero)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostMarkoth)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostNoEyes)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostMarmu)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostGalien)
		{
			this.completionPercentage += 1f;
		}
		this.completionPercentage += (float)this.fireballLevel;
		this.completionPercentage += (float)this.quakeLevel;
		this.completionPercentage += (float)this.screamLevel;
		if (this.hasCyclone)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasDashSlash)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasUpwardSlash)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasDash)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasWalljump)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasDoubleJump)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasAcidArmour)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasSuperDash)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasShadowDash)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasKingsBrand)
		{
			this.completionPercentage += 2f;
		}
		if (this.lurienDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.hegemolDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.monomonDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasDreamNail)
		{
			this.completionPercentage += 1f;
		}
		if (this.dreamNailUpgraded)
		{
			this.completionPercentage += 1f;
		}
		if (this.mothDeparted)
		{
			this.completionPercentage += 1f;
		}
		this.completionPercentage += (float)this.nailSmithUpgrades;
		this.completionPercentage += (float)(this.maxHealthBase - 5);
		int mpreserveMax = this.MPReserveMax;
		if (mpreserveMax != 33)
		{
			if (mpreserveMax != 66)
			{
				if (mpreserveMax == 99)
				{
					this.completionPercentage += 3f;
				}
			}
			else
			{
				this.completionPercentage += 2f;
			}
		}
		else
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGrimm)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedNightmareGrimm || this.destroyedNightmareLantern)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasGodfinder)
		{
			this.completionPercentage += 1f;
		}
		if (this.bossDoorStateTier1.completed)
		{
			this.completionPercentage += 1f;
		}
		if (this.bossDoorStateTier2.completed)
		{
			this.completionPercentage += 1f;
		}
		if (this.bossDoorStateTier3.completed)
		{
			this.completionPercentage += 1f;
		}
		if (this.bossDoorStateTier4.completed)
		{
			this.completionPercentage += 1f;
		}
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x0007D5FC File Offset: 0x0007B7FC
	public void CountCharms()
	{
		this.charmsOwned = 0;
		if (this.gotCharm_1)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_2)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_3)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_4)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_5)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_6)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_7)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_8)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_9)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_10)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_11)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_12)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_13)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_14)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_15)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_16)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_17)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_18)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_19)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_20)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_21)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_22)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_23)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_24)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_25)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_26)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_27)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_28)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_29)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_30)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_31)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_32)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_33)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_34)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_35)
		{
			this.charmsOwned++;
		}
		if (this.royalCharmState > 2)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_37)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_38)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_39)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_40)
		{
			this.charmsOwned++;
		}
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x0007D984 File Offset: 0x0007BB84
	public void CountJournalEntries()
	{
		this.journalEntriesCompleted = 0;
		this.journalNotesCompleted = 0;
		this.journalEntriesTotal = 146;
		if (this.killedCrawler)
		{
			this.journalEntriesCompleted += 2;
		}
		if (this.killedBuzzer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBouncer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedClimber)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedWorm)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpitter)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHatcher)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHatchling)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieRunner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieHornhead)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieLeaper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieBarger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieShield)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieGuard)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigBuzzer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigFly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMawlek)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFalseKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoller)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlocker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPrayerSlug)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMenderBug)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedMossmanRunner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossmanShaker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMosquito)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlobFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungifiedZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPlantShooter)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossCharger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMegaMossCharger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSnapperTrap)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGrassHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAcidFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAcidWalker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossKnightFat)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossWalker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedInfectedKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLazyFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZapBug)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedJellyfish)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedJellyCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMegaJellyfish)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungoonBaby)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomTurret)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantis)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomRoller)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomBrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomBaby)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantisFlyerChild)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungusFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantisLord)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlackKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMage)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalDandy)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalCoward)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalPlumper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlyingSentrySword)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlyingSentryJavelin)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSentry)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSentryFat)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageBlob)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGreatShieldZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedJarCollector)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageBalloon)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageLord)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGorgeousHusk)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlipHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlukeman)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedInflater)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlukefly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlukeMother)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedDungDefender)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCrystalCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCrystalFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLaserBug)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBeamMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMegaBeamMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMinesCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAngryBuzzer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBurstingBouncer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBurstingZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpittingZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBabyCentipede)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigCentipede)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCentipedeHatcher)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLesserMawlek)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSlashSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpiderCorpse)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedShootSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMiniSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpiderFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMimicSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBeeHatchling)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBeeStinger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigBee)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHiveKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlowFly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCeilingDropper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGiantHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGrubMimic)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMawlekTurret)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedOrangeScuttler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHealthScuttler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPigeon)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieHive)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHornet)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAbyssCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSuperSpitter)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSibling)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAbyssTendril)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPalaceFly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedEggSac)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMummy)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedOrangeBalloon)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHeavyMantis)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedTraitorLord)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantisHeavyFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGardenZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalGuard)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedWhiteRoyal)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedOblobble)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZote)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedBlobble)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColMosquito)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColRoller)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColFlyingSentry)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColShield)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColWorm)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedElectricMage)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLobsterLancer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostAladar)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostXero)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostHu)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostMarmu)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostNoEyes)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostMarkoth)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostGalien)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedWhiteDefender)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedGreyPrince)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedZotelingBuzzer)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedZotelingHopper)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedZotelingBalloon)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedHollowKnight)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFinalBoss)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFlameBearerSmall)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFlameBearerMed)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFlameBearerLarge)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedGrimm)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedNightmareGrimm)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFatFluke)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPaleLurker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedNailBros)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedPaintmaster)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedNailsage)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedHollowKnightPrime)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killsCrawler == 0)
		{
			this.journalNotesCompleted += 2;
		}
		if (this.killsBuzzer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBouncer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsClimber == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsWorm == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpitter == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHatcher == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHatchling == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieRunner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieHornhead == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieLeaper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieBarger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieShield == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieGuard == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigBuzzer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigFly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMawlek == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFalseKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoller == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlocker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPrayerSlug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMenderBug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossmanRunner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossmanShaker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMosquito == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlobFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungifiedZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPlantShooter == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossCharger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMegaMossCharger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSnapperTrap == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGrassHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAcidFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAcidWalker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossKnightFat == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossWalker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsInfectedKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLazyFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZapBug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsJellyfish == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsJellyCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMegaJellyfish == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungoonBaby == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomTurret == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantis == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomRoller == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomBrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomBaby == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantisFlyerChild == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungusFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantisLord == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlackKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMage == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalDandy == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalCoward == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalPlumper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlyingSentrySword == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlyingSentryJavelin == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSentry == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSentryFat == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageBlob == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGreatShieldZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsJarCollector == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageBalloon == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageLord == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGorgeousHusk == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlipHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlukeman == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsInflater == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlukefly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlukeMother == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsDungDefender == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCrystalCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCrystalFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLaserBug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBeamMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMegaBeamMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMinesCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAngryBuzzer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBurstingBouncer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBurstingZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpittingZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBabyCentipede == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigCentipede == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCentipedeHatcher == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLesserMawlek == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSlashSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpiderCorpse == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsShootSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMiniSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpiderFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMimicSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBeeHatchling == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBeeStinger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigBee == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHiveKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlowFly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCeilingDropper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGiantHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGrubMimic == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMawlekTurret == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsOrangeScuttler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHealthScuttler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPigeon == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieHive == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHornet == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAbyssCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSuperSpitter == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSibling == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAbyssTendril == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPalaceFly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsEggSac == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMummy == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsOrangeBalloon == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHeavyMantis == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsTraitorLord == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantisHeavyFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGardenZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalGuard == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsWhiteRoyal == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsOblobble == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZote == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlobble == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColMosquito == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColRoller == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColFlyingSentry == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColShield == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColWorm == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsElectricMage == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLobsterLancer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostAladar == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostXero == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostHu == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostMarmu == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostNoEyes == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostMarkoth == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostGalien == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedWhiteDefender)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedGreyPrince)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedZotelingBuzzer)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedZotelingHopper)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedZotelingBalloon)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHollowKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFinalBoss == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedFlameBearerSmall)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedFlameBearerMed)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedFlameBearerLarge)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedGrimm)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedNightmareGrimm)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedFatFluke)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedPaleLurker)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedNailBros)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedPaintmaster)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedNailsage)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedHollowKnightPrime)
		{
			this.journalNotesCompleted++;
		}
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x0007F6AC File Offset: 0x0007D8AC
	private void SetupNewPlayerData()
	{
		this.openingCreditsPlayed = false;
		this.playTime = 0f;
		this.completionPercent = 0f;
		this.permadeathMode = 0;
		this.version = "1.5.78.11833";
		this.awardAllAchievements = false;
		this.health = 10;
		this.maxHealth = 10;
		this.maxHealthBase = 10;
		this.healthBlue = 0;
		this.joniHealthBlue = 0;
		this.damagedBlue = false;
		this.heartPieces = 0;
		this.heartPieceCollected = false;
		this.maxHealthCap = 13;
		this.heartPieceMax = false;
		this.prevHealth = this.health;
		this.blockerHits = 4;
		this.firstGeo = false;
		this.geo = 0;
		this.maxMP = 99;
		this.MPCharge = 0;
		this.MPReserve = 0;
		this.MPReserveMax = 0;
		this.soulLimited = false;
		this.focusMP_amount = 33;
		this.vesselFragments = 0;
		this.vesselFragmentCollected = false;
		this.MPReserveCap = 99;
		this.vesselFragmentMax = false;
		this.atBench = false;
		this.respawnScene = "Tutorial_01";
		this.respawnMarkerName = "Death Respawn Marker";
		this.mapZone = MapZone.KINGS_PASS;
		this.respawnType = 0;
		this.respawnFacingRight = false;
		this.hazardRespawnFacingRight = false;
		this.shadeScene = "None";
		this.shadeMapZone = "";
		this.shadePositionX = -999f;
		this.shadePositionY = -999f;
		this.shadeHealth = 0;
		this.shadeMP = 0;
		this.shadeFireballLevel = 0;
		this.shadeQuakeLevel = 0;
		this.shadeScreamLevel = 0;
		this.shadeSpecialType = 0;
		this.shadeMapPos = new Vector3(0f, 0f, 0f);
		this.dreamgateMapPos = new Vector3(0f, 0f, 0f);
		this.geoPool = 0;
		this.nailDamage = 5;
		this.nailRange = 0;
		this.beamDamage = 0;
		this.canDash = false;
		this.canBackDash = false;
		this.canWallJump = false;
		this.canSuperDash = false;
		this.canShadowDash = false;
		this.hasSpell = false;
		this.fireballLevel = 0;
		this.quakeLevel = 0;
		this.screamLevel = 0;
		this.hasNailArt = false;
		this.hasCyclone = false;
		this.hasDashSlash = false;
		this.hasUpwardSlash = false;
		this.hasAllNailArts = false;
		this.hasDreamNail = false;
		this.hasDreamGate = false;
		this.dreamNailUpgraded = false;
		this.dreamOrbs = 0;
		this.dreamOrbsSpent = 0;
		this.dreamGateScene = "";
		this.dreamGateX = 0f;
		this.dreamGateY = 0f;
		this.hasDash = false;
		this.hasWalljump = false;
		this.hasSuperDash = false;
		this.hasShadowDash = false;
		this.hasAcidArmour = false;
		this.hasDoubleJump = false;
		this.hasLantern = false;
		this.hasTramPass = false;
		this.hasQuill = false;
		this.hasCityKey = false;
		this.hasSlykey = false;
		this.gaveSlykey = false;
		this.hasWhiteKey = false;
		this.usedWhiteKey = false;
		this.hasMenderKey = false;
		this.hasWaterwaysKey = false;
		this.hasSpaKey = false;
		this.hasLoveKey = false;
		this.hasKingsBrand = false;
		this.hasXunFlower = false;
		this.ghostCoins = 0;
		this.ore = 0;
		this.foundGhostCoin = false;
		this.trinket1 = 0;
		this.foundTrinket1 = false;
		this.trinket2 = 0;
		this.foundTrinket2 = false;
		this.trinket3 = 0;
		this.foundTrinket3 = false;
		this.trinket4 = 0;
		this.foundTrinket4 = false;
		this.noTrinket1 = false;
		this.noTrinket2 = false;
		this.noTrinket3 = false;
		this.noTrinket4 = false;
		this.soldTrinket1 = 0;
		this.soldTrinket2 = 0;
		this.soldTrinket3 = 0;
		this.soldTrinket4 = 0;
		this.simpleKeys = 0;
		this.rancidEggs = 0;
		this.notchShroomOgres = false;
		this.notchFogCanyon = false;
		this.gotLurkerKey = false;
		this.gMap_doorX = 0f;
		this.gMap_doorY = 0f;
		this.gMap_doorScene = "";
		this.gMap_doorMapZone = "";
		this.gMap_doorOriginOffsetX = 0f;
		this.gMap_doorOriginOffsetY = 0f;
		this.gMap_doorSceneWidth = 0f;
		this.gMap_doorSceneHeight = 0f;
		this.guardiansDefeated = 0;
		this.lurienDefeated = false;
		this.hegemolDefeated = false;
		this.monomonDefeated = false;
		this.maskBrokenLurien = false;
		this.maskBrokenHegemol = false;
		this.maskBrokenMonomon = false;
		this.maskToBreak = 0;
		this.elderbug = 0;
		this.metElderbug = false;
		this.elderbugReintro = false;
		this.elderbugHistory = 0;
		this.elderbugHistory1 = false;
		this.elderbugHistory2 = false;
		this.elderbugHistory3 = false;
		this.elderbugSpeechSly = false;
		this.elderbugSpeechStation = false;
		this.elderbugSpeechEggTemple = false;
		this.elderbugSpeechMapShop = false;
		this.elderbugSpeechBretta = false;
		this.elderbugSpeechJiji = false;
		this.elderbugSpeechMinesLift = false;
		this.elderbugSpeechKingsPass = false;
		this.elderbugSpeechInfectedCrossroads = false;
		this.elderbugSpeechFinalBossDoor = false;
		this.elderbugRequestedFlower = false;
		this.elderbugGaveFlower = false;
		this.elderbugFirstCall = false;
		this.metQuirrel = false;
		this.quirrelEggTemple = 0;
		this.quirrelLeftEggTemple = false;
		this.quirrelSlugShrine = 0;
		this.quirrelRuins = 0;
		this.quirrelMines = 0;
		this.quirrelLeftStation = false;
		this.quirrelCityEncountered = false;
		this.quirrelCityLeft = false;
		this.quirrelMinesEncountered = false;
		this.quirrelMinesLeft = false;
		this.visitedDeepnestSpa = false;
		this.quirrelSpaReady = false;
		this.quirrelSpaEncountered = false;
		this.quirrelArchiveEncountered = false;
		this.quirrelEpilogueCompleted = false;
		this.quirrelMantisEncountered = false;
		this.enteredMantisLordArea = false;
		this.metRelicDealer = false;
		this.metRelicDealerShop = false;
		this.marmOutside = false;
		this.marmOutsideConvo = false;
		this.marmConvo1 = false;
		this.marmConvo2 = false;
		this.marmConvo3 = false;
		this.marmConvoNailsmith = false;
		this.cornifer = 0;
		this.metCornifer = false;
		this.corniferIntroduced = false;
		this.corniferAtHome = false;
		this.corn_crossroadsEncountered = false;
		this.corn_crossroadsLeft = false;
		this.corn_greenpathEncountered = false;
		this.corn_greenpathLeft = false;
		this.corn_fogCanyonEncountered = false;
		this.corn_fogCanyonLeft = false;
		this.corn_fungalWastesEncountered = false;
		this.corn_fungalWastesLeft = false;
		this.corn_cityEncountered = false;
		this.corn_cityLeft = false;
		this.corn_waterwaysEncountered = false;
		this.corn_waterwaysLeft = false;
		this.corn_minesEncountered = false;
		this.corn_minesLeft = false;
		this.corn_cliffsEncountered = false;
		this.corn_cliffsLeft = false;
		this.corn_deepnestEncountered = false;
		this.corn_deepnestLeft = false;
		this.corn_deepnestMet1 = false;
		this.corn_deepnestMet2 = false;
		this.corn_outskirtsEncountered = false;
		this.corn_outskirtsLeft = false;
		this.corn_royalGardensEncountered = false;
		this.corn_royalGardensLeft = false;
		this.corn_abyssEncountered = false;
		this.corn_abyssLeft = false;
		this.metIselda = false;
		this.iseldaCorniferHomeConvo = false;
		this.iseldaConvo1 = false;
		this.brettaRescued = false;
		this.brettaPosition = 0;
		this.brettaState = 0;
		this.brettaSeenBench = false;
		this.brettaSeenBed = false;
		this.brettaSeenBenchDiary = false;
		this.brettaSeenBedDiary = false;
		this.brettaLeftTown = false;
		this.slyRescued = false;
		this.slyBeta = false;
		this.metSlyShop = false;
		this.gotSlyCharm = false;
		this.slyShellFrag1 = false;
		this.slyShellFrag2 = false;
		this.slyShellFrag3 = false;
		this.slyShellFrag4 = false;
		this.slyVesselFrag1 = false;
		this.slyVesselFrag2 = false;
		this.slyVesselFrag3 = false;
		this.slyVesselFrag4 = false;
		this.slyNotch1 = false;
		this.slyNotch2 = false;
		this.slySimpleKey = false;
		this.slyRancidEgg = false;
		this.slyConvoNailArt = false;
		this.slyConvoMapper = false;
		this.slyConvoNailHoned = false;
		this.jijiDoorUnlocked = false;
		this.jijiMet = false;
		this.jijiShadeOffered = false;
		this.jijiShadeCharmConvo = false;
		this.metJinn = false;
		this.jinnConvo1 = false;
		this.jinnConvo2 = false;
		this.jinnConvo3 = false;
		this.jinnConvoKingBrand = false;
		this.jinnConvoShadeCharm = false;
		this.jinnEggsSold = 0;
		this.zote = 0;
		this.zoteDead = false;
		this.zoteDeathPos = 0;
		this.zoteRescuedBuzzer = false;
		this.zoteSpokenCity = false;
		this.zoteLeftCity = false;
		this.zoteRescuedDeepnest = false;
		this.zoteDefeated = false;
		this.zoteTrappedDeepnest = false;
		this.zoteSpokenColosseum = false;
		this.zotePrecept = 1;
		this.zoteTownConvo = 0;
		this.shaman = 0;
		this.shamanScreamConvo = false;
		this.shamanQuakeConvo = false;
		this.shamanFireball2Convo = false;
		this.shamanScream2Convo = false;
		this.shamanQuake2Convo = false;
		this.metMiner = false;
		this.miner = 0;
		this.minerEarly = 0;
		this.hornetGreenpath = 0;
		this.hornetFung = 0;
		this.hornet_f19 = false;
		this.hornetFountainEncounter = false;
		this.hornetCityBridge_ready = false;
		this.hornetCityBridge_completed = false;
		this.hornetAbyssEncounter = false;
		this.hornetDenEncounter = false;
		this.metMoth = false;
		this.ignoredMoth = false;
		this.gladeDoorOpened = false;
		this.mothDeparted = false;
		this.completedRGDreamPlant = false;
		this.dreamReward1 = false;
		this.dreamReward2 = false;
		this.dreamReward3 = false;
		this.dreamReward4 = false;
		this.dreamReward5 = false;
		this.dreamReward5b = false;
		this.dreamReward6 = false;
		this.dreamReward7 = false;
		this.dreamReward8 = false;
		this.dreamReward9 = false;
		this.dreamMothConvo1 = false;
		this.bankerAccountPurchased = false;
		this.metBanker = false;
		this.bankerBalance = 0;
		this.bankerDeclined = false;
		this.bankerTheftCheck = false;
		this.bankerTheft = 0;
		this.bankerSpaMet = false;
		this.metGiraffe = false;
		this.metCharmSlug = false;
		this.salubraNotch1 = false;
		this.salubraNotch2 = false;
		this.salubraNotch3 = false;
		this.salubraNotch4 = false;
		this.salubraBlessing = false;
		this.salubraConvoCombo = false;
		this.salubraConvoOvercharm = false;
		this.salubraConvoTruth = false;
		this.cultistTransformed = false;
		this.metNailsmith = false;
		this.honedNail = false;
		this.nailSmithUpgrades = 0;
		this.nailsmithCliff = false;
		this.nailsmithKilled = false;
		this.nailsmithSpared = false;
		this.nailsmithKillSpeech = false;
		this.nailsmithSheo = false;
		this.nailsmithConvoArt = false;
		this.metNailmasterMato = false;
		this.metNailmasterSheo = false;
		this.metNailmasterOro = false;
		this.matoConvoSheo = false;
		this.matoConvoOro = false;
		this.matoConvoSly = false;
		this.sheoConvoMato = false;
		this.sheoConvoOro = false;
		this.sheoConvoSly = false;
		this.sheoConvoNailsmith = false;
		this.oroConvoSheo = false;
		this.oroConvoMato = false;
		this.oroConvoSly = false;
		this.hunterRoared = false;
		this.metHunter = false;
		this.hunterRewardOffered = false;
		this.huntersMarkOffered = false;
		this.hasHuntersMark = false;
		this.metLegEater = false;
		this.paidLegEater = false;
		this.refusedLegEater = false;
		this.legEaterBrokenConvo = false;
		this.legEaterDungConvo = false;
		this.legEaterInfectedCrossroadConvo = false;
		this.legEaterBoughtConvo = false;
		this.legEaterConvo1 = false;
		this.legEaterConvo2 = false;
		this.legEaterConvo3 = false;
		this.legEaterGoldConvo = false;
		this.legEaterLeft = false;
		this.tukMet = false;
		this.tukEggPrice = 0;
		this.tukDungEgg = false;
		this.metEmilitia = false;
		this.emilitiaKingsBrandConvo = false;
		this.metCloth = false;
		this.clothEnteredTramRoom = false;
		this.savedCloth = false;
		this.clothEncounteredQueensGarden = false;
		this.clothKilled = false;
		this.clothInTown = false;
		this.clothLeftTown = false;
		this.clothGhostSpoken = false;
		this.bigCatHitTail = false;
		this.bigCatHitTailConvo = false;
		this.bigCatMeet = false;
		this.bigCatTalk1 = false;
		this.bigCatTalk2 = false;
		this.bigCatTalk3 = false;
		this.bigCatKingsBrandConvo = false;
		this.bigCatShadeConvo = false;
		this.tisoEncounteredTown = false;
		this.tisoEncounteredBench = false;
		this.tisoEncounteredLake = false;
		this.tisoEncounteredColosseum = false;
		this.tisoShieldConvo = false;
		this.tisoDead = false;
		this.mossCultist = 0;
		this.maskmakerMet = false;
		this.maskmakerConvo1 = false;
		this.maskmakerConvo2 = false;
		this.maskmakerUnmasked1 = false;
		this.maskmakerUnmasked2 = false;
		this.maskmakerShadowDash = false;
		this.maskmakerKingsBrand = false;
		this.dungDefenderConvo1 = false;
		this.dungDefenderConvo2 = false;
		this.dungDefenderConvo3 = false;
		this.dungDefenderCharmConvo = false;
		this.dungDefenderIsmaConvo = false;
		this.dungDefenderAwakeConvo = false;
		this.dungDefenderAwoken = false;
		this.dungDefenderLeft = false;
		this.midwifeMet = false;
		this.midwifeConvo1 = false;
		this.midwifeConvo2 = false;
		this.metQueen = false;
		this.queenTalk1 = false;
		this.queenTalk2 = false;
		this.queenDung1 = false;
		this.queenDung2 = false;
		this.queenHornet = false;
		this.queenTalkExtra = false;
		this.gotQueenFragment = false;
		this.gotKingFragment = false;
		this.metXun = false;
		this.xunFlowerBroken = false;
		this.xunFlowerBrokeTimes = 0;
		this.xunFlowerGiven = false;
		this.xunRewardGiven = false;
		this.xunFailedConvo1 = false;
		this.xunFailedConvo2 = true;
		this.menderState = 0;
		this.menderSignBroken = false;
		this.allBelieverTabletsDestroyed = false;
		this.mrMushroomState = 0;
		this.openedMapperShop = false;
		this.openedSlyShop = false;
		this.metStag = false;
		this.travelling = false;
		this.stagPosition = -1;
		this.stationsOpened = 0;
		this.stagConvoTram = false;
		this.stagConvoTiso = false;
		this.stagRemember1 = false;
		this.stagRemember2 = false;
		this.stagRemember3 = false;
		this.stagEggInspected = false;
		this.stagHopeConvo = false;
		this.nextScene = "";
		this.littleFoolMet = false;
		this.ranAway = false;
		this.seenColosseumTitle = false;
		this.colosseumBronzeOpened = false;
		this.colosseumBronzeCompleted = false;
		this.colosseumSilverOpened = false;
		this.colosseumSilverCompleted = false;
		this.colosseumGoldOpened = false;
		this.colosseumGoldCompleted = false;
		this.openedTown = true;
		this.openedTownBuilding = false;
		this.openedCrossroads = false;
		this.openedGreenpath = false;
		this.openedFungalWastes = false;
		this.openedRuins1 = false;
		this.openedRuins2 = false;
		this.openedRoyalGardens = false;
		this.openedRestingGrounds = false;
		this.openedDeepnest = false;
		this.openedStagNest = false;
		this.openedHiddenStation = false;
		this.dreamReturnScene = "Dream_NailCollection";
		this.charmSlots = 40;
		this.charmSlotsFilled = 0;
		this.hasCharm = false;
		this.equippedCharms = new List<int>();
		this.charmBenchMsg = false;
		this.charmsOwned = 0;
		this.canOvercharm = false;
		this.overcharmed = false;
		this.gotCharm_1 = false;
		this.equippedCharm_1 = false;
		this.charmCost_1 = 1;
		this.newCharm_1 = true;
		this.gotCharm_2 = false;
		this.equippedCharm_2 = false;
		this.charmCost_2 = 1;
		this.newCharm_2 = true;
		this.gotCharm_3 = false;
		this.equippedCharm_3 = false;
		this.charmCost_3 = 1;
		this.newCharm_3 = true;
		this.gotCharm_4 = false;
		this.equippedCharm_4 = false;
		this.charmCost_4 = 1;
		this.newCharm_4 = true;
		this.gotCharm_5 = false;
		this.equippedCharm_5 = false;
		this.charmCost_5 = 1;
		this.newCharm_5 = true;
		this.gotCharm_6 = false;
		this.equippedCharm_6 = false;
		this.charmCost_6 = 1;
		this.newCharm_6 = true;
		this.gotCharm_7 = false;
		this.equippedCharm_7 = false;
		this.charmCost_7 = 1;
		this.newCharm_7 = true;
		this.gotCharm_8 = false;
		this.equippedCharm_8 = false;
		this.charmCost_8 = 1;
		this.newCharm_8 = true;
		this.gotCharm_9 = false;
		this.equippedCharm_9 = false;
		this.charmCost_9 = 1;
		this.newCharm_9 = true;
		this.gotCharm_10 = false;
		this.equippedCharm_10 = false;
		this.charmCost_10 = 1;
		this.newCharm_10 = true;
		this.gotCharm_11 = false;
		this.equippedCharm_11 = false;
		this.charmCost_11 = 1;
		this.newCharm_11 = true;
		this.gotCharm_12 = false;
		this.equippedCharm_12 = false;
		this.charmCost_12 = 1;
		this.newCharm_12 = true;
		this.gotCharm_13 = false;
		this.equippedCharm_13 = false;
		this.charmCost_13 = 1;
		this.newCharm_13 = true;
		this.gotCharm_14 = false;
		this.equippedCharm_14 = false;
		this.charmCost_14 = 1;
		this.newCharm_14 = true;
		this.gotCharm_15 = false;
		this.equippedCharm_15 = false;
		this.charmCost_15 = 1;
		this.newCharm_15 = true;
		this.gotCharm_16 = false;
		this.equippedCharm_16 = false;
		this.charmCost_16 = 1;
		this.newCharm_16 = true;
		this.gotCharm_17 = false;
		this.equippedCharm_17 = false;
		this.charmCost_17 = 1;
		this.newCharm_17 = true;
		this.gotCharm_18 = false;
		this.equippedCharm_18 = false;
		this.charmCost_18 = 1;
		this.newCharm_18 = true;
		this.gotCharm_19 = false;
		this.equippedCharm_19 = false;
		this.charmCost_19 = 1;
		this.newCharm_19 = true;
		this.gotCharm_20 = false;
		this.equippedCharm_20 = false;
		this.charmCost_20 = 1;
		this.newCharm_20 = true;
		this.gotCharm_21 = false;
		this.equippedCharm_21 = false;
		this.charmCost_21 = 1;
		this.newCharm_21 = true;
		this.gotCharm_22 = false;
		this.equippedCharm_22 = false;
		this.charmCost_22 = 1;
		this.newCharm_22 = true;
		this.gotCharm_23 = false;
		this.equippedCharm_23 = false;
		this.brokenCharm_23 = false;
		this.charmCost_23 = 1;
		this.newCharm_23 = true;
		this.gotCharm_24 = false;
		this.equippedCharm_24 = false;
		this.brokenCharm_24 = false;
		this.charmCost_24 = 1;
		this.newCharm_24 = true;
		this.gotCharm_25 = false;
		this.equippedCharm_25 = false;
		this.brokenCharm_25 = false;
		this.charmCost_25 = 1;
		this.newCharm_25 = true;
		this.gotCharm_26 = false;
		this.equippedCharm_26 = false;
		this.charmCost_26 = 1;
		this.newCharm_26 = true;
		this.gotCharm_27 = false;
		this.equippedCharm_27 = false;
		this.charmCost_27 = 1;
		this.newCharm_27 = true;
		this.gotCharm_28 = false;
		this.equippedCharm_28 = false;
		this.charmCost_28 = 1;
		this.newCharm_28 = true;
		this.gotCharm_29 = false;
		this.equippedCharm_29 = false;
		this.charmCost_29 = 1;
		this.newCharm_29 = true;
		this.gotCharm_30 = false;
		this.equippedCharm_30 = false;
		this.charmCost_30 = 1;
		this.newCharm_30 = true;
		this.gotCharm_31 = false;
		this.equippedCharm_31 = false;
		this.charmCost_31 = 1;
		this.newCharm_31 = true;
		this.gotCharm_32 = false;
		this.equippedCharm_32 = false;
		this.charmCost_32 = 1;
		this.newCharm_32 = true;
		this.gotCharm_33 = false;
		this.equippedCharm_33 = false;
		this.charmCost_33 = 1;
		this.newCharm_33 = true;
		this.gotCharm_34 = false;
		this.equippedCharm_34 = false;
		this.charmCost_34 = 1;
		this.newCharm_34 = true;
		this.gotCharm_35 = false;
		this.equippedCharm_35 = false;
		this.charmCost_35 = 1;
		this.newCharm_35 = true;
		this.gotCharm_36 = false;
		this.equippedCharm_36 = false;
		this.charmCost_36 = 1;
		this.newCharm_36 = true;
		this.gotCharm_37 = false;
		this.equippedCharm_37 = false;
		this.charmCost_37 = 1;
		this.newCharm_37 = false;
		this.gotCharm_38 = false;
		this.equippedCharm_38 = false;
		this.charmCost_38 = 1;
		this.newCharm_38 = false;
		this.gotCharm_39 = false;
		this.equippedCharm_39 = false;
		this.charmCost_39 = 1;
		this.newCharm_39 = false;
		this.gotCharm_40 = false;
		this.equippedCharm_40 = false;
		this.charmCost_40 = 1;
		this.newCharm_40 = false;
		this.fragileHealth_unbreakable = false;
		this.fragileGreed_unbreakable = false;
		this.fragileStrength_unbreakable = false;
		this.royalCharmState = 0;
		this.hasJournal = false;
		this.lastJournalItem = 0;
		this.killedDummy = false;
		this.killsDummy = 0;
		this.newDataDummy = false;
		this.seenJournalMsg = false;
		this.seenHunterMsg = false;
		this.fillJournal = false;
		this.journalEntriesCompleted = 0;
		this.journalNotesCompleted = 0;
		this.journalEntriesTotal = 0;
		this.killedCrawler = true;
		this.killsCrawler = 0;
		this.newDataCrawler = false;
		this.killedBuzzer = false;
		this.killsBuzzer = 45;
		this.newDataBuzzer = false;
		this.killedBouncer = false;
		this.killsBouncer = 25;
		this.newDataBouncer = false;
		this.killedClimber = false;
		this.killsClimber = 30;
		this.newDataClimber = false;
		this.killedHopper = false;
		this.killsHopper = 25;
		this.newDataHopper = false;
		this.killedWorm = false;
		this.killsWorm = 10;
		this.newDataWorm = false;
		this.killedSpitter = false;
		this.killsSpitter = 20;
		this.newDataSpitter = false;
		this.killedHatcher = false;
		this.killsHatcher = 15;
		this.newDataHatcher = false;
		this.killedHatchling = false;
		this.killsHatchling = 30;
		this.newDataHatchling = false;
		this.killedZombieRunner = false;
		this.killsZombieRunner = 35;
		this.newDataZombieRunner = false;
		this.killedZombieHornhead = false;
		this.killsZombieHornhead = 35;
		this.newDataZombieHornhead = false;
		this.killedZombieLeaper = false;
		this.killsZombieLeaper = 35;
		this.newDataZombieLeaper = false;
		this.killedZombieBarger = false;
		this.killsZombieBarger = 35;
		this.newDataZombieBarger = false;
		this.killedZombieShield = false;
		this.killsZombieShield = 10;
		this.newDataZombieShield = false;
		this.killedZombieGuard = false;
		this.killsZombieGuard = 6;
		this.newDataZombieGuard = false;
		this.killedBigBuzzer = false;
		this.killsBigBuzzer = 2;
		this.newDataBigBuzzer = false;
		this.killedBigFly = false;
		this.killsBigFly = 3;
		this.newDataBigFly = false;
		this.killedMawlek = false;
		this.killsMawlek = 1;
		this.newDataMawlek = false;
		this.killedFalseKnight = false;
		this.killsFalseKnight = 1;
		this.newDataFalseKnight = false;
		this.killedRoller = false;
		this.killsRoller = 20;
		this.newDataRoller = false;
		this.killedBlocker = false;
		this.killsBlocker = 1;
		this.newDataBlocker = false;
		this.killedPrayerSlug = false;
		this.killsPrayerSlug = 2;
		this.newDataPrayerSlug = false;
		this.killedMenderBug = false;
		this.killsMenderBug = 1;
		this.newDataMenderBug = false;
		this.killedMossmanRunner = false;
		this.killsMossmanRunner = 25;
		this.newDataMossmanRunner = false;
		this.killedMossmanShaker = false;
		this.killsMossmanShaker = 25;
		this.newDataMossmanShaker = false;
		this.killedMosquito = false;
		this.killsMosquito = 25;
		this.newDataMosquito = false;
		this.killedBlobFlyer = false;
		this.killsBlobFlyer = 20;
		this.newDataBlobFlyer = false;
		this.killedFungifiedZombie = false;
		this.killsFungifiedZombie = 10;
		this.newDataFungifiedZombie = false;
		this.killedPlantShooter = false;
		this.killsPlantShooter = 15;
		this.newDataPlantShooter = false;
		this.killedMossCharger = false;
		this.killsMossCharger = 15;
		this.newDataMossCharger = false;
		this.killedMegaMossCharger = false;
		this.killsMegaMossCharger = 1;
		this.newDataMegaMossCharger = false;
		this.killedSnapperTrap = false;
		this.killsSnapperTrap = 15;
		this.newDataSnapperTrap = false;
		this.killedMossKnight = false;
		this.killsMossKnight = 8;
		this.newDataMossKnight = false;
		this.killedGrassHopper = false;
		this.killsGrassHopper = 15;
		this.newDataGrassHopper = false;
		this.killedAcidFlyer = false;
		this.killsAcidFlyer = 8;
		this.newDataAcidFlyer = false;
		this.killedAcidWalker = false;
		this.killsAcidWalker = 8;
		this.newDataAcidWalker = false;
		this.killedMossFlyer = false;
		this.killsMossFlyer = 25;
		this.newDataMossFlyer = false;
		this.killedMossKnightFat = false;
		this.killsMossKnightFat = 10;
		this.newDataMossKnightFat = false;
		this.killedMossWalker = false;
		this.killsMossWalker = 30;
		this.newDataMossWalker = false;
		this.killedInfectedKnight = false;
		this.killsInfectedKnight = 1;
		this.newDataInfectedKnight = false;
		this.killedLazyFlyer = false;
		this.killsLazyFlyer = 1;
		this.newDataLazyFlyer = false;
		this.killedZapBug = false;
		this.killsZapBug = 1;
		this.newDataZapBug = false;
		this.killedJellyfish = false;
		this.killsJellyfish = 12;
		this.newDataJellyfish = false;
		this.killedJellyCrawler = false;
		this.killsJellyCrawler = 20;
		this.newDataJellyCrawler = false;
		this.killedMegaJellyfish = false;
		this.killsMegaJellyfish = 1;
		this.newDataMegaJellyfish = false;
		this.killedFungoonBaby = false;
		this.killsFungoonBaby = 30;
		this.newDataFungoonBaby = false;
		this.killedMushroomTurret = false;
		this.killsMushroomTurret = 20;
		this.newDataMushroomTurret = false;
		this.killedMantis = false;
		this.killsMantis = 25;
		this.newDataMantis = false;
		this.killedMushroomRoller = false;
		this.killsMushroomRoller = 20;
		this.newDataMushroomRoller = false;
		this.killedMushroomBrawler = false;
		this.killsMushroomBrawler = 8;
		this.newDataMushroomBrawler = false;
		this.killedMushroomBaby = false;
		this.killsMushroomBaby = 20;
		this.newDataMushroomBaby = false;
		this.killedMantisFlyerChild = false;
		this.killsMantisFlyerChild = 25;
		this.newDataMantisFlyerChild = false;
		this.killedFungusFlyer = false;
		this.killsFungusFlyer = 20;
		this.newDataFungusFlyer = false;
		this.killedFungCrawler = false;
		this.killsFungCrawler = 15;
		this.newDataFungCrawler = false;
		this.killedMantisLord = false;
		this.killsMantisLord = 1;
		this.newDataMantisLord = false;
		this.killedBlackKnight = false;
		this.killsBlackKnight = 10;
		this.newDataBlackKnight = false;
		this.killedElectricMage = false;
		this.killsElectricMage = 6;
		this.newDataElectricMage = false;
		this.killedMage = false;
		this.killsMage = 20;
		this.newDataMage = false;
		this.killedMageKnight = false;
		this.killsMageKnight = 2;
		this.newDataMageKnight = false;
		this.killedRoyalDandy = false;
		this.killsRoyalDandy = 25;
		this.newDataRoyalDandy = false;
		this.killedRoyalCoward = false;
		this.killsRoyalCoward = 25;
		this.newDataRoyalCoward = false;
		this.killedRoyalPlumper = false;
		this.killsRoyalPlumper = 25;
		this.newDataRoyalPlumper = false;
		this.killedFlyingSentrySword = false;
		this.killsFlyingSentrySword = 30;
		this.newDataFlyingSentrySword = false;
		this.killedFlyingSentryJavelin = false;
		this.killsFlyingSentryJavelin = 25;
		this.newDataFlyingSentryJavelin = false;
		this.killedSentry = false;
		this.killsSentry = 25;
		this.newDataSentry = false;
		this.killedSentryFat = false;
		this.killsSentryFat = 20;
		this.newDataSentryFat = false;
		this.killedMageBlob = false;
		this.killsMageBlob = 25;
		this.newDataMageBlob = false;
		this.killedGreatShieldZombie = false;
		this.killsGreatShieldZombie = 10;
		this.newDataGreatShieldZombie = false;
		this.killedJarCollector = false;
		this.killsJarCollector = 1;
		this.newDataJarCollector = false;
		this.killedMageBalloon = false;
		this.killsMageBalloon = 15;
		this.newDataMageBalloon = false;
		this.killedMageLord = false;
		this.killsMageLord = 1;
		this.newDataMageLord = false;
		this.killedGorgeousHusk = false;
		this.killsGorgeousHusk = 1;
		this.newDataGorgeousHusk = false;
		this.killedFlipHopper = false;
		this.killsFlipHopper = 20;
		this.newDataFlipHopper = false;
		this.killedFlukeman = false;
		this.killsFlukeman = 20;
		this.newDataFlukeman = false;
		this.killedInflater = false;
		this.killsInflater = 20;
		this.newDataInflater = false;
		this.killedFlukefly = false;
		this.killsFlukefly = 15;
		this.newDataFlukefly = false;
		this.killedFlukeMother = false;
		this.killsFlukeMother = 1;
		this.newDataFlukeMother = false;
		this.killedDungDefender = false;
		this.killsDungDefender = 1;
		this.newDataDungDefender = false;
		this.killedCrystalCrawler = false;
		this.killsCrystalCrawler = 15;
		this.newDataCrystalCrawler = false;
		this.killedCrystalFlyer = false;
		this.killsCrystalFlyer = 20;
		this.newDataCrystalFlyer = false;
		this.killedLaserBug = false;
		this.killsLaserBug = 15;
		this.newDataLaserBug = false;
		this.killedBeamMiner = false;
		this.killsBeamMiner = 15;
		this.newDataBeamMiner = false;
		this.killedZombieMiner = false;
		this.killsZombieMiner = 20;
		this.newDataZombieMiner = false;
		this.killedMegaBeamMiner = false;
		this.killsMegaBeamMiner = 2;
		this.newDataMegaBeamMiner = false;
		this.killedMinesCrawler = false;
		this.killsMinesCrawler = 15;
		this.newDataMinesCrawler = false;
		this.killedAngryBuzzer = false;
		this.killsAngryBuzzer = 15;
		this.newDataAngryBuzzer = false;
		this.killedBurstingBouncer = false;
		this.killsBurstingBouncer = 15;
		this.newDataBurstingBouncer = false;
		this.killedBurstingZombie = false;
		this.killsBurstingZombie = 15;
		this.newDataBurstingZombie = false;
		this.killedSpittingZombie = false;
		this.killsSpittingZombie = 15;
		this.newDataSpittingZombie = false;
		this.killedBabyCentipede = false;
		this.killsBabyCentipede = 35;
		this.newDataBabyCentipede = false;
		this.killedBigCentipede = false;
		this.killsBigCentipede = 10;
		this.newDataBigCentipede = false;
		this.killedCentipedeHatcher = false;
		this.killsCentipedeHatcher = 15;
		this.newDataCentipedeHatcher = false;
		this.killedLesserMawlek = false;
		this.killsLesserMawlek = 10;
		this.newDataLesserMawlek = false;
		this.killedSlashSpider = false;
		this.killsSlashSpider = 15;
		this.newDataSlashSpider = false;
		this.killedSpiderCorpse = false;
		this.killsSpiderCorpse = 15;
		this.newDataSpiderCorpse = false;
		this.killedShootSpider = false;
		this.killsShootSpider = 20;
		this.newDataShootSpider = false;
		this.killedMiniSpider = false;
		this.killsMiniSpider = 25;
		this.newDataMiniSpider = false;
		this.killedSpiderFlyer = false;
		this.killsSpiderFlyer = 20;
		this.newDataSpiderFlyer = false;
		this.killedMimicSpider = false;
		this.killsMimicSpider = 1;
		this.newDataMimicSpider = false;
		this.killedBeeHatchling = false;
		this.killsBeeHatchling = 30;
		this.newDataBeeHatchling = false;
		this.killedBeeStinger = false;
		this.killsBeeStinger = 15;
		this.newDataBeeStinger = false;
		this.killedBigBee = false;
		this.killsBigBee = 12;
		this.newDataBigBee = false;
		this.killedHiveKnight = false;
		this.killsHiveKnight = 1;
		this.newDataHiveKnight = false;
		this.killedBlowFly = false;
		this.killsBlowFly = 20;
		this.newDataBlowFly = false;
		this.killedCeilingDropper = false;
		this.killsCeilingDropper = 15;
		this.newDataCeilingDropper = false;
		this.killedGiantHopper = false;
		this.killsGiantHopper = 10;
		this.newDataGiantHopper = false;
		this.killedGrubMimic = false;
		this.killsGrubMimic = 5;
		this.newDataGrubMimic = false;
		this.killedMawlekTurret = false;
		this.killsMawlekTurret = 10;
		this.newDataMawlekTurret = false;
		this.killedOrangeScuttler = false;
		this.killsOrangeScuttler = 20;
		this.newDataOrangeScuttler = false;
		this.killedHealthScuttler = false;
		this.killsHealthScuttler = 10;
		this.newDataHealthScuttler = false;
		this.killedPigeon = false;
		this.killsPigeon = 15;
		this.newDataPigeon = false;
		this.killedZombieHive = false;
		this.killsZombieHive = 10;
		this.newDataZombieHive = false;
		this.killedDreamGuard = false;
		this.killsDreamGuard = 20;
		this.newDataDreamGuard = false;
		this.killedHornet = false;
		this.killsHornet = 2;
		this.newDataHornet = false;
		this.killedAbyssCrawler = false;
		this.killsAbyssCrawler = 20;
		this.newDataAbyssCrawler = false;
		this.killedSuperSpitter = false;
		this.killsSuperSpitter = 25;
		this.newDataSuperSpitter = false;
		this.killedSibling = false;
		this.killsSibling = 25;
		this.newDataSibling = false;
		this.killedPalaceFly = false;
		this.killsPalaceFly = 10;
		this.newDataPalaceFly = false;
		this.killedEggSac = false;
		this.killsEggSac = 5;
		this.newDataEggSac = false;
		this.killedMummy = false;
		this.killsMummy = 10;
		this.newDataMummy = false;
		this.killedOrangeBalloon = false;
		this.killsOrangeBalloon = 10;
		this.newDataOrangeBalloon = false;
		this.killedAbyssTendril = false;
		this.killsAbyssTendril = 10;
		this.newDataAbyssTendril = false;
		this.killedHeavyMantis = false;
		this.killsHeavyMantis = 15;
		this.newDataHeavyMantis = false;
		this.killedTraitorLord = false;
		this.killsTraitorLord = 1;
		this.newDataTraitorLord = false;
		this.killedMantisHeavyFlyer = false;
		this.killsMantisHeavyFlyer = 16;
		this.newDataMantisHeavyFlyer = false;
		this.killedGardenZombie = false;
		this.killsGardenZombie = 20;
		this.newDataGardenZombie = false;
		this.killedRoyalGuard = false;
		this.killsRoyalGuard = 2;
		this.newDataRoyalGuard = false;
		this.killedWhiteRoyal = false;
		this.killsWhiteRoyal = 10;
		this.newDataWhiteRoyal = false;
		this.killedOblobble = false;
		this.killsOblobble = 3;
		this.newDataOblobble = false;
		this.killedZote = false;
		this.killsZote = 1;
		this.newDataZote = false;
		this.killedBlobble = false;
		this.killsBlobble = 15;
		this.newDataBlobble = false;
		this.killedColMosquito = false;
		this.killsColMosquito = 15;
		this.newDataColMosquito = false;
		this.killedColRoller = false;
		this.killsColRoller = 20;
		this.newDataColRoller = false;
		this.killedColFlyingSentry = false;
		this.killsColFlyingSentry = 25;
		this.newDataColFlyingSentry = false;
		this.killedColMiner = false;
		this.killsColMiner = 25;
		this.newDataColMiner = false;
		this.killedColShield = false;
		this.killsColShield = 25;
		this.newDataColShield = false;
		this.killedColWorm = false;
		this.killsColWorm = 20;
		this.newDataColWorm = false;
		this.killedColHopper = false;
		this.killsColHopper = 15;
		this.newDataColHopper = false;
		this.killedLobsterLancer = false;
		this.killsLobsterLancer = 1;
		this.newDataLobsterLancer = false;
		this.killedGhostAladar = false;
		this.killsGhostAladar = 1;
		this.newDataGhostAladar = false;
		this.killedGhostXero = false;
		this.killsGhostXero = 1;
		this.newDataGhostXero = false;
		this.killedGhostHu = false;
		this.killsGhostHu = 1;
		this.newDataGhostHu = false;
		this.killedGhostMarmu = false;
		this.killsGhostMarmu = 1;
		this.newDataGhostMarmu = false;
		this.killedGhostNoEyes = false;
		this.killsGhostNoEyes = 1;
		this.newDataGhostNoEyes = false;
		this.killedGhostMarkoth = false;
		this.killsGhostMarkoth = 1;
		this.newDataGhostMarkoth = false;
		this.killedGhostGalien = false;
		this.killsGhostGalien = 1;
		this.newDataGhostGalien = false;
		this.killedWhiteDefender = false;
		this.killsWhiteDefender = 1;
		this.newDataWhiteDefender = false;
		this.killedGreyPrince = false;
		this.killsGreyPrince = 1;
		this.newDataGreyPrince = false;
		this.killedZotelingBalloon = false;
		this.killsZotelingBalloon = 1;
		this.newDataZotelingBalloon = false;
		this.killedZotelingHopper = false;
		this.killsZotelingHopper = 1;
		this.newDataZotelingHopper = false;
		this.killedZotelingBuzzer = false;
		this.killsZotelingBuzzer = 1;
		this.newDataZotelingBuzzer = false;
		this.killedHollowKnight = false;
		this.killsHollowKnight = 1;
		this.newDataHollowKnight = false;
		this.killedFinalBoss = false;
		this.killsFinalBoss = 1;
		this.newDataFinalBoss = false;
		this.killedHunterMark = false;
		this.killsHunterMark = 1;
		this.newDataHunterMark = false;
		this.killedFlameBearerSmall = false;
		this.killsFlameBearerSmall = 3;
		this.newDataFlameBearerSmall = false;
		this.killedFlameBearerMed = false;
		this.killsFlameBearerMed = 4;
		this.newDataFlameBearerMed = false;
		this.killedFlameBearerLarge = false;
		this.killsFlameBearerLarge = 5;
		this.newDataFlameBearerLarge = false;
		this.killedGrimm = false;
		this.killsGrimm = 1;
		this.newDataGrimm = false;
		this.killedNightmareGrimm = false;
		this.killsNightmareGrimm = 1;
		this.newDataNightmareGrimm = false;
		this.killedBindingSeal = false;
		this.killsBindingSeal = 1;
		this.newDataBindingSeal = false;
		this.killedFatFluke = false;
		this.killsFatFluke = 8;
		this.newDataFatFluke = false;
		this.killedPaleLurker = false;
		this.killsPaleLurker = 1;
		this.newDataPaleLurker = false;
		this.killedNailBros = false;
		this.killsNailBros = 1;
		this.newDataNailBros = false;
		this.killedPaintmaster = false;
		this.killsPaintmaster = 1;
		this.newDataPaintmaster = false;
		this.killedNailsage = false;
		this.killsNailsage = 1;
		this.newDataNailsage = false;
		this.killedHollowKnightPrime = false;
		this.killsHollowKnightPrime = 1;
		this.newDataHollowKnightPrime = false;
		this.killedGodseekerMask = false;
		this.killsGodseekerMask = 1;
		this.newDataGodseekerMask = false;
		this.killedVoidIdol_1 = false;
		this.killsVoidIdol_1 = 1;
		this.newDataVoidIdol_1 = false;
		this.killedVoidIdol_2 = false;
		this.killsVoidIdol_2 = 1;
		this.newDataVoidIdol_2 = false;
		this.killedVoidIdol_3 = false;
		this.killsVoidIdol_3 = 1;
		this.newDataVoidIdol_3 = false;
		this.grubsCollected = 0;
		this.grubRewards = 0;
		this.finalGrubRewardCollected = false;
		this.fatGrubKing = false;
		this.falseKnightDefeated = false;
		this.falseKnightDreamDefeated = false;
		this.falseKnightOrbsCollected = false;
		this.mawlekDefeated = false;
		this.giantBuzzerDefeated = false;
		this.giantFlyDefeated = false;
		this.blocker1Defeated = false;
		this.blocker2Defeated = false;
		this.hornet1Defeated = false;
		this.collectorDefeated = false;
		this.hornetOutskirtsDefeated = false;
		this.mageLordDreamDefeated = false;
		this.mageLordOrbsCollected = false;
		this.infectedKnightDreamDefeated = false;
		this.infectedKnightOrbsCollected = false;
		this.whiteDefenderDefeated = false;
		this.whiteDefenderOrbsCollected = false;
		this.whiteDefenderDefeats = 0;
		this.greyPrinceDefeats = 0;
		this.greyPrinceDefeated = false;
		this.greyPrinceOrbsCollected = false;
		this.aladarSlugDefeated = 0;
		this.xeroDefeated = 0;
		this.elderHuDefeated = 0;
		this.mumCaterpillarDefeated = 0;
		this.noEyesDefeated = 0;
		this.markothDefeated = 0;
		this.galienDefeated = 0;
		this.XERO_encountered = false;
		this.ALADAR_encountered = false;
		this.HU_encountered = false;
		this.MUMCAT_encountered = false;
		this.NOEYES_encountered = false;
		this.MARKOTH_encountered = false;
		this.GALIEN_encountered = false;
		this.xeroPinned = false;
		this.aladarPinned = false;
		this.huPinned = false;
		this.mumCaterpillarPinned = false;
		this.noEyesPinned = false;
		this.markothPinned = false;
		this.galienPinned = false;
		this.currentInvPane = 0;
		this.showGeoUI = false;
		this.showHealthUI = false;
		this.promptFocus = false;
		this.seenFocusTablet = false;
		this.seenDreamNailPrompt = false;
		this.isFirstGame = true;
		this.enteredTutorialFirstTime = false;
		this.isInvincible = false;
		this.infiniteAirJump = false;
		this.invinciTest = false;
		this.hazardRespawnLocation = Vector3.zero;
		this.currentArea = 0;
		this.visitedDirtmouth = false;
		this.visitedCrossroads = false;
		this.visitedGreenpath = false;
		this.visitedFungus = false;
		this.visitedHive = false;
		this.visitedCrossroadsInfected = false;
		this.visitedRuins = false;
		this.visitedMines = false;
		this.visitedRoyalGardens = false;
		this.visitedFogCanyon = false;
		this.visitedDeepnest = false;
		this.visitedRestingGrounds = false;
		this.visitedWaterways = false;
		this.visitedAbyss = false;
		this.visitedOutskirts = false;
		this.visitedWhitePalace = false;
		this.visitedCliffs = false;
		this.visitedAbyssLower = false;
		this.visitedGodhome = false;
		this.visitedMines10 = false;
		this.scenesVisited = new List<string>();
		this.scenesMapped = new List<string>();
		this.scenesMapped.Add("Cinematic_Stag_travel");
		this.scenesMapped.Add("Room_Town_Stag_Station");
		this.scenesMapped.Add("Room_Charm_Shop");
		this.scenesMapped.Add("Room_Mender_House");
		this.scenesMapped.Add("Room_mapper");
		this.scenesMapped.Add("Room_nailmaster");
		this.scenesMapped.Add("Room_nailmaster_02");
		this.scenesMapped.Add("Room_nailmaster_03");
		this.scenesMapped.Add("Room_shop");
		this.scenesMapped.Add("Room_nailsmith");
		this.scenesMapped.Add("Room_temple");
		this.scenesMapped.Add("Room_ruinhouse");
		this.scenesMapped.Add("Room_Mansion");
		this.scenesMapped.Add("Room_Tram");
		this.scenesMapped.Add("Room_Tram_RG");
		this.scenesMapped.Add("Room_Bretta");
		this.scenesMapped.Add("Room_Fungus_Shaman");
		this.scenesMapped.Add("Room_Ouiji");
		this.scenesMapped.Add("Room_Jinn");
		this.scenesMapped.Add("Room_Colosseum_01");
		this.scenesMapped.Add("Room_Colosseum_02");
		this.scenesMapped.Add("Room_Colosseum_03");
		this.scenesMapped.Add("Room_Colosseum_Bronze");
		this.scenesMapped.Add("Room_Colosseum_Silver");
		this.scenesMapped.Add("Room_Colosseum_Gold");
		this.scenesMapped.Add("Room_Slug_Shrine");
		this.scenesMapped.Add("Crossroads_ShamanTemple");
		this.scenesMapped.Add("Ruins_House_01");
		this.scenesMapped.Add("Ruins_House_02");
		this.scenesMapped.Add("Ruins_House_03");
		this.scenesMapped.Add("Fungus1_35");
		this.scenesMapped.Add("Fungus1_36");
		this.scenesMapped.Add("Fungus3_archive");
		this.scenesMapped.Add("Fungus3_archive_02");
		this.scenesMapped.Add("Cliffs_03");
		this.scenesMapped.Add("RestingGrounds_07");
		this.scenesMapped.Add("Deepnest_45_v02");
		this.scenesMapped.Add("Deepnest_Spider_Town");
		this.scenesMapped.Add("Room_spider_small");
		this.scenesMapped.Add("Room_Wyrm");
		this.scenesMapped.Add("Abyss_Lighthouse_room");
		this.scenesMapped.Add("Room_Queen");
		this.scenesMapped.Add("White_Palace_01");
		this.scenesMapped.Add("White_Palace_02");
		this.scenesMapped.Add("White_Palace_03_hub");
		this.scenesMapped.Add("White_Palace_04");
		this.scenesMapped.Add("White_Palace_05");
		this.scenesMapped.Add("White_Palace_06");
		this.scenesMapped.Add("White_Palace_07");
		this.scenesMapped.Add("White_Palace_08");
		this.scenesMapped.Add("White_Palace_09");
		this.scenesMapped.Add("White_Palace_11");
		this.scenesMapped.Add("White_Palace_12");
		this.scenesMapped.Add("White_Palace_13");
		this.scenesMapped.Add("White_Palace_14");
		this.scenesMapped.Add("White_Palace_15");
		this.scenesMapped.Add("White_Palace_16");
		this.scenesMapped.Add("Dream_Nailcollection");
		this.scenesMapped.Add("Dream_01_False_Knight");
		this.scenesMapped.Add("Dream_03_Infected_Knight");
		this.scenesMapped.Add("Dream_02_Mage_Lord");
		this.scenesMapped.Add("Dream_Guardian");
		this.scenesMapped.Add("Dream_Guardian_Hegemol");
		this.scenesMapped.Add("Dream_Guardian_Lurien");
		this.scenesMapped.Add("Dream_Guardian_Monomon");
		this.scenesMapped.Add("Cutscene_Boss_Door");
		this.scenesMapped.Add("Dream_Backer_Shrine");
		this.scenesMapped.Add("Dream_Room_Believer_Shrine");
		this.scenesMapped.Add("Dream_Abyss");
		this.scenesMapped.Add("Dream_Final_Boss");
		this.scenesMapped.Add("Room_Final_Boss_Atrium");
		this.scenesMapped.Add("Room_Final_Boss_Core");
		this.scenesMapped.Add("Cinematic_Ending_A");
		this.scenesMapped.Add("Cinematic_Ending_B");
		this.scenesMapped.Add("Cinematic_Ending_C");
		this.scenesMapped.Add("Cinematic_Ending_D");
		this.scenesMapped.Add("Cinematic_Ending_E");
		this.scenesMapped.Add("End_Credits");
		this.scenesMapped.Add("Cinematic_MrMushroom");
		this.scenesMapped.Add("End_Game_Completion");
		this.scenesMapped.Add("PermaDeath");
		this.scenesMapped.Add("PermaDeath_Unlock");
		this.scenesMapped.Add("Deepnest_East_17");
		this.scenesEncounteredBench = new List<string>();
		this.scenesEncounteredCocoon = new List<string>();
		this.scenesGrubRescued = new List<string>();
		this.scenesFlameCollected = new List<string>();
		this.scenesEncounteredDreamPlant = new List<string>();
		this.scenesEncounteredDreamPlantC = new List<string>();
		this.hasMap = false;
		this.mapAllRooms = false;
		this.atMapPrompt = false;
		this.mapDirtmouth = true;
		this.mapCrossroads = false;
		this.mapGreenpath = false;
		this.mapFogCanyon = false;
		this.mapRoyalGardens = false;
		this.mapFungalWastes = false;
		this.mapCity = false;
		this.mapWaterways = false;
		this.mapMines = false;
		this.mapDeepnest = false;
		this.mapCliffs = false;
		this.mapOutskirts = false;
		this.mapRestingGrounds = false;
		this.mapAbyss = false;
		this.hasPin = false;
		this.hasPinBench = false;
		this.hasPinCocoon = false;
		this.hasPinDreamPlant = false;
		this.hasPinGuardian = false;
		this.hasPinBlackEgg = false;
		this.hasPinShop = false;
		this.hasPinSpa = false;
		this.hasPinStag = false;
		this.hasPinTram = false;
		this.hasPinGhost = false;
		this.hasPinGrub = false;
		this.hasMarker = false;
		this.hasMarker_r = false;
		this.hasMarker_b = false;
		this.hasMarker_y = false;
		this.hasMarker_w = false;
		this.spareMarkers_r = 6;
		this.spareMarkers_b = 6;
		this.spareMarkers_y = 6;
		this.spareMarkers_w = 6;
		this.placedMarkers_r = new List<Vector3>();
		this.placedMarkers_b = new List<Vector3>();
		this.placedMarkers_y = new List<Vector3>();
		this.placedMarkers_w = new List<Vector3>();
		this.environmentType = 0;
		this.previousDarkness = 0;
		this.openedTramLower = false;
		this.openedTramRestingGrounds = false;
		this.tramLowerPosition = 0;
		this.tramRestingGroundsPosition = 0;
		this.mineLiftOpened = false;
		this.menderDoorOpened = false;
		this.vesselFragStagNest = false;
		this.shamanPillar = false;
		this.crossroadsMawlekWall = false;
		this.eggTempleVisited = false;
		this.crossroadsInfected = false;
		this.falseKnightFirstPlop = false;
		this.falseKnightWallRepaired = false;
		this.falseKnightWallBroken = false;
		this.falseKnightGhostDeparted = false;
		this.spaBugsEncountered = false;
		this.hornheadVinePlat = false;
		this.infectedKnightEncountered = false;
		this.megaMossChargerEncountered = false;
		this.megaMossChargerDefeated = false;
		this.dreamerScene1 = false;
		this.slugEncounterComplete = false;
		this.defeatedDoubleBlockers = false;
		this.oneWayArchive = false;
		this.defeatedMegaJelly = false;
		this.summonedMonomon = false;
		this.sawWoundedQuirrel = false;
		this.encounteredMegaJelly = false;
		this.defeatedMantisLords = false;
		this.encounteredGatekeeper = false;
		this.deepnestWall = false;
		this.queensStationNonDisplay = false;
		this.cityBridge1 = false;
		this.cityBridge2 = false;
		this.cityLift1 = false;
		this.cityLift1_isUp = false;
		this.liftArrival = false;
		this.openedMageDoor_v2 = false;
		this.brokenMageWindow = false;
		this.brokenMageWindowGlass = false;
		this.mageLordEncountered = false;
		this.mageLordEncountered_2 = false;
		this.mageLordDefeated = false;
		this.ruins1_5_tripleDoor = false;
		this.openedWaterwaysManhole = false;
		this.openedCityGate = false;
		this.cityGateClosed = false;
		this.bathHouseOpened = false;
		this.bathHouseWall = false;
		this.cityLift2 = true;
		this.cityLift2_isUp = false;
		this.city2_sewerDoor = false;
		this.openedLoveDoor = false;
		this.watcherChandelier = false;
		this.completedQuakeArea = false;
		this.kingsStationNonDisplay = false;
		this.tollBenchCity = false;
		this.waterwaysGate = false;
		this.defeatedDungDefender = false;
		this.dungDefenderEncounterReady = false;
		this.flukeMotherEncountered = false;
		this.flukeMotherDefeated = false;
		this.waterwaysAcidDrained = false;
		this.dungDefenderWallBroken = false;
		this.dungDefenderSleeping = false;
		this.defeatedMegaBeamMiner = false;
		this.defeatedMegaBeamMiner2 = false;
		this.brokeMinersWall = false;
		this.encounteredMimicSpider = false;
		this.steppedBeyondBridge = false;
		this.deepnestBridgeCollapsed = false;
		this.spiderCapture = false;
		this.deepnest26b_switch = false;
		this.openedRestingGrounds02 = false;
		this.restingGroundsCryptWall = false;
		this.dreamNailConvo = false;
		this.gladeGhostsKilled = 0;
		this.openedGardensStagStation = false;
		this.extendedGramophone = false;
		this.tollBenchQueensGardens = false;
		this.blizzardEnded = false;
		this.encounteredHornet = false;
		this.savedByHornet = false;
		this.outskirtsWall = false;
		this.abyssGateOpened = false;
		this.abyssLighthouse = false;
		this.blueVineDoor = false;
		this.gotShadeCharm = false;
		this.tollBenchAbyss = false;
		this.fountainGeo = 0;
		this.fountainVesselSummoned = false;
		this.openedBlackEggPath = false;
		this.enteredDreamWorld = false;
		this.duskKnightDefeated = false;
		this.whitePalaceOrb_1 = false;
		this.whitePalaceOrb_2 = false;
		this.whitePalaceOrb_3 = false;
		this.whitePalace05_lever = false;
		this.whitePalaceMidWarp = false;
		this.whitePalaceSecretRoomVisited = false;
		this.tramOpenedDeepnest = false;
		this.tramOpenedCrossroads = false;
		this.openedBlackEggDoor = false;
		this.unchainedHollowKnight = false;
		this.flamesCollected = 0;
		this.flamesRequired = 3;
		this.nightmareLanternAppeared = false;
		this.nightmareLanternLit = false;
		this.troupeInTown = false;
		this.divineInTown = false;
		this.grimmChildLevel = 1;
		this.elderbugConvoGrimm = false;
		this.slyConvoGrimm = false;
		this.iseldaConvoGrimm = false;
		this.midwifeWeaverlingConvo = false;
		this.metGrimm = false;
		this.foughtGrimm = false;
		this.metBrum = false;
		this.defeatedNightmareGrimm = false;
		this.grimmchildAwoken = false;
		this.gotBrummsFlame = false;
		this.brummBrokeBrazier = false;
		this.destroyedNightmareLantern = false;
		this.gotGrimmNotch = false;
		this.nymmInTown = false;
		this.nymmSpoken = false;
		this.elderbugNymmConvo = false;
		this.slyNymmConvo = false;
		this.iseldaNymmConvo = false;
		this.elderbugTroupeLeftConvo = false;
		this.jijiGrimmConvo = false;
		this.nymmMissedEggOpen = false;
		this.elderbugBrettaLeft = false;
		this.metDivine = false;
		this.divineFinalConvo = false;
		this.gaveFragileHeart = false;
		this.gaveFragileGreed = false;
		this.gaveFragileStrength = false;
		this.pooedFragileHeart = false;
		this.pooedFragileGreed = false;
		this.pooedFragileStrength = false;
		this.divineEatenConvos = 0;
		this.completionPercentage = 0f;
		this.unlockedCompletionRate = false;
		this.disablePause = false;
		this.backerCredits = false;
		this.mapKeyPref = 0;
		this.playerStory = new List<string>();
		this.betaEnd = false;
		this.bossReturnEntryGate = "";
		this.bossDoorStateTier1 = BossSequenceDoor.Completion.None;
		this.bossDoorStateTier2 = BossSequenceDoor.Completion.None;
		this.bossDoorStateTier3 = BossSequenceDoor.Completion.None;
		this.bossDoorStateTier4 = BossSequenceDoor.Completion.None;
		this.bossDoorStateTier5 = BossSequenceDoor.Completion.None;
		this.bossStatueTargetLevel = -1;
		this.currentBossStatueCompletionKey = "";
		this.statueStateGruzMother = BossStatue.Completion.None;
		this.statueStateVengefly = BossStatue.Completion.None;
		this.statueStateBroodingMawlek = BossStatue.Completion.None;
		this.statueStateFalseKnight = BossStatue.Completion.None;
		this.statueStateFailedChampion = BossStatue.Completion.None;
		this.statueStateHornet1 = BossStatue.Completion.None;
		this.statueStateHornet2 = BossStatue.Completion.None;
		this.statueStateMegaMossCharger = BossStatue.Completion.None;
		this.statueStateMantisLords = BossStatue.Completion.None;
		this.statueStateOblobbles = BossStatue.Completion.None;
		this.statueStateGreyPrince = BossStatue.Completion.None;
		this.statueStateBrokenVessel = BossStatue.Completion.None;
		this.statueStateLostKin = BossStatue.Completion.None;
		this.statueStateNosk = BossStatue.Completion.None;
		this.statueStateFlukemarm = BossStatue.Completion.None;
		this.statueStateCollector = BossStatue.Completion.None;
		this.statueStateWatcherKnights = BossStatue.Completion.None;
		this.statueStateSoulMaster = BossStatue.Completion.None;
		this.statueStateSoulTyrant = BossStatue.Completion.None;
		this.statueStateGodTamer = BossStatue.Completion.None;
		this.statueStateCrystalGuardian1 = BossStatue.Completion.None;
		this.statueStateCrystalGuardian2 = BossStatue.Completion.None;
		this.statueStateUumuu = BossStatue.Completion.None;
		this.statueStateDungDefender = BossStatue.Completion.None;
		this.statueStateWhiteDefender = BossStatue.Completion.None;
		this.statueStateHiveKnight = BossStatue.Completion.None;
		this.statueStateTraitorLord = BossStatue.Completion.None;
		this.statueStateGrimm = BossStatue.Completion.None;
		this.statueStateNightmareGrimm = BossStatue.Completion.None;
		this.statueStateHollowKnight = BossStatue.Completion.None;
		this.statueStateElderHu = BossStatue.Completion.None;
		this.statueStateGalien = BossStatue.Completion.None;
		this.statueStateMarkoth = BossStatue.Completion.None;
		this.statueStateMarmu = BossStatue.Completion.None;
		this.statueStateNoEyes = BossStatue.Completion.None;
		this.statueStateXero = BossStatue.Completion.None;
		this.statueStateGorb = BossStatue.Completion.None;
		this.statueStateRadiance = new BossStatue.Completion
		{
			hasBeenSeen = true
		};
		this.statueStateSly = BossStatue.Completion.None;
		this.statueStateNailmasters = BossStatue.Completion.None;
		this.statueStateMageKnight = BossStatue.Completion.None;
		this.statueStatePaintmaster = BossStatue.Completion.None;
		this.statueStateZote = BossStatue.Completion.None;
		this.statueStateNoskHornet = BossStatue.Completion.None;
		this.statueStateMantisLordsExtra = BossStatue.Completion.None;
		this.godseekerUnlocked = false;
		this.currentBossSequence = null;
		this.bossRushMode = false;
		this.bossDoorCageUnlocked = false;
		this.blueRoomDoorUnlocked = false;
		this.blueRoomActivated = false;
		this.finalBossDoorUnlocked = false;
		this.hasGodfinder = false;
		this.unlockedNewBossStatue = true;
		this.scaredFlukeHermitEncountered = false;
		this.scaredFlukeHermitReturned = false;
		this.enteredGGAtrium = false;
		this.extraFlowerAppear = false;
		this.givenGodseekerFlower = false;
		this.givenOroFlower = false;
		this.givenWhiteLadyFlower = false;
		this.givenEmilitiaFlower = false;
		this.unlockedBossScenes = new List<string>();
		this.queuedGodfinderIcon = false;
		this.godseekerSpokenAwake = false;
		this.nailsmithCorpseAppeared = false;
		this.godseekerWaterwaysSeenState = -1;
		this.godseekerWaterwaysSpoken1 = false;
		this.godseekerWaterwaysSpoken2 = false;
		this.godseekerWaterwaysSpoken3 = false;
		this.bossDoorEntranceTextSeen = -1;
		this.seenDoor4Finale = false;
		this.zoteStatueWallBroken = false;
		this.seenGGWastes = false;
		this.ordealAchieved = false;
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x00082768 File Offset: 0x00080968
	public void AddGGPlayerDataOverrides()
	{
		this.bossRushMode = true;
		this.atBench = false;
		this.respawnScene = "GG_Entrance_Cutscene";
		this.respawnMarkerName = "Death Respawn Marker";
		this.mapZone = MapZone.GODS_GLORY;
		this.respawnType = 0;
		this.respawnFacingRight = true;
		this.hazardRespawnFacingRight = true;
		this.maxHealthBase = this.maxHealthCap;
		this.MPReserveMax = this.MPReserveCap;
		this.heartPieceMax = true;
		this.nailDamage = 21;
		this.honedNail = true;
		this.nailSmithUpgrades = 4;
		this.canDash = true;
		this.canShadowDash = true;
		this.hasDash = true;
		this.hasShadowDash = true;
		this.hasWalljump = true;
		this.hasDoubleJump = true;
		this.hasSuperDash = true;
		this.hasDreamNail = true;
		this.hasDreamGate = true;
		this.dreamOrbs = 1;
		this.hasNailArt = true;
		this.hasDashSlash = true;
		this.hasCyclone = true;
		this.hasUpwardSlash = true;
		this.hasSpell = true;
		this.shadeFireballLevel = 2;
		this.shadeQuakeLevel = 2;
		this.shadeScreamLevel = 2;
		this.fireballLevel = 2;
		this.quakeLevel = 2;
		this.screamLevel = 2;
		this.grimmChildLevel = 4;
		this.hasAcidArmour = true;
		this.hasLantern = true;
		this.hasCharm = true;
		this.charmSlots = 11;
		this.equippedCharm_36 = true;
		if (!this.equippedCharms.Contains(36))
		{
			this.equippedCharms.Add(36);
		}
		this.charmCost_36 = 0;
		this.fragileGreed_unbreakable = true;
		this.fragileHealth_unbreakable = true;
		this.fragileStrength_unbreakable = true;
		this.gotShadeCharm = true;
		this.hasGodfinder = true;
		this.greyPrinceDefeats = 1;
		this.greyPrinceDefeated = true;
		this.seenDoor4Finale = true;
		foreach (FieldInfo fieldInfo in base.GetType().GetFields())
		{
			if (fieldInfo.FieldType == typeof(BossSequenceDoor.Completion))
			{
				BossSequenceDoor.Completion completion = (BossSequenceDoor.Completion)fieldInfo.GetValue(this);
				completion.unlocked = true;
				fieldInfo.SetValue(this, completion);
			}
			else if (fieldInfo.FieldType == typeof(BossStatue.Completion))
			{
				if (!fieldInfo.Name.IsAny(new string[]
				{
					"statueStateRadiance"
				}))
				{
					BossStatue.Completion completion2 = (BossStatue.Completion)fieldInfo.GetValue(this);
					completion2.isUnlocked = true;
					completion2.hasBeenSeen = true;
					fieldInfo.SetValue(this, completion2);
				}
			}
			else
			{
				string a = fieldInfo.Name.Split(new char[]
				{
					'_'
				})[0];
				if (a == "gotCharm")
				{
					fieldInfo.SetValue(this, true);
				}
				else if (a == "newCharm")
				{
					fieldInfo.SetValue(this, false);
				}
			}
		}
	}

	// Token: 0x040012E3 RID: 4835
	public string version;

	// Token: 0x040012E4 RID: 4836
	public bool awardAllAchievements;

	// Token: 0x040012E5 RID: 4837
	public int profileID;

	// Token: 0x040012E6 RID: 4838
	public float playTime;

	// Token: 0x040012E7 RID: 4839
	public float completionPercent;

	// Token: 0x040012E8 RID: 4840
	public bool openingCreditsPlayed;

	// Token: 0x040012E9 RID: 4841
	public int permadeathMode;

	// Token: 0x040012EA RID: 4842
	public int health;

	// Token: 0x040012EB RID: 4843
	public int maxHealth;

	// Token: 0x040012EC RID: 4844
	public int maxHealthBase;

	// Token: 0x040012ED RID: 4845
	public int healthBlue;

	// Token: 0x040012EE RID: 4846
	public int joniHealthBlue;

	// Token: 0x040012EF RID: 4847
	public bool damagedBlue;

	// Token: 0x040012F0 RID: 4848
	public int heartPieces;

	// Token: 0x040012F1 RID: 4849
	public bool heartPieceCollected;

	// Token: 0x040012F2 RID: 4850
	public int maxHealthCap;

	// Token: 0x040012F3 RID: 4851
	public bool heartPieceMax;

	// Token: 0x040012F4 RID: 4852
	public int prevHealth;

	// Token: 0x040012F5 RID: 4853
	public int blockerHits;

	// Token: 0x040012F6 RID: 4854
	public bool firstGeo;

	// Token: 0x040012F7 RID: 4855
	public int geo;

	// Token: 0x040012F8 RID: 4856
	public int maxMP;

	// Token: 0x040012F9 RID: 4857
	public int MPCharge;

	// Token: 0x040012FA RID: 4858
	public int MPReserve;

	// Token: 0x040012FB RID: 4859
	public int MPReserveMax;

	// Token: 0x040012FC RID: 4860
	public bool soulLimited;

	// Token: 0x040012FD RID: 4861
	public int vesselFragments;

	// Token: 0x040012FE RID: 4862
	public bool vesselFragmentCollected;

	// Token: 0x040012FF RID: 4863
	public int MPReserveCap;

	// Token: 0x04001300 RID: 4864
	public bool vesselFragmentMax;

	// Token: 0x04001301 RID: 4865
	public int focusMP_amount;

	// Token: 0x04001302 RID: 4866
	public bool atBench;

	// Token: 0x04001303 RID: 4867
	public string respawnScene;

	// Token: 0x04001304 RID: 4868
	public MapZone mapZone;

	// Token: 0x04001305 RID: 4869
	public string respawnMarkerName;

	// Token: 0x04001306 RID: 4870
	public int respawnType;

	// Token: 0x04001307 RID: 4871
	public bool respawnFacingRight;

	// Token: 0x04001308 RID: 4872
	[NonSerialized]
	public Vector3 hazardRespawnLocation;

	// Token: 0x04001309 RID: 4873
	public bool hazardRespawnFacingRight;

	// Token: 0x0400130A RID: 4874
	public string shadeScene;

	// Token: 0x0400130B RID: 4875
	public string shadeMapZone;

	// Token: 0x0400130C RID: 4876
	public float shadePositionX;

	// Token: 0x0400130D RID: 4877
	public float shadePositionY;

	// Token: 0x0400130E RID: 4878
	public int shadeHealth;

	// Token: 0x0400130F RID: 4879
	public int shadeMP;

	// Token: 0x04001310 RID: 4880
	public int shadeFireballLevel;

	// Token: 0x04001311 RID: 4881
	public int shadeQuakeLevel;

	// Token: 0x04001312 RID: 4882
	public int shadeScreamLevel;

	// Token: 0x04001313 RID: 4883
	public int shadeSpecialType;

	// Token: 0x04001314 RID: 4884
	public Vector3 shadeMapPos;

	// Token: 0x04001315 RID: 4885
	public Vector3 dreamgateMapPos;

	// Token: 0x04001316 RID: 4886
	public int geoPool;

	// Token: 0x04001317 RID: 4887
	public int nailDamage;

	// Token: 0x04001318 RID: 4888
	public int nailRange;

	// Token: 0x04001319 RID: 4889
	public int beamDamage;

	// Token: 0x0400131A RID: 4890
	public bool canDash;

	// Token: 0x0400131B RID: 4891
	public bool canBackDash;

	// Token: 0x0400131C RID: 4892
	public bool canWallJump;

	// Token: 0x0400131D RID: 4893
	public bool canSuperDash;

	// Token: 0x0400131E RID: 4894
	public bool canShadowDash;

	// Token: 0x0400131F RID: 4895
	public bool hasSpell;

	// Token: 0x04001320 RID: 4896
	public int fireballLevel;

	// Token: 0x04001321 RID: 4897
	public int quakeLevel;

	// Token: 0x04001322 RID: 4898
	public int screamLevel;

	// Token: 0x04001323 RID: 4899
	public bool hasNailArt;

	// Token: 0x04001324 RID: 4900
	public bool hasCyclone;

	// Token: 0x04001325 RID: 4901
	public bool hasDashSlash;

	// Token: 0x04001326 RID: 4902
	public bool hasUpwardSlash;

	// Token: 0x04001327 RID: 4903
	public bool hasAllNailArts;

	// Token: 0x04001328 RID: 4904
	public bool hasDreamNail;

	// Token: 0x04001329 RID: 4905
	public bool hasDreamGate;

	// Token: 0x0400132A RID: 4906
	public bool dreamNailUpgraded;

	// Token: 0x0400132B RID: 4907
	public int dreamOrbs;

	// Token: 0x0400132C RID: 4908
	public int dreamOrbsSpent;

	// Token: 0x0400132D RID: 4909
	public string dreamGateScene;

	// Token: 0x0400132E RID: 4910
	public float dreamGateX;

	// Token: 0x0400132F RID: 4911
	public float dreamGateY;

	// Token: 0x04001330 RID: 4912
	public bool hasDash;

	// Token: 0x04001331 RID: 4913
	public bool hasWalljump;

	// Token: 0x04001332 RID: 4914
	public bool hasSuperDash;

	// Token: 0x04001333 RID: 4915
	public bool hasShadowDash;

	// Token: 0x04001334 RID: 4916
	public bool hasAcidArmour;

	// Token: 0x04001335 RID: 4917
	public bool hasDoubleJump;

	// Token: 0x04001336 RID: 4918
	public bool hasLantern;

	// Token: 0x04001337 RID: 4919
	public bool hasTramPass;

	// Token: 0x04001338 RID: 4920
	public bool hasQuill;

	// Token: 0x04001339 RID: 4921
	public bool hasCityKey;

	// Token: 0x0400133A RID: 4922
	public bool hasSlykey;

	// Token: 0x0400133B RID: 4923
	public bool gaveSlykey;

	// Token: 0x0400133C RID: 4924
	public bool hasWhiteKey;

	// Token: 0x0400133D RID: 4925
	public bool usedWhiteKey;

	// Token: 0x0400133E RID: 4926
	public bool hasMenderKey;

	// Token: 0x0400133F RID: 4927
	public bool hasWaterwaysKey;

	// Token: 0x04001340 RID: 4928
	public bool hasSpaKey;

	// Token: 0x04001341 RID: 4929
	public bool hasLoveKey;

	// Token: 0x04001342 RID: 4930
	public bool hasKingsBrand;

	// Token: 0x04001343 RID: 4931
	public bool hasXunFlower;

	// Token: 0x04001344 RID: 4932
	public int ghostCoins;

	// Token: 0x04001345 RID: 4933
	public int ore;

	// Token: 0x04001346 RID: 4934
	public bool foundGhostCoin;

	// Token: 0x04001347 RID: 4935
	public int trinket1;

	// Token: 0x04001348 RID: 4936
	public bool foundTrinket1;

	// Token: 0x04001349 RID: 4937
	public int trinket2;

	// Token: 0x0400134A RID: 4938
	public bool foundTrinket2;

	// Token: 0x0400134B RID: 4939
	public int trinket3;

	// Token: 0x0400134C RID: 4940
	public bool foundTrinket3;

	// Token: 0x0400134D RID: 4941
	public int trinket4;

	// Token: 0x0400134E RID: 4942
	public bool foundTrinket4;

	// Token: 0x0400134F RID: 4943
	public bool noTrinket1;

	// Token: 0x04001350 RID: 4944
	public bool noTrinket2;

	// Token: 0x04001351 RID: 4945
	public bool noTrinket3;

	// Token: 0x04001352 RID: 4946
	public bool noTrinket4;

	// Token: 0x04001353 RID: 4947
	public int soldTrinket1;

	// Token: 0x04001354 RID: 4948
	public int soldTrinket2;

	// Token: 0x04001355 RID: 4949
	public int soldTrinket3;

	// Token: 0x04001356 RID: 4950
	public int soldTrinket4;

	// Token: 0x04001357 RID: 4951
	public int simpleKeys;

	// Token: 0x04001358 RID: 4952
	public int rancidEggs;

	// Token: 0x04001359 RID: 4953
	public bool notchShroomOgres;

	// Token: 0x0400135A RID: 4954
	public bool notchFogCanyon;

	// Token: 0x0400135B RID: 4955
	public bool gotLurkerKey;

	// Token: 0x0400135C RID: 4956
	public float gMap_doorX;

	// Token: 0x0400135D RID: 4957
	public float gMap_doorY;

	// Token: 0x0400135E RID: 4958
	public string gMap_doorScene;

	// Token: 0x0400135F RID: 4959
	public string gMap_doorMapZone;

	// Token: 0x04001360 RID: 4960
	public float gMap_doorOriginOffsetX;

	// Token: 0x04001361 RID: 4961
	public float gMap_doorOriginOffsetY;

	// Token: 0x04001362 RID: 4962
	public float gMap_doorSceneWidth;

	// Token: 0x04001363 RID: 4963
	public float gMap_doorSceneHeight;

	// Token: 0x04001364 RID: 4964
	public int guardiansDefeated;

	// Token: 0x04001365 RID: 4965
	public bool lurienDefeated;

	// Token: 0x04001366 RID: 4966
	public bool hegemolDefeated;

	// Token: 0x04001367 RID: 4967
	public bool monomonDefeated;

	// Token: 0x04001368 RID: 4968
	public bool maskBrokenLurien;

	// Token: 0x04001369 RID: 4969
	public bool maskBrokenHegemol;

	// Token: 0x0400136A RID: 4970
	public bool maskBrokenMonomon;

	// Token: 0x0400136B RID: 4971
	public int maskToBreak;

	// Token: 0x0400136C RID: 4972
	public int elderbug;

	// Token: 0x0400136D RID: 4973
	public bool metElderbug;

	// Token: 0x0400136E RID: 4974
	public bool elderbugReintro;

	// Token: 0x0400136F RID: 4975
	public int elderbugHistory;

	// Token: 0x04001370 RID: 4976
	public bool elderbugHistory1;

	// Token: 0x04001371 RID: 4977
	public bool elderbugHistory2;

	// Token: 0x04001372 RID: 4978
	public bool elderbugHistory3;

	// Token: 0x04001373 RID: 4979
	public bool elderbugSpeechSly;

	// Token: 0x04001374 RID: 4980
	public bool elderbugSpeechStation;

	// Token: 0x04001375 RID: 4981
	public bool elderbugSpeechEggTemple;

	// Token: 0x04001376 RID: 4982
	public bool elderbugSpeechMapShop;

	// Token: 0x04001377 RID: 4983
	public bool elderbugSpeechBretta;

	// Token: 0x04001378 RID: 4984
	public bool elderbugSpeechJiji;

	// Token: 0x04001379 RID: 4985
	public bool elderbugSpeechMinesLift;

	// Token: 0x0400137A RID: 4986
	public bool elderbugSpeechKingsPass;

	// Token: 0x0400137B RID: 4987
	public bool elderbugSpeechInfectedCrossroads;

	// Token: 0x0400137C RID: 4988
	public bool elderbugSpeechFinalBossDoor;

	// Token: 0x0400137D RID: 4989
	public bool elderbugRequestedFlower;

	// Token: 0x0400137E RID: 4990
	public bool elderbugGaveFlower;

	// Token: 0x0400137F RID: 4991
	public bool elderbugFirstCall;

	// Token: 0x04001380 RID: 4992
	public bool metQuirrel;

	// Token: 0x04001381 RID: 4993
	public int quirrelEggTemple;

	// Token: 0x04001382 RID: 4994
	public int quirrelSlugShrine;

	// Token: 0x04001383 RID: 4995
	public int quirrelRuins;

	// Token: 0x04001384 RID: 4996
	public int quirrelMines;

	// Token: 0x04001385 RID: 4997
	public bool quirrelLeftStation;

	// Token: 0x04001386 RID: 4998
	public bool quirrelLeftEggTemple;

	// Token: 0x04001387 RID: 4999
	public bool quirrelCityEncountered;

	// Token: 0x04001388 RID: 5000
	public bool quirrelCityLeft;

	// Token: 0x04001389 RID: 5001
	public bool quirrelMinesEncountered;

	// Token: 0x0400138A RID: 5002
	public bool quirrelMinesLeft;

	// Token: 0x0400138B RID: 5003
	public bool quirrelMantisEncountered;

	// Token: 0x0400138C RID: 5004
	public bool enteredMantisLordArea;

	// Token: 0x0400138D RID: 5005
	public bool visitedDeepnestSpa;

	// Token: 0x0400138E RID: 5006
	public bool quirrelSpaReady;

	// Token: 0x0400138F RID: 5007
	public bool quirrelSpaEncountered;

	// Token: 0x04001390 RID: 5008
	public bool quirrelArchiveEncountered;

	// Token: 0x04001391 RID: 5009
	public bool quirrelEpilogueCompleted;

	// Token: 0x04001392 RID: 5010
	public bool metRelicDealer;

	// Token: 0x04001393 RID: 5011
	public bool metRelicDealerShop;

	// Token: 0x04001394 RID: 5012
	public bool marmOutside;

	// Token: 0x04001395 RID: 5013
	public bool marmOutsideConvo;

	// Token: 0x04001396 RID: 5014
	public bool marmConvo1;

	// Token: 0x04001397 RID: 5015
	public bool marmConvo2;

	// Token: 0x04001398 RID: 5016
	public bool marmConvo3;

	// Token: 0x04001399 RID: 5017
	public bool marmConvoNailsmith;

	// Token: 0x0400139A RID: 5018
	public int cornifer;

	// Token: 0x0400139B RID: 5019
	public bool metCornifer;

	// Token: 0x0400139C RID: 5020
	public bool corniferIntroduced;

	// Token: 0x0400139D RID: 5021
	public bool corniferAtHome;

	// Token: 0x0400139E RID: 5022
	public bool corn_crossroadsEncountered;

	// Token: 0x0400139F RID: 5023
	public bool corn_crossroadsLeft;

	// Token: 0x040013A0 RID: 5024
	public bool corn_greenpathEncountered;

	// Token: 0x040013A1 RID: 5025
	public bool corn_greenpathLeft;

	// Token: 0x040013A2 RID: 5026
	public bool corn_fogCanyonEncountered;

	// Token: 0x040013A3 RID: 5027
	public bool corn_fogCanyonLeft;

	// Token: 0x040013A4 RID: 5028
	public bool corn_fungalWastesEncountered;

	// Token: 0x040013A5 RID: 5029
	public bool corn_fungalWastesLeft;

	// Token: 0x040013A6 RID: 5030
	public bool corn_cityEncountered;

	// Token: 0x040013A7 RID: 5031
	public bool corn_cityLeft;

	// Token: 0x040013A8 RID: 5032
	public bool corn_waterwaysEncountered;

	// Token: 0x040013A9 RID: 5033
	public bool corn_waterwaysLeft;

	// Token: 0x040013AA RID: 5034
	public bool corn_minesEncountered;

	// Token: 0x040013AB RID: 5035
	public bool corn_minesLeft;

	// Token: 0x040013AC RID: 5036
	public bool corn_cliffsEncountered;

	// Token: 0x040013AD RID: 5037
	public bool corn_cliffsLeft;

	// Token: 0x040013AE RID: 5038
	public bool corn_deepnestEncountered;

	// Token: 0x040013AF RID: 5039
	public bool corn_deepnestLeft;

	// Token: 0x040013B0 RID: 5040
	public bool corn_deepnestMet1;

	// Token: 0x040013B1 RID: 5041
	public bool corn_deepnestMet2;

	// Token: 0x040013B2 RID: 5042
	public bool corn_outskirtsEncountered;

	// Token: 0x040013B3 RID: 5043
	public bool corn_outskirtsLeft;

	// Token: 0x040013B4 RID: 5044
	public bool corn_royalGardensEncountered;

	// Token: 0x040013B5 RID: 5045
	public bool corn_royalGardensLeft;

	// Token: 0x040013B6 RID: 5046
	public bool corn_abyssEncountered;

	// Token: 0x040013B7 RID: 5047
	public bool corn_abyssLeft;

	// Token: 0x040013B8 RID: 5048
	public bool metIselda;

	// Token: 0x040013B9 RID: 5049
	public bool iseldaCorniferHomeConvo;

	// Token: 0x040013BA RID: 5050
	public bool iseldaConvo1;

	// Token: 0x040013BB RID: 5051
	public bool brettaRescued;

	// Token: 0x040013BC RID: 5052
	public int brettaPosition;

	// Token: 0x040013BD RID: 5053
	public int brettaState;

	// Token: 0x040013BE RID: 5054
	public bool brettaSeenBench;

	// Token: 0x040013BF RID: 5055
	public bool brettaSeenBed;

	// Token: 0x040013C0 RID: 5056
	public bool brettaSeenBenchDiary;

	// Token: 0x040013C1 RID: 5057
	public bool brettaSeenBedDiary;

	// Token: 0x040013C2 RID: 5058
	public bool brettaLeftTown;

	// Token: 0x040013C3 RID: 5059
	public bool slyRescued;

	// Token: 0x040013C4 RID: 5060
	public bool slyBeta;

	// Token: 0x040013C5 RID: 5061
	public bool metSlyShop;

	// Token: 0x040013C6 RID: 5062
	public bool gotSlyCharm;

	// Token: 0x040013C7 RID: 5063
	public bool slyShellFrag1;

	// Token: 0x040013C8 RID: 5064
	public bool slyShellFrag2;

	// Token: 0x040013C9 RID: 5065
	public bool slyShellFrag3;

	// Token: 0x040013CA RID: 5066
	public bool slyShellFrag4;

	// Token: 0x040013CB RID: 5067
	public bool slyVesselFrag1;

	// Token: 0x040013CC RID: 5068
	public bool slyVesselFrag2;

	// Token: 0x040013CD RID: 5069
	public bool slyVesselFrag3;

	// Token: 0x040013CE RID: 5070
	public bool slyVesselFrag4;

	// Token: 0x040013CF RID: 5071
	public bool slyNotch1;

	// Token: 0x040013D0 RID: 5072
	public bool slyNotch2;

	// Token: 0x040013D1 RID: 5073
	public bool slySimpleKey;

	// Token: 0x040013D2 RID: 5074
	public bool slyRancidEgg;

	// Token: 0x040013D3 RID: 5075
	public bool slyConvoNailArt;

	// Token: 0x040013D4 RID: 5076
	public bool slyConvoMapper;

	// Token: 0x040013D5 RID: 5077
	public bool slyConvoNailHoned;

	// Token: 0x040013D6 RID: 5078
	public bool jijiDoorUnlocked;

	// Token: 0x040013D7 RID: 5079
	public bool jijiMet;

	// Token: 0x040013D8 RID: 5080
	public bool jijiShadeOffered;

	// Token: 0x040013D9 RID: 5081
	public bool jijiShadeCharmConvo;

	// Token: 0x040013DA RID: 5082
	public bool metJinn;

	// Token: 0x040013DB RID: 5083
	public bool jinnConvo1;

	// Token: 0x040013DC RID: 5084
	public bool jinnConvo2;

	// Token: 0x040013DD RID: 5085
	public bool jinnConvo3;

	// Token: 0x040013DE RID: 5086
	public bool jinnConvoKingBrand;

	// Token: 0x040013DF RID: 5087
	public bool jinnConvoShadeCharm;

	// Token: 0x040013E0 RID: 5088
	public int jinnEggsSold;

	// Token: 0x040013E1 RID: 5089
	public int zote;

	// Token: 0x040013E2 RID: 5090
	public bool zoteRescuedBuzzer;

	// Token: 0x040013E3 RID: 5091
	public bool zoteDead;

	// Token: 0x040013E4 RID: 5092
	public int zoteDeathPos;

	// Token: 0x040013E5 RID: 5093
	public bool zoteSpokenCity;

	// Token: 0x040013E6 RID: 5094
	public bool zoteLeftCity;

	// Token: 0x040013E7 RID: 5095
	public bool zoteTrappedDeepnest;

	// Token: 0x040013E8 RID: 5096
	public bool zoteRescuedDeepnest;

	// Token: 0x040013E9 RID: 5097
	public bool zoteDefeated;

	// Token: 0x040013EA RID: 5098
	public bool zoteSpokenColosseum;

	// Token: 0x040013EB RID: 5099
	public int zotePrecept;

	// Token: 0x040013EC RID: 5100
	public int zoteTownConvo;

	// Token: 0x040013ED RID: 5101
	public int shaman;

	// Token: 0x040013EE RID: 5102
	public bool shamanScreamConvo;

	// Token: 0x040013EF RID: 5103
	public bool shamanQuakeConvo;

	// Token: 0x040013F0 RID: 5104
	public bool shamanFireball2Convo;

	// Token: 0x040013F1 RID: 5105
	public bool shamanScream2Convo;

	// Token: 0x040013F2 RID: 5106
	public bool shamanQuake2Convo;

	// Token: 0x040013F3 RID: 5107
	public bool metMiner;

	// Token: 0x040013F4 RID: 5108
	public int miner;

	// Token: 0x040013F5 RID: 5109
	public int minerEarly;

	// Token: 0x040013F6 RID: 5110
	public int hornetGreenpath;

	// Token: 0x040013F7 RID: 5111
	public int hornetFung;

	// Token: 0x040013F8 RID: 5112
	public bool hornet_f19;

	// Token: 0x040013F9 RID: 5113
	public bool hornetFountainEncounter;

	// Token: 0x040013FA RID: 5114
	public bool hornetCityBridge_ready;

	// Token: 0x040013FB RID: 5115
	public bool hornetCityBridge_completed;

	// Token: 0x040013FC RID: 5116
	public bool hornetAbyssEncounter;

	// Token: 0x040013FD RID: 5117
	public bool hornetDenEncounter;

	// Token: 0x040013FE RID: 5118
	public bool metMoth;

	// Token: 0x040013FF RID: 5119
	public bool ignoredMoth;

	// Token: 0x04001400 RID: 5120
	public bool gladeDoorOpened;

	// Token: 0x04001401 RID: 5121
	public bool mothDeparted;

	// Token: 0x04001402 RID: 5122
	public bool completedRGDreamPlant;

	// Token: 0x04001403 RID: 5123
	public bool dreamReward1;

	// Token: 0x04001404 RID: 5124
	public bool dreamReward2;

	// Token: 0x04001405 RID: 5125
	public bool dreamReward3;

	// Token: 0x04001406 RID: 5126
	public bool dreamReward4;

	// Token: 0x04001407 RID: 5127
	public bool dreamReward5;

	// Token: 0x04001408 RID: 5128
	public bool dreamReward5b;

	// Token: 0x04001409 RID: 5129
	public bool dreamReward6;

	// Token: 0x0400140A RID: 5130
	public bool dreamReward7;

	// Token: 0x0400140B RID: 5131
	public bool dreamReward8;

	// Token: 0x0400140C RID: 5132
	public bool dreamReward9;

	// Token: 0x0400140D RID: 5133
	public bool dreamMothConvo1;

	// Token: 0x0400140E RID: 5134
	public bool bankerAccountPurchased;

	// Token: 0x0400140F RID: 5135
	public bool metBanker;

	// Token: 0x04001410 RID: 5136
	public int bankerBalance;

	// Token: 0x04001411 RID: 5137
	public bool bankerDeclined;

	// Token: 0x04001412 RID: 5138
	public bool bankerTheftCheck;

	// Token: 0x04001413 RID: 5139
	public int bankerTheft;

	// Token: 0x04001414 RID: 5140
	public bool bankerSpaMet;

	// Token: 0x04001415 RID: 5141
	public bool metGiraffe;

	// Token: 0x04001416 RID: 5142
	public bool metCharmSlug;

	// Token: 0x04001417 RID: 5143
	public bool salubraNotch1;

	// Token: 0x04001418 RID: 5144
	public bool salubraNotch2;

	// Token: 0x04001419 RID: 5145
	public bool salubraNotch3;

	// Token: 0x0400141A RID: 5146
	public bool salubraNotch4;

	// Token: 0x0400141B RID: 5147
	public bool salubraBlessing;

	// Token: 0x0400141C RID: 5148
	public bool salubraConvoCombo;

	// Token: 0x0400141D RID: 5149
	public bool salubraConvoOvercharm;

	// Token: 0x0400141E RID: 5150
	public bool salubraConvoTruth;

	// Token: 0x0400141F RID: 5151
	public bool cultistTransformed;

	// Token: 0x04001420 RID: 5152
	public bool metNailsmith;

	// Token: 0x04001421 RID: 5153
	public int nailSmithUpgrades;

	// Token: 0x04001422 RID: 5154
	public bool honedNail;

	// Token: 0x04001423 RID: 5155
	public bool nailsmithCliff;

	// Token: 0x04001424 RID: 5156
	public bool nailsmithKilled;

	// Token: 0x04001425 RID: 5157
	public bool nailsmithSpared;

	// Token: 0x04001426 RID: 5158
	public bool nailsmithKillSpeech;

	// Token: 0x04001427 RID: 5159
	public bool nailsmithSheo;

	// Token: 0x04001428 RID: 5160
	public bool nailsmithConvoArt;

	// Token: 0x04001429 RID: 5161
	public bool metNailmasterMato;

	// Token: 0x0400142A RID: 5162
	public bool metNailmasterSheo;

	// Token: 0x0400142B RID: 5163
	public bool metNailmasterOro;

	// Token: 0x0400142C RID: 5164
	public bool matoConvoSheo;

	// Token: 0x0400142D RID: 5165
	public bool matoConvoOro;

	// Token: 0x0400142E RID: 5166
	public bool matoConvoSly;

	// Token: 0x0400142F RID: 5167
	public bool sheoConvoMato;

	// Token: 0x04001430 RID: 5168
	public bool sheoConvoOro;

	// Token: 0x04001431 RID: 5169
	public bool sheoConvoSly;

	// Token: 0x04001432 RID: 5170
	public bool sheoConvoNailsmith;

	// Token: 0x04001433 RID: 5171
	public bool oroConvoSheo;

	// Token: 0x04001434 RID: 5172
	public bool oroConvoMato;

	// Token: 0x04001435 RID: 5173
	public bool oroConvoSly;

	// Token: 0x04001436 RID: 5174
	public bool hunterRoared;

	// Token: 0x04001437 RID: 5175
	public bool metHunter;

	// Token: 0x04001438 RID: 5176
	public bool hunterRewardOffered;

	// Token: 0x04001439 RID: 5177
	public bool huntersMarkOffered;

	// Token: 0x0400143A RID: 5178
	public bool hasHuntersMark;

	// Token: 0x0400143B RID: 5179
	public bool metLegEater;

	// Token: 0x0400143C RID: 5180
	public bool paidLegEater;

	// Token: 0x0400143D RID: 5181
	public bool refusedLegEater;

	// Token: 0x0400143E RID: 5182
	public bool legEaterConvo1;

	// Token: 0x0400143F RID: 5183
	public bool legEaterConvo2;

	// Token: 0x04001440 RID: 5184
	public bool legEaterConvo3;

	// Token: 0x04001441 RID: 5185
	public bool legEaterBrokenConvo;

	// Token: 0x04001442 RID: 5186
	public bool legEaterDungConvo;

	// Token: 0x04001443 RID: 5187
	public bool legEaterInfectedCrossroadConvo;

	// Token: 0x04001444 RID: 5188
	public bool legEaterBoughtConvo;

	// Token: 0x04001445 RID: 5189
	public bool legEaterGoldConvo;

	// Token: 0x04001446 RID: 5190
	public bool legEaterLeft;

	// Token: 0x04001447 RID: 5191
	public bool tukMet;

	// Token: 0x04001448 RID: 5192
	public int tukEggPrice;

	// Token: 0x04001449 RID: 5193
	public bool tukDungEgg;

	// Token: 0x0400144A RID: 5194
	public bool metEmilitia;

	// Token: 0x0400144B RID: 5195
	public bool emilitiaKingsBrandConvo;

	// Token: 0x0400144C RID: 5196
	public bool metCloth;

	// Token: 0x0400144D RID: 5197
	public bool clothEnteredTramRoom;

	// Token: 0x0400144E RID: 5198
	public bool savedCloth;

	// Token: 0x0400144F RID: 5199
	public bool clothEncounteredQueensGarden;

	// Token: 0x04001450 RID: 5200
	public bool clothKilled;

	// Token: 0x04001451 RID: 5201
	public bool clothInTown;

	// Token: 0x04001452 RID: 5202
	public bool clothLeftTown;

	// Token: 0x04001453 RID: 5203
	public bool clothGhostSpoken;

	// Token: 0x04001454 RID: 5204
	public bool bigCatHitTail;

	// Token: 0x04001455 RID: 5205
	public bool bigCatHitTailConvo;

	// Token: 0x04001456 RID: 5206
	public bool bigCatMeet;

	// Token: 0x04001457 RID: 5207
	public bool bigCatTalk1;

	// Token: 0x04001458 RID: 5208
	public bool bigCatTalk2;

	// Token: 0x04001459 RID: 5209
	public bool bigCatTalk3;

	// Token: 0x0400145A RID: 5210
	public bool bigCatKingsBrandConvo;

	// Token: 0x0400145B RID: 5211
	public bool bigCatShadeConvo;

	// Token: 0x0400145C RID: 5212
	public bool tisoEncounteredTown;

	// Token: 0x0400145D RID: 5213
	public bool tisoEncounteredBench;

	// Token: 0x0400145E RID: 5214
	public bool tisoEncounteredLake;

	// Token: 0x0400145F RID: 5215
	public bool tisoEncounteredColosseum;

	// Token: 0x04001460 RID: 5216
	public bool tisoDead;

	// Token: 0x04001461 RID: 5217
	public bool tisoShieldConvo;

	// Token: 0x04001462 RID: 5218
	public int mossCultist;

	// Token: 0x04001463 RID: 5219
	public bool maskmakerMet;

	// Token: 0x04001464 RID: 5220
	public bool maskmakerConvo1;

	// Token: 0x04001465 RID: 5221
	public bool maskmakerConvo2;

	// Token: 0x04001466 RID: 5222
	public bool maskmakerUnmasked1;

	// Token: 0x04001467 RID: 5223
	public bool maskmakerUnmasked2;

	// Token: 0x04001468 RID: 5224
	public bool maskmakerShadowDash;

	// Token: 0x04001469 RID: 5225
	public bool maskmakerKingsBrand;

	// Token: 0x0400146A RID: 5226
	public bool dungDefenderConvo1;

	// Token: 0x0400146B RID: 5227
	public bool dungDefenderConvo2;

	// Token: 0x0400146C RID: 5228
	public bool dungDefenderConvo3;

	// Token: 0x0400146D RID: 5229
	public bool dungDefenderCharmConvo;

	// Token: 0x0400146E RID: 5230
	public bool dungDefenderIsmaConvo;

	// Token: 0x0400146F RID: 5231
	public bool dungDefenderAwoken;

	// Token: 0x04001470 RID: 5232
	public bool dungDefenderLeft;

	// Token: 0x04001471 RID: 5233
	public bool dungDefenderAwakeConvo;

	// Token: 0x04001472 RID: 5234
	public bool midwifeMet;

	// Token: 0x04001473 RID: 5235
	public bool midwifeConvo1;

	// Token: 0x04001474 RID: 5236
	public bool midwifeConvo2;

	// Token: 0x04001475 RID: 5237
	public bool metQueen;

	// Token: 0x04001476 RID: 5238
	public bool queenTalk1;

	// Token: 0x04001477 RID: 5239
	public bool queenTalk2;

	// Token: 0x04001478 RID: 5240
	public bool queenDung1;

	// Token: 0x04001479 RID: 5241
	public bool queenDung2;

	// Token: 0x0400147A RID: 5242
	public bool queenHornet;

	// Token: 0x0400147B RID: 5243
	public bool queenTalkExtra;

	// Token: 0x0400147C RID: 5244
	public bool gotQueenFragment;

	// Token: 0x0400147D RID: 5245
	public bool queenConvo_grimm1;

	// Token: 0x0400147E RID: 5246
	public bool queenConvo_grimm2;

	// Token: 0x0400147F RID: 5247
	public bool gotKingFragment;

	// Token: 0x04001480 RID: 5248
	public bool metXun;

	// Token: 0x04001481 RID: 5249
	public bool xunFailedConvo1;

	// Token: 0x04001482 RID: 5250
	public bool xunFailedConvo2;

	// Token: 0x04001483 RID: 5251
	public bool xunFlowerBroken;

	// Token: 0x04001484 RID: 5252
	public int xunFlowerBrokeTimes;

	// Token: 0x04001485 RID: 5253
	public bool xunFlowerGiven;

	// Token: 0x04001486 RID: 5254
	public bool xunRewardGiven;

	// Token: 0x04001487 RID: 5255
	public int menderState;

	// Token: 0x04001488 RID: 5256
	public bool menderSignBroken;

	// Token: 0x04001489 RID: 5257
	public bool allBelieverTabletsDestroyed;

	// Token: 0x0400148A RID: 5258
	public int mrMushroomState;

	// Token: 0x0400148B RID: 5259
	public bool openedMapperShop;

	// Token: 0x0400148C RID: 5260
	public bool openedSlyShop;

	// Token: 0x0400148D RID: 5261
	public bool metStag;

	// Token: 0x0400148E RID: 5262
	public bool travelling;

	// Token: 0x0400148F RID: 5263
	public int stagPosition;

	// Token: 0x04001490 RID: 5264
	public int stationsOpened;

	// Token: 0x04001491 RID: 5265
	public bool stagConvoTram;

	// Token: 0x04001492 RID: 5266
	public bool stagConvoTiso;

	// Token: 0x04001493 RID: 5267
	public bool stagRemember1;

	// Token: 0x04001494 RID: 5268
	public bool stagRemember2;

	// Token: 0x04001495 RID: 5269
	public bool stagRemember3;

	// Token: 0x04001496 RID: 5270
	public bool stagEggInspected;

	// Token: 0x04001497 RID: 5271
	public bool stagHopeConvo;

	// Token: 0x04001498 RID: 5272
	public string nextScene;

	// Token: 0x04001499 RID: 5273
	public bool littleFoolMet;

	// Token: 0x0400149A RID: 5274
	public bool ranAway;

	// Token: 0x0400149B RID: 5275
	public bool seenColosseumTitle;

	// Token: 0x0400149C RID: 5276
	public bool colosseumBronzeOpened;

	// Token: 0x0400149D RID: 5277
	public bool colosseumBronzeCompleted;

	// Token: 0x0400149E RID: 5278
	public bool colosseumSilverOpened;

	// Token: 0x0400149F RID: 5279
	public bool colosseumSilverCompleted;

	// Token: 0x040014A0 RID: 5280
	public bool colosseumGoldOpened;

	// Token: 0x040014A1 RID: 5281
	public bool colosseumGoldCompleted;

	// Token: 0x040014A2 RID: 5282
	public bool openedTown;

	// Token: 0x040014A3 RID: 5283
	public bool openedTownBuilding;

	// Token: 0x040014A4 RID: 5284
	public bool openedCrossroads;

	// Token: 0x040014A5 RID: 5285
	public bool openedGreenpath;

	// Token: 0x040014A6 RID: 5286
	public bool openedRuins1;

	// Token: 0x040014A7 RID: 5287
	public bool openedRuins2;

	// Token: 0x040014A8 RID: 5288
	public bool openedFungalWastes;

	// Token: 0x040014A9 RID: 5289
	public bool openedRoyalGardens;

	// Token: 0x040014AA RID: 5290
	public bool openedRestingGrounds;

	// Token: 0x040014AB RID: 5291
	public bool openedDeepnest;

	// Token: 0x040014AC RID: 5292
	public bool openedStagNest;

	// Token: 0x040014AD RID: 5293
	public bool openedHiddenStation;

	// Token: 0x040014AE RID: 5294
	public string dreamReturnScene;

	// Token: 0x040014AF RID: 5295
	public int charmSlots;

	// Token: 0x040014B0 RID: 5296
	public int charmSlotsFilled;

	// Token: 0x040014B1 RID: 5297
	public bool hasCharm;

	// Token: 0x040014B2 RID: 5298
	public List<int> equippedCharms;

	// Token: 0x040014B3 RID: 5299
	public bool charmBenchMsg;

	// Token: 0x040014B4 RID: 5300
	public int charmsOwned;

	// Token: 0x040014B5 RID: 5301
	public bool canOvercharm;

	// Token: 0x040014B6 RID: 5302
	public bool overcharmed;

	// Token: 0x040014B7 RID: 5303
	public bool gotCharm_1;

	// Token: 0x040014B8 RID: 5304
	public bool equippedCharm_1;

	// Token: 0x040014B9 RID: 5305
	public int charmCost_1;

	// Token: 0x040014BA RID: 5306
	public bool newCharm_1;

	// Token: 0x040014BB RID: 5307
	public bool gotCharm_2;

	// Token: 0x040014BC RID: 5308
	public bool equippedCharm_2;

	// Token: 0x040014BD RID: 5309
	public int charmCost_2;

	// Token: 0x040014BE RID: 5310
	public bool newCharm_2;

	// Token: 0x040014BF RID: 5311
	public bool gotCharm_3;

	// Token: 0x040014C0 RID: 5312
	public bool equippedCharm_3;

	// Token: 0x040014C1 RID: 5313
	public int charmCost_3;

	// Token: 0x040014C2 RID: 5314
	public bool newCharm_3;

	// Token: 0x040014C3 RID: 5315
	public bool gotCharm_4;

	// Token: 0x040014C4 RID: 5316
	public bool equippedCharm_4;

	// Token: 0x040014C5 RID: 5317
	public int charmCost_4;

	// Token: 0x040014C6 RID: 5318
	public bool newCharm_4;

	// Token: 0x040014C7 RID: 5319
	public bool gotCharm_5;

	// Token: 0x040014C8 RID: 5320
	public bool equippedCharm_5;

	// Token: 0x040014C9 RID: 5321
	public int charmCost_5;

	// Token: 0x040014CA RID: 5322
	public bool newCharm_5;

	// Token: 0x040014CB RID: 5323
	public bool gotCharm_6;

	// Token: 0x040014CC RID: 5324
	public bool equippedCharm_6;

	// Token: 0x040014CD RID: 5325
	public int charmCost_6;

	// Token: 0x040014CE RID: 5326
	public bool newCharm_6;

	// Token: 0x040014CF RID: 5327
	public bool gotCharm_7;

	// Token: 0x040014D0 RID: 5328
	public bool equippedCharm_7;

	// Token: 0x040014D1 RID: 5329
	public int charmCost_7;

	// Token: 0x040014D2 RID: 5330
	public bool newCharm_7;

	// Token: 0x040014D3 RID: 5331
	public bool gotCharm_8;

	// Token: 0x040014D4 RID: 5332
	public bool equippedCharm_8;

	// Token: 0x040014D5 RID: 5333
	public int charmCost_8;

	// Token: 0x040014D6 RID: 5334
	public bool newCharm_8;

	// Token: 0x040014D7 RID: 5335
	public bool gotCharm_9;

	// Token: 0x040014D8 RID: 5336
	public bool equippedCharm_9;

	// Token: 0x040014D9 RID: 5337
	public int charmCost_9;

	// Token: 0x040014DA RID: 5338
	public bool newCharm_9;

	// Token: 0x040014DB RID: 5339
	public bool gotCharm_10;

	// Token: 0x040014DC RID: 5340
	public bool equippedCharm_10;

	// Token: 0x040014DD RID: 5341
	public int charmCost_10;

	// Token: 0x040014DE RID: 5342
	public bool newCharm_10;

	// Token: 0x040014DF RID: 5343
	public bool gotCharm_11;

	// Token: 0x040014E0 RID: 5344
	public bool equippedCharm_11;

	// Token: 0x040014E1 RID: 5345
	public int charmCost_11;

	// Token: 0x040014E2 RID: 5346
	public bool newCharm_11;

	// Token: 0x040014E3 RID: 5347
	public bool gotCharm_12;

	// Token: 0x040014E4 RID: 5348
	public bool equippedCharm_12;

	// Token: 0x040014E5 RID: 5349
	public int charmCost_12;

	// Token: 0x040014E6 RID: 5350
	public bool newCharm_12;

	// Token: 0x040014E7 RID: 5351
	public bool gotCharm_13;

	// Token: 0x040014E8 RID: 5352
	public bool equippedCharm_13;

	// Token: 0x040014E9 RID: 5353
	public int charmCost_13;

	// Token: 0x040014EA RID: 5354
	public bool newCharm_13;

	// Token: 0x040014EB RID: 5355
	public bool gotCharm_14;

	// Token: 0x040014EC RID: 5356
	public bool equippedCharm_14;

	// Token: 0x040014ED RID: 5357
	public int charmCost_14;

	// Token: 0x040014EE RID: 5358
	public bool newCharm_14;

	// Token: 0x040014EF RID: 5359
	public bool gotCharm_15;

	// Token: 0x040014F0 RID: 5360
	public bool equippedCharm_15;

	// Token: 0x040014F1 RID: 5361
	public int charmCost_15;

	// Token: 0x040014F2 RID: 5362
	public bool newCharm_15;

	// Token: 0x040014F3 RID: 5363
	public bool gotCharm_16;

	// Token: 0x040014F4 RID: 5364
	public bool equippedCharm_16;

	// Token: 0x040014F5 RID: 5365
	public int charmCost_16;

	// Token: 0x040014F6 RID: 5366
	public bool newCharm_16;

	// Token: 0x040014F7 RID: 5367
	public bool gotCharm_17;

	// Token: 0x040014F8 RID: 5368
	public bool equippedCharm_17;

	// Token: 0x040014F9 RID: 5369
	public int charmCost_17;

	// Token: 0x040014FA RID: 5370
	public bool newCharm_17;

	// Token: 0x040014FB RID: 5371
	public bool gotCharm_18;

	// Token: 0x040014FC RID: 5372
	public bool equippedCharm_18;

	// Token: 0x040014FD RID: 5373
	public int charmCost_18;

	// Token: 0x040014FE RID: 5374
	public bool newCharm_18;

	// Token: 0x040014FF RID: 5375
	public bool gotCharm_19;

	// Token: 0x04001500 RID: 5376
	public bool equippedCharm_19;

	// Token: 0x04001501 RID: 5377
	public int charmCost_19;

	// Token: 0x04001502 RID: 5378
	public bool newCharm_19;

	// Token: 0x04001503 RID: 5379
	public bool gotCharm_20;

	// Token: 0x04001504 RID: 5380
	public bool equippedCharm_20;

	// Token: 0x04001505 RID: 5381
	public int charmCost_20;

	// Token: 0x04001506 RID: 5382
	public bool newCharm_20;

	// Token: 0x04001507 RID: 5383
	public bool gotCharm_21;

	// Token: 0x04001508 RID: 5384
	public bool equippedCharm_21;

	// Token: 0x04001509 RID: 5385
	public int charmCost_21;

	// Token: 0x0400150A RID: 5386
	public bool newCharm_21;

	// Token: 0x0400150B RID: 5387
	public bool gotCharm_22;

	// Token: 0x0400150C RID: 5388
	public bool equippedCharm_22;

	// Token: 0x0400150D RID: 5389
	public int charmCost_22;

	// Token: 0x0400150E RID: 5390
	public bool newCharm_22;

	// Token: 0x0400150F RID: 5391
	public bool gotCharm_23;

	// Token: 0x04001510 RID: 5392
	public bool equippedCharm_23;

	// Token: 0x04001511 RID: 5393
	public bool brokenCharm_23;

	// Token: 0x04001512 RID: 5394
	public int charmCost_23;

	// Token: 0x04001513 RID: 5395
	public bool newCharm_23;

	// Token: 0x04001514 RID: 5396
	public bool gotCharm_24;

	// Token: 0x04001515 RID: 5397
	public bool equippedCharm_24;

	// Token: 0x04001516 RID: 5398
	public bool brokenCharm_24;

	// Token: 0x04001517 RID: 5399
	public int charmCost_24;

	// Token: 0x04001518 RID: 5400
	public bool newCharm_24;

	// Token: 0x04001519 RID: 5401
	public bool gotCharm_25;

	// Token: 0x0400151A RID: 5402
	public bool equippedCharm_25;

	// Token: 0x0400151B RID: 5403
	public bool brokenCharm_25;

	// Token: 0x0400151C RID: 5404
	public int charmCost_25;

	// Token: 0x0400151D RID: 5405
	public bool newCharm_25;

	// Token: 0x0400151E RID: 5406
	public bool gotCharm_26;

	// Token: 0x0400151F RID: 5407
	public bool equippedCharm_26;

	// Token: 0x04001520 RID: 5408
	public int charmCost_26;

	// Token: 0x04001521 RID: 5409
	public bool newCharm_26;

	// Token: 0x04001522 RID: 5410
	public bool gotCharm_27;

	// Token: 0x04001523 RID: 5411
	public bool equippedCharm_27;

	// Token: 0x04001524 RID: 5412
	public int charmCost_27;

	// Token: 0x04001525 RID: 5413
	public bool newCharm_27;

	// Token: 0x04001526 RID: 5414
	public bool gotCharm_28;

	// Token: 0x04001527 RID: 5415
	public bool equippedCharm_28;

	// Token: 0x04001528 RID: 5416
	public int charmCost_28;

	// Token: 0x04001529 RID: 5417
	public bool newCharm_28;

	// Token: 0x0400152A RID: 5418
	public bool gotCharm_29;

	// Token: 0x0400152B RID: 5419
	public bool equippedCharm_29;

	// Token: 0x0400152C RID: 5420
	public int charmCost_29;

	// Token: 0x0400152D RID: 5421
	public bool newCharm_29;

	// Token: 0x0400152E RID: 5422
	public bool gotCharm_30;

	// Token: 0x0400152F RID: 5423
	public bool equippedCharm_30;

	// Token: 0x04001530 RID: 5424
	public int charmCost_30;

	// Token: 0x04001531 RID: 5425
	public bool newCharm_30;

	// Token: 0x04001532 RID: 5426
	public bool gotCharm_31;

	// Token: 0x04001533 RID: 5427
	public bool equippedCharm_31;

	// Token: 0x04001534 RID: 5428
	public int charmCost_31;

	// Token: 0x04001535 RID: 5429
	public bool newCharm_31;

	// Token: 0x04001536 RID: 5430
	public bool gotCharm_32;

	// Token: 0x04001537 RID: 5431
	public bool equippedCharm_32;

	// Token: 0x04001538 RID: 5432
	public int charmCost_32;

	// Token: 0x04001539 RID: 5433
	public bool newCharm_32;

	// Token: 0x0400153A RID: 5434
	public bool gotCharm_33;

	// Token: 0x0400153B RID: 5435
	public bool equippedCharm_33;

	// Token: 0x0400153C RID: 5436
	public int charmCost_33;

	// Token: 0x0400153D RID: 5437
	public bool newCharm_33;

	// Token: 0x0400153E RID: 5438
	public bool gotCharm_34;

	// Token: 0x0400153F RID: 5439
	public bool equippedCharm_34;

	// Token: 0x04001540 RID: 5440
	public int charmCost_34;

	// Token: 0x04001541 RID: 5441
	public bool newCharm_34;

	// Token: 0x04001542 RID: 5442
	public bool gotCharm_35;

	// Token: 0x04001543 RID: 5443
	public bool equippedCharm_35;

	// Token: 0x04001544 RID: 5444
	public int charmCost_35;

	// Token: 0x04001545 RID: 5445
	public bool newCharm_35;

	// Token: 0x04001546 RID: 5446
	public bool gotCharm_36;

	// Token: 0x04001547 RID: 5447
	public bool equippedCharm_36;

	// Token: 0x04001548 RID: 5448
	public int charmCost_36;

	// Token: 0x04001549 RID: 5449
	public bool newCharm_36;

	// Token: 0x0400154A RID: 5450
	public bool gotCharm_37;

	// Token: 0x0400154B RID: 5451
	public bool equippedCharm_37;

	// Token: 0x0400154C RID: 5452
	public int charmCost_37;

	// Token: 0x0400154D RID: 5453
	public bool newCharm_37;

	// Token: 0x0400154E RID: 5454
	public bool gotCharm_38;

	// Token: 0x0400154F RID: 5455
	public bool equippedCharm_38;

	// Token: 0x04001550 RID: 5456
	public int charmCost_38;

	// Token: 0x04001551 RID: 5457
	public bool newCharm_38;

	// Token: 0x04001552 RID: 5458
	public bool gotCharm_39;

	// Token: 0x04001553 RID: 5459
	public bool equippedCharm_39;

	// Token: 0x04001554 RID: 5460
	public int charmCost_39;

	// Token: 0x04001555 RID: 5461
	public bool newCharm_39;

	// Token: 0x04001556 RID: 5462
	public bool gotCharm_40;

	// Token: 0x04001557 RID: 5463
	public bool equippedCharm_40;

	// Token: 0x04001558 RID: 5464
	public int charmCost_40;

	// Token: 0x04001559 RID: 5465
	public bool newCharm_40;

	// Token: 0x0400155A RID: 5466
	public bool fragileHealth_unbreakable;

	// Token: 0x0400155B RID: 5467
	public bool fragileGreed_unbreakable;

	// Token: 0x0400155C RID: 5468
	public bool fragileStrength_unbreakable;

	// Token: 0x0400155D RID: 5469
	public int royalCharmState;

	// Token: 0x0400155E RID: 5470
	public bool hasJournal;

	// Token: 0x0400155F RID: 5471
	public int lastJournalItem;

	// Token: 0x04001560 RID: 5472
	public bool killedDummy;

	// Token: 0x04001561 RID: 5473
	public int killsDummy;

	// Token: 0x04001562 RID: 5474
	public bool newDataDummy;

	// Token: 0x04001563 RID: 5475
	public bool seenJournalMsg;

	// Token: 0x04001564 RID: 5476
	public bool seenHunterMsg;

	// Token: 0x04001565 RID: 5477
	public bool fillJournal;

	// Token: 0x04001566 RID: 5478
	public int journalEntriesCompleted;

	// Token: 0x04001567 RID: 5479
	public int journalNotesCompleted;

	// Token: 0x04001568 RID: 5480
	public int journalEntriesTotal;

	// Token: 0x04001569 RID: 5481
	public bool killedCrawler;

	// Token: 0x0400156A RID: 5482
	public int killsCrawler;

	// Token: 0x0400156B RID: 5483
	public bool newDataCrawler;

	// Token: 0x0400156C RID: 5484
	public bool killedBuzzer;

	// Token: 0x0400156D RID: 5485
	public int killsBuzzer;

	// Token: 0x0400156E RID: 5486
	public bool newDataBuzzer;

	// Token: 0x0400156F RID: 5487
	public bool killedBouncer;

	// Token: 0x04001570 RID: 5488
	public int killsBouncer;

	// Token: 0x04001571 RID: 5489
	public bool newDataBouncer;

	// Token: 0x04001572 RID: 5490
	public bool killedClimber;

	// Token: 0x04001573 RID: 5491
	public int killsClimber;

	// Token: 0x04001574 RID: 5492
	public bool newDataClimber;

	// Token: 0x04001575 RID: 5493
	public bool killedHopper;

	// Token: 0x04001576 RID: 5494
	public int killsHopper;

	// Token: 0x04001577 RID: 5495
	public bool newDataHopper;

	// Token: 0x04001578 RID: 5496
	public bool killedWorm;

	// Token: 0x04001579 RID: 5497
	public int killsWorm;

	// Token: 0x0400157A RID: 5498
	public bool newDataWorm;

	// Token: 0x0400157B RID: 5499
	public bool killedSpitter;

	// Token: 0x0400157C RID: 5500
	public int killsSpitter;

	// Token: 0x0400157D RID: 5501
	public bool newDataSpitter;

	// Token: 0x0400157E RID: 5502
	public bool killedHatcher;

	// Token: 0x0400157F RID: 5503
	public int killsHatcher;

	// Token: 0x04001580 RID: 5504
	public bool newDataHatcher;

	// Token: 0x04001581 RID: 5505
	public bool killedHatchling;

	// Token: 0x04001582 RID: 5506
	public int killsHatchling;

	// Token: 0x04001583 RID: 5507
	public bool newDataHatchling;

	// Token: 0x04001584 RID: 5508
	public bool killedZombieRunner;

	// Token: 0x04001585 RID: 5509
	public int killsZombieRunner;

	// Token: 0x04001586 RID: 5510
	public bool newDataZombieRunner;

	// Token: 0x04001587 RID: 5511
	public bool killedZombieHornhead;

	// Token: 0x04001588 RID: 5512
	public int killsZombieHornhead;

	// Token: 0x04001589 RID: 5513
	public bool newDataZombieHornhead;

	// Token: 0x0400158A RID: 5514
	public bool killedZombieLeaper;

	// Token: 0x0400158B RID: 5515
	public int killsZombieLeaper;

	// Token: 0x0400158C RID: 5516
	public bool newDataZombieLeaper;

	// Token: 0x0400158D RID: 5517
	public bool killedZombieBarger;

	// Token: 0x0400158E RID: 5518
	public int killsZombieBarger;

	// Token: 0x0400158F RID: 5519
	public bool newDataZombieBarger;

	// Token: 0x04001590 RID: 5520
	public bool killedZombieShield;

	// Token: 0x04001591 RID: 5521
	public int killsZombieShield;

	// Token: 0x04001592 RID: 5522
	public bool newDataZombieShield;

	// Token: 0x04001593 RID: 5523
	public bool killedZombieGuard;

	// Token: 0x04001594 RID: 5524
	public int killsZombieGuard;

	// Token: 0x04001595 RID: 5525
	public bool newDataZombieGuard;

	// Token: 0x04001596 RID: 5526
	public bool killedBigBuzzer;

	// Token: 0x04001597 RID: 5527
	public int killsBigBuzzer;

	// Token: 0x04001598 RID: 5528
	public bool newDataBigBuzzer;

	// Token: 0x04001599 RID: 5529
	public bool killedBigFly;

	// Token: 0x0400159A RID: 5530
	public int killsBigFly;

	// Token: 0x0400159B RID: 5531
	public bool newDataBigFly;

	// Token: 0x0400159C RID: 5532
	public bool killedMawlek;

	// Token: 0x0400159D RID: 5533
	public int killsMawlek;

	// Token: 0x0400159E RID: 5534
	public bool newDataMawlek;

	// Token: 0x0400159F RID: 5535
	public bool killedFalseKnight;

	// Token: 0x040015A0 RID: 5536
	public int killsFalseKnight;

	// Token: 0x040015A1 RID: 5537
	public bool newDataFalseKnight;

	// Token: 0x040015A2 RID: 5538
	public bool killedRoller;

	// Token: 0x040015A3 RID: 5539
	public int killsRoller;

	// Token: 0x040015A4 RID: 5540
	public bool newDataRoller;

	// Token: 0x040015A5 RID: 5541
	public bool killedBlocker;

	// Token: 0x040015A6 RID: 5542
	public int killsBlocker;

	// Token: 0x040015A7 RID: 5543
	public bool newDataBlocker;

	// Token: 0x040015A8 RID: 5544
	public bool killedPrayerSlug;

	// Token: 0x040015A9 RID: 5545
	public int killsPrayerSlug;

	// Token: 0x040015AA RID: 5546
	public bool newDataPrayerSlug;

	// Token: 0x040015AB RID: 5547
	public bool killedMenderBug;

	// Token: 0x040015AC RID: 5548
	public int killsMenderBug;

	// Token: 0x040015AD RID: 5549
	public bool newDataMenderBug;

	// Token: 0x040015AE RID: 5550
	public bool killedMossmanRunner;

	// Token: 0x040015AF RID: 5551
	public int killsMossmanRunner;

	// Token: 0x040015B0 RID: 5552
	public bool newDataMossmanRunner;

	// Token: 0x040015B1 RID: 5553
	public bool killedMossmanShaker;

	// Token: 0x040015B2 RID: 5554
	public int killsMossmanShaker;

	// Token: 0x040015B3 RID: 5555
	public bool newDataMossmanShaker;

	// Token: 0x040015B4 RID: 5556
	public bool killedMosquito;

	// Token: 0x040015B5 RID: 5557
	public int killsMosquito;

	// Token: 0x040015B6 RID: 5558
	public bool newDataMosquito;

	// Token: 0x040015B7 RID: 5559
	public bool killedBlobFlyer;

	// Token: 0x040015B8 RID: 5560
	public int killsBlobFlyer;

	// Token: 0x040015B9 RID: 5561
	public bool newDataBlobFlyer;

	// Token: 0x040015BA RID: 5562
	public bool killedFungifiedZombie;

	// Token: 0x040015BB RID: 5563
	public int killsFungifiedZombie;

	// Token: 0x040015BC RID: 5564
	public bool newDataFungifiedZombie;

	// Token: 0x040015BD RID: 5565
	public bool killedPlantShooter;

	// Token: 0x040015BE RID: 5566
	public int killsPlantShooter;

	// Token: 0x040015BF RID: 5567
	public bool newDataPlantShooter;

	// Token: 0x040015C0 RID: 5568
	public bool killedMossCharger;

	// Token: 0x040015C1 RID: 5569
	public int killsMossCharger;

	// Token: 0x040015C2 RID: 5570
	public bool newDataMossCharger;

	// Token: 0x040015C3 RID: 5571
	public bool killedMegaMossCharger;

	// Token: 0x040015C4 RID: 5572
	public int killsMegaMossCharger;

	// Token: 0x040015C5 RID: 5573
	public bool newDataMegaMossCharger;

	// Token: 0x040015C6 RID: 5574
	public bool killedSnapperTrap;

	// Token: 0x040015C7 RID: 5575
	public int killsSnapperTrap;

	// Token: 0x040015C8 RID: 5576
	public bool newDataSnapperTrap;

	// Token: 0x040015C9 RID: 5577
	public bool killedMossKnight;

	// Token: 0x040015CA RID: 5578
	public int killsMossKnight;

	// Token: 0x040015CB RID: 5579
	public bool newDataMossKnight;

	// Token: 0x040015CC RID: 5580
	public bool killedGrassHopper;

	// Token: 0x040015CD RID: 5581
	public int killsGrassHopper;

	// Token: 0x040015CE RID: 5582
	public bool newDataGrassHopper;

	// Token: 0x040015CF RID: 5583
	public bool killedAcidFlyer;

	// Token: 0x040015D0 RID: 5584
	public int killsAcidFlyer;

	// Token: 0x040015D1 RID: 5585
	public bool newDataAcidFlyer;

	// Token: 0x040015D2 RID: 5586
	public bool killedAcidWalker;

	// Token: 0x040015D3 RID: 5587
	public int killsAcidWalker;

	// Token: 0x040015D4 RID: 5588
	public bool newDataAcidWalker;

	// Token: 0x040015D5 RID: 5589
	public bool killedMossFlyer;

	// Token: 0x040015D6 RID: 5590
	public int killsMossFlyer;

	// Token: 0x040015D7 RID: 5591
	public bool newDataMossFlyer;

	// Token: 0x040015D8 RID: 5592
	public bool killedMossKnightFat;

	// Token: 0x040015D9 RID: 5593
	public int killsMossKnightFat;

	// Token: 0x040015DA RID: 5594
	public bool newDataMossKnightFat;

	// Token: 0x040015DB RID: 5595
	public bool killedMossWalker;

	// Token: 0x040015DC RID: 5596
	public int killsMossWalker;

	// Token: 0x040015DD RID: 5597
	public bool newDataMossWalker;

	// Token: 0x040015DE RID: 5598
	public bool killedInfectedKnight;

	// Token: 0x040015DF RID: 5599
	public int killsInfectedKnight;

	// Token: 0x040015E0 RID: 5600
	public bool newDataInfectedKnight;

	// Token: 0x040015E1 RID: 5601
	public bool killedLazyFlyer;

	// Token: 0x040015E2 RID: 5602
	public int killsLazyFlyer;

	// Token: 0x040015E3 RID: 5603
	public bool newDataLazyFlyer;

	// Token: 0x040015E4 RID: 5604
	public bool killedZapBug;

	// Token: 0x040015E5 RID: 5605
	public int killsZapBug;

	// Token: 0x040015E6 RID: 5606
	public bool newDataZapBug;

	// Token: 0x040015E7 RID: 5607
	public bool killedJellyfish;

	// Token: 0x040015E8 RID: 5608
	public int killsJellyfish;

	// Token: 0x040015E9 RID: 5609
	public bool newDataJellyfish;

	// Token: 0x040015EA RID: 5610
	public bool killedJellyCrawler;

	// Token: 0x040015EB RID: 5611
	public int killsJellyCrawler;

	// Token: 0x040015EC RID: 5612
	public bool newDataJellyCrawler;

	// Token: 0x040015ED RID: 5613
	public bool killedMegaJellyfish;

	// Token: 0x040015EE RID: 5614
	public int killsMegaJellyfish;

	// Token: 0x040015EF RID: 5615
	public bool newDataMegaJellyfish;

	// Token: 0x040015F0 RID: 5616
	public bool killedFungoonBaby;

	// Token: 0x040015F1 RID: 5617
	public int killsFungoonBaby;

	// Token: 0x040015F2 RID: 5618
	public bool newDataFungoonBaby;

	// Token: 0x040015F3 RID: 5619
	public bool killedMushroomTurret;

	// Token: 0x040015F4 RID: 5620
	public int killsMushroomTurret;

	// Token: 0x040015F5 RID: 5621
	public bool newDataMushroomTurret;

	// Token: 0x040015F6 RID: 5622
	public bool killedMantis;

	// Token: 0x040015F7 RID: 5623
	public int killsMantis;

	// Token: 0x040015F8 RID: 5624
	public bool newDataMantis;

	// Token: 0x040015F9 RID: 5625
	public bool killedMushroomRoller;

	// Token: 0x040015FA RID: 5626
	public int killsMushroomRoller;

	// Token: 0x040015FB RID: 5627
	public bool newDataMushroomRoller;

	// Token: 0x040015FC RID: 5628
	public bool killedMushroomBrawler;

	// Token: 0x040015FD RID: 5629
	public int killsMushroomBrawler;

	// Token: 0x040015FE RID: 5630
	public bool newDataMushroomBrawler;

	// Token: 0x040015FF RID: 5631
	public bool killedMushroomBaby;

	// Token: 0x04001600 RID: 5632
	public int killsMushroomBaby;

	// Token: 0x04001601 RID: 5633
	public bool newDataMushroomBaby;

	// Token: 0x04001602 RID: 5634
	public bool killedMantisFlyerChild;

	// Token: 0x04001603 RID: 5635
	public int killsMantisFlyerChild;

	// Token: 0x04001604 RID: 5636
	public bool newDataMantisFlyerChild;

	// Token: 0x04001605 RID: 5637
	public bool killedFungusFlyer;

	// Token: 0x04001606 RID: 5638
	public int killsFungusFlyer;

	// Token: 0x04001607 RID: 5639
	public bool newDataFungusFlyer;

	// Token: 0x04001608 RID: 5640
	public bool killedFungCrawler;

	// Token: 0x04001609 RID: 5641
	public int killsFungCrawler;

	// Token: 0x0400160A RID: 5642
	public bool newDataFungCrawler;

	// Token: 0x0400160B RID: 5643
	public bool killedMantisLord;

	// Token: 0x0400160C RID: 5644
	public int killsMantisLord;

	// Token: 0x0400160D RID: 5645
	public bool newDataMantisLord;

	// Token: 0x0400160E RID: 5646
	public bool killedBlackKnight;

	// Token: 0x0400160F RID: 5647
	public int killsBlackKnight;

	// Token: 0x04001610 RID: 5648
	public bool newDataBlackKnight;

	// Token: 0x04001611 RID: 5649
	public bool killedElectricMage;

	// Token: 0x04001612 RID: 5650
	public int killsElectricMage;

	// Token: 0x04001613 RID: 5651
	public bool newDataElectricMage;

	// Token: 0x04001614 RID: 5652
	public bool killedMage;

	// Token: 0x04001615 RID: 5653
	public int killsMage;

	// Token: 0x04001616 RID: 5654
	public bool newDataMage;

	// Token: 0x04001617 RID: 5655
	public bool killedMageKnight;

	// Token: 0x04001618 RID: 5656
	public int killsMageKnight;

	// Token: 0x04001619 RID: 5657
	public bool newDataMageKnight;

	// Token: 0x0400161A RID: 5658
	public bool killedRoyalDandy;

	// Token: 0x0400161B RID: 5659
	public int killsRoyalDandy;

	// Token: 0x0400161C RID: 5660
	public bool newDataRoyalDandy;

	// Token: 0x0400161D RID: 5661
	public bool killedRoyalCoward;

	// Token: 0x0400161E RID: 5662
	public int killsRoyalCoward;

	// Token: 0x0400161F RID: 5663
	public bool newDataRoyalCoward;

	// Token: 0x04001620 RID: 5664
	public bool killedRoyalPlumper;

	// Token: 0x04001621 RID: 5665
	public int killsRoyalPlumper;

	// Token: 0x04001622 RID: 5666
	public bool newDataRoyalPlumper;

	// Token: 0x04001623 RID: 5667
	public bool killedFlyingSentrySword;

	// Token: 0x04001624 RID: 5668
	public int killsFlyingSentrySword;

	// Token: 0x04001625 RID: 5669
	public bool newDataFlyingSentrySword;

	// Token: 0x04001626 RID: 5670
	public bool killedFlyingSentryJavelin;

	// Token: 0x04001627 RID: 5671
	public int killsFlyingSentryJavelin;

	// Token: 0x04001628 RID: 5672
	public bool newDataFlyingSentryJavelin;

	// Token: 0x04001629 RID: 5673
	public bool killedSentry;

	// Token: 0x0400162A RID: 5674
	public int killsSentry;

	// Token: 0x0400162B RID: 5675
	public bool newDataSentry;

	// Token: 0x0400162C RID: 5676
	public bool killedSentryFat;

	// Token: 0x0400162D RID: 5677
	public int killsSentryFat;

	// Token: 0x0400162E RID: 5678
	public bool newDataSentryFat;

	// Token: 0x0400162F RID: 5679
	public bool killedMageBlob;

	// Token: 0x04001630 RID: 5680
	public int killsMageBlob;

	// Token: 0x04001631 RID: 5681
	public bool newDataMageBlob;

	// Token: 0x04001632 RID: 5682
	public bool killedGreatShieldZombie;

	// Token: 0x04001633 RID: 5683
	public int killsGreatShieldZombie;

	// Token: 0x04001634 RID: 5684
	public bool newDataGreatShieldZombie;

	// Token: 0x04001635 RID: 5685
	public bool killedJarCollector;

	// Token: 0x04001636 RID: 5686
	public int killsJarCollector;

	// Token: 0x04001637 RID: 5687
	public bool newDataJarCollector;

	// Token: 0x04001638 RID: 5688
	public bool killedMageBalloon;

	// Token: 0x04001639 RID: 5689
	public int killsMageBalloon;

	// Token: 0x0400163A RID: 5690
	public bool newDataMageBalloon;

	// Token: 0x0400163B RID: 5691
	public bool killedMageLord;

	// Token: 0x0400163C RID: 5692
	public int killsMageLord;

	// Token: 0x0400163D RID: 5693
	public bool newDataMageLord;

	// Token: 0x0400163E RID: 5694
	public bool killedGorgeousHusk;

	// Token: 0x0400163F RID: 5695
	public int killsGorgeousHusk;

	// Token: 0x04001640 RID: 5696
	public bool newDataGorgeousHusk;

	// Token: 0x04001641 RID: 5697
	public bool killedFlipHopper;

	// Token: 0x04001642 RID: 5698
	public int killsFlipHopper;

	// Token: 0x04001643 RID: 5699
	public bool newDataFlipHopper;

	// Token: 0x04001644 RID: 5700
	public bool killedFlukeman;

	// Token: 0x04001645 RID: 5701
	public int killsFlukeman;

	// Token: 0x04001646 RID: 5702
	public bool newDataFlukeman;

	// Token: 0x04001647 RID: 5703
	public bool killedInflater;

	// Token: 0x04001648 RID: 5704
	public int killsInflater;

	// Token: 0x04001649 RID: 5705
	public bool newDataInflater;

	// Token: 0x0400164A RID: 5706
	public bool killedFlukefly;

	// Token: 0x0400164B RID: 5707
	public int killsFlukefly;

	// Token: 0x0400164C RID: 5708
	public bool newDataFlukefly;

	// Token: 0x0400164D RID: 5709
	public bool killedFlukeMother;

	// Token: 0x0400164E RID: 5710
	public int killsFlukeMother;

	// Token: 0x0400164F RID: 5711
	public bool newDataFlukeMother;

	// Token: 0x04001650 RID: 5712
	public bool killedDungDefender;

	// Token: 0x04001651 RID: 5713
	public int killsDungDefender;

	// Token: 0x04001652 RID: 5714
	public bool newDataDungDefender;

	// Token: 0x04001653 RID: 5715
	public bool killedCrystalCrawler;

	// Token: 0x04001654 RID: 5716
	public int killsCrystalCrawler;

	// Token: 0x04001655 RID: 5717
	public bool newDataCrystalCrawler;

	// Token: 0x04001656 RID: 5718
	public bool killedCrystalFlyer;

	// Token: 0x04001657 RID: 5719
	public int killsCrystalFlyer;

	// Token: 0x04001658 RID: 5720
	public bool newDataCrystalFlyer;

	// Token: 0x04001659 RID: 5721
	public bool killedLaserBug;

	// Token: 0x0400165A RID: 5722
	public int killsLaserBug;

	// Token: 0x0400165B RID: 5723
	public bool newDataLaserBug;

	// Token: 0x0400165C RID: 5724
	public bool killedBeamMiner;

	// Token: 0x0400165D RID: 5725
	public int killsBeamMiner;

	// Token: 0x0400165E RID: 5726
	public bool newDataBeamMiner;

	// Token: 0x0400165F RID: 5727
	public bool killedZombieMiner;

	// Token: 0x04001660 RID: 5728
	public int killsZombieMiner;

	// Token: 0x04001661 RID: 5729
	public bool newDataZombieMiner;

	// Token: 0x04001662 RID: 5730
	public bool killedMegaBeamMiner;

	// Token: 0x04001663 RID: 5731
	public int killsMegaBeamMiner;

	// Token: 0x04001664 RID: 5732
	public bool newDataMegaBeamMiner;

	// Token: 0x04001665 RID: 5733
	public bool killedMinesCrawler;

	// Token: 0x04001666 RID: 5734
	public int killsMinesCrawler;

	// Token: 0x04001667 RID: 5735
	public bool newDataMinesCrawler;

	// Token: 0x04001668 RID: 5736
	public bool killedAngryBuzzer;

	// Token: 0x04001669 RID: 5737
	public int killsAngryBuzzer;

	// Token: 0x0400166A RID: 5738
	public bool newDataAngryBuzzer;

	// Token: 0x0400166B RID: 5739
	public bool killedBurstingBouncer;

	// Token: 0x0400166C RID: 5740
	public int killsBurstingBouncer;

	// Token: 0x0400166D RID: 5741
	public bool newDataBurstingBouncer;

	// Token: 0x0400166E RID: 5742
	public bool killedBurstingZombie;

	// Token: 0x0400166F RID: 5743
	public int killsBurstingZombie;

	// Token: 0x04001670 RID: 5744
	public bool newDataBurstingZombie;

	// Token: 0x04001671 RID: 5745
	public bool killedSpittingZombie;

	// Token: 0x04001672 RID: 5746
	public int killsSpittingZombie;

	// Token: 0x04001673 RID: 5747
	public bool newDataSpittingZombie;

	// Token: 0x04001674 RID: 5748
	public bool killedBabyCentipede;

	// Token: 0x04001675 RID: 5749
	public int killsBabyCentipede;

	// Token: 0x04001676 RID: 5750
	public bool newDataBabyCentipede;

	// Token: 0x04001677 RID: 5751
	public bool killedBigCentipede;

	// Token: 0x04001678 RID: 5752
	public int killsBigCentipede;

	// Token: 0x04001679 RID: 5753
	public bool newDataBigCentipede;

	// Token: 0x0400167A RID: 5754
	public bool killedCentipedeHatcher;

	// Token: 0x0400167B RID: 5755
	public int killsCentipedeHatcher;

	// Token: 0x0400167C RID: 5756
	public bool newDataCentipedeHatcher;

	// Token: 0x0400167D RID: 5757
	public bool killedLesserMawlek;

	// Token: 0x0400167E RID: 5758
	public int killsLesserMawlek;

	// Token: 0x0400167F RID: 5759
	public bool newDataLesserMawlek;

	// Token: 0x04001680 RID: 5760
	public bool killedSlashSpider;

	// Token: 0x04001681 RID: 5761
	public int killsSlashSpider;

	// Token: 0x04001682 RID: 5762
	public bool newDataSlashSpider;

	// Token: 0x04001683 RID: 5763
	public bool killedSpiderCorpse;

	// Token: 0x04001684 RID: 5764
	public int killsSpiderCorpse;

	// Token: 0x04001685 RID: 5765
	public bool newDataSpiderCorpse;

	// Token: 0x04001686 RID: 5766
	public bool killedShootSpider;

	// Token: 0x04001687 RID: 5767
	public int killsShootSpider;

	// Token: 0x04001688 RID: 5768
	public bool newDataShootSpider;

	// Token: 0x04001689 RID: 5769
	public bool killedMiniSpider;

	// Token: 0x0400168A RID: 5770
	public int killsMiniSpider;

	// Token: 0x0400168B RID: 5771
	public bool newDataMiniSpider;

	// Token: 0x0400168C RID: 5772
	public bool killedSpiderFlyer;

	// Token: 0x0400168D RID: 5773
	public int killsSpiderFlyer;

	// Token: 0x0400168E RID: 5774
	public bool newDataSpiderFlyer;

	// Token: 0x0400168F RID: 5775
	public bool killedMimicSpider;

	// Token: 0x04001690 RID: 5776
	public int killsMimicSpider;

	// Token: 0x04001691 RID: 5777
	public bool newDataMimicSpider;

	// Token: 0x04001692 RID: 5778
	public bool killedBeeHatchling;

	// Token: 0x04001693 RID: 5779
	public int killsBeeHatchling;

	// Token: 0x04001694 RID: 5780
	public bool newDataBeeHatchling;

	// Token: 0x04001695 RID: 5781
	public bool killedBeeStinger;

	// Token: 0x04001696 RID: 5782
	public int killsBeeStinger;

	// Token: 0x04001697 RID: 5783
	public bool newDataBeeStinger;

	// Token: 0x04001698 RID: 5784
	public bool killedBigBee;

	// Token: 0x04001699 RID: 5785
	public int killsBigBee;

	// Token: 0x0400169A RID: 5786
	public bool newDataBigBee;

	// Token: 0x0400169B RID: 5787
	public bool killedHiveKnight;

	// Token: 0x0400169C RID: 5788
	public int killsHiveKnight;

	// Token: 0x0400169D RID: 5789
	public bool newDataHiveKnight;

	// Token: 0x0400169E RID: 5790
	public bool killedBlowFly;

	// Token: 0x0400169F RID: 5791
	public int killsBlowFly;

	// Token: 0x040016A0 RID: 5792
	public bool newDataBlowFly;

	// Token: 0x040016A1 RID: 5793
	public bool killedCeilingDropper;

	// Token: 0x040016A2 RID: 5794
	public int killsCeilingDropper;

	// Token: 0x040016A3 RID: 5795
	public bool newDataCeilingDropper;

	// Token: 0x040016A4 RID: 5796
	public bool killedGiantHopper;

	// Token: 0x040016A5 RID: 5797
	public int killsGiantHopper;

	// Token: 0x040016A6 RID: 5798
	public bool newDataGiantHopper;

	// Token: 0x040016A7 RID: 5799
	public bool killedGrubMimic;

	// Token: 0x040016A8 RID: 5800
	public int killsGrubMimic;

	// Token: 0x040016A9 RID: 5801
	public bool newDataGrubMimic;

	// Token: 0x040016AA RID: 5802
	public bool killedMawlekTurret;

	// Token: 0x040016AB RID: 5803
	public int killsMawlekTurret;

	// Token: 0x040016AC RID: 5804
	public bool newDataMawlekTurret;

	// Token: 0x040016AD RID: 5805
	public bool killedOrangeScuttler;

	// Token: 0x040016AE RID: 5806
	public int killsOrangeScuttler;

	// Token: 0x040016AF RID: 5807
	public bool newDataOrangeScuttler;

	// Token: 0x040016B0 RID: 5808
	public bool killedHealthScuttler;

	// Token: 0x040016B1 RID: 5809
	public int killsHealthScuttler;

	// Token: 0x040016B2 RID: 5810
	public bool newDataHealthScuttler;

	// Token: 0x040016B3 RID: 5811
	public bool killedPigeon;

	// Token: 0x040016B4 RID: 5812
	public int killsPigeon;

	// Token: 0x040016B5 RID: 5813
	public bool newDataPigeon;

	// Token: 0x040016B6 RID: 5814
	public bool killedZombieHive;

	// Token: 0x040016B7 RID: 5815
	public int killsZombieHive;

	// Token: 0x040016B8 RID: 5816
	public bool newDataZombieHive;

	// Token: 0x040016B9 RID: 5817
	public bool killedDreamGuard;

	// Token: 0x040016BA RID: 5818
	public int killsDreamGuard;

	// Token: 0x040016BB RID: 5819
	public bool newDataDreamGuard;

	// Token: 0x040016BC RID: 5820
	public bool killedHornet;

	// Token: 0x040016BD RID: 5821
	public int killsHornet;

	// Token: 0x040016BE RID: 5822
	public bool newDataHornet;

	// Token: 0x040016BF RID: 5823
	public bool killedAbyssCrawler;

	// Token: 0x040016C0 RID: 5824
	public int killsAbyssCrawler;

	// Token: 0x040016C1 RID: 5825
	public bool newDataAbyssCrawler;

	// Token: 0x040016C2 RID: 5826
	public bool killedSuperSpitter;

	// Token: 0x040016C3 RID: 5827
	public int killsSuperSpitter;

	// Token: 0x040016C4 RID: 5828
	public bool newDataSuperSpitter;

	// Token: 0x040016C5 RID: 5829
	public bool killedSibling;

	// Token: 0x040016C6 RID: 5830
	public int killsSibling;

	// Token: 0x040016C7 RID: 5831
	public bool newDataSibling;

	// Token: 0x040016C8 RID: 5832
	public bool killedPalaceFly;

	// Token: 0x040016C9 RID: 5833
	public int killsPalaceFly;

	// Token: 0x040016CA RID: 5834
	public bool newDataPalaceFly;

	// Token: 0x040016CB RID: 5835
	public bool killedEggSac;

	// Token: 0x040016CC RID: 5836
	public int killsEggSac;

	// Token: 0x040016CD RID: 5837
	public bool newDataEggSac;

	// Token: 0x040016CE RID: 5838
	public bool killedMummy;

	// Token: 0x040016CF RID: 5839
	public int killsMummy;

	// Token: 0x040016D0 RID: 5840
	public bool newDataMummy;

	// Token: 0x040016D1 RID: 5841
	public bool killedOrangeBalloon;

	// Token: 0x040016D2 RID: 5842
	public int killsOrangeBalloon;

	// Token: 0x040016D3 RID: 5843
	public bool newDataOrangeBalloon;

	// Token: 0x040016D4 RID: 5844
	public bool killedAbyssTendril;

	// Token: 0x040016D5 RID: 5845
	public int killsAbyssTendril;

	// Token: 0x040016D6 RID: 5846
	public bool newDataAbyssTendril;

	// Token: 0x040016D7 RID: 5847
	public bool killedHeavyMantis;

	// Token: 0x040016D8 RID: 5848
	public int killsHeavyMantis;

	// Token: 0x040016D9 RID: 5849
	public bool newDataHeavyMantis;

	// Token: 0x040016DA RID: 5850
	public bool killedTraitorLord;

	// Token: 0x040016DB RID: 5851
	public int killsTraitorLord;

	// Token: 0x040016DC RID: 5852
	public bool newDataTraitorLord;

	// Token: 0x040016DD RID: 5853
	public bool killedMantisHeavyFlyer;

	// Token: 0x040016DE RID: 5854
	public int killsMantisHeavyFlyer;

	// Token: 0x040016DF RID: 5855
	public bool newDataMantisHeavyFlyer;

	// Token: 0x040016E0 RID: 5856
	public bool killedGardenZombie;

	// Token: 0x040016E1 RID: 5857
	public int killsGardenZombie;

	// Token: 0x040016E2 RID: 5858
	public bool newDataGardenZombie;

	// Token: 0x040016E3 RID: 5859
	public bool killedRoyalGuard;

	// Token: 0x040016E4 RID: 5860
	public int killsRoyalGuard;

	// Token: 0x040016E5 RID: 5861
	public bool newDataRoyalGuard;

	// Token: 0x040016E6 RID: 5862
	public bool killedWhiteRoyal;

	// Token: 0x040016E7 RID: 5863
	public int killsWhiteRoyal;

	// Token: 0x040016E8 RID: 5864
	public bool newDataWhiteRoyal;

	// Token: 0x040016E9 RID: 5865
	public bool openedPalaceGrounds;

	// Token: 0x040016EA RID: 5866
	public bool killedOblobble;

	// Token: 0x040016EB RID: 5867
	public int killsOblobble;

	// Token: 0x040016EC RID: 5868
	public bool newDataOblobble;

	// Token: 0x040016ED RID: 5869
	public bool killedZote;

	// Token: 0x040016EE RID: 5870
	public int killsZote;

	// Token: 0x040016EF RID: 5871
	public bool newDataZote;

	// Token: 0x040016F0 RID: 5872
	public bool killedBlobble;

	// Token: 0x040016F1 RID: 5873
	public int killsBlobble;

	// Token: 0x040016F2 RID: 5874
	public bool newDataBlobble;

	// Token: 0x040016F3 RID: 5875
	public bool killedColMosquito;

	// Token: 0x040016F4 RID: 5876
	public int killsColMosquito;

	// Token: 0x040016F5 RID: 5877
	public bool newDataColMosquito;

	// Token: 0x040016F6 RID: 5878
	public bool killedColRoller;

	// Token: 0x040016F7 RID: 5879
	public int killsColRoller;

	// Token: 0x040016F8 RID: 5880
	public bool newDataColRoller;

	// Token: 0x040016F9 RID: 5881
	public bool killedColFlyingSentry;

	// Token: 0x040016FA RID: 5882
	public int killsColFlyingSentry;

	// Token: 0x040016FB RID: 5883
	public bool newDataColFlyingSentry;

	// Token: 0x040016FC RID: 5884
	public bool killedColMiner;

	// Token: 0x040016FD RID: 5885
	public int killsColMiner;

	// Token: 0x040016FE RID: 5886
	public bool newDataColMiner;

	// Token: 0x040016FF RID: 5887
	public bool killedColShield;

	// Token: 0x04001700 RID: 5888
	public int killsColShield;

	// Token: 0x04001701 RID: 5889
	public bool newDataColShield;

	// Token: 0x04001702 RID: 5890
	public bool killedColWorm;

	// Token: 0x04001703 RID: 5891
	public int killsColWorm;

	// Token: 0x04001704 RID: 5892
	public bool newDataColWorm;

	// Token: 0x04001705 RID: 5893
	public bool killedColHopper;

	// Token: 0x04001706 RID: 5894
	public int killsColHopper;

	// Token: 0x04001707 RID: 5895
	public bool newDataColHopper;

	// Token: 0x04001708 RID: 5896
	public bool killedLobsterLancer;

	// Token: 0x04001709 RID: 5897
	public int killsLobsterLancer;

	// Token: 0x0400170A RID: 5898
	public bool newDataLobsterLancer;

	// Token: 0x0400170B RID: 5899
	public bool killedGhostAladar;

	// Token: 0x0400170C RID: 5900
	public int killsGhostAladar;

	// Token: 0x0400170D RID: 5901
	public bool newDataGhostAladar;

	// Token: 0x0400170E RID: 5902
	public bool killedGhostXero;

	// Token: 0x0400170F RID: 5903
	public int killsGhostXero;

	// Token: 0x04001710 RID: 5904
	public bool newDataGhostXero;

	// Token: 0x04001711 RID: 5905
	public bool killedGhostHu;

	// Token: 0x04001712 RID: 5906
	public int killsGhostHu;

	// Token: 0x04001713 RID: 5907
	public bool newDataGhostHu;

	// Token: 0x04001714 RID: 5908
	public bool killedGhostMarmu;

	// Token: 0x04001715 RID: 5909
	public int killsGhostMarmu;

	// Token: 0x04001716 RID: 5910
	public bool newDataGhostMarmu;

	// Token: 0x04001717 RID: 5911
	public bool killedGhostNoEyes;

	// Token: 0x04001718 RID: 5912
	public int killsGhostNoEyes;

	// Token: 0x04001719 RID: 5913
	public bool newDataGhostNoEyes;

	// Token: 0x0400171A RID: 5914
	public bool killedGhostMarkoth;

	// Token: 0x0400171B RID: 5915
	public int killsGhostMarkoth;

	// Token: 0x0400171C RID: 5916
	public bool newDataGhostMarkoth;

	// Token: 0x0400171D RID: 5917
	public bool killedGhostGalien;

	// Token: 0x0400171E RID: 5918
	public int killsGhostGalien;

	// Token: 0x0400171F RID: 5919
	public bool newDataGhostGalien;

	// Token: 0x04001720 RID: 5920
	public bool killedWhiteDefender;

	// Token: 0x04001721 RID: 5921
	public int killsWhiteDefender;

	// Token: 0x04001722 RID: 5922
	public bool newDataWhiteDefender;

	// Token: 0x04001723 RID: 5923
	public bool killedGreyPrince;

	// Token: 0x04001724 RID: 5924
	public int killsGreyPrince;

	// Token: 0x04001725 RID: 5925
	public bool newDataGreyPrince;

	// Token: 0x04001726 RID: 5926
	public bool killedZotelingBalloon;

	// Token: 0x04001727 RID: 5927
	public int killsZotelingBalloon;

	// Token: 0x04001728 RID: 5928
	public bool newDataZotelingBalloon;

	// Token: 0x04001729 RID: 5929
	public bool killedZotelingHopper;

	// Token: 0x0400172A RID: 5930
	public int killsZotelingHopper;

	// Token: 0x0400172B RID: 5931
	public bool newDataZotelingHopper;

	// Token: 0x0400172C RID: 5932
	public bool killedZotelingBuzzer;

	// Token: 0x0400172D RID: 5933
	public int killsZotelingBuzzer;

	// Token: 0x0400172E RID: 5934
	public bool newDataZotelingBuzzer;

	// Token: 0x0400172F RID: 5935
	public bool killedHollowKnight;

	// Token: 0x04001730 RID: 5936
	public int killsHollowKnight;

	// Token: 0x04001731 RID: 5937
	public bool newDataHollowKnight;

	// Token: 0x04001732 RID: 5938
	public bool killedFinalBoss;

	// Token: 0x04001733 RID: 5939
	public int killsFinalBoss;

	// Token: 0x04001734 RID: 5940
	public bool newDataFinalBoss;

	// Token: 0x04001735 RID: 5941
	public bool killedHunterMark;

	// Token: 0x04001736 RID: 5942
	public int killsHunterMark;

	// Token: 0x04001737 RID: 5943
	public bool newDataHunterMark;

	// Token: 0x04001738 RID: 5944
	public bool killedFlameBearerSmall;

	// Token: 0x04001739 RID: 5945
	public int killsFlameBearerSmall;

	// Token: 0x0400173A RID: 5946
	public bool newDataFlameBearerSmall;

	// Token: 0x0400173B RID: 5947
	public bool killedFlameBearerMed;

	// Token: 0x0400173C RID: 5948
	public int killsFlameBearerMed;

	// Token: 0x0400173D RID: 5949
	public bool newDataFlameBearerMed;

	// Token: 0x0400173E RID: 5950
	public bool killedFlameBearerLarge;

	// Token: 0x0400173F RID: 5951
	public int killsFlameBearerLarge;

	// Token: 0x04001740 RID: 5952
	public bool newDataFlameBearerLarge;

	// Token: 0x04001741 RID: 5953
	public bool killedGrimm;

	// Token: 0x04001742 RID: 5954
	public int killsGrimm;

	// Token: 0x04001743 RID: 5955
	public bool newDataGrimm;

	// Token: 0x04001744 RID: 5956
	public bool killedNightmareGrimm;

	// Token: 0x04001745 RID: 5957
	public int killsNightmareGrimm;

	// Token: 0x04001746 RID: 5958
	public bool newDataNightmareGrimm;

	// Token: 0x04001747 RID: 5959
	public bool killedBindingSeal;

	// Token: 0x04001748 RID: 5960
	public int killsBindingSeal;

	// Token: 0x04001749 RID: 5961
	public bool newDataBindingSeal;

	// Token: 0x0400174A RID: 5962
	public bool killedFatFluke;

	// Token: 0x0400174B RID: 5963
	public int killsFatFluke;

	// Token: 0x0400174C RID: 5964
	public bool newDataFatFluke;

	// Token: 0x0400174D RID: 5965
	public bool killedPaleLurker;

	// Token: 0x0400174E RID: 5966
	public int killsPaleLurker;

	// Token: 0x0400174F RID: 5967
	public bool newDataPaleLurker;

	// Token: 0x04001750 RID: 5968
	public bool killedNailBros;

	// Token: 0x04001751 RID: 5969
	public int killsNailBros;

	// Token: 0x04001752 RID: 5970
	public bool newDataNailBros;

	// Token: 0x04001753 RID: 5971
	public bool killedPaintmaster;

	// Token: 0x04001754 RID: 5972
	public int killsPaintmaster;

	// Token: 0x04001755 RID: 5973
	public bool newDataPaintmaster;

	// Token: 0x04001756 RID: 5974
	public bool killedNailsage;

	// Token: 0x04001757 RID: 5975
	public int killsNailsage;

	// Token: 0x04001758 RID: 5976
	public bool newDataNailsage;

	// Token: 0x04001759 RID: 5977
	public bool killedHollowKnightPrime;

	// Token: 0x0400175A RID: 5978
	public int killsHollowKnightPrime;

	// Token: 0x0400175B RID: 5979
	public bool newDataHollowKnightPrime;

	// Token: 0x0400175C RID: 5980
	public bool killedGodseekerMask;

	// Token: 0x0400175D RID: 5981
	public int killsGodseekerMask;

	// Token: 0x0400175E RID: 5982
	public bool newDataGodseekerMask;

	// Token: 0x0400175F RID: 5983
	public bool killedVoidIdol_1;

	// Token: 0x04001760 RID: 5984
	public int killsVoidIdol_1;

	// Token: 0x04001761 RID: 5985
	public bool newDataVoidIdol_1;

	// Token: 0x04001762 RID: 5986
	public bool killedVoidIdol_2;

	// Token: 0x04001763 RID: 5987
	public int killsVoidIdol_2;

	// Token: 0x04001764 RID: 5988
	public bool newDataVoidIdol_2;

	// Token: 0x04001765 RID: 5989
	public bool killedVoidIdol_3;

	// Token: 0x04001766 RID: 5990
	public int killsVoidIdol_3;

	// Token: 0x04001767 RID: 5991
	public bool newDataVoidIdol_3;

	// Token: 0x04001768 RID: 5992
	public int grubsCollected;

	// Token: 0x04001769 RID: 5993
	public int grubRewards;

	// Token: 0x0400176A RID: 5994
	public bool finalGrubRewardCollected;

	// Token: 0x0400176B RID: 5995
	public bool fatGrubKing;

	// Token: 0x0400176C RID: 5996
	public bool falseKnightDefeated;

	// Token: 0x0400176D RID: 5997
	public bool falseKnightDreamDefeated;

	// Token: 0x0400176E RID: 5998
	public bool falseKnightOrbsCollected;

	// Token: 0x0400176F RID: 5999
	public bool mawlekDefeated;

	// Token: 0x04001770 RID: 6000
	public bool giantBuzzerDefeated;

	// Token: 0x04001771 RID: 6001
	public bool giantFlyDefeated;

	// Token: 0x04001772 RID: 6002
	public bool blocker1Defeated;

	// Token: 0x04001773 RID: 6003
	public bool blocker2Defeated;

	// Token: 0x04001774 RID: 6004
	public bool hornet1Defeated;

	// Token: 0x04001775 RID: 6005
	public bool collectorDefeated;

	// Token: 0x04001776 RID: 6006
	public bool hornetOutskirtsDefeated;

	// Token: 0x04001777 RID: 6007
	public bool mageLordDreamDefeated;

	// Token: 0x04001778 RID: 6008
	public bool mageLordOrbsCollected;

	// Token: 0x04001779 RID: 6009
	public bool infectedKnightDreamDefeated;

	// Token: 0x0400177A RID: 6010
	public bool infectedKnightOrbsCollected;

	// Token: 0x0400177B RID: 6011
	public bool whiteDefenderDefeated;

	// Token: 0x0400177C RID: 6012
	public bool whiteDefenderOrbsCollected;

	// Token: 0x0400177D RID: 6013
	public int whiteDefenderDefeats;

	// Token: 0x0400177E RID: 6014
	public int greyPrinceDefeats;

	// Token: 0x0400177F RID: 6015
	public bool greyPrinceDefeated;

	// Token: 0x04001780 RID: 6016
	public bool greyPrinceOrbsCollected;

	// Token: 0x04001781 RID: 6017
	public int aladarSlugDefeated;

	// Token: 0x04001782 RID: 6018
	public int xeroDefeated;

	// Token: 0x04001783 RID: 6019
	public int elderHuDefeated;

	// Token: 0x04001784 RID: 6020
	public int mumCaterpillarDefeated;

	// Token: 0x04001785 RID: 6021
	public int noEyesDefeated;

	// Token: 0x04001786 RID: 6022
	public int markothDefeated;

	// Token: 0x04001787 RID: 6023
	public int galienDefeated;

	// Token: 0x04001788 RID: 6024
	public bool XERO_encountered;

	// Token: 0x04001789 RID: 6025
	public bool ALADAR_encountered;

	// Token: 0x0400178A RID: 6026
	public bool HU_encountered;

	// Token: 0x0400178B RID: 6027
	public bool MUMCAT_encountered;

	// Token: 0x0400178C RID: 6028
	public bool NOEYES_encountered;

	// Token: 0x0400178D RID: 6029
	public bool MARKOTH_encountered;

	// Token: 0x0400178E RID: 6030
	public bool GALIEN_encountered;

	// Token: 0x0400178F RID: 6031
	public bool xeroPinned;

	// Token: 0x04001790 RID: 6032
	public bool aladarPinned;

	// Token: 0x04001791 RID: 6033
	public bool huPinned;

	// Token: 0x04001792 RID: 6034
	public bool mumCaterpillarPinned;

	// Token: 0x04001793 RID: 6035
	public bool noEyesPinned;

	// Token: 0x04001794 RID: 6036
	public bool markothPinned;

	// Token: 0x04001795 RID: 6037
	public bool galienPinned;

	// Token: 0x04001796 RID: 6038
	public int currentInvPane;

	// Token: 0x04001797 RID: 6039
	public bool showGeoUI;

	// Token: 0x04001798 RID: 6040
	public bool showHealthUI;

	// Token: 0x04001799 RID: 6041
	public bool promptFocus;

	// Token: 0x0400179A RID: 6042
	public bool seenFocusTablet;

	// Token: 0x0400179B RID: 6043
	public bool seenDreamNailPrompt;

	// Token: 0x0400179C RID: 6044
	public bool isFirstGame;

	// Token: 0x0400179D RID: 6045
	public bool enteredTutorialFirstTime;

	// Token: 0x0400179E RID: 6046
	public bool isInvincible;

	// Token: 0x0400179F RID: 6047
	public bool infiniteAirJump;

	// Token: 0x040017A0 RID: 6048
	public bool invinciTest;

	// Token: 0x040017A1 RID: 6049
	public int currentArea;

	// Token: 0x040017A2 RID: 6050
	public bool visitedDirtmouth;

	// Token: 0x040017A3 RID: 6051
	public bool visitedCrossroads;

	// Token: 0x040017A4 RID: 6052
	public bool visitedGreenpath;

	// Token: 0x040017A5 RID: 6053
	public bool visitedFungus;

	// Token: 0x040017A6 RID: 6054
	public bool visitedHive;

	// Token: 0x040017A7 RID: 6055
	public bool visitedCrossroadsInfected;

	// Token: 0x040017A8 RID: 6056
	public bool visitedRuins;

	// Token: 0x040017A9 RID: 6057
	public bool visitedMines;

	// Token: 0x040017AA RID: 6058
	public bool visitedRoyalGardens;

	// Token: 0x040017AB RID: 6059
	public bool visitedFogCanyon;

	// Token: 0x040017AC RID: 6060
	public bool visitedDeepnest;

	// Token: 0x040017AD RID: 6061
	public bool visitedRestingGrounds;

	// Token: 0x040017AE RID: 6062
	public bool visitedWaterways;

	// Token: 0x040017AF RID: 6063
	public bool visitedAbyss;

	// Token: 0x040017B0 RID: 6064
	public bool visitedOutskirts;

	// Token: 0x040017B1 RID: 6065
	public bool visitedWhitePalace;

	// Token: 0x040017B2 RID: 6066
	public bool visitedCliffs;

	// Token: 0x040017B3 RID: 6067
	public bool visitedAbyssLower;

	// Token: 0x040017B4 RID: 6068
	public bool visitedGodhome;

	// Token: 0x040017B5 RID: 6069
	public bool visitedMines10;

	// Token: 0x040017B6 RID: 6070
	public List<string> scenesVisited;

	// Token: 0x040017B7 RID: 6071
	public List<string> scenesMapped;

	// Token: 0x040017B8 RID: 6072
	public List<string> scenesEncounteredBench;

	// Token: 0x040017B9 RID: 6073
	public List<string> scenesGrubRescued;

	// Token: 0x040017BA RID: 6074
	public List<string> scenesFlameCollected;

	// Token: 0x040017BB RID: 6075
	public List<string> scenesEncounteredCocoon;

	// Token: 0x040017BC RID: 6076
	public List<string> scenesEncounteredDreamPlant;

	// Token: 0x040017BD RID: 6077
	public List<string> scenesEncounteredDreamPlantC;

	// Token: 0x040017BE RID: 6078
	public bool hasMap;

	// Token: 0x040017BF RID: 6079
	public bool mapAllRooms;

	// Token: 0x040017C0 RID: 6080
	public bool atMapPrompt;

	// Token: 0x040017C1 RID: 6081
	public bool mapDirtmouth;

	// Token: 0x040017C2 RID: 6082
	public bool mapCrossroads;

	// Token: 0x040017C3 RID: 6083
	public bool mapGreenpath;

	// Token: 0x040017C4 RID: 6084
	public bool mapFogCanyon;

	// Token: 0x040017C5 RID: 6085
	public bool mapRoyalGardens;

	// Token: 0x040017C6 RID: 6086
	public bool mapFungalWastes;

	// Token: 0x040017C7 RID: 6087
	public bool mapCity;

	// Token: 0x040017C8 RID: 6088
	public bool mapWaterways;

	// Token: 0x040017C9 RID: 6089
	public bool mapMines;

	// Token: 0x040017CA RID: 6090
	public bool mapDeepnest;

	// Token: 0x040017CB RID: 6091
	public bool mapCliffs;

	// Token: 0x040017CC RID: 6092
	public bool mapOutskirts;

	// Token: 0x040017CD RID: 6093
	public bool mapRestingGrounds;

	// Token: 0x040017CE RID: 6094
	public bool mapAbyss;

	// Token: 0x040017CF RID: 6095
	private Dictionary<string, PlayerData.MapBools> mapZoneBools;

	// Token: 0x040017D0 RID: 6096
	public bool hasPin;

	// Token: 0x040017D1 RID: 6097
	public bool hasPinBench;

	// Token: 0x040017D2 RID: 6098
	public bool hasPinCocoon;

	// Token: 0x040017D3 RID: 6099
	public bool hasPinDreamPlant;

	// Token: 0x040017D4 RID: 6100
	public bool hasPinGuardian;

	// Token: 0x040017D5 RID: 6101
	public bool hasPinBlackEgg;

	// Token: 0x040017D6 RID: 6102
	public bool hasPinShop;

	// Token: 0x040017D7 RID: 6103
	public bool hasPinSpa;

	// Token: 0x040017D8 RID: 6104
	public bool hasPinStag;

	// Token: 0x040017D9 RID: 6105
	public bool hasPinTram;

	// Token: 0x040017DA RID: 6106
	public bool hasPinGhost;

	// Token: 0x040017DB RID: 6107
	public bool hasPinGrub;

	// Token: 0x040017DC RID: 6108
	public bool hasMarker;

	// Token: 0x040017DD RID: 6109
	public bool hasMarker_r;

	// Token: 0x040017DE RID: 6110
	public bool hasMarker_b;

	// Token: 0x040017DF RID: 6111
	public bool hasMarker_y;

	// Token: 0x040017E0 RID: 6112
	public bool hasMarker_w;

	// Token: 0x040017E1 RID: 6113
	public int spareMarkers_r;

	// Token: 0x040017E2 RID: 6114
	public int spareMarkers_b;

	// Token: 0x040017E3 RID: 6115
	public int spareMarkers_y;

	// Token: 0x040017E4 RID: 6116
	public int spareMarkers_w;

	// Token: 0x040017E5 RID: 6117
	public List<Vector3> placedMarkers_r;

	// Token: 0x040017E6 RID: 6118
	public List<Vector3> placedMarkers_b;

	// Token: 0x040017E7 RID: 6119
	public List<Vector3> placedMarkers_y;

	// Token: 0x040017E8 RID: 6120
	public List<Vector3> placedMarkers_w;

	// Token: 0x040017E9 RID: 6121
	public int environmentType;

	// Token: 0x040017EA RID: 6122
	public int environmentTypeDefault;

	// Token: 0x040017EB RID: 6123
	public int previousDarkness;

	// Token: 0x040017EC RID: 6124
	public bool openedTramLower;

	// Token: 0x040017ED RID: 6125
	public bool openedTramRestingGrounds;

	// Token: 0x040017EE RID: 6126
	public int tramLowerPosition;

	// Token: 0x040017EF RID: 6127
	public int tramRestingGroundsPosition;

	// Token: 0x040017F0 RID: 6128
	public bool mineLiftOpened;

	// Token: 0x040017F1 RID: 6129
	public bool menderDoorOpened;

	// Token: 0x040017F2 RID: 6130
	public bool vesselFragStagNest;

	// Token: 0x040017F3 RID: 6131
	public bool shamanPillar;

	// Token: 0x040017F4 RID: 6132
	public bool crossroadsMawlekWall;

	// Token: 0x040017F5 RID: 6133
	public bool eggTempleVisited;

	// Token: 0x040017F6 RID: 6134
	public bool crossroadsInfected;

	// Token: 0x040017F7 RID: 6135
	public bool falseKnightFirstPlop;

	// Token: 0x040017F8 RID: 6136
	public bool falseKnightWallRepaired;

	// Token: 0x040017F9 RID: 6137
	public bool falseKnightWallBroken;

	// Token: 0x040017FA RID: 6138
	public bool falseKnightGhostDeparted;

	// Token: 0x040017FB RID: 6139
	public bool spaBugsEncountered;

	// Token: 0x040017FC RID: 6140
	public bool hornheadVinePlat;

	// Token: 0x040017FD RID: 6141
	public bool infectedKnightEncountered;

	// Token: 0x040017FE RID: 6142
	public bool megaMossChargerEncountered;

	// Token: 0x040017FF RID: 6143
	public bool megaMossChargerDefeated;

	// Token: 0x04001800 RID: 6144
	public bool dreamerScene1;

	// Token: 0x04001801 RID: 6145
	public bool slugEncounterComplete;

	// Token: 0x04001802 RID: 6146
	public bool defeatedDoubleBlockers;

	// Token: 0x04001803 RID: 6147
	public bool oneWayArchive;

	// Token: 0x04001804 RID: 6148
	public bool defeatedMegaJelly;

	// Token: 0x04001805 RID: 6149
	public bool summonedMonomon;

	// Token: 0x04001806 RID: 6150
	public bool sawWoundedQuirrel;

	// Token: 0x04001807 RID: 6151
	public bool encounteredMegaJelly;

	// Token: 0x04001808 RID: 6152
	public bool defeatedMantisLords;

	// Token: 0x04001809 RID: 6153
	public bool encounteredGatekeeper;

	// Token: 0x0400180A RID: 6154
	public bool deepnestWall;

	// Token: 0x0400180B RID: 6155
	public bool queensStationNonDisplay;

	// Token: 0x0400180C RID: 6156
	public bool cityBridge1;

	// Token: 0x0400180D RID: 6157
	public bool cityBridge2;

	// Token: 0x0400180E RID: 6158
	public bool cityLift1;

	// Token: 0x0400180F RID: 6159
	public bool cityLift1_isUp;

	// Token: 0x04001810 RID: 6160
	public bool liftArrival;

	// Token: 0x04001811 RID: 6161
	public bool openedMageDoor;

	// Token: 0x04001812 RID: 6162
	public bool openedMageDoor_v2;

	// Token: 0x04001813 RID: 6163
	public bool brokenMageWindow;

	// Token: 0x04001814 RID: 6164
	public bool brokenMageWindowGlass;

	// Token: 0x04001815 RID: 6165
	public bool mageLordEncountered;

	// Token: 0x04001816 RID: 6166
	public bool mageLordEncountered_2;

	// Token: 0x04001817 RID: 6167
	public bool mageLordDefeated;

	// Token: 0x04001818 RID: 6168
	public bool ruins1_5_tripleDoor;

	// Token: 0x04001819 RID: 6169
	public bool openedCityGate;

	// Token: 0x0400181A RID: 6170
	public bool cityGateClosed;

	// Token: 0x0400181B RID: 6171
	public bool bathHouseOpened;

	// Token: 0x0400181C RID: 6172
	public bool bathHouseWall;

	// Token: 0x0400181D RID: 6173
	public bool cityLift2;

	// Token: 0x0400181E RID: 6174
	public bool cityLift2_isUp;

	// Token: 0x0400181F RID: 6175
	public bool city2_sewerDoor;

	// Token: 0x04001820 RID: 6176
	public bool openedLoveDoor;

	// Token: 0x04001821 RID: 6177
	public bool watcherChandelier;

	// Token: 0x04001822 RID: 6178
	public bool completedQuakeArea;

	// Token: 0x04001823 RID: 6179
	public bool kingsStationNonDisplay;

	// Token: 0x04001824 RID: 6180
	public bool tollBenchCity;

	// Token: 0x04001825 RID: 6181
	public bool waterwaysGate;

	// Token: 0x04001826 RID: 6182
	public bool defeatedDungDefender;

	// Token: 0x04001827 RID: 6183
	public bool dungDefenderEncounterReady;

	// Token: 0x04001828 RID: 6184
	public bool flukeMotherEncountered;

	// Token: 0x04001829 RID: 6185
	public bool flukeMotherDefeated;

	// Token: 0x0400182A RID: 6186
	public bool openedWaterwaysManhole;

	// Token: 0x0400182B RID: 6187
	public bool waterwaysAcidDrained;

	// Token: 0x0400182C RID: 6188
	public bool dungDefenderWallBroken;

	// Token: 0x0400182D RID: 6189
	public bool dungDefenderSleeping;

	// Token: 0x0400182E RID: 6190
	public bool defeatedMegaBeamMiner;

	// Token: 0x0400182F RID: 6191
	public bool defeatedMegaBeamMiner2;

	// Token: 0x04001830 RID: 6192
	public bool brokeMinersWall;

	// Token: 0x04001831 RID: 6193
	public bool encounteredMimicSpider;

	// Token: 0x04001832 RID: 6194
	public bool steppedBeyondBridge;

	// Token: 0x04001833 RID: 6195
	public bool deepnestBridgeCollapsed;

	// Token: 0x04001834 RID: 6196
	public bool spiderCapture;

	// Token: 0x04001835 RID: 6197
	public bool deepnest26b_switch;

	// Token: 0x04001836 RID: 6198
	public bool openedRestingGrounds02;

	// Token: 0x04001837 RID: 6199
	public bool restingGroundsCryptWall;

	// Token: 0x04001838 RID: 6200
	public bool dreamNailConvo;

	// Token: 0x04001839 RID: 6201
	public int gladeGhostsKilled;

	// Token: 0x0400183A RID: 6202
	public bool openedGardensStagStation;

	// Token: 0x0400183B RID: 6203
	public bool extendedGramophone;

	// Token: 0x0400183C RID: 6204
	public bool tollBenchQueensGardens;

	// Token: 0x0400183D RID: 6205
	public bool blizzardEnded;

	// Token: 0x0400183E RID: 6206
	public bool encounteredHornet;

	// Token: 0x0400183F RID: 6207
	public bool savedByHornet;

	// Token: 0x04001840 RID: 6208
	public bool outskirtsWall;

	// Token: 0x04001841 RID: 6209
	public bool abyssGateOpened;

	// Token: 0x04001842 RID: 6210
	public bool abyssLighthouse;

	// Token: 0x04001843 RID: 6211
	public bool blueVineDoor;

	// Token: 0x04001844 RID: 6212
	public bool gotShadeCharm;

	// Token: 0x04001845 RID: 6213
	public bool tollBenchAbyss;

	// Token: 0x04001846 RID: 6214
	public int fountainGeo;

	// Token: 0x04001847 RID: 6215
	public bool fountainVesselSummoned;

	// Token: 0x04001848 RID: 6216
	public bool openedBlackEggPath;

	// Token: 0x04001849 RID: 6217
	public bool enteredDreamWorld;

	// Token: 0x0400184A RID: 6218
	public bool duskKnightDefeated;

	// Token: 0x0400184B RID: 6219
	public bool whitePalaceOrb_1;

	// Token: 0x0400184C RID: 6220
	public bool whitePalaceOrb_2;

	// Token: 0x0400184D RID: 6221
	public bool whitePalaceOrb_3;

	// Token: 0x0400184E RID: 6222
	public bool whitePalace05_lever;

	// Token: 0x0400184F RID: 6223
	public bool whitePalaceMidWarp;

	// Token: 0x04001850 RID: 6224
	public bool whitePalaceSecretRoomVisited;

	// Token: 0x04001851 RID: 6225
	public bool tramOpenedDeepnest;

	// Token: 0x04001852 RID: 6226
	public bool tramOpenedCrossroads;

	// Token: 0x04001853 RID: 6227
	public bool openedBlackEggDoor;

	// Token: 0x04001854 RID: 6228
	public bool unchainedHollowKnight;

	// Token: 0x04001855 RID: 6229
	public int flamesCollected;

	// Token: 0x04001856 RID: 6230
	public int flamesRequired;

	// Token: 0x04001857 RID: 6231
	public bool nightmareLanternAppeared;

	// Token: 0x04001858 RID: 6232
	public bool nightmareLanternLit;

	// Token: 0x04001859 RID: 6233
	public bool troupeInTown;

	// Token: 0x0400185A RID: 6234
	public bool divineInTown;

	// Token: 0x0400185B RID: 6235
	public int grimmChildLevel;

	// Token: 0x0400185C RID: 6236
	public bool elderbugConvoGrimm;

	// Token: 0x0400185D RID: 6237
	public bool slyConvoGrimm;

	// Token: 0x0400185E RID: 6238
	public bool iseldaConvoGrimm;

	// Token: 0x0400185F RID: 6239
	public bool midwifeWeaverlingConvo;

	// Token: 0x04001860 RID: 6240
	public bool metGrimm;

	// Token: 0x04001861 RID: 6241
	public bool foughtGrimm;

	// Token: 0x04001862 RID: 6242
	public bool metBrum;

	// Token: 0x04001863 RID: 6243
	public bool defeatedNightmareGrimm;

	// Token: 0x04001864 RID: 6244
	public bool grimmchildAwoken;

	// Token: 0x04001865 RID: 6245
	public bool gotBrummsFlame;

	// Token: 0x04001866 RID: 6246
	public bool brummBrokeBrazier;

	// Token: 0x04001867 RID: 6247
	public bool destroyedNightmareLantern;

	// Token: 0x04001868 RID: 6248
	public bool gotGrimmNotch;

	// Token: 0x04001869 RID: 6249
	public bool nymmInTown;

	// Token: 0x0400186A RID: 6250
	public bool nymmSpoken;

	// Token: 0x0400186B RID: 6251
	public bool nymmCharmConvo;

	// Token: 0x0400186C RID: 6252
	public bool nymmFinalConvo;

	// Token: 0x0400186D RID: 6253
	public bool elderbugNymmConvo;

	// Token: 0x0400186E RID: 6254
	public bool slyNymmConvo;

	// Token: 0x0400186F RID: 6255
	public bool iseldaNymmConvo;

	// Token: 0x04001870 RID: 6256
	public bool nymmMissedEggOpen;

	// Token: 0x04001871 RID: 6257
	public bool elderbugTroupeLeftConvo;

	// Token: 0x04001872 RID: 6258
	public bool elderbugBrettaLeft;

	// Token: 0x04001873 RID: 6259
	public bool jijiGrimmConvo;

	// Token: 0x04001874 RID: 6260
	public bool metDivine;

	// Token: 0x04001875 RID: 6261
	public bool divineFinalConvo;

	// Token: 0x04001876 RID: 6262
	public bool gaveFragileHeart;

	// Token: 0x04001877 RID: 6263
	public bool gaveFragileGreed;

	// Token: 0x04001878 RID: 6264
	public bool gaveFragileStrength;

	// Token: 0x04001879 RID: 6265
	public int divineEatenConvos;

	// Token: 0x0400187A RID: 6266
	public bool pooedFragileHeart;

	// Token: 0x0400187B RID: 6267
	public bool pooedFragileGreed;

	// Token: 0x0400187C RID: 6268
	public bool pooedFragileStrength;

	// Token: 0x0400187D RID: 6269
	public float completionPercentage;

	// Token: 0x0400187E RID: 6270
	public bool disablePause;

	// Token: 0x0400187F RID: 6271
	public bool backerCredits;

	// Token: 0x04001880 RID: 6272
	public bool unlockedCompletionRate;

	// Token: 0x04001881 RID: 6273
	public int mapKeyPref;

	// Token: 0x04001882 RID: 6274
	public List<string> playerStory;

	// Token: 0x04001883 RID: 6275
	public string playerStoryOutput;

	// Token: 0x04001884 RID: 6276
	public bool betaEnd;

	// Token: 0x04001885 RID: 6277
	public bool newDatTraitorLord;

	// Token: 0x04001886 RID: 6278
	public string bossReturnEntryGate;

	// Token: 0x04001887 RID: 6279
	public BossSequenceDoor.Completion bossDoorStateTier1;

	// Token: 0x04001888 RID: 6280
	public BossSequenceDoor.Completion bossDoorStateTier2;

	// Token: 0x04001889 RID: 6281
	public BossSequenceDoor.Completion bossDoorStateTier3;

	// Token: 0x0400188A RID: 6282
	public BossSequenceDoor.Completion bossDoorStateTier4;

	// Token: 0x0400188B RID: 6283
	public BossSequenceDoor.Completion bossDoorStateTier5;

	// Token: 0x0400188C RID: 6284
	public int bossStatueTargetLevel;

	// Token: 0x0400188D RID: 6285
	public string currentBossStatueCompletionKey;

	// Token: 0x0400188E RID: 6286
	public BossStatue.Completion statueStateGruzMother;

	// Token: 0x0400188F RID: 6287
	public BossStatue.Completion statueStateVengefly;

	// Token: 0x04001890 RID: 6288
	public BossStatue.Completion statueStateBroodingMawlek;

	// Token: 0x04001891 RID: 6289
	public BossStatue.Completion statueStateFalseKnight;

	// Token: 0x04001892 RID: 6290
	public BossStatue.Completion statueStateFailedChampion;

	// Token: 0x04001893 RID: 6291
	public BossStatue.Completion statueStateHornet1;

	// Token: 0x04001894 RID: 6292
	public BossStatue.Completion statueStateHornet2;

	// Token: 0x04001895 RID: 6293
	public BossStatue.Completion statueStateMegaMossCharger;

	// Token: 0x04001896 RID: 6294
	public BossStatue.Completion statueStateMantisLords;

	// Token: 0x04001897 RID: 6295
	public BossStatue.Completion statueStateOblobbles;

	// Token: 0x04001898 RID: 6296
	public BossStatue.Completion statueStateGreyPrince;

	// Token: 0x04001899 RID: 6297
	public BossStatue.Completion statueStateBrokenVessel;

	// Token: 0x0400189A RID: 6298
	public BossStatue.Completion statueStateLostKin;

	// Token: 0x0400189B RID: 6299
	public BossStatue.Completion statueStateNosk;

	// Token: 0x0400189C RID: 6300
	public BossStatue.Completion statueStateFlukemarm;

	// Token: 0x0400189D RID: 6301
	public BossStatue.Completion statueStateCollector;

	// Token: 0x0400189E RID: 6302
	public BossStatue.Completion statueStateWatcherKnights;

	// Token: 0x0400189F RID: 6303
	public BossStatue.Completion statueStateSoulMaster;

	// Token: 0x040018A0 RID: 6304
	public BossStatue.Completion statueStateSoulTyrant;

	// Token: 0x040018A1 RID: 6305
	public BossStatue.Completion statueStateGodTamer;

	// Token: 0x040018A2 RID: 6306
	public BossStatue.Completion statueStateCrystalGuardian1;

	// Token: 0x040018A3 RID: 6307
	public BossStatue.Completion statueStateCrystalGuardian2;

	// Token: 0x040018A4 RID: 6308
	public BossStatue.Completion statueStateUumuu;

	// Token: 0x040018A5 RID: 6309
	public BossStatue.Completion statueStateDungDefender;

	// Token: 0x040018A6 RID: 6310
	public BossStatue.Completion statueStateWhiteDefender;

	// Token: 0x040018A7 RID: 6311
	public BossStatue.Completion statueStateHiveKnight;

	// Token: 0x040018A8 RID: 6312
	public BossStatue.Completion statueStateTraitorLord;

	// Token: 0x040018A9 RID: 6313
	public BossStatue.Completion statueStateGrimm;

	// Token: 0x040018AA RID: 6314
	public BossStatue.Completion statueStateNightmareGrimm;

	// Token: 0x040018AB RID: 6315
	public BossStatue.Completion statueStateHollowKnight;

	// Token: 0x040018AC RID: 6316
	public BossStatue.Completion statueStateElderHu;

	// Token: 0x040018AD RID: 6317
	public BossStatue.Completion statueStateGalien;

	// Token: 0x040018AE RID: 6318
	public BossStatue.Completion statueStateMarkoth;

	// Token: 0x040018AF RID: 6319
	public BossStatue.Completion statueStateMarmu;

	// Token: 0x040018B0 RID: 6320
	public BossStatue.Completion statueStateNoEyes;

	// Token: 0x040018B1 RID: 6321
	public BossStatue.Completion statueStateXero;

	// Token: 0x040018B2 RID: 6322
	public BossStatue.Completion statueStateGorb;

	// Token: 0x040018B3 RID: 6323
	public BossStatue.Completion statueStateRadiance;

	// Token: 0x040018B4 RID: 6324
	public BossStatue.Completion statueStateSly;

	// Token: 0x040018B5 RID: 6325
	public BossStatue.Completion statueStateNailmasters;

	// Token: 0x040018B6 RID: 6326
	public BossStatue.Completion statueStateMageKnight;

	// Token: 0x040018B7 RID: 6327
	public BossStatue.Completion statueStatePaintmaster;

	// Token: 0x040018B8 RID: 6328
	public BossStatue.Completion statueStateZote;

	// Token: 0x040018B9 RID: 6329
	public BossStatue.Completion statueStateNoskHornet;

	// Token: 0x040018BA RID: 6330
	public BossStatue.Completion statueStateMantisLordsExtra;

	// Token: 0x040018BB RID: 6331
	public bool godseekerUnlocked;

	// Token: 0x040018BC RID: 6332
	public BossSequenceController.BossSequenceData currentBossSequence;

	// Token: 0x040018BD RID: 6333
	public bool bossRushMode;

	// Token: 0x040018BE RID: 6334
	public bool bossDoorCageUnlocked;

	// Token: 0x040018BF RID: 6335
	public bool blueRoomDoorUnlocked;

	// Token: 0x040018C0 RID: 6336
	public bool blueRoomActivated;

	// Token: 0x040018C1 RID: 6337
	public bool finalBossDoorUnlocked;

	// Token: 0x040018C2 RID: 6338
	public bool hasGodfinder;

	// Token: 0x040018C3 RID: 6339
	public bool unlockedNewBossStatue;

	// Token: 0x040018C4 RID: 6340
	public bool scaredFlukeHermitEncountered;

	// Token: 0x040018C5 RID: 6341
	public bool scaredFlukeHermitReturned;

	// Token: 0x040018C6 RID: 6342
	public bool enteredGGAtrium;

	// Token: 0x040018C7 RID: 6343
	public bool extraFlowerAppear;

	// Token: 0x040018C8 RID: 6344
	public bool givenGodseekerFlower;

	// Token: 0x040018C9 RID: 6345
	public bool givenOroFlower;

	// Token: 0x040018CA RID: 6346
	public bool givenWhiteLadyFlower;

	// Token: 0x040018CB RID: 6347
	public bool givenEmilitiaFlower;

	// Token: 0x040018CC RID: 6348
	public List<string> unlockedBossScenes;

	// Token: 0x040018CD RID: 6349
	public bool queuedGodfinderIcon;

	// Token: 0x040018CE RID: 6350
	public bool godseekerSpokenAwake;

	// Token: 0x040018CF RID: 6351
	public bool nailsmithCorpseAppeared;

	// Token: 0x040018D0 RID: 6352
	public int godseekerWaterwaysSeenState;

	// Token: 0x040018D1 RID: 6353
	public bool godseekerWaterwaysSpoken1;

	// Token: 0x040018D2 RID: 6354
	public bool godseekerWaterwaysSpoken2;

	// Token: 0x040018D3 RID: 6355
	public bool godseekerWaterwaysSpoken3;

	// Token: 0x040018D4 RID: 6356
	public int bossDoorEntranceTextSeen;

	// Token: 0x040018D5 RID: 6357
	public bool seenDoor4Finale;

	// Token: 0x040018D6 RID: 6358
	public bool zoteStatueWallBroken;

	// Token: 0x040018D7 RID: 6359
	public bool seenGGWastes;

	// Token: 0x040018D8 RID: 6360
	public bool ordealAchieved;

	// Token: 0x040018D9 RID: 6361
	private static PlayerData _instance;

	// Token: 0x0200037A RID: 890
	private enum MapBools
	{
		// Token: 0x040018DB RID: 6363
		MapDirtmouth,
		// Token: 0x040018DC RID: 6364
		MapCrossroads,
		// Token: 0x040018DD RID: 6365
		MapGreenpath,
		// Token: 0x040018DE RID: 6366
		MapFogCanyon,
		// Token: 0x040018DF RID: 6367
		MapRoyalGardens,
		// Token: 0x040018E0 RID: 6368
		MapFungalWastes,
		// Token: 0x040018E1 RID: 6369
		MapCity,
		// Token: 0x040018E2 RID: 6370
		MapWaterways,
		// Token: 0x040018E3 RID: 6371
		MapMines,
		// Token: 0x040018E4 RID: 6372
		MapDeepnest,
		// Token: 0x040018E5 RID: 6373
		MapCliffs,
		// Token: 0x040018E6 RID: 6374
		MapOutskirts,
		// Token: 0x040018E7 RID: 6375
		MapRestingGrounds,
		// Token: 0x040018E8 RID: 6376
		MapAbyss
	}
}
