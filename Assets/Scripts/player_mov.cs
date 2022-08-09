using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_mov : MonoBehaviour
{
    bool alive = true;

    public float vel;
    [SerializeField] Rigidbody rb;
    [SerializeField] float horizMult;

    float horizInput;
    public float velIncrease = 0.5f;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        if(!alive) return; // se alive n for true, para de rodar a funcao

        Vector3 fowardMove = transform.forward * vel * Time.fixedDeltaTime;
        Vector3 horizMov = transform.right * horizInput * vel * Time.fixedDeltaTime * horizMult;
        rb.MovePosition(rb.position + fowardMove + horizMov);        
    }

    // Update is called once per frame
    void Update()
    {
        horizInput = Input.GetAxis("Horizontal");

        if(transform.position.y < -5){
            Perdeu();
        }
    }

    public void Perdeu(){
        alive = false;
        //Invoke("Restart", 2); //chama a restart funcao dps de 2 seg
        Invoke("Restart", 0);
    }

    void Restart(){
        SceneManager.LoadScene("Menu");
    }
}
