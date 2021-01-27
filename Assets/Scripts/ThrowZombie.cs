using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowZombie : MonoBehaviour
{
    private float waitedTime;

    public float waitTimeAttack = 3;

    public GameObject ballPrefab;

    public Transform launchSpawnPoint;

    private void Start()
    {
        waitedTime = waitTimeAttack;

    }

    private void Update()
    {
        if(waitedTime <= 0){

            waitedTime = waitTimeAttack;
            Invoke("LaunchBall",0.5f);

        }else{
            waitedTime -=Time.deltaTime;
        }
    }

    public void LaunchBall(){

        GameObject newBall;
        newBall= Instantiate(ballPrefab,launchSpawnPoint.position,launchSpawnPoint.rotation);

    }


}
