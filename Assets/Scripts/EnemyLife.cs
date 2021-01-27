using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public GameObject muerteZombie;
    // Start is called before the first frame update
    public void EnemyDamaged(){
        Instantiate(muerteZombie);
        Invoke("Muerte",0.2f);
    }
    
    public void Muerte(){
    Destroy(gameObject);
    }

}

