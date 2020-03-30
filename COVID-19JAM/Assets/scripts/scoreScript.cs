using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 0;
    public static int record_score = 0;
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
