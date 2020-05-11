// Background Music Script
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusicNoDestroy : MonoBehaviour {
    private string sceneName = "";
    [SerializeField] AudioSource MainMenuMusic = null;

    void Awake() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Music");
        if(objects.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Update() {
        sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "DeathScreen") {
            MainMenuMusic.mute = true;
        } else {
            MainMenuMusic.mute = false;
        }
    }
}
