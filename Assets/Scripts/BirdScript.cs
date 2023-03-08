using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
    public GameManagerScript gameManagerScript;
    public Rigidbody2D rigidBody;
    public float flapStrength;
    public bool isBirdAlive = true;

    // Start is called before the first frame update
    void Start() {
        gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update() {
        bool shouldFlap = isBirdAlive && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0));

        if (shouldFlap) {
            Flap();
        }
    }

    void Flap() {
        rigidBody.velocity = Vector2.up * flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        gameManagerScript.GameOver();
        isBirdAlive = false;
    }
}
