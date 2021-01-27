using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class FinalFlag : MonoBehaviour
{   
    public GameObject sonidoVictoria;
    public Text levelCompleted;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Meta alcanzada");
            GetComponent<Animator>().enabled = true;
            Invoke("MessageWin",1);
            Invoke("ChangeScene",3);

        }
    } 

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    void MessageWin()
    {
        levelCompleted.gameObject.SetActive(true);
        Instantiate(sonidoVictoria); 
    }
}
