using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class record_print : MonoBehaviour
{
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreScript.record_score.ToString();
    }
}
