﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EsperaCinematica : MonoBehaviour
{

  public float tiempo;
  void Start(){
  
  Invoke("ChangeScene",tiempo);
  }

void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


}
