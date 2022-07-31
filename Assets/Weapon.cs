using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform target;

    public Vector3 desPosition;
    public float speed = 10;

    private void Start()
    {
        desPosition = target.position;
    }
    void Update()
    {
        Vector3 direction = (desPosition - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
