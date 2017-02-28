using UnityEngine;
using System.Collections;

public class lu_ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(this.transform.position.y < -5)
		{
			this.transform.position = new Vector3 (0, 5, 2);
		}

	}
}
