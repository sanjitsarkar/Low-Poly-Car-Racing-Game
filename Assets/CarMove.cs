using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {

	// Use this for initialization
	public GameObject player,cc;
// public GameManager gameManager;
//  public count c;

//  public GameObject SpawnZone;
  void Awake()
 {
	//   GameObject cc = GameObject.Find("count");     
    //      c = cc.GetComponent<count>(); 
 }
	void Start () {
		Debug.Log("Hello");
		// c = GetComponent<count>();
// Int Speed = Random(2,7);
		// Debug.Log(speed);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(CounterTimer.instance.start)
		{
		transform.Translate(Vector3.forward*Random.Range(-20,-30)*Time.deltaTime);
		if(transform.position.z==player.transform.position.z)
		{
			Destroy(this.gameObject);
		}
		}
	}
}
