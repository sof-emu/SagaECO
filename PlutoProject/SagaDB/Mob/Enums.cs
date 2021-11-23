﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SagaDB.Mob
{
    public enum MobType
    {
        CC_BOSS,


        HUMAN,
        HUMAN_SKILL,
        HUMAN_BOSS,
        HUMAN_BOSS_SKILL,
        HUMAN_NOTOUCH,
        HUMAN_CHAMP,
        HUMAN_BOSS_CHAMP,
        HUMAN_SKILL_CHAMP,
        HUMAN_SKILL_BOSS_CHAMP,
        HUMAN_SMARK_HETERODOXY,
        HUMAN_SMARK_BOSS_HETERODOXY,
        HUMAN_BOSS_MIRROR,
        HUMAN_BOSS_SKILL_CHAMP,

        PLANT,
        PLANT_MARK,
        PLANT_BOSS,
        PLANT_SKILL,
        PLANT_NOTOUCH,
        PLANT_MATERIAL,
        PLANT_UNITE,
        PLANT_NOTPTDROPRANGE,
        PLANT_BOSS_SKILL,
        PLANT_BOSS_SKILL_NOTPTDROPRANGE,
        PLANT_MATERIAL_EAST,
        PLANT_MATERIAL_WEST,
        PLANT_MATERIAL_SOUTH,
        PLANT_MATERIAL_NORTH,
        PLANT_MATERIAL_SKILL,
        PLANT_MATERIAL_HETERODOXY,
        PLANT_MATERIAL_NOTPTDROPRANGE,
        PLANT_MATERIAL_BOSS_MARK,
        PLANT_MATERIAL_EAST_BOSS_SKILL_WALL,
        PLANT_MATERIAL_WEST_BOSS_SKILL_WALL,
        PLANT_MATERIAL_SOUTH_BOSS_SKILL_WALL,
        PLANT_MATERIAL_NORTH_BOSS_SKILL_WALL,

        ROCK,
        ROCK_MATERIAL,
        ROCK_SKILL,
        ROCK_BOMB_SKILL,
        ROCK_MATERIAL_SKILL,
        ROCK_MATERIAL_NORTH_NOTOUCH,
        ROCK_MATERIAL_SOUTH_NOTOUCH,
        ROCK_MATERIAL_EAST_NOTOUCH,
        ROCK_MATERIAL_WEST_NOTOUCH,
        ROCK_NOTPTDROPRANGE,
        ROCK_BOSS_SKILL_WALL,
        ROCK_MATERIAL_BOSS_NOTPTDROPRANGE,
        ROCK_MATERIAL_BOSS_SKILL_NOTPTDROPRANGE,
        ROCK_BOSS_SKILL_NOTPTDROPRANGE,
        ROCK_MATERIAL_BOSS,

        BIRD,
        BIRD_BOSS,
        BIRD_UNITE,
        BIRD_NOTOUCH,
        BIRD_BOSS_SKILL,
        BIRD_SPBOSS_SKILL,

        ANIMAL,
        ANIMAL_BOSS,
        ANIMAL_NOTOUCH,
        ANIMAL_SKILL,
        ANIMAL_BOSS_SKILL,
        ANIMAL_BOMB_SKILL,
        ANIMAL_RIDE_BREEDER,
        ANIMAL_SPBOSS_SKILL,
        ANIMAL_NOTPTDROPRANGE,
        ANIMAL_BOSS_SKILL_NOTPTDROPRANGE,
        ANIMAL_SPBOSS_SKILL_NOTPTDROPRANGE,
        ANIMAL_BOSS_NOTPTDROPRANGE,

        WATER_ANIMAL,
        WATER_ANIMAL_BOSS,
        WATER_ANIMAL_SKILL,
        WATER_ANIMAL_NOTOUCH,
        WATER_ANIMAL_BOSS_SKILL,
        WATER_ANIMAL_LVDIFF,

        INSECT,
        INSECT_SKILL,
        INSECT_BOSS,
        INSECT_UNITE,
        INSECT_NOTOUCH,
        INSECT_BOSS_SKILL,
        INSECT_NOTPTDROPRANGE,
        INSECT_BOSS_NOTPTDROPRANGE,
        INSECT_BOSS_CHAMP,


        MAGIC_CREATURE,
        MAGIC_CREATURE_SKILL,
        MAGIC_CREATURE_BOSS,
        MAGIC_CREATURE_LVDIFF,
        MAGIC_CREATURE_NOTOUCH,
        MAGIC_CREATURE_MATERIAL,
        MAGIC_CREATURE_BOSS_SKILL,
        MAGIC_CREATURE_NOTPTDROPRANGE,
        MAGIC_CREATURE_BOSS_SKILL_NOTPTDROPRANGE,
        MAGIC_CREATURE_BOMB_SKILL,


        UNDEAD,
        UNDEAD_BOSS,
        UNDEAD_SKILL,
        UNDEAD_NOTOUCH,
        UNDEAD_BOSS_SKILL,
        UNDEAD_BOSS_BOMB_SKILL,
        UNDEAD_BOSS_SKILL_CHAMP,
        UNDEAD_BOSS_CHAMP_BOMB_SKILL_NOTPTDROPRANGE,
        UNDEAD_BOSS_SKILL_NOTPTDROPRANGE,

        MACHINE,
        MACHINE_BOSS,
        MACHINE_NOTOUCH,
        MACHINE_MATERIAL,
        MACHINE_SKILL,
        MACHINE_BOSS_SKILL,
        MACHINE_BOSS_CHAMP,
        MACHINE_NOTPTDROPRANGE,
        MACHINE_SKILL_BOSS,
        MACHINE_SMARK_BOSS_SKILL_HETERODOXY_NONBLAST,
        MACHINE_BOSS_SKILL_NOTPTDROPRANGE,

        ELEMENT,
        ELEMENT_NOTOUCH,
        ELEMENT_NOTOUCH_SKILL,
        ELEMENT_MATERIAL_NOTOUCH_SKILL,
        ELEMENT_BOSS_SKILL,
        ELEMENT_SKILL,
        ELEMENT_NOTPTDROPRANGE,
        ELEMENT_SKILL_BOSS,

        NONE_INFO_MATERIAL,

        TREE,

        EVENT_BOSS,

        TREE_MATERIAL,
        KNIGHTS_WAR_MATERIAL,
        KNIGHTS_WAR_INFO_MATERIAL,
        LANT_MATERIAL_SKILL,
        TREASURE_BOX,
        TREASURE_BOX_MATERIAL,
        CONTAINER,
        CONTAINER_MATERIAL,
        TIMBER_BOX_MATERIAL,
        COLISEUM_MATERIAL,
        CULTURE_PLANT,
        CULTURE_TREE_MATERIAL,
        CULTURE_PLANT_MATERIAL,

        INSECT_RIDE,
        ANIMAL_RIDE,
        MACHINE_RIDE_ROBOT,
        MACHINE_RIDE,
        MAGIC_CREATURE_RIDE,
        WATER_ANIMAL_RIDE,
        HUMAN_RIDE,
        UNDEAD_RIDE,

        HUMAN_69,
        HUMAN_68,
        HUMAN_67,
        HUMAN_66,
        HUMAN_65,
        HUMAN_64,

        HUMAN_63,
        HUMAN_62,
        HUMAN_61,
        HUMAN_60,
        HUMAN_59,
        HUMAN_58,
        HUMAN_58_MASTERLV,

        PLANT_BOSS_BSEARCH,
        PLANT_BOMB_BOSS_SKILL,
        PLANT_INFO_NOTPTDROPRANGE,
        ANIMAL_BOSS_BSEARCH_SKILL,
        INSECT_BOSS_BSEARCH,
        INSECT_BOMB_BOSS_SKILL,
        ANIMAL_BOMB_BOSS_SKILL,
        ANIMAL_MARK,
        ANIMAL_BOSS_BSEARCH_NOTPTDROPRANGE,
        ANIMAL_BOMB_BOSS_BSEARCH_SKILL,
        ANIMAL_BOSS_BSEARCH,
        ANIMAL_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE,
        ANIMAL_BOSS_SKILL_INFO_NOTPTDROPRANGE,
        BIRD_BOSS_SKILL_NOTPTDROPRANGE,
        BIRD_BOSS_BSEARCH_SKILL,
        UNDEAD_MARK,
        INSECT_BOSS_BSEARCH_SKILL,
        MAGIC_CREATURE_BOSS_SKIL,
        UNDEAD_BOSS_BSEARCH,
        UNDEAD_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        UNDEAD_BOSS_NOTPTDROPRANGE,
        MAGIC_CREATURE_BOSS_BSEARCH,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        TREASURE_BOX_MATERIAL_INFO_NOTPTDROPRANGE,
        UNDEAD_SKILL_INFO_,
        UNDEAD_NOTPTDROPRANGE,
        BIRD_SKILL_NOTPTDROPRANGE,
        HUMAN_NOTPTDROPRANGE,
        HUMAN_BOSS_NOTPTDROPRANGE,
        HUMAN_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        HUMAN_BOSS_SKILL_NOTPTDROPRANGE,
        MACHINE_BOSS_BSEARCH_SKILL,
        PLANT_BOSS_BSEARCH_SKILL,
        PLANT_BOSS_NOTOUCH,
        MACHINE_SKILL_BOSS_BSEARCH,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE,
        MAGIC_CREATURE_BOSS_SKILL_INFO_NOTPTDROPRANGE,
        MACHINE_BOSS_BSEARCH_CHAMP,
        ANIMAL_SPBOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        ROCK_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL,
        MACHINE_BOSS_BSEARCH_,
        MACHINE_SKILL_BOSS_BSEARCH_LVDIFF_NONBLAST_ATRE_,
        HUMAN_BOSS_BSEARCH_CHAMP,
        UNDEAD_BOSS_BSEARCH_CHAMP_BOMB_SKILL_NOTPTDROPRANGE,
        UNDEAD_BOSS_BSEARCH_BOMB_SKILL,
        HUMAN_BOSS_BSEARCH,
        HUMAN_SKILL_BOSS_BSEARCH_CHAMP,
        ANIMAL_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        UNDEAD_BOSS_BSEARCH_SKILL,
        MACHINE_BOSS_BSEARCH_SKILL_CHAMP,
        MACHINE_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        MACHINE_BOSS_BSEARCH,
        WATER_ANIMAL_BOSS_BSEARCH,
        HUMAN_BOSS_BSEARCH_SKILL_CHAMP,
        MAGIC_CREATURE_BOSS_BSEARCH_INFO_NOTPTDROPRANGE,
        PLANT_BOSS_BSEARCH_INFO_NOTPTDROPRANGE,
        ANIMAL_BOSS_BSEARCH_INFO_NOTPTDROPRANGE,
        BIRD_NOTPTDROPRANGE,
        MAGIC_CREATURE_SPBOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_LVDIFF_PTRE,
        MAGIC_CREATURE_INFO_NOTPTDROPRANGE_LVDIFF,
        MAGIC_CREATURE_BOSS_SKILL_INFO_NOTPTDROPRANGE_BSEARCH_PTRE,
        HUMAN_BOSS_BSEARCH_SKILL,
        UNDEAD_BOSS_BSEARCH_SKILL_CHAMP,
        HUMAN_BOSS_BSEARCH_MIRROR,
        HUMAN_MIRROR,
        MACHINE_SMARK_HETERODOXY,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE,
        WATER_ANIMAL_BOSS_SKILL_INFO_NOTPTDROPRANGE,
        BIRD_BOSS_BSEARCH,
        BIRD_SPBOSS_BSEARCH_SKILL,
        BIRD_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE,
        BIRD_BOSS_SKILL_INFO_NOTPTDROPRANGE,
        ELEMENT_BOSS_BSEARCH_SKILL,
        ELEMENT_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        ELEMENT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE,
        ELEMENT_BOSS_SKILL_INFO_NOTPTDROPRANGE,
        WATER_ANIMAL_INFO,
        ELEMENT_BOSS_NOTOUCH,
        ELEMENT_BOSS,
        HUMAN_INFO_BOSS_BSEARCH_NOTPTDROPRANGE,
        HUMAN_INFO_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE,
        TREASURE_BOX_MATERIAL_BOSS_SKILL,
        KNIGHTS_WAR_BOSS_MATERIAL,
        HUMAN_INFO_BOSS_NOTPTDROPRANGE,
        ROCK_INFO_MATERIAL_NOTPTDROPRANGE,
        ROCK_INFO_MATERIAL,
        PLANT_MATERIAL_BOSS,
        ROCK_BOSS,
        TREE_BOSS_MATERIAL,
        TIMBER_BOX_MATERIAL_SKILL,
        MAGIC_CREATURE_MATERIAL_BOSS_NONBLAST,
        PLANT_MATERIAL_NOTOUCH_BOSS_SKILL_WALL,
        TREASURE_BOX_MATERIAL_SKILL,
        WATER_ANIMAL_BOSS_SKILL_NOTPTDROPRANGE,
        MACHINE_BOSS_SKILL_CHAMP,
        MAGIC_CREATURE_BOSS_INFO_NOTPTDROPRANGE,
        PLANT_BOSS_INFO_NOTPTDROPRANGE,
        ANIMAL_BOSS_INFO_NOTPTDROPRANGE,
        ELEMENT_BOSS_SKILL_NOTPTDROPRANGE,
        HUMAN_INFO_BOSS_SKILL_NOTPTDROPRANGE,

        KING,
        KING_BOSS,
        KING_MIRROR,

        ANIMAL_BOSS_SKILL_CHAMP,
        ROCK_MATERIAL_BOSS_NOTPTDROPRANGE_CHAMP,

        HUMAN_NOPITEM,

        BIRD_RIDE,
        PLANT_RIDE,
        ANIMAL_RIDE_NOPITEM,
        PLANT_NODEATH_NOTPTDROPRANGE,
        PLANT_NODEATH_NOHIDING_NOTPTDROPRANGE,
        PLANT_LVDIFF,
        PLANT_NOTPTDROPRANGE_BOSS,
        PLANT_COMBATNPCNOTOUCH,
        BIRD_LVDIFF,
        ANIMAL_LVDIFF,
        ANIMAL_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        INSECT_LVDIFF,
        INSECT_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        INSECT_NOTPTDROPRANGE_BOSS,
        WATER_ANIMAL_LVDIFF_NODEATH,
        WATER_ANIMAL_NOTPTDROPRANGE_BOSS,
        WATER_ANIMAL_NODEATH,
        WATER_ANIMAL_NODEATH_NOHIDING,
        WATER_ANIMAL_MARK,
        PLANT_NODEATH,
        PLANT_NODEATH_NOHIDING,
        ANIMAL_LVDIFF_NODEATH,
        ANIMAL_BOSS_BSEARCH_NONBLAST_SKILL,
        BIRD_CHRONICLE_NOTPTDROPRANGE,
        BIRD_NODEATH,
        BIRD_NODEATH_NOHIDING,
        ANIMAL_BOSS_NONBLAST_SKILL,
        UNDEAD_LVDIFF_NODEATH,
        UNDEAD_LVDIFF,
        INSECT_BOSS_BSEARCH_NONBLAST,
        MAGIC_CREATURE_NOTPTDROPRANGE_BOSS,
        MAGIC_CREATURE_LVDIFF_NODEATH,
        MAGIC_CREATURE_CHRONICLE,
        UNDEAD_NOTPTDROPRANGE_BOSS,
        UNDEAD_BOSS_NONBLAST_SKILL,
        UNDEAD_NODEATH,
        UNDEAD_NODEATH_NOHIDING,
        MAGIC_CREATURE_BOSS_LVDIFF,
        MAGIC_CREATURE_NOTPTDROPRANGE_BOSS_SKILL,
        MAGIC_CREATURE_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        MAGIC_CREATURE_BOSS_SKILL_LVDIFF_INFO_NOTPTDROPRANGE_PTRE_FAKE,
        MAGIC_CREATURE_BOSS_LVDIFF_FAKE,
        MAGIC_CREATURE_SKILL_BOSS_LVDIFF_FAKE,
        TREASURE_BOX_MATERIAL_NOTPTDROPRANGE_NONBLAST_PTRE,
        TREASURE_BOX_MATERIAL_PLAYER_PARTNERNOTOUCH,
        TREASURE_BOX_MATERIAL_NONBLAST_PLAYER_PARTNERNOTOUCH_NODEATH,
        MACHINE_NODEATH,
        MACHINE_NODEATH_NOHIDING,
        HUMAN_NODEATH,
        HUMAN_NODEATH_NOHIDING,
        HUMAN_LVDIFF,
        HUMAN_LVDIFF_NODEATH,
        HUMAN_CHRONICLE,
        HUMAN_BOSS_NODEATH_NONBLAST_NORTH_WEST,
        ANIMAL_BOSS_BSEARCH_NONBLAST,
        BIRD_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        MACHINE_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        MACHINE_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH,
        PLANT_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        HUMAN_BOSS_BSEARCH_NONBLAST,
        NONE_MATERIAL_LVDIFF_BOSS,
        MACHINE_BOSS_NONBLAST_SKILL_SOUTH,
        BIRD_LVDIFF_NODEATH,
        MAGIC_CREATURE_NOSKILLEFFECT_COMBATNPCNOTOUCH,
        MACHINE_LVDIFF,
        MACHINE_SKILL_NODEATH,
        MACHINE_LVDIFF_NODEATH,
        MACHINE_SKILL_LVDIFF_NODEATH,
        MACHINE_FAKE_NONBLAST_MOVENOTCELL,
        MACHINE_FAKE_NONBLAST_MOVENOTCELL_NODEATH,
        MACHINE_BOSS_LVDIFF,
        ROCK_LVDIFF_NODEATH,
        ROCK_NODEATH,
        ROCK_NODEATH_NOHIDING,
        ANIMAL_BOSS_BSEARCH_SKILL_LVDIFF,
        MACHINE_SKILL_BOSS_BSEARCH_NOHIDING,
        MACHINE_BOSS_BSEARCH_NOHIDING,
        MACHINE_SKILL_BOSS_BSEARCH_NOHIDING_CHAMP,
        ANIMAL_BOSS_BSEARCH_SKILL_LVDIFF_NONBLAST_SOUTH_NOSKETCH,
        ANIMAL_NODEATH_LVDIFF_NOSKETCH,
        ANIMAL_NODEATH_SKILL_LVDIFF_NOSKETCH,
        ANIMAL_BOSS_NODEATH_SKILL_LVDIFF_NOSKETCH,
        INSECT_LVDIFF_NODEATH,
        INSECT_BOSS_LVDIFF,
        UNDEAD_SKILL_NODEATH,
        WATER_ANIMAL_CHRONICLE,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        WATER_ANIMAL_BOSS_NODEATH_NONBLAST,
        WATER_ANIMAL_NOTPTDROPRANGE,
        WATER_ANIMAL_CHRONICLE_NOTPTDROPRANGE,
        ANIMAL_SKILL_NODEATH,
        ROCK_LVDIFF,
        ROCK_SKILL_NODEATH,
        HUMAN_SKILL_NODEATH,
        HUMAN_SKILL_BOSS_BSEARCH,
        HUMAN_BOSS_BSEARCH_LVDIFF,
        MACHINE_NOTPTDROPRANGE_NODEATH,
        MACHINE_NOTPTDROPRANGE_NODEATH_NOHIDING,
        MACHINE_NODEATH_LVDIFF,
        INSECT_NODEATH_LVDIFF,
        INSECT_NOTPTDROPRANGE_NODEATH,
        INSECT_NOTPTDROPRANGE_NODEATH_NOHIDING,
        ELEMENT_BOSS_NODEATH_NONBLAST_SOUTH,
        ELEMENT_NOTPTDROPRANGE_NODEATH,
        ELEMENT_NOTPTDROPRANGE_NODEATH_NOHIDING,
        ELEMENT_NOTPTDROPRANGE_BOSS,
        ELEMENT_NODEATH,
        ELEMENT_NODEATH_LVDIFF,
        ELEMENT_NOTPTDROPRANGE_CHRONICLE,
        ELEMENT_NODEATH_LVDIFF_NOSKETCH,
        ELEMENT_SKILL_LVDIFF_NODEATH_NOSKETCH,
        ELEMENT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        ELEMENT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        ELEMENT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        PLANT_NOTPTDROPRANGE_NODEATH,
        PLANT_NOTPTDROPRANGE_NODEATH_NOHIDING,
        PLANT_NODEATH_LVDIFF,
        PLANT_NOTPTDROPRANGE_CHRONICLE_NOTPTDROPRANGE,
        PLANT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        PLANT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        PLANT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        PLANT_BOSS_NODEATH_NONBLAST,
        UNDEAD_NODEATH_LVDIFF,
        ANIMAL_NOTPTDROPRANGE_NODEATH,
        ANIMAL_NOTPTDROPRANGE_NODEATH_NOHIDING,
        ANIMAL_NODEATH_LVDIFF,
        ANIMAL_BOSS_NODEATH_NONBLAST,
        ROCK_BOSS_SKILL,
        MACHINE_BOSS_SKILL_LVDIFF,
        MACHINE_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        MACHINE_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        MACHINE_CHRONICLE_NOTPTDROPRANGE,
        MACHINE_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        INSECT_SKILL_NODEATH,
        ANIMAL_NODEATH,
        ANIMAL_SKILL_LVDIFF,
        MAGIC_CREATURE_BOMB_SKILL_NODEATH,
        MAGIC_CREATURE_SKILL_NODEATH,
        MAGIC_CREATURE_BOSS_BSEARCH_NONBLAST,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL_NONBLAST,
        MAGIC_CREATURE_BOSS_NODEATH_NONBLAST,
        INSECT_SKILL_LVDIFF,
        INSECT_NODEATH,
        INSECT_NODEATH_NOHIDING,
        INSECT_CHRONICLE,
        MACHINE_SKILL_NODEATH_BOSS_BSEARCH,
        MACHINE_BOSS_NODEATH_NONBLAST,
        MACHINE_NODEATH_BOSS_BSEARCH,
        MACHINE_BOSS_BSEARCH_NOTOUCH,
        MACHINE_BOSS_BSEARCH_NONBLAST_SKILL,
        MACHINE_BOSS_SKILL_NOTPTDROPRANGE_NODEATH_NONBLAST,
        HUMAN_NOTPTDROPRANGE_COMBATNPCNOTOUCH,
        PLANT_NOTPTDROPRANGE_COMBATNPCNOTOUCH,
        MAGIC_CREATURE_BOSS_BSEARCH_NONBLAST_SKILL,
        MAGIC_CREATURE_NODEATH,
        MAGIC_CREATURE_NODEATH_NOHIDING,
        ANIMAL_BOMB_NONBLAST_NOTPTDROPRANGE_BOSS,
        ANIMAL_NODEATH_NOHIDING,
        ANIMAL_NODEATH_NOTPTDROPRANGE,
        PLANT_NODEATH_SKILL,
        PLANT_NODEATH_NOHIDING_SKILL,
        ELEMENT_NODEATH_NONBLAST_SKILL,
        MAGIC_CREATURE_COMBATNPCNOTOUCH,
        ANIMAL_BOSS_NONBLAST_SKILL_SOUTH,
        ANIMAL_BOSS_NONBLAST,
        ANIMAL_CHRONICLE_NOTPTDROPRANGE,
        BIRD_MARK_SKILL,
        EGG_BOSS_SKILL_NOTPTDROPRANGE,
        ANIMAL_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        ANIMAL_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        ANIMAL_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        INSECT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        INSECT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        INSECT_NOHIDING_NODEATH,
        INSECT_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        INSECT_SKILL_NODEATH_NOHIDING,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL_REC_NOTPTDROPRANGE,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL_REC,
        MAGIC_CREATURE_NOHIDING_NODEATH_NOTPTDROPRANGE,
        HUMAN_NODEATH_SKILL,
        HUMAN_NODEATH_NOHIDING_SKILL,
        MAGIC_CREATURE_MARK,
        UNDEAD_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        UNDEAD_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        UNDEAD_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        INSECT_SKILL_BOSS_SKILL,
        UNDEAD_CHRONICLE,
        ANIMAL_SKILL_NOHIDING_NODEATH,
        ANIMAL_BOSS_BSEARCH_SKILL_REC_NOTPTDROPRANGE_NOHIDING_NONBLAST,
        ELEMENT_SKILL_BOSS_SKILL,
        PLANT_LVDIFF_SKILL,
        PLANT_CHRONICLE_NOTPTDROPRANGE,
        NONE_BOSS_PLAYER,
        HUMAN_BOSS_BSEARCH_NONBLAST_EAST,
        HUMAN_BOSS_SKILL_LVDIFF_NONBLAST_NOHIDING_WEST_NOSKETCH,
        HUMAN_BOSS_BSEARCH_SKILL_NONBLAST_NOSKETCH,
        HUMAN_BOSS_BSEARCH_SKILL_NONBLAST_SOUTH,
        HUMAN_BOSS_BSEARCH_NONBLAST_SKILL,
        MAGIC_CREATURE_SPBOSS_SKILL_INFO_NOTPTDROPRANGE_BSEARCH_PTRE,
        ELEMENT_BOSS_SKILL_INFO_NOTPTDROPRANGE_BSEARCH_PTRE,
        ELEMENT_BOSS_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        ROCK_BOSS_SKILL_NOHIDING_BOSS_BSEARCH_NONBLAST,
        ROCK_BOSS_SKILL_NOHIDING_BOSS_NONBLAST,
        ROCK_BOSS_SKILL_INFO_NOTPTDROPRANGE_BSEARCH_PTRE_NOHIDING,
        ROCK_BOSS_BSEARCH_NONBLAST,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        UNDEAD_BOSS_BSEARCH_NONBLAST_NOHIDING_CHAMP,
        UNDEAD_NOTPTDROPRANGE_BOSS_SKILL,
        ELEMENT_NODEATH_NONBLAST,
        MAGIC_CREATURE_SKILL_NODEATH_NOHIDING_NONBLAST_COMBATNPCNOTOUCH_PARTNERNOTOUCH,
        HUMAN_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        HUMAN_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        BIRD_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        BIRD_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        ROCK_CHRONICLE,
        ROCK_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE_REC,
        ROCK_BOSS_BSEARCH_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        ROCK_MATERIAL_SMARK,
        NONE_BOSS_NOHIDING,
        ELEMENT_BOSS_BSEARCH_CHAMP,
        HUMAN_SPBOSS_BSEARCH_SKILL_NOTPTDROPRANGE_PTRE,
        INSECT_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE_PTRE,
        INSECT_NOHIDING_BOSS_BSEARCH_SKILL_SOUTH_VISIONMAX_SMARK,
        ANIMAL_NOHIDING_NODEATH,
        ANIMAL_BOSS_NOHIDING,
        ANIMAL_NOTPTDROPRANGE_BOSS,
        ANIMAL_BOSS_BSEARCH_SKILL_REC_NOTPTDROPRANGE_NOHIDING_NONBLAST_INFO,
        MACHINE_BOSS_BSEARCH_NONBLAST,
        MACHINE_BOSS_NONBLAST,
        BIRD_BOSS_BSEARCH_SKILL_REC_NOTPTDROPRANGE_NONBLAST,
        BIRD_BSEARCH_SKILL_NOTPTDROPRANGE_NOHIDING,
        BIRD_BOSS_NONBLAST_SKILL_SOUTH,
        BIRD_BOSS_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        HUMAN_BOSS_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        HUMAN_BOSS_SKILL_INFO_NOTPTDROPRANGE_PTRE,
        WATER_ANIMAL_BOSS_SKILL_INFO_NOTPTDROPRANGE_PTRE_NOHIDING,
        MACHINE_SKILL_BOSS_BSEARCH_NONBLAST_PLAYER,
        WATER_ANIMAL_BOSS_BSEARCH_SKILL_NOTPTDROPRANGE_PLAYER,
        WATER_ANIMAL_BOSS_BSEARCH_NONBLAST,
        ANIMAL_BOSS_BSEARCH_NONBLAST_PLAYER_REC,
        WATER_ANIMAL_NOHIDING_BOSS_BSEARCH_SKILL_WEST_VISIONMAX_MOVENOTCELL_SMARK,
        WATER_ANIMAL_NOHIDING_BOSS_BSEARCH_SKILL_MOVENOTCELL_SMARK,
        MACHINE_NODEATH_NONBLAST_SKILL,
        HUMAN_NODEATH_NONBLAST_NORTH,
        ANIMAL_SMARK_HETERODOXY,
        HUMAN_COMBATNPCNOTOUCH,
        HUMAN_BOSS_NOTPTDROPRANGE_BSEARCH,
        HUMAN_BOSS_SKILL_NOTOUCH,
        HUMAN_BOSS_NOTPTDROPRANGE_NOHIDING_SKILL_BSEARCH,
        HUMAN_BOSS_NOTPTDROPRANGE_BSEARCH_SKILL,
        HUMAN_BOSS_NOTPTDROPRANGE_SKILL_BSEARCH,
        HUMAN_BOSS_NOTPTDROPRANGE_SKILL_CHAMP_BSEARCH,
        HUMAN_SKILL_BOSS_NOHIDING_NONBLAST_COMBATNPCNOTOUCH_PARTNERNOTOUCH,
        HUMAN_BOSS_BSEARCH_NONBLAST_NOSKETCH_SKILL_MIRROR,
        HUMAN_BOSS_SOUTH_LVDIFF_NONBLAST_BSEARCH_NODEATH_NOHIDING_NOSKETCH,
        HUMAN_BOSS_SKILL_WEST_LVDIFF_NONBLAST_BSEARCH_NODEATH_NOHIDING_NOSKETCH,
        ELEMENT_BOSS_NONBLAST_NOSKETCH,
        ELEMENT_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        ELEMENT_BOSS_NOHIDING_NONBLAST_NOSKETCH_NORTH_NODIR_NOCAMCHK_SMARK,
        ELEMENT_BOSS_NONBLAST_NOHIDING_NOSKETCH_NOCAMCHK,
        HUMAN_NODEATH_LVDIFF,
        HUMAN_BOSS_NODEATH_NONBLAST_SKILL,
        MAGIC_CREATURE_BOSS_NONBLAST_REC,
        MAGIC_CREATURE_BOSS_NONBLAST,
        ELEMENT_SKILL_NODEATH,
        ELEMENT_SKILL_BOSS_BSEARCH_NONBLAST,
        ELEMENT_NOHIDING_BOSS_BSEARCH_SKILL_MOVENOTCELL_SMARK_NOTOUCH,
        MAGIC_CREATURE_BOSS_BSEARCH_SKILL_REC_NOTPTDROPRANGE_NOHIDING_NONBLAST_INFO,
        ELEMENT_NODEATH_NOHIDING,
        ELEMENT_LVDIFF_NODEATH,
        ELEMENT_CHRONICLE,
        MAGIC_CREATURE_BOSS_SKILL_LVDIFF,
        MAGIC_CREATURE_BOSS_SKILL_NOTPTDROPRANGE_NODEATH_LVDIFF,
        BIRD_NOTPTDROPRANGE_BOSS,
        ELEMENT_LVDIFF,
        WATER_ANIMAL_BOSS_NOTPTDROPRANGE,
        WATER_ANIMAL_BOSS_SKILL_NODEATH_NONBLAST_NOHIDING_NOSKETCH_NORTH,
        MAGIC_CREATURE_BOSS_MARK_SKILL,
        ROCK_MATERIAL_NOTPTDROPRANGE,
        ROCK_MATERIAL_COMBATNPCNOTOUCH_PARTNERNOTOUCH_BOSS_NODEATH_NOSKETCH,
        ROCK_MATERIAL_SKILL_NODEATH_NONBLAST_MOVENOTCELL,
        ROCK_MATERIAL_LVDIFF,
        TREE_MATERIAL_LVDIFF,
        PLANT_MATERIAL_BOSS_LVDIFF,
        PLANT_MATERIAL_LVDIFF,
        TREASURE_BOX_MATERIAL_NOTPTDROPRANGE_NONBLAST,
        TIMBER_BOX_MATERIAL_SOUTH,
        TIMBER_BOX_MATERIAL_PLAYER_PARTNERNOTOUCH_NOTPTDROPLOOT_COMBATNPCNOTOUCH,
        TIMBER_BOX_MATERIAL_PLAYER_PARTNERNOTOUCH_NOTPTDROPRANGE_NOTPTDROPLOOT_COMBATNPCNOTOUCH,
        MACHINE_MATERIAL_SMARK,
        MACHINE_MATERIAL_NODEATH,
        ROCK_MATERIAL_COMBATNPCNOTOUCH,
        MACHINE_BOSS_SKILL_NODEATH_NONBLAST,
        PLANT_MATERIAL_NOTPTDROPRANGE_COMBATNPCNOTOUCH,
        ROCK_NOSKILLEFFECT_COMBATNPCNOTOUCH,
        MAGIC_CREATURE_NOSKILLEFFECT_COMBATNPCNOTOUCH_BOSS_NONBLAST,
        NONE_MATERIAL_SOUTH_BOSS_SKILL_WALL,
        NONE_MATERIAL_SOUTH_WEST_BOSS_SKILL_WALL,
        NONE_MATERIAL_WEST_BOSS_SKILL_WALL,
        NONE_MATERIAL_NORTH_WEST_BOSS_SKILL_WALL,
        NONE_MATERIAL_NORTH_BOSS_SKILL_WALL,
        NONE_MATERIAL_NORTH_EAST_BOSS_SKILL_WALL,
        NONE_MATERIAL_EAST_BOSS_SKILL_WALL,
        NONE_MATERIAL_SOUTH_EAST_BOSS_SKILL_WALL,
        MAGIC_CREATURE_MATERIAL_BOSS_NONBLAST_COMBATNPCNOTOUCH,
        PLANT_MATERIAL_EAST_NOTOUCH_BOSS_SKILL_WALL_MOVENOTCELL,
        PLANT_MATERIAL_SOUTH_NOTOUCH_BOSS_SKILL_WALL_MOVENOTCELL,
        PLANT_MATERIAL_NOTOUCH_BOSS_SKILL_WALL_MOVENOTCELL,
        NONE_MATERIAL_SOUTH_BOSS_SKILL_WALL_NOTOUCH,
        NONE_MATERIAL_SOUTH_WEST_BOSS_SKILL_WALL_NOTOUCH,
        NONE_MATERIAL_WEST_BOSS_SKILL_WALL_NOTOUCH,
        NONE_MATERIAL_NORTH_WEST_BOSS_SKILL_WALL_NOTOUCH,
        NONE_MATERIAL_NORTH_BOSS_SKILL_WALL_NOTOUCH,
        NONE_MATERIAL_NORTH_EAST_BOSS_SKILL_WALL_NOTOUCH,
        NONE_MATERIAL_EAST_BOSS_SKILL_WALL_NOTOUCH,
        NONE_MATERIAL_SOUTH_EAST_BOSS_SKILL_WALL_NOTOUCH,
        KNIGHTS_WAR_MATERIAL_KWARE,
        KNIGHTS_WAR_MATERIAL_SMARK,
        KNIGHTS_WAR_MATERIAL_KWARW,
        KNIGHTS_WAR_MATERIAL_KWARS,
        KNIGHTS_WAR_MATERIAL_KWARN,
        CONTAINER_MATERIAL_SMARK,
        MAGIC_CREATURE_SKILL_NOTOUCH,
        ROCK_BOSS_NONBLAST_SKILL,
        ROCK_NONBLAST,
        PLANT_MATERIAL_BOSS_SKILL_WALL,
        NONE_MATERIAL_NOTOUCH,
        NONE_MATERIAL_SOUTH_NOTOUCH,
        NONE_MATERIAL_WEST_NOTOUCH,
        NONE_MATERIAL_NORTH_NOTOUCH,
        NONE_MATERIAL_EAST_NOTOUCH,
        NONE_BOSS_MATERIAL_NOTOUCH_NONBLAST_SKILL,
        NONE_MATERIAL_NOTOUCH_NOHIDING,
        NONE_MATERIAL_NOTOUCH_NOHIDING_SKILL,
        NONE_MATERIAL_NOHIDING_SKILL,
        NONE_MATERIAL_NOTOUCH_NOHIDING_SKILL_MOVENOTCEL,
        NONE_BOSS_MATERIAL_NOTOUCH_NONBLAST_SKILL_MOVENOTCELL,
        NONE_BOSS_NONBLAST_SKILL,
        NONE_MATERIAL_NOTOUCH_NOHIDING_NONBLAST_SKILL,
        NONE_MATERIAL_NOTOUCH_NOHIDING_NONBLAST_SKILL_NORTH,
        NONE_MATERIAL_NOTOUCH_NOHIDING_NONBLAST_SKILL_SOUTH,
        NONE_MATERIAL_NOTOUCH_NOHIDING_NONBLAST_SKILL_EAST,
        NONE_MATERIAL_NOTOUCH_NOHIDING_NONBLAST_SKILL_WEST,
        MAGIC_CREATURE_NOTOUCH_NOHIDING_NONBLAST_SKILL,
        NONE_MATERIAL_NOTOUCH_NOHIDING_NONBLAST_SKILL_SOUTH_VISIONMAX,
        NONE_BOSS_MATERIAL_NOTOUCH_NONBLAST_SKILL_NOHIDING_VISIONMAX_NOINFO,
        NONE_BOSS_MATERIAL_NOTOUCH_NOHIDING_NONBLAST_NOINFO,
        HUMAN_BOSS_NONBLAST,
        MAGIC_CREATURE_BOSS_NONBLAST_SKILL,
        UNDEAD_BOSS_NONBLAST,
        NONE_MATERIAL,
        NONE_BOSS_MATERIAL_NOTOUCH_NONBLAST_SKILL_MOVENOTCELL_NOHIDING_VISIONMAX_NOINFO,
        NONE_BOSS_MATERIAL_SOUTH_NOTOUCH_NONBLAST_SKILL_NOHIDING_VISIONMAX_NOINFO,
        NONE_BOSS_MATERIAL_SOUTH_NOTOUCH_NONBLAST_SKILL_MOVENOTCELL_NOHIDING_VISIONMAX_NOINFO,
        NONE_BOSS_NONBLAST_SKILL_NOHIDING_NOSKETCH,
        NONE_BOSS_NONBLAST_SKILL_NOHIDING_NOSKETCH_PARTNERNOTOUCH,
        ROCK_BOSS_NONBLAST_SKILL_NOHIDING_NOSKETCH_PARTNERNOTOUCH,
        NONE_BOSS_MATERIAL_NOTOUCH_NONBLAST_SKILL_NOHIDING_NOHPVIEW_NOINFO,
        NONE_MATERIAL_NOTOUCH_NOHIDING_MOVENOTCELL_NOHPVIEW_NODIR_NOINFO,
        ROCK_BOSS_NONBLAST_SKILL_NOSKETCH,
        NONE_MATERIAL_NOTOUCH_NOHIDING_MOVENOTCELL_NOHPVIEW_NOINFO,
        UNDEAD_NOSKETCH,
        NONE_MATERIAL_NOTOUCH_NOHIDING_MOVENOTCELL_NOHPVIEW_SKILL_NOINFO,
        MAGIC_CREATURE_BOSS_NOSKETCH,
        HUMAN_BOSS_NOSKETCH,
        ANIMAL_NOHIDING_NODEATH_NOSKETCH,
        NONE_BOSS_MATERIAL_NONBLAST_SKILL_MOVENOTCELL_NOHIDING_VISIONMAX_NOSKETCH_NOERASETIME_DAMAGE1,
        NONE_MATERIAL_NOTOUCH_NOHIDING_MOVENOTCELL_NOHPVIEW_NODIR_NOINFO_NOSKETCH,
        ELEMENT_BOSS_NOTOUCH_NONBLAST_NOSKETCH_NOCAMCHK,
        ELEMENT_BOSS_NONBLAST_NOHIDING_NOSKETCH_NOCAMCHK_SKILL_LVDIFF,
        ELEMENT_BOSS_NONBLAST_NOSKETCH_NODEATH_NONBLAST_SKILL,
        NONE_MATERIAL_NOTOUCH_NONBLAST_NOHIDING_NOINFO_SKILL,
        NONE_NOTOUCH_MOVENOTCELL,
        NONE_NOTOUCH,
        NONE_BOSS_NODEATH_NONBLAST_NOHPVIEW,
        NONE_BOSS_NODEATH_NONBLAST_VISIONMAX_NOHPVIEW,
        MACHINE_SKILL_BOSS_SKILL,
    }
}