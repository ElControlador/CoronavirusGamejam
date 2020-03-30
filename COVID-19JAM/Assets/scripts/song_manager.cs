using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class song_manager : MonoBehaviour
{
    public static AudioClip player_hit, player_pick;
    static AudioSource audioScr;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        player_hit = Resources.Load<AudioClip>("payerhit");
        player_pick = Resources.Load<AudioClip>("playerpick");
        audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pause.game_status >= 2)
        {
            if(pause.game_status == 3)
            {
                //audioScr.PlayOneShot(player_hit);
                timer = timer + 0.02f;
            }
            if(timer >= 0.17f)
            {
                AudioListener.pause = true;
            }
            
        }
        else
        {
            AudioListener.pause = false;
        }

    }

    public static void Playsound(int clip)
    {
        if(clip == 0)
        {
            audioScr.PlayOneShot(player_pick);
        }
        if(clip == 1)
        {
            audioScr.PlayOneShot(player_hit);
           
        }
    }
}
