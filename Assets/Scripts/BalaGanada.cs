using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaGanada : MonoBehaviour
{
    public GameObject audioVida;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {   
            Instantiate(audioVida);
            GetComponent<SpriteRenderer>().enabled = false;

            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            
            collision.transform.GetChild(4).GetComponent<Shotgun>().municionExtra();
            Debug.Log("Hola");
            Destroy(gameObject, 0.5f);


        }

    }
}
