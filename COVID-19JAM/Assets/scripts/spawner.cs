using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject elemento;
    public float maxPos;
    public float delayTimer = 3f;
    public float rango;
    public bool need_reset;
    private int contador_spawns;
    float timer;


    // Use this for initialization
    void Start()
    {
        timer = delayTimer;
        contador_spawns = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(pause.game_status == 1)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                if (need_reset == true && contador_spawns == 1)
                { //nunca salen a la vez el coronavirus y el presidente
                    timer = 48;
                    contador_spawns = 0;
                }
                else
                {
                    Vector3 enemyPos = new Vector3(Random.Range(maxPos - rango, maxPos + rango), transform.position.y, transform.position.x);

                    Instantiate(elemento, enemyPos, transform.rotation);
                    contador_spawns++;
                    timer = delayTimer;
                }

            }
        }
    }
}
