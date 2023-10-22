using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    [Header("物品数据，ID以2开头")]
    [Header("ID与头像")]
    public int itemID;
    public string itemName;
    public ItemType ItemType;
    public Sprite itemIcon;
    public Sprite itemOnWorldSprite;
    public string itemDescription;

    [Header("基础数据")]
    public int itemUseRadius;
    [Range(0, 5)]
    public int itemPrice;

    [Header("物品状态")]
    public bool canPickedup;

}