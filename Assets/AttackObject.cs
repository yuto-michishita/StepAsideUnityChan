using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackObject : MonoBehaviour {

	public GameObject unityChanControll;
	private Transform unitytrans;
	// Use this for initialization
	void Start () {
		unityChanControll = GameObject.Find ("unitychan");
		unitytrans = unityChanControll.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.position = new Vector3 (0,
			0,unitytrans.transform.position.z-10);
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "CarTag") {
			Destroy (other.gameObject);
		}
		else if(other.gameObject.tag=="CoinTag"){
				Destroy (other.gameObject);
			}
		else if(other.gameObject.tag=="TrafficConeTag"){
					Destroy (other.gameObject);
			}
		}

}
