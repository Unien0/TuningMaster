using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearChild : MonoBehaviour
{
    public void ClearChilds(Transform parent)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
