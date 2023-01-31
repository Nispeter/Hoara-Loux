using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : AbstractGrid
{
    private static int mult = 7;
    public GameObject[] spawn = new GameObject[mult];
    /*
    spawn[0] = enemy_01
    spawn[1] = coin
    */

    public float[] intervalDecrement = new float[mult];
    public float[] spawnInterval = new float[mult];
    public float[] timeUntilSpawn = new float[mult];

    private float varY;

    new void Start(){
        setVars();
        setSpawn();
        
    }

    private void setVars(){
        varY = transform.position.y;
    }

    private void setSpawn(){
        for(int i = 0; i <= mult; i++){
            StartCoroutine(SpawnEnemy(spawnInterval[i], spawn[i],i,0));
        }
    }
    
    private IEnumerator WaitInit(float interval){
        yield return new WaitForSeconds(interval);
    }

    private IEnumerator SpawnEnemy( float interval, GameObject enemy, int n, int id){
        if(id == 0)
            yield return WaitInit(timeUntilSpawn[n]);
        else 
            yield return WaitInit(interval);
        int tempSpace = checkSpawnPos(n);
        float tempPos = fixedPositions[tempSpace];
        
        GameObject newEnemy = Instantiate(enemy, new Vector3 (tempPos, varY, 1), Quaternion.identity);
        if(tempSpace >= columnCounter/2 && (n == 2 || n == 4)){ //change this crappy solution eventually.
            newEnemy.transform.localScale =  new Vector3(newEnemy.transform.localScale.x * -1,newEnemy.transform.localScale.y,1);
        }
        id = IncrementDifficulty(n,id);     //Mala solucion
        
        StartCoroutine(SpawnEnemy(spawnInterval[n], enemy, n, id+1)); 
    }

    private int IncrementDifficulty(int n, int id){
        if(id > 25 && spawnInterval[n] > 0.4f){
            id -= 25;
            spawnInterval[n] -= intervalDecrement[n];
        }
        return id;
    }

    private int checkSpawnPos(int n){
        if(n == 2 || n == 6)
            return Random.Range(columnCounter/2 - 1,columnCounter/2+1);
        if(n == 4 || n == 7){
            int temp = Random.Range(0,2);
            if(temp == 0){
                return 0;
            }
            return columnCounter-1;
        }
        return Random.Range(0,columnCounter);
    }
}
