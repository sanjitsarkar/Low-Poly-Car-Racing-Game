using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
public bool destroy,start;

  public int timeLeft = 3; //Seconds Overall
  public Text countdown; //UI Text Object
public AudioSource ready;
	// Use this for initialization
	void Start () {
		while(timeLeft!=-1)
		{
StartCoroutine("LoseTime");
		}

start = false;
    Time.timeScale = 1; 
	}
	public void des(bool dstry)
	{
		destroy = dstry;
	}
	public bool getdes()
	{
		return destroy;
	}

	
	// Update is called once per frame
	void Update () {
		if(timeLeft==0)
		{
start = true;
countdown.gameObject.SetActive(false);
ready.Stop();
		}
		    countdown.text = ("" + timeLeft); //Showing the Score on the Canvas

	}
	  //Simple Coroutine
  IEnumerator LoseTime()
  {
    while (true) {
      yield return new WaitForSeconds (1);
	  ready.Play();
      timeLeft--; 
    }
  }
}
