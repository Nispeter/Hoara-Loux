using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : AbstractGrid
{
    public GameObject enemy_01;
    public float intervalDecrement = 0.02f;

    [SerializeField] private float spawnInterval = 2f;
    private float varY;

    void Start(){
        varY = transform.position.y;
        StartCoroutine(SpawnEnemy(spawnInterval, enemy_01));
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy){
        yield return new WaitForSeconds(interval);
        float tempPos = fixedPositions[Random.Range(0,6)];
        GameObject newEnemy = Instantiate(enemy, new Vector3 (tempPos, varY, 0), Quaternion.identity);
        interval -= intervalDecrement;
        spawnInterval -= intervalDecrement;
        StartCoroutine(SpawnEnemy(interval, enemy)); 
    }
}
