using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData_SO", menuName = "Data/PlayerData")]
public class PlayerData_SO : ScriptableObject
{
    /// <summary>
    /// 主角的作为调教师的属性
    /// </summary>
    [Header("角色数据")]
    [Header("ID与头像")]
    public string playerName;
    public Sprite playerIcon;
    public Sprite playerOnWorldSprite;
    [Multiline]public string playerDescription;//玩家介绍
    [Space(10)]


    [Header("基础数据")]
    [Header("体力,上限1000")]
    [Range(0,1000)]public int playerPhysical;
    [Header("金钱，初始为0")]
    public int playerTired;
    [Space(10)]


    [Header("角色状态")]
    [Header("异常状态")]
    public AbnormalStateType abnormalStateType;
    [Space(10)]


    [Header("成长属性经验，最高经验值未定，最高等级10级")]
    [Header("技巧，初始为0,技巧影响调教进度")]
    public int technique;
    [Range(0, 10)] public int techniqueLevel;
    [Header("体能，初始为0，体能影响调教的体力消耗以及受到反抗时的压制能力")]
    public int physicalFitness;
    [Range(0, 10)] public int physicalFitnessLevel;
    [Header("意志，初始为0，意志影响疼痛和抗性以及受到诱惑时的压制能力")]
    public int volition;
    [Range(0, 10)] public int volitionLevel;
    [Header("支配，初始为0，支配影响主动以及减少反抗的几率")]
    public int dominate;
    [Range(0, 10)] public int dominateLevel;
    [Header("学识，初始为0，学识影响学习能力与技术力，能使用更多道具")]
    public int knowledge;
    [Range(0, 10)] public int knowledgeLevel;
    [Header("淫乱，初始为0，淫乱影响色情行为时的选项和结果以及诱惑时的成功率")]
    public int promiscuous;
    [Range(0, 10)] public int promiscuousLevel;
    [Space(10)]


    [Header("角色技能，最高经验值未定，最高等级10级")]
    [Header("田径跑步，初始为0，增加抓捕时的成功率")]
    public int trackFieldSkill;
    [Range(0, 10)] public int trackFieldSkillLevel;
    [Header("口才，初始为0，增加诱拐，欺骗的成功率")]
    public int eloquence;
    [Range(0, 10)] public int eloquenceSkillLevel;
    [Header("隐匿，初始为0，增加尾随，逃跑的成功率")]
    public int concealment;
    [Range(0, 10)] public int concealmentSkillLevel;
    [Header("家务，初始为0，需要时常打扫来保证npc不会得病")]
    public int houseworkSkill;
    [Range(0, 10)] public int houseworkSkillLevel;
    [Header("照护，初始为0，用来照顾受伤与得病的npc")]
    public int nurseSkill;
    [Range(0, 10)] public int nurseSkillLevel;
    [Header("鉴定，初始为0，用于在黑市发掘能力更高的npc")]
    public int identifySkill;
    [Range(0, 10)] public int identifySkillLevel;
    [Space(10)]


    [Header("性技，最高经验值未定，最高等级10级。用于提升相关部位的调教程度")]
    [Header("口，初始为0")]
    public int oralTechnique;
    [Range(0, 10)] public int oralTechniqueLevel;
    [Header("胸，初始为0")]
    public int chestTechnique;
    [Range(0, 10)] public int chestTechniqueLevel;
    [Header("手，初始为0")]
    public int chiralityTechnique;
    [Range(0, 10)] public int chiralityTechniqueLevel;
    [Header("阴部，初始为0")]
    public int pudendalTechnique;
    [Range(0, 10)] public int pudendalTechniqueLevel;
    [Header("后庭，初始为0")]
    public int vestibularTechnique;
    [Range(0, 10)] public int vestibularTechniqueLevel;
    [Header("脚，初始为0")]
    public int footworkTechnique;
    [Range(0, 10)] public int footworkTechniqueLevel;






    //———————————————未调整—————————————————


    [Header("升级相关")]
    public int experience = 0;
    public int level = 1;
    public int experienceCap;
    [System.Serializable]
    public class LevelRange
    {
        public int startLevel;
        public int endLevel;
        public int experienceCapIncrease;
    }
    public List<LevelRange> levelRanges;
    #region 升级程序
    //void LevelUpChecker()
    //{
    //    if (experience >= experienceCap)
    //    {
    //        level++;
    //        experience -= experienceCap;

    //        int experienceCapIncrease = 0;
    //        foreach (LevelRange range in levelRanges)
    //        {
    //            if (level >= range.startLevel && level <= range.endLevel)
    //            {
    //                experienceCapIncrease = range.experienceCapIncrease;
    //                break;
    //            }
    //            experienceCap += experienceCapIncrease;

    //            //UpdateLevelText();

    //            //GameManager.instance.StartLevelUp();
    //        }
    //    }
    //}
    //void UpdateExpBar()
    //{
    //    expBar.fillAmount = (float)experience / experienceCap;
    //}
    #endregion 

    public bool isDead;
    public bool attackable;
    public bool removable;
    public bool invincible;
}
