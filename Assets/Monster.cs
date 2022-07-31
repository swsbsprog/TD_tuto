using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public void SetDestination(Vector3 pos)
    {
        GetComponent<IAstarAI>().destination = pos;
    }
}
