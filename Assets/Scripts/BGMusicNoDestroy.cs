// Background Music Script
using UnityEngine;

public class BGMusicNoDestroy : MonoBehaviour {
    void Awake() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Music");
        if(objects.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
