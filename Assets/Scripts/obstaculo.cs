using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstaculo : MonoBehaviour
{
    player_mov playerMovScript;
    score scoreScript;
    
    [SerializeField] Material playerMat;
    
    Material obstMat;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody>();
        playerMovScript = GameObject.FindObjectOfType<player_mov>();
        scoreScript = GameObject.FindObjectOfType<score>();
        
        
        obstMat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player" && playerMat.color != obstMat.color){ //MATAR
            scoreScript.saveScore();
            playerMovScript.Perdeu();
        }else if(other.gameObject.tag == "Player" && playerMat.color == obstMat.color){
            scoreScript.aumentarScore();
            Destroy(rb.gameObject);
            
        }
    }
}
