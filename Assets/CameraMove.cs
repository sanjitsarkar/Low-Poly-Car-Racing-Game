using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//x-54
//y-24
//z- -8
public class CameraMove : MonoBehaviour {

	// Use this for initialization
 public GameObject player;
 public Move move;
// public GameManager gameManager;
private float offsetz,offsetx,offsety;
	void Start () {
	
		//  move = GetComponent<Move>();
		// gameManager = GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
// if(move.destroy==true)
		{
		// Debug.Log("Fucked Up");
			 offsetz =  player.transform.position.z-70f;
		 offsetx = 54f;
		 offsety = 24f;

		transform.position = new Vector3(player.transform.position.x-5f,offsety,offsetz);
		}
	
	
// }
}
}
