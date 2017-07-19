using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFSM : MonoBehaviour {

	public enum  State
	{
		Idle,
		Move,
		Attack,
		AttackWait,
		Dead
	}

	public State currentState = State.Idle;

	PlayerAni myAni; //PlayAni클래스를 myAni변수에 담기

	// Use this for initialization
	void Start () {
		myAni = GetComponent<PlayerAni>();  //PlayerAni의 
		myAni.ChangeAni (PlayerAni.ANI_WALK);
	}

	void UpdateState (){
		switch (currentState){

		case State.Idle:
			print("Idle");
			break;
		case State.Move:
			print("Move");
			break;
		case State.Attack:	
			print("Attack");
			break;
		case State.AttackWait:
			print("AttackWait");
			break;
		case State.Dead:
			print("Dead");
			break;	

		}
	}
	
	// Update is called once per frame
	void Update () {
		UpdateState();
	}
}
