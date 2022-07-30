using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum WeaponType
{
    Arrow,
    Shield,
    Magic,
    Bomb,
}
public class WeaponButton : MonoBehaviour
{
    public WeaponType weapon;
    public GameObject icon;
    public GameObject checkMark;
    public TextMeshProUGUI priceText;


    public void Init()
    {
        icon.SetActive(true);
        checkMark.SetActive(false);
    }
    void OnMouseDown()
    {
        if (checkMark.activeSelf == false)
        {
            print($"{weapon} 건물 지을지 선택체크 박스 보여주기");
            icon.SetActive(false);
            checkMark.SetActive(true);
        }
        else
        {
            print($"{weapon} 건물 짓자");

        }
    }
}
