using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour {

    public float mass = 100f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
    
    // Update is called once per physics engine execution
    void FixedUpdate() {
        if (mass <= 0f) {
            Destroy(gameObject);
        }
    }

    void AttackedWithForce(float force) {
        mass -= force;

    }
}
