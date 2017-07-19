using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}

	void CheckClick (){
		if(Input.GetMouseButton(0)){

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;

			if(Physics.Raycast(ray, out hit)){
				if ( hit.collider.gameObject.name == "Terrain"){
					player.transform.position = hit.point;
				}
			}
			print(Input.mousePosition);
		}
	}
	
	// Update is called once per frame
	void Update () {
		CheckClick();
	}
}
