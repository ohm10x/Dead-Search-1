using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    // Start is called before the first frame update

    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;
    public GameObject[] hearts;
    private int life;

    void Start()
    {
        life = hearts.Length;
        if (PlayerPrefs.GetFloat("checkPointPositionX") != 0) {

            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }

    }

    private void CheckLife()
    {
        if(life < 1 ){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }else if(life < 2){
            hearts[1].gameObject.SetActive(false);
        }else if(life < 3){
            hearts[2].gameObject.SetActive(false);
        }
    }

    
    private void CheckLife2()
    {
        if(life == 2 ){
            hearts[1].gameObject.SetActive(true);
        }else if(life == 3){
             hearts[2].gameObject.SetActive(true);
        }
    }

    public void ReachedCheckPoint(float x, float y)
    {

        PlayerPrefs.SetFloat("checkPointPositionX", x);

        PlayerPrefs.SetFloat("checkPointPositionY", y);

    }

    public void PlayerDamaged()
    {
        
        life--;
        CheckLife();

    }

    public void PlayerLife(){
        if(life < 3){
            life++;
            CheckLife2();
        }
        
    }

}
