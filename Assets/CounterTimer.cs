using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CounterTimer : MonoBehaviour {
	public static CounterTimer instance;

public  Text countdown,score,score1,GAME_OVER;
// z=316p
// y=6
// x=54.50
public  GameObject p;

public  GameObject ui,camera;
public SpriteRenderer sprite;
public string game_over;
public  bool start;
public  bool paused,stopped;

public  int timeLeft = 3,time;
	// Use this for initialization

	void OnLevelWasLoaded() 
	{
// p = GetComponent<GameObject>();
// 		ui = GetComponent<GameObject>();
// 		countdown  = GetComponent<Text>();
// startgame();
	// init();
// Debug.Log("Called");
	}
		public void startgame()
	{
		StartCoroutine("CountDown");
	}
	public  void init()
	{
		if(timeLeft==0)
		{
start = true;

countdown.gameObject.SetActive(false);

StopCoroutine("CountDown");
		}
countdown.text = ""+timeLeft;
	}
		IEnumerator CountDown()
  {
    while (true) {
      yield return new WaitForSeconds (1);

      timeLeft--; 
    }
  }
	void Awake()
	{
		 Make();
		 init();
		
		 paused = false;
		 stopped = false;
	}
	void Start () {
		score1.text = ""+time;
		// p = GetComponent<GameObject>();
		// ui = GetComponent<GameObject>();
		// countdown  = GetComponent<Text>();
		start = false;
	startgame();
	}
	public void win(string text)
	{
game_over = text;
	}
	public string wintext()
	{
return game_over;
	}
// 	public void startgame()
// 	{
// 		StartCoroutine("CountDown");
// 	}
// 	public void init()
// 	{
// 		if(timeLeft==0)
// 		{
// start = true;

// countdown.gameObject.SetActive(false);

// StopCoroutine("CountDown");
// 		}
// countdown.text = ""+timeLeft;
// 	}
	// Update is called once per frame
	void Update () {
			init();
			if(start && !stopped && !paused)
			{
			 score.text =""+time;
			 time++;
			}
			if(stopped)
			{
			score1.text = ""+time;
	}
	}

  void Make()
  {
	    if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
			// DontDestroyOnLoad(p);
			// DontDestroyOnLoad(ui);
			// DontDestroyOnLoad(countdown);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);

        }
  }
  public void Pause()
  { if(paused==false)
  {
	  Time.timeScale = 0;
	  paused = true;
  }
	  
  else
  {
	 Time.timeScale = 1f;  
	 paused = false;
  }
  }
  public void Stop()
  {

	  if(stopped==false)
	  {
		
		  if(wintext()=="Game Over")
		  {
			GAME_OVER.fontSize = 40;
			 GAME_OVER.text = wintext();
		  }
		 
		  else if(wintext()=="Level Completed")
		  {
			  	GAME_OVER.fontSize = 20;
		  GAME_OVER.text = wintext();
		  }
		  else
		  {
			  GAME_OVER.text = "Game Over";
			  camera.transform.position = new Vector3(100f,camera.transform.position.y,400f);
			  camera.transform.rotation = Quaternion.Euler(90f,camera.transform.rotation.y,camera.transform.rotation.z);
		  }
	  stopped=true;
ui.gameObject.SetActive(false);
p.SetActive(true);
	  Time.timeScale = 0;
	  }
	//   else
	//   {
	// 	  stopped=true;
	//   }
  }
  public void startGame()
  {
	//   CounterTimer.Nullify();
 SceneManager.LoadScene("main");
  }
	}