using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButton : MonoBehaviour {

	public int rescene = 0;
	public int nextscenes = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void nextGame()
	{
		SceneManager.LoadScene (nextscenes);
		Debug.Log ("asasa");
	}

	public void restartGame()
	{
		SceneManager.LoadScene (rescene);
		Debug.Log("sasasasa");
	}
}
