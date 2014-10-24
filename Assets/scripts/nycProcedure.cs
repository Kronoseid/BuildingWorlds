using UnityEngine;
using System.Collections;

public class nycProcedure : MonoBehaviour {

	public GameObject firstThing;
	public GameObject secondThing;
	public GameObject thirdThing;
	public GameObject fourthThing;
	public int counter;

	// Use this for initialization
	void Start () {
		StartCoroutine (NewYorkMaker);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator NewYorkMaker(){

	}
}
