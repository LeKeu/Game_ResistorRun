using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class butoes : MonoBehaviour
{
    [SerializeField] KeyCode Key;
    // Update is called once per frame
    void Start() 
    {
        GameObject.Find("highScoreText").GetComponent<TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("highscore");    
    }
    void Update()
    {
        if (Input.GetKey(Key))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Sair(){
        Application.Quit();
    }
}
