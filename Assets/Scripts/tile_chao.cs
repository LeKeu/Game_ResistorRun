using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_chao : MonoBehaviour
{
    chao_spawn tile_do_chao; // assim eu consigo acessar funcoes e var do outro script
    List<Color> cores = new List<Color>();
    // Start is called before the first frame update
    void Start()
    {
        cores.Add(Color.black);
        cores.Add(new Color32(123, 63, 0, 255));
        cores.Add(Color.red);
        cores.Add(new Color32(255, 140, 0, 255));
        cores.Add(Color.yellow);
        cores.Add(Color.green);
        cores.Add(Color.blue);
        cores.Add(new Color32(138, 43, 226, 255));
        cores.Add(Color.grey);
        cores.Add(Color.white);
        
        tile_do_chao = GameObject.FindObjectOfType<chao_spawn>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other) {
        tile_do_chao.SpawnTile();
        Destroy(gameObject, 2); // destruir 2 seg dps q o player sair do trigger
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject obstaculo;
    [SerializeField] Material obstMat;
    [SerializeField] Renderer myObject;

    void SpawnObstacle(){
        int obstclSpawnIndex = Random.Range(2, 5); // vai pegar os filhos na nos index 2, 3 e 4
        Transform spawnPonto = transform.GetChild(obstclSpawnIndex).transform;

        int colorIndex = Random.Range(0, 10);
    
        GameObject go = Instantiate(obstaculo, spawnPonto.position, Quaternion.identity, transform);
        go.GetComponent<MeshRenderer>().material.color = cores[colorIndex]; // faz serem criadas c cores diferentes
    }
}
