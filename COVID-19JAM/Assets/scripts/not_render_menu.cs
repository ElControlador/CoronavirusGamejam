using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class not_render_menu : MonoBehaviour
{
    private Image background;
    public Image title;
    private Text start;
    public Text exit;
    public Text pausa;
    public Image marcador;
    public Text marcador_texto;
    public Text restart;
    public Text gameover;
    public Text your_score;
    public Text record;
    public Text final_score;
    public Text final_record;
    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        // title = GetComponentInChildren<Image>();
        start = GetComponentInChildren<Text>();
        // exit = start.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pause.game_status != 0)
        {
            if(pause.game_status != 2)
            {
                background.color = new Color32(0, 0, 0, 0);
                title.color = new Color32(255, 255, 255, 0);
                start.color = new Color32(255, 255, 255, 0);
                exit.color = new Color32(255, 255, 255, 0);
                pausa.color = new Color32(255, 255, 255, 0);
                if(pause.game_status == 1)
                {
                    marcador.color = new Color32(255, 255, 255, 255);
                    marcador_texto.color = new Color32(255, 255, 255, 255);
                }
                else
                {
                    marcador.color = new Color32(255, 255, 255, 0);
                    marcador_texto.color = new Color32(255, 255, 255, 0);
                }
                if(pause.game_status == 3)
                {
                    restart.color = new Color32(255, 255, 255, 255);
                    exit.color = new Color32(255, 255, 255, 255);
                    gameover.color = new Color32(255, 255, 255, 255);
                    background.color = new Color32(0, 0, 0, 100);
                    your_score.color = new Color32(255, 255, 255, 255);
                    record.color = new Color32(255, 255, 255, 255);
                    final_score.color = new Color32(255, 255, 255, 255);
                    final_record.color = new Color32(255, 255, 255, 255);
                }
            }

            else
            {
                background.color = new Color32(0, 0, 0, 100);
                start.color = new Color32(255, 255, 255, 255);
                exit.color = new Color32(255, 255, 255, 255);
                pausa.color = new Color32(255, 255, 255, 255);
                marcador.color = new Color32(255, 255, 255, 0);
                marcador_texto.color = new Color32(255, 255, 255, 0);
            }
        }
        else
        {
            background.color = new Color32(0, 0, 0, 100);
            title.color = new Color32(255, 255, 255, 255);
            start.color = new Color32(255, 255, 255, 255);
            exit.color = new Color32(255, 255, 255, 255);
            pausa.color = new Color32(255, 255, 255, 0);
        }
    }
}
