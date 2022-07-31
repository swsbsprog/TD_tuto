using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHelper : MonoBehaviour
{
    public bool disableOnStart = false;
    void Start()
    {
        if(disableOnStart) gameObject.SetActive(false);
    }
}
