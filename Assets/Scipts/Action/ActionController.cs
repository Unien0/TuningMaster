using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    public PlayerData_SO PlayerData;
    #region SO数据
    public int playerPhysical//体力
    {
        get { if (PlayerData != null) return PlayerData.playerPhysical; else return 0; }
        set { PlayerData.playerPhysical = value; }
    }
    public int playerTired//钱
    {
        get { if (PlayerData != null) return PlayerData.playerTired; else return 0; }
        set { PlayerData.playerTired = value; }
    }
    public AbnormalStateType abnormalStateType//状态
    {
        get { if (PlayerData != null) return PlayerData.abnormalStateType; else return 0; }
        set { PlayerData.abnormalStateType = value; }
    }
    public int technique//技巧
    {
        get { if (PlayerData != null) return PlayerData.technique; else return 0; }
        set { PlayerData.technique = value; }
    }
    public int techniqueLevel//技巧等级
    {
        get { if (PlayerData != null) return PlayerData.techniqueLevel; else return 0; }
        set { PlayerData.techniqueLevel = value; }
    }
    #endregion

    public void PlayerSleep(int PhysicalToRestore)
    {
        //体力恢复
        if (playerPhysical + PhysicalToRestore < 1000)
        {
            playerPhysical += PhysicalToRestore;
        }
        else
        {
            playerPhysical = 1000;//体力最大值
        }
        //时间过去两个小时段

        //音效

        //特效
    }
}
