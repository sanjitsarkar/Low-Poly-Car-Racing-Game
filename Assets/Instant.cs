using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant : MonoBehaviour {

	// Use this for initialization
	public GameObject[] cars;
	public float maxPos =70f ,minPos = 37f;
public int carno;
	void Start () {
		// Instantiate(cars[0],transform.position,transform.rotation);
		
		InvokeRepeating("Spawn",1f,Random.Range(2,4));
		Debug.Log("Why");
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void Spawn()
	{
		Debug.Log("Fuck");
		  carno = Random.Range(0,8);
		Vector3 carPos = new Vector3(Random.Range(minPos,maxPos),transform.position.y,transform.position.z);
		Instantiate(cars[carno],carPos,transform.rotation);

	}
}
