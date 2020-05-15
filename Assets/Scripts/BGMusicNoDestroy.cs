// Background Music Script
using UnityEngine;

public class BGMusicNoDestroy : MonoBehaviour {
    private AudioSource aSource = null;
    
    void Awake() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Music");
        if(objects.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Start() { aSource = GetComponent<AudioSource>(); }

    private void Update() {
        if (PlayerPrefs.GetInt("MuteMusic") == 0) {
            aSource.mute = false;
        } else {
            aSource.mute = true;
        }
    }
}
