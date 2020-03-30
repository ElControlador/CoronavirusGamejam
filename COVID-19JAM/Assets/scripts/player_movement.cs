using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{
    public float velocidad = 5f;
    public Rigidbody2D rb;

    Vector2 movimiento;
    private Vector2 currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pause.game_status == 1)
        {
            movimiento.x = Input.GetAxisRaw("Horizontal");

            movimiento.y = 0;
        }
        
        
    }
    private void FixedUpdate()
    {
        if (pause.game_status == 1)
        {
            currentPosition = rb.position + movimiento * velocidad * Time.fixedDeltaTime;
            if (!(currentPosition.x <= -2 || currentPosition.x >= 2))
            {
                rb.MovePosition(currentPosition);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("objeto"))
        {
            scoreScript.score++;
            song_manager.Playsound(0);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("enemigo"))
        {
            song_manager.Playsound(1);
            if(scoreScript.score >= scoreScript.record_score)
            {
                scoreScript.record_score = scoreScript.score;
            }
            Destroy(gameObject);
            pause.game_status = 3;
        }

    }
    

}
