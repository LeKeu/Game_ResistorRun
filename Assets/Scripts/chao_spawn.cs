using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao_spawn : MonoBehaviour
{
    [SerializeField] GameObject chaoTile;
    Vector3 novoSpawnPonto;

    public void SpawnTile()
    {
        GameObject tempr = Instantiate(chaoTile, novoSpawnPonto, Quaternion.identity);
        novoSpawnPonto = tempr.transform.GetChild(1).transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 15; i++){
            SpawnTile();
        }
        
    }

}
