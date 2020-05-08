// Unused script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBounces : MonoBehaviour {
    public Transform paperball;
    void Update() {
        if (BounceCount.numBounces == 10) {
            Instantiate(paperball, new Vector3(-0.11f, 2.63f, 0f), Quaternion.identity);
        }
    }
}
