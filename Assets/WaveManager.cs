using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    static public WaveManager instance;
    void Awake() => instance = this;
    void OnDestroy() => instance = null;
    public WaveInfo[] waves;


    public int currentWave = 0;
    public Transform startPosition;
    public float spawnRange = 1;
    public Transform destination;
    public void StartNextWave()
    {
        var wave = waves[currentWave];
        for (int i = 0; i < wave.spawnCount; i++)
        {
            NewMethod(wave.monster);
        }
        currentWave++;
    }

    private void NewMethod(Monster monster)
    {
        var newMonster = Instantiate(monster);
        var startPos = startPosition.transform.position;
        startPos += new Vector3(Random.Range(-spawnRange, spawnRange),
            Random.Range(-spawnRange, spawnRange), 0);
        newMonster.transform.position = startPos;
        newMonster.SetDestination(destination.position);
    }
}

[System.Serializable]
public class WaveInfo
{
    public Monster monster;
    public int spawnCount = 5;
}
