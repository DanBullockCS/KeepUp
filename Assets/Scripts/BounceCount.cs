using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BounceCount : MonoBehaviour {
    public static int numBounces = 0;
    TMP_Text text;

    // Show coin count
    void Start() {
        numBounces = 0;
        text = GetComponent<TMP_Text>();
    }
    void Update() {
        text.text = numBounces.ToString();
    }
}
