using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public float tiempoDeVida;
    void Start()
    {
        Destroy(gameObject,tiempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
