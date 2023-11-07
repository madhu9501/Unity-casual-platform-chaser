using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
     public GameObject powerPrefab;
    private Vector2 spawnRange = new Vector2(15, -15);
    private int enemyCount;
    private int powerCount;
    private int enemyWave;
    //private Coroutine powerCoroutine =null;

    void Awake(){
        enemyWave = 0;
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyController>().Length;
        if(enemyCount == 0){
            enemyWave++;
            SpawnEnemy();
            SpawnPower();
        }
    }

    public void StartSpawning(){
        enabled = true;
        SpawnEnemy();
    }

    void SpawnEnemy(){
        for(int i=0; i<=enemyWave; i++){
            SpawnEntity(enemyPrefab);            
        }
    }

    void SpawnPower(){
        SpawnEntity(powerPrefab); 
    }

    private void SpawnEntity(GameObject entity){
        Vector3 spawnPos = new Vector3(
        Random.Range(spawnRange[0], spawnRange[1]), 
        entity.transform.position.y, 
        Random.Range(spawnRange[0], spawnRange[1]));
        Instantiate(entity, spawnPos, entity.transform.rotation);
    }

}
