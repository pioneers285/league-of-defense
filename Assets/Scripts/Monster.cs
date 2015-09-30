using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour 
{
	
	// Use this for initialization
	void Start () 
	{
		// Navigate to Castle
		GameObject nexus = GameObject.Find("Nexus");
		if (nexus)
			GetComponent<NavMeshAgent>().destination = nexus.transform.position;
		
	}
	void OnTriggerEnter(Collider co) {
		// If castle then deal Damage
		if (co.name == "Nexus") {
			co.GetComponentInChildren<Health> ().decrease ();
			Destroy(gameObject);
		}
	}
		
	}
