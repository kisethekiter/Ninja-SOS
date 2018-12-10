using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooPool : MonoBehaviour {

    public float spawnrate = 4f;
    public int BambooPoolsize = 5;
    public float BlocksYmin = -2f;
    public float BlocksYmax = 2f;

    private float timesinceLastSpawn;
    private float spawnXPos = 10f;
    private int currentBlocks = 0;

    public GameObject BlocksPrefab;
    private GameObject[] Blocks;
    private Vector2 objectpoolPosition = new Vector2(-25, -25);

    void Start () {

        Blocks = new GameObject[BambooPoolsize];
        for(int i = 0; i <BambooPoolsize; i++)
        {
            Blocks[i] = (GameObject)Instantiate(BlocksPrefab, objectpoolPosition, Quaternion.identity);
        }
		
	}
	
	
	void Update () {
        timesinceLastSpawn += Time.deltaTime;
        if(!GameControl.instance.isGameOver && timesinceLastSpawn >= spawnrate)
        {
            timesinceLastSpawn = 0;

            float spawnYPos = Random.Range(BlocksYmin, BlocksYmax);
            Blocks[currentBlocks].transform.position = new Vector2(spawnXPos, spawnYPos);
            Blocks[currentBlocks].SendMessage("ChangeSpeed", SendMessageOptions.DontRequireReceiver);
            currentBlocks++;

            if (currentBlocks >= BambooPoolsize){ currentBlocks = 0; }
        }
	}
}
