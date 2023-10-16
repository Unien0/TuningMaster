public enum PersonaType
{

}

public enum ItemType
{
    Melee, Bow,//近战和远程
    Crystal,Money,//经验结晶和钱
    Consumables

}

public enum FatigueStateType
{
    Sleep,Rest,Sober, Motion
    //睡眠，休息，清醒，运动（根据事件决定消耗）
}

public enum StarvationType
{
    Satiety,Hunger, Malnutrition, HungryDizziness
    //饱腹，饥饿，营养不良，饿晕
}

public enum PainStateType
{
    Normal,Defeat, DifficultMove, Incapacitated, Coma
    //正常，战败，难以移动，无法行动，昏迷
}

public enum AbnormalStateType
{
    Normal,
    Coma,Stupor,Fetter, Charm
    //昏迷，恍惚，束缚，魅惑
}