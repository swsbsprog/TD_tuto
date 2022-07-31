using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public WeaponType weaponType;

    HashSet<Collider2D> stayMonsters = new HashSet<Collider2D>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision);
        stayMonsters.Add(collision);
        if (attackTarget == null)
            attackTarget = stayMonsters.First().transform;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        stayMonsters.Remove(collision);
        if (attackTarget == collision.transform)
            attackTarget = null;
    }

    public Transform attackTarget;

    public float nextAttackableTime;
    private float attackCoolTime = 1f;

    private void Update()
    {
        if (nextAttackableTime > Time.time)
            return;
        if (attackTarget == null)
        {
            if(stayMonsters.Count > 0)
                attackTarget = stayMonsters.First().transform;

            if(attackTarget == null)
                return;
        }

        nextAttackableTime = Time.time + attackCoolTime;
        Attack(attackTarget);
    }

    public Weapon weapon;
    public Transform weaponSpawnPosition;
    private void Attack(Transform attackTarget)
    {
        var newWeapon = Instantiate(weapon);
        newWeapon.transform.position = weaponSpawnPosition.position;
        newWeapon.target = attackTarget;
    }
}
