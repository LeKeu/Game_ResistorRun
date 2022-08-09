using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    TextMeshProUGUI normalScoreTXT;
    int scoreN;
    [SerializeField] player_mov playerMovScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreN = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("scoreText").GetComponent<TextMeshProUGUI>().text = "Score: " + scoreN;
    }

    public void aumentarScore(){
        scoreN++;
        
        playerMovScript.vel += playerMovScript.velIncrease;
        Debug.Log("VEL " + playerMovScript.vel);
    }

    public void saveScore(){
        if(scoreN > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", scoreN);
        }
    }
}
