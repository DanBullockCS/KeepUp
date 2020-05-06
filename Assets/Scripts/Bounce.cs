using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {
    private Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col) {
        //rb.angularVelocity = 0.0f;
        rb.AddTorque(0.1f);
        
        if (col.gameObject.tag.Equals("Player")) {
            AddBounce(col);
        }
    }

    public void AddBounce(Collision2D col) {
        BounceCount.numBounces += 1;
    }
}
