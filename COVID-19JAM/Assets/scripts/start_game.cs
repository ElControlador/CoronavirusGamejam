﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(pause.game_status != 3)
            {
                pause.game_status = 1;
            }
            else
            {
                SceneManager.LoadScene("game");
                scoreScript.score = 0;
                pause.game_status = 0;
            }
        }
    }
}
