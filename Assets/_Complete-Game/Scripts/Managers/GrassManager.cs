using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassManager : MonoBehaviour {

	public GameObject Plant;
	public int jumlah;
	float x;
	float y;
	float z;
	Vector3 pos;
	void Start()
	{
		//x = Random.Range( -20, 0);
		//y = 1;
		//z = Random.Range( -20 , 0);
		pos = new Vector3(x, y, z);
		transform.position = pos;
		for(int c=0; c < jumlah; c++){
			x = Random.Range(c-60, c);
			y = 0;
			z = Random.Range(c-40, c);

			Instantiate(Plant, new Vector3(x, y, z), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
