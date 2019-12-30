using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	// Rigidbody rb;	
	Vector3 position,roadPos;
	public GameObject[] road;
	public GameObject spawner;
	// public count c;
	public bool destroy;
	public float maxpos=70f,minpos =37f,carSpeed=5f;
	void Awake()
	{
		
		
	}
	void Start () {

		// c = GetComponent<count>();

destroy = false;
		// rb  = GetComponent<Rigidbody>();
		position = transform.position;
		// spawner = GetComponent<GameObject>();
		// gameManager = GetComponent<GameManager>();
			// gameManager.des(false);
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetButton("Jump"))
	{
CounterTimer.instance.Pause();
	}
	// transform.Translate(Vector3.forward*-30*Time.deltaTime);
		// gameManager.des(false);
		// Debug.Log("Pressed");
		// Vector3 position = Input.GetAxis("Horizontal")*-10*Time.deltaTime;
		//  position = Mathf.Clamp(-maxpos,maxpos);
		if(CounterTimer.instance.start)
		{
			
		 position.x -=Input.GetAxis("Horizontal")*carSpeed*Time.deltaTime;
		//  position.z += 50*Time.deltaTime;
		 if(Input.GetAxis("Vertical")>0)
		 {
			position.z += ((Input.GetAxis("Vertical")*30f)+50f)*Time.deltaTime; 
		 }
		 else if(Input.GetAxis("Vertical")<0)
		 {
position.z -=((Input.GetAxis("Vertical")*10f)+0f)*Time.deltaTime;
		 }
		 else
		 {
			 		 position.z += 50*Time.deltaTime;
		 }
		//  position.x = Mathf.Clamp(position.x,maxpos,minpos);
		if(position.x<=43f)
		{
			position.x=43f;
		}
		else if(position.x>=75f)
		{
			position.x=75f;
		}
		 transform.position = position;
		}
		
	}
	
 private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "car")
		{
			
		
         destroy = true;
		 CounterTimer.instance.win("Game Over");
		//  Destroy(spawner.gameObject);
			Time.timeScale = 0f;
			CounterTimer.instance.Stop();
		//    StartCoroutine("des");
			
		}
		
	}
 private void OnTriggerEnter(Collider other)
	{
if(other.gameObject.tag == "spawner")
		{
			Destroy(other.gameObject);
			Debug.Log("Destroyed");
			// Instantiate(road[0],new Vector3(7.5f,-120f,223f),transform.rotation);
		// Instantiate(cars[carno],carPos,transform.rotation);

		}
		else if(other.gameObject.tag == "finish")
		{
			CounterTimer.instance.win("Level Completed");
			CounterTimer.instance.Stop();
			
			// Instantiate(road[0],new Vector3(7.5f,-120f,223f),transform.rotation);
		// Instantiate(cars[carno],carPos,transform.rotation);

		}
		
	}
	// IEnumerator des()
	// {
			
	// 		// 
			  
	// 	yield return new WaitForSeconds(1f);
	// 	destroy = true;
	// 	Time.timeScale = 0;

			
	// }
	// IEnumerator des1()
	// {
			
	// 		// 
	// 		  Time.timeScale = 0.25f;
	// 	yield return new WaitForSeconds(2f);
			
	// }
}
