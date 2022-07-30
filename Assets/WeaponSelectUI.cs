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
        transform.position = pos;
        gameObject.SetActive(true);
        
        animator.Play("ScaleUp", 0, 0);
        foreach (var item in weaponButtons)
            item.Init();
    }
}
