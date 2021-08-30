using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score = " + PlayerControll.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score = " + PlayerControll.score.ToString();
    }
}
