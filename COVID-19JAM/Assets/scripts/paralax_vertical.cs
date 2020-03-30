using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax_vertical : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject cam;
    public float parallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.y;
        lenght = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(pause.game_status == 1 || pause.game_status == 0)
        {
            float dist = Mathf.Repeat(Time.time * parallaxEffect, lenght);
            transform.position = new Vector3(transform.position.x, startpos + dist, transform.position.z);
        }
    }
}
