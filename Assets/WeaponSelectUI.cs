using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelectUI : MonoBehaviour
{
    static public WeaponSelectUI instance;
    
    void Awake() => instance = this;    
    void OnDestroy() => instance = null;
    Animator animator;
    public WeaponButton[] weaponButtons;
    void Start()
    {
        gameObject.SetActive(false);
        animator = GetComponent<Animator>();
        weaponButtons = GetComponentsInChildren<WeaponButton>(true);
    }
    public void Show(Vector3 pos)
    {
        if (gameObject.activeSelf)
            return;

        transform.position = pos;
        gameObject.SetActive(true);
        
        animator.Play("ScaleUp", 0, 0);
        foreach (var item in weaponButtons)
            item.Init();
    }

    internal void OnSelectTower(WeaponType weapon)
    {
        var towerPrefab = GetTowerPrefab(weapon);
        var newTower = Instantiate(towerPrefab);
        newTower.transform.position = transform.position;
        gameObject.SetActive(false);
    }

    public List<Tower> towers = new();
    private Tower GetTowerPrefab(WeaponType type)
    {
        return towers.Find(x => x.weaponType == type);
    }
}
