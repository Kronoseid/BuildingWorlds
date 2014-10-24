using UnityEngine;
using System.Collections;

public class nycProcedure : MonoBehaviour {

	public Transform tower;
	public Transform taxi;
	public Transform bagel;
	public Transform bridge;
	public int counter;


	// Use this for initialization
	void Start () {
		StartCoroutine (NewYorkMaker());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel (0);
		}
	}

	IEnumerator NewYorkMaker(){
		while (counter < 50){
			yield return new WaitForSeconds(.1f);

			Vector3 origin = new Vector3(0f, 0f, 0f);
			int randomizer = Random.Range (0,4);

			if (randomizer <= 1){
				Instantiate(tower, new Vector3(Random.Range(-50f,50f), 0, Random.Range(-50f,50f)), Quaternion.identity);
				yield return new WaitForSeconds (.1f);
			}
			else if ((randomizer <= 2) && (randomizer > 1)){
				Instantiate(taxi, new Vector3(Random.Range(-50f,50f), 0, Random.Range(-50f,50f)), Quaternion.identity);
				yield return new WaitForSeconds (.1f);
			}
			else if ((randomizer <= 3) && (randomizer > 2)){
				Instantiate(bagel, new Vector3(Random.Range(-50f,50f), 0, Random.Range(-50f,50f)), Quaternion.identity);
				yield return new WaitForSeconds (.1f);
			}
			else if ((randomizer <= 4) && (randomizer > 3)){
				Instantiate(bridge, new Vector3(Random.Range(-50f,50f), 0, Random.Range(-50f,50f)), Quaternion.identity);
				yield return new WaitForSeconds (.1f);
			}

			counter++;


		}
	}
}
