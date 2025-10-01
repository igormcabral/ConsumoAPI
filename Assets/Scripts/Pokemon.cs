using UnityEngine;

[System.Serializable]
public class Pokemon
{
    public Ability[] abilities;
    public int base_experience;
    public Cries cries;
    public Form[] forms;
    public Game_Indices[] game_indices;
    public int height;
    public Held_Items[] held_items;
    public int id;
    public bool is_default;
    public string location_area_encounters;
    public Move[] moves;
    public string name;
    public int order;
    public Past_Abilities[] past_abilities;
    public string[] past_types;
    public Species species;
    public Sprites sprites;
    public Stat[] stats;
    public Type[] types;
    public int weight;
}

[System.Serializable]
public class Cries
{
    public string latest;
    public string legacy;
}

[System.Serializable]
public class Species
{
    public string name;
    public string url;
}

[System.Serializable]
public class Sprites
{
    public string back_default;
    public string back_female;
    public string back_shiny;
    public string back_shiny_female;
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
    public Other other;
    public Versions versions;
}

[System.Serializable]
public class Other
{
    public Dream_World dream_world;
    public Home home;
    public OfficialArtwork officialartwork;
    public Showdown showdown;
}

[System.Serializable]
public class Dream_World
{
    public string front_default;
    public string front_female;
}

[System.Serializable]
public class Home
{
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class OfficialArtwork
{
    public string front_default;
    public string front_shiny;
}

[System.Serializable]
public class Showdown
{
    public string back_default;
    public string back_female;
    public string back_shiny;
    public string back_shiny_female;
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class Versions
{
    public GenerationI generationi;
    public GenerationIi generationii;
    public GenerationIii generationiii;
    public GenerationIv generationiv;
    public GenerationV generationv;
    public GenerationVi generationvi;
    public GenerationVii generationvii;
    public GenerationViii generationviii;
}

[System.Serializable]
public class GenerationI
{
    public RedBlue redblue;
    public Yellow yellow;
}

[System.Serializable]
public class RedBlue
{
    public string back_default;
    public string back_gray;
    public string back_transparent;
    public string front_default;
    public string front_gray;
    public string front_transparent;
}

[System.Serializable]
public class Yellow
{
    public string back_default;
    public string back_gray;
    public string back_transparent;
    public string front_default;
    public string front_gray;
    public string front_transparent;
}

[System.Serializable]
public class GenerationIi
{
    public Crystal crystal;
    public Gold gold;
    public Silver silver;
}

[System.Serializable]
public class Crystal
{
    public string back_default;
    public string back_shiny;
    public string back_shiny_transparent;
    public string back_transparent;
    public string front_default;
    public string front_shiny;
    public string front_shiny_transparent;
    public string front_transparent;
}

[System.Serializable]
public class Gold
{
    public string back_default;
    public string back_shiny;
    public string front_default;
    public string front_shiny;
    public string front_transparent;
}

[System.Serializable]
public class Silver
{
    public string back_default;
    public string back_shiny;
    public string front_default;
    public string front_shiny;
    public string front_transparent;
}

[System.Serializable]
public class GenerationIii
{
    public Emerald emerald;
    public FireredLeafgreen fireredleafgreen;
    public RubySapphire rubysapphire;
}

[System.Serializable]
public class Emerald
{
    public string front_default;
    public string front_shiny;
}

[System.Serializable]
public class FireredLeafgreen
{
    public string back_default;
    public string back_shiny;
    public string front_default;
    public string front_shiny;
}

[System.Serializable]
public class RubySapphire
{
    public string back_default;
    public string back_shiny;
    public string front_default;
    public string front_shiny;
}

[System.Serializable]
public class GenerationIv
{
    public DiamondPearl diamondpearl;
    public HeartgoldSoulsilver heartgoldsoulsilver;
    public Platinum platinum;
}

[System.Serializable]
public class DiamondPearl
{
    public string back_default;
    public string back_female;
    public string back_shiny;
    public string back_shiny_female;
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class HeartgoldSoulsilver
{
    public string back_default;
    public string back_female;
    public string back_shiny;
    public string back_shiny_female;
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class Platinum
{
    public string back_default;
    public string back_female;
    public string back_shiny;
    public string back_shiny_female;
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class GenerationV
{
    public BlackWhite blackwhite;
}

[System.Serializable]
public class BlackWhite
{
    public Animated animated;
    public string back_default;
    public string back_female;
    public string back_shiny;
    public string back_shiny_female;
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class Animated
{
    public string back_default;
    public string back_female;
    public string back_shiny;
    public string back_shiny_female;
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class GenerationVi
{
    public OmegarubyAlphasapphire omegarubyalphasapphire;
    public XY xy;
}

[System.Serializable]
public class OmegarubyAlphasapphire
{
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class XY
{
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class GenerationVii
{
    public Icons icons;
    public UltraSunUltraMoon ultrasunultramoon;
}

[System.Serializable]
public class Icons
{
    public string front_default;
    public string front_female;
}

[System.Serializable]
public class UltraSunUltraMoon
{
    public string front_default;
    public string front_female;
    public string front_shiny;
    public string front_shiny_female;
}

[System.Serializable]
public class GenerationViii
{
    public Icons1 icons;
}

[System.Serializable]
public class Icons1
{
    public string front_default;
    public string front_female;
}

[System.Serializable]
public class Ability
{
    public Ability1 ability;
    public bool is_hidden;
    public int slot;
}

[System.Serializable]
public class Ability1
{
    public string name;
    public string url;
}

[System.Serializable]
public class Form
{
    public string name;
    public string url;
}

[System.Serializable]
public class Game_Indices
{
    public int game_index;
    public Version version;
}

[System.Serializable]
public class Version
{
    public string name;
    public string url;
}

[System.Serializable]
public class Held_Items
{
    public Item item;
    public Version_Details[] version_details;
}

[System.Serializable]
public class Item
{
    public string name;
    public string url;
}

[System.Serializable]
public class Version_Details
{
    public int rarity;
    public Version1 version;
}

[System.Serializable]
public class Version1
{
    public string name;
    public string url;
}

[System.Serializable]
public class Move
{
    public Move1 move;
    public Version_Group_Details[] version_group_details;
}

[System.Serializable]
public class Move1
{
    public string name;
    public string url;
}

[System.Serializable]
public class Version_Group_Details
{
    public int level_learned_at;
    public Move_Learn_Method move_learn_method;
    public string order;
    public Version_Group version_group;
}

[System.Serializable]
public class Move_Learn_Method
{
    public string name;
    public string url;
}

[System.Serializable]
public class Version_Group
{
    public string name;
    public string url;
}

[System.Serializable]
public class Past_Abilities
{
    public Ability2[] abilities;
    public Generation generation;
}

[System.Serializable]
public class Generation
{
    public string name;
    public string url;
}

[System.Serializable]
public class Ability2
{
    public string ability;
    public bool is_hidden;
    public int slot;
}

[System.Serializable]
public class Stat
{
    public int base_stat;
    public int effort;
    public Stat1 stat;
}

[System.Serializable]
public class Stat1
{
    public string name;
    public string url;
}

[System.Serializable]
public class Type
{
    public int slot;
    public Type1 type;
}

[System.Serializable]
public class Type1
{
    public string name;
    public string url;
}