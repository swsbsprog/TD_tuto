using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    void OnMouseDown()
    {
        print("�ǹ� ���� �޴� �����ֱ�");
        WeaponSelectUI.instance.Show(transform.position);
    }
}
