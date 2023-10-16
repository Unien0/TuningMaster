using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData_SO", menuName = "Data/PlayerData")]
public class PlayerData_SO : ScriptableObject
{
    [Header("角色数据")]
    [Header("ID与头像")]
    public string playerName;
    public Sprite playerIcon;
    public Sprite playerOnWorldSprite;
    [Multiline]public string playerDescription;//玩家介绍
    [Space(10)]
    [Header("基础数据")]
    [Header("营养,初始为5000")]
    [Range(0,5000)]public int playerNutrition;//营养
    [Header("疲劳，初始为0")]
    [Range(0,2000)]public int playerTired;//疲劳
    [Header("情绪，初始为0")]
    [Range(-500,500)] public int playerEmotion;//情绪
    [Header("压力，初始为0")]
    [Range(0, 1000)] public int playerPressure;//压力
    [Header("疼痛，初始为0")]
    [Range(0, 200)] public int playerPain;//疼痛
    [Header("信心，初始为0")]
    [Range(-500,500)] public int playerConfidence;//信心
    [Header("专注，初始为5000")]
    [Range(0, 5000)] public int playerConcentration;//专注
    [Header("魅力，初始为0")]
    [Range(0, 5000)] public int playerCharm;//魅力
    [Header("魅惑，初始为0")]
    [Range(0, 5000)] public int playerGlamour;//魅惑
    [Header("高潮，初始为0")]
    [Range(0, 1000)] public int playerClimax;//高潮
    [Space(10)]
    [Header("角色状态")]
    [Header("疲劳状态，睡眠-250/h，休息-150/10min，清醒+1/min，运动（另算）")]
    public FatigueStateType fatigueStateType;
    [Header("营养状态，日常行动-1/min，运动或体力劳动-4/min，饥饿状态下压力随之增长")]
    public StarvationType starvationType;
    [Header("疼痛状态，日常行动-10/h，睡眠-20/h，治疗后-50/h，在疼痛超过100时无法战斗")]
    public PainStateType painStateType;
    [Header("异常状态")]
    public AbnormalStateType abnormalStateType;

    [Space(10)]
    [Header("成长属性经验，最高经验值未定，最高等级10级")]
    [Header("容貌，初始为0,容貌影响魅力与吸引力")]
    public int beautiful;
    [Range(0, 10)] public int beautifulLevel;
    [Header("体能，初始为0，体能影响战斗")]
    public int physicalFitness;
    [Range(0, 10)] public int physicalFitnessLevel;
    [Header("意志，初始为0，意志影响疼痛和抗性")]
    public int volition;
    [Range(0, 10)] public int volitionLevel;
    [Header("支配，初始为0，支配影响主动")]
    public int dominate;
    [Range(0, 10)] public int dominateLevel;
    [Header("学识，初始为0，学识影响学习能力与技术力")]
    public int knowledge;
    [Range(0, 10)] public int knowledgeLevel;
    [Header("淫乱，初始为0，淫乱影响色情行为时的选项和结果")]
    public int promiscuous;
    [Range(0, 10)] public int promiscuousLevel;
    [Header("露出，初始为0，露出影响露出的意愿度")]
    public int exhibitionism;
    [Range(0, 10)] public int exhibitionismLevel;
    [Header("异种，初始为0，异种影响异种行为时的选项和结果")]
    public int xenogenesis;
    [Range(0, 10)] public int xenogenesisLevel;
    [Space(10)]
    [Header("角色技能，最高经验值未定，最高等级10级")]
    [Header("田径跑步，初始为0")]
    public int trackFieldSkill;
    [Range(0, 10)] public int trackFieldSkillLevel;
    [Header("舞蹈，初始为0")]
    public int danceSkill;
    [Range(0, 10)] public int danceSkillLevel;
    [Header("家务，初始为0")]
    public int houseworkSkill;
    [Range(0, 10)] public int houseworkSkillLevel;
    [Header("种植，初始为0")]
    public int cultivateSkill;
    [Range(0, 10)] public int cultivateSkillLevel;
    [Header("照护，初始为0")]
    public int nurseSkill;
    [Range(0, 10)] public int nurseSkillLevel;
    [Header("鉴定，初始为0")]
    public int identifySkill;
    [Range(0, 10)] public int identifySkillLevel;
    [Header("机械师，初始为0")]
    public int mechanicSkill;
    [Range(0, 10)] public int mechanicSkillLevel;
    [Header("欺骗，初始为0")]
    public int deceiveSkill;
    [Range(0, 10)] public int deceiveSkillLevel;
    [Header("偷窃，初始为0")]
    public int stealSkill;
    [Range(0, 10)] public int stealSkillLevel;
    [Space(10)]
    [Header("学历等级，最高经验值未定，最高等级10级")]
    [Header("文学，初始为0")]
    public int literature;
    [Range(0, 10)] public int literatureLevel;
    [Header("数学，初始为0")]
    public int mathematics;
    [Range(0, 10)] public int mathematicsLevel;
    [Header("科学，初始为0")]
    public int science;
    [Range(0, 10)] public int scienceLevel;
    [Header("历史，初始为0")]
    public int history;
    [Range(0, 10)] public int historyLevel;
    [Header("地理，初始为0")]
    public int geography;
    [Range(0, 10)] public int geographyLevel;
    [Space(10)]
    [Header("性技，最高经验值未定，最高等级10级")]
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
