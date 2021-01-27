using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vaccine : MonoBehaviour
{
    public GameObject sonidoVictoria;

    public Text vacunaConceguida;
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {   

            GetComponent<SpriteRenderer>().enabled = false;

            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            collision.transform.GetComponent<PlayerRespawn>().PlayerLife();
            vacunaConceguida.gameObject.SetActive(true);
            Instantiate(sonidoVictoria);     
            Invoke("QuitarTexto",1);
            Destroy(gameObject, 1.5f);
            
        }
    } 

    

    void QuitarTexto()
    {
        Debug.Log("hola");
        vacunaConceguida.gameObject.SetActive(false);
    }
}
