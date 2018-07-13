using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);	
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit it.");
        //other.transform.parent.rotation = transform.rotation - other.transform.rotation;
        transform.rotation = other.transform.rotation;
    }
}
