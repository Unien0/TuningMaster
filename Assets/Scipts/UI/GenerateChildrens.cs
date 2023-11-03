using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateChildrens : MonoBehaviour
{
    public GameObject ParentObject;
    public void AddChildren(GameObject childrens)
    {
        Instantiate(childrens, ParentObject.transform,false);
        //GameObject Child =Instantiate(childrens);
        //Child.transform.parent = ParentObject.transform;
        //Child.transform.localPosition = new Vector3(0, 0, 0);
    }

}
