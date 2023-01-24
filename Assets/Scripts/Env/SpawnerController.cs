using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : AbstractGrid
{
    private static int mult = 2;
    public GameObject[] spawn = new GameObject[mult];
    /*
    spawn[0] = enemy_01
    spawn[1] = coin
    */

    public float[] intervalDecrement = new float[mult];
    public float[] spawnInterval = new float[mult];

    private float varY;

    void Start(){
        setVars();
        StartCoroutine(SpawnEnemy(spawnInterval[0], spawn[0],0));
        StartCoroutine(SpawnEnemy(spawnInterval[1], spawn[1],1));
    }

    private void setVars(){
        varY = transform.position.y;
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy, int n){
        yield return new WaitForSeconds(interval);
        float tempPos = fixedPositions[Random.Range(0,columnCounter)];
        GameObject newEnemy = Instantiate(enemy, new Vector3 (tempPos, varY, 0), Quaternion.identity);
        interval -= intervalDecrement[n];
        spawnInterval[n] -= intervalDecrement[n];
        StartCoroutine(SpawnEnemy(interval, enemy, n)); 
    }
}
