using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_noplayer : MonoBehaviour
{
    public float speedH;
    public float speedV;
    public float limitposIz;
    public float limitposRight;
    private Vector2 position;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(pause.game_status == 1)
        {
            position = transform.position;
            position = new Vector2(position.x - speedH * Time.deltaTime, position.y - speedV * Time.deltaTime);
            transform.position = position;


            if (transform.position.x <= limitposIz || transform.position.x >= limitposRight)
            {
                speedH = -speedH;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
    }
}
