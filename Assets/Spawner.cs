using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	public GameObject[] cars;
	public GameObject car;
	public float maxPos =70f ,minPos = 37f;
public int carno;
	void Start () {
		// Instantiate(cars[0],transform.position,transform.rotation);
		// if(CounterTimer.instance.start)
		// {
		InvokeRepeating("Spawn",1f,Random.Range(6,8));
		Debug.Log("Why");
		// }
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void Spawn()
	{
		if(CounterTimer.instance.start)
		{
	
		// Debug.Log("Fuck");
		  carno = Random.Range(0,cars.Length-1);
		Vector3 carPos = new Vector3(Random.Range(minPos,maxPos),transform.position.y,transform.position.z);
		Instantiate(cars[carno],carPos,transform.rotation);

		// Instantiate(car,carPos,transform.rotation);
		
		}
	}
}
