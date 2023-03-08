using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
    public Rigidbody2D rigidBody;
    public float flapStrength;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() {
        bool shouldFlap = Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0);

        if (shouldFlap) {
            Flap();
        }
    }

    void Flap() {
        rigidBody.velocity = Vector2.up * flapStrength;
    }
}
