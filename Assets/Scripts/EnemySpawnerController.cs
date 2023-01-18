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
        GameObject newEnemy = Instantiate(enemy, new Vector3 (fixedPositions[Random.Range(0,6)], varY, 0), Quaternion.identity);
        interval -= intervalDecrement;
        StartCoroutine(SpawnEnemy(interval, enemy)); 
    }
}
