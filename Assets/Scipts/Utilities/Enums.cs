public enum PersonaType
{

}

public enum ItemType
{
    Melee, Bow,//近战和远程
    Crystal,Money,//经验结晶和钱
    Consumables

}


//目前主要是改变女性角色的状态

/// <summary>
/// 行为状态
/// </summary>
public enum FatigueStateType
{
    Rest,Sober, Motion
    //休息，清醒，调教中
}

/// <summary>
/// 饥饿状态
/// </summary>
public enum StarvationType
{
    Satiety,Hunger, Malnutrition, HungryDizziness
    //饱腹，饥饿，营养不良，饿晕
}

/// <summary>
/// 调教时状态
/// </summary>
public enum PainStateType
{
    Normal, Exciting, DifficultMove, Incapacitated, Coma
    //正常，战败，难以移动，拘束，昏迷
}

/// <summary>
/// 性状态
/// </summary>
public enum NPCSpecialState
{
    None,
    Desire, Sensitive,
    //渴望，敏感
    Exhausted,
    //疲惫：体力耗尽时触发
}

//主角的状态
public enum AbnormalStateType
{
    Normal,
    Depression, Fatigue, Enthusiasm
    //沮丧、疲倦、狂热
}