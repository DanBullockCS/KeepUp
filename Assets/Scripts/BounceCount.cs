using UnityEngine;
using TMPro;

public class BounceCount : MonoBehaviour {
    public static int numBounces = 0;
    TMP_Text text;

    // Show Bounce count
    void Start() {
        numBounces = 0;
        text = GetComponent<TMP_Text>();
    }
    void Update() {
        text.text = numBounces.ToString();
        PlayerPrefs.SetInt("Score", numBounces);
        PlayerPrefs.Save();
    }
}
