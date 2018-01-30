using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratracksplayer : MonoBehaviour {

    Transform player;


	// Use this for initialization
	void Start () {
        GameObject player_go = gameobject.FindGameObjectWithTag("player");

        if (player_go == null)
            Debug.LogError("Couldn't Find a Object with the Tag 'Player' ");
            return;
        {

        }

        player = player_go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
