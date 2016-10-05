using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
    public GameObject[] prefab;
    private Transform myplayer;
    private int counter=7;
    private float length = 10.0f;
    private float count = 0.0f;
    // Use this for initialization
    void Start () {
        myplayer = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i = 0; i < counter; i++)
        {

        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void spawntitle()
    {
        
        GameObject tile;
        tile = Instantiate(prefab[0]);
        tile.transform.position = new Vector3(0, 0, count);
        count += length;

    }
}
