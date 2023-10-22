using UnityEngine;

[System.Serializable]
public class NPCDetails
{
    [Header("角色数据，ID以0001开头")]
    [Header("ID与头像")]
    public int npcID;
    public string npcName;
    public Sprite npcIcon;
    public Sprite npcOnWorldSprite;
    [Multiline] public string npcDescription;//NPC介绍
    [Space(10)]


    [Header("基础数据")]
    [Header("体力,上限1000")]
    [Range(0, 1000)] public int npcPhysical;
    [Header("信赖,上限1000")]
    [Range(0, 1000)] public int npcRely;
    [Header("爱欲,上限1000")]
    [Range(0, 1000)] public int npcEros;
    [Space(10)]


    [Header("角色状态")]
    [Header("行为状态")]
    public FatigueStateType fatigueStateType;
    [Header("营养状态")]
    public StarvationType starvationType;
    [Header("调教时状态")]
    public PainStateType painStateType;
    [Header("性状态")]
    public NPCSpecialState npcSpecialState;
    [Space(10)]


    //游戏中有些订单会要求一些特殊的属性
    [Header("成长属性经验，最高经验值未定，最高等级10级")]
    [Header("淫乱，淫乱影响色情行为时的选项和结果以及诱惑时的成功率")]
    public int npcPromiscuous;
    [Range(0, 10)] public int npcPromiscuousLevel;
    [Header("技巧,影响部位的学习能力")]
    public int npcTechnique;
    [Range(0, 10)] public int npcTechniqueLevel;
    [Header("体能，体能影响调教的体力消耗以及受到反抗时的能力")]
    public int npcPhysicalFitness;
    [Range(0, 10)] public int npcPhysicalFitnessLevel;
    [Header("S，施虐倾向，影响主动以及反抗的几率")]
    public int npcSadism;
    [Range(0, 10)] public int npcSadismLevel;
    [Header("M，受虐倾向，影响疼痛和抗性以及诱惑的几率")]
    public int npcMasochism;
    [Range(0, 10)] public int npcMasochismLevel;
    [Space(10)]

    //游戏中有些订单会要求一些特殊的属性
    [Header("性技，最高经验值未定，最高等级10级。用于提升相关部位的调教程度")]
    [Header("口")]
    public int npcOralTechnique;
    [Range(0, 10)] public int npcOralTechniqueLevel;
    [Header("胸")]
    public int npcChestTechnique;
    [Range(0, 10)] public int npcChestTechniqueLevel;
    [Header("手")]
    public int npcChiralityTechnique;
    [Range(0, 10)] public int npcChiralityTechniqueLevel;
    [Header("阴部")]
    public int npcPudendalTechnique;
    [Range(0, 10)] public int npcPudendalTechniqueLevel;
    [Header("后庭")]
    public int npcVestibularTechnique;
    [Range(0, 10)] public int npcVestibularTechniqueLevel;
    [Header("脚")]
    public int npcFootworkTechnique;
    [Range(0, 10)] public int npcFootworkTechniqueLevel;

    [Header("角色技能")]
    [Header("跑步，增加逃跑时的成功率")]
    public int trackFieldSkill;
    [Range(0, 10)] public int trackFieldSkillLevel;
    [Header("口才，增加欺骗的成功率")]
    public int eloquence;
    [Range(0, 10)] public int eloquenceSkillLevel;
    [Header("隐匿，增加躲避的成功率")]
    public int concealment;
    [Range(0, 10)] public int concealmentSkillLevel;
    [Header("家务，需要时常打扫来保证npc不会得病")]
    public int houseworkSkill;
    [Range(0, 10)] public int houseworkSkillLevel;
    [Header("照护，用来照顾受伤与得病的npc")]
    public int nurseSkill;
    [Range(0, 10)] public int nurseSkillLevel;
    [Header("鉴定，用于在作为副手时的管理")]
    public int identifySkill;
    [Range(0, 10)] public int identifySkillLevel;
    [Space(10)]


    //词条系统



    [Header("死亡状态")]
    public bool isDead;

}
