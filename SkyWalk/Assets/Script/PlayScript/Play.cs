﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{   private int i =1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(i<1000){
            Debug.Log(i);
            i++;
        }
        else{
            SceneManager.LoadScene("SelectScene");
        }
    }
}
