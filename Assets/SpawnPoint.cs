using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    void OnMouseDown()
    {
        print("건물 선택 메뉴 보여주기");
        WeaponSelectUI.instance.Show(transform.position);
    }
}
