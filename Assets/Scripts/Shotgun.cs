using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shotgun : MonoBehaviour
{

    public Text numeroBalas;

    public int balas = 2;

    private int municion;

    public SpriteRenderer spriteRenderer;

    public GameObject audioDisparo;
    public GameObject audioVacio;

    public GameObject bulletPrefab;

    public Transform launchSpawnPoint;

    private void Start()
    {
        municion = balas;

    }

    private void Update()
    {
        numeroBalas.text= municion.ToString();

        if (Input.GetKeyDown("x")) {
            if(municion > 0){
                Invoke("LaunchBullet",0);
                municion--;
            }else{
                Instantiate(audioVacio);
            }
        }         
        
    }

    public void LaunchBullet(){

        GameObject newBullet;
        newBullet= Instantiate(bulletPrefab,launchSpawnPoint.position,launchSpawnPoint.rotation);
        Instantiate(audioDisparo);

    }

    public void municionExtra(){
            municion = municion + 1;    
    }

    public void shotgunButton(){

        if(municion > 0){
                Invoke("LaunchBullet",0);
                municion--;
            }else{
                Instantiate(audioVacio);
            }
    }
}
