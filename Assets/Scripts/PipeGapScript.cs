using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Layer {
    Bird = 3
}

public class PipeGapScript : MonoBehaviour {
    public GameManagerScript gameManagerScript;

    // Start is called before the first frame update
    void Start() {
        gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == (int) Layer.Bird) {
            gameManagerScript.AddScore(1);
        }
    }
}
