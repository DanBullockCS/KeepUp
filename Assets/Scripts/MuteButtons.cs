// TODO - Animate pictures and actually mute the sound/music
using UnityEngine;
using UnityEngine.UI;

public class MuteButtons : MonoBehaviour {
    private int mutedSound = 0;
    private int mutedMusic = 0;

    public Sprite soundOnImg;
    public Sprite soundOffImg;
    public Sprite musicOnImg;
    public Sprite musicOffImg;

    private Image soundImg;
    private Image musicImg;

    private void Start() {
        mutedSound = PlayerPrefs.GetInt("MuteSound", 0);
        mutedMusic = PlayerPrefs.GetInt("MuteMusic", 0);

        soundImg = GameObject.Find("SoundButton").GetComponent<Image>();
        musicImg = GameObject.Find("MusicButton").GetComponent<Image>();

        if (mutedSound == 0) {
            soundImg.sprite = soundOnImg;
        } else {
            soundImg.sprite = soundOffImg;
        }
        if (mutedMusic == 0) {
            musicImg.sprite = musicOnImg;
        } else {
            musicImg.sprite = musicOffImg;
        }
    }

    public void ChangeSoundButton() {
        if (PlayerPrefs.GetInt("MuteSound") == 0) {
            mutedSound = 1;
            soundImg.sprite = soundOffImg;
        } else {
            mutedSound = 0;
            soundImg.sprite = soundOnImg;
        }

        PlayerPrefs.SetInt("MuteSound", mutedSound);
        PlayerPrefs.Save();
    }

    public void ChangeMusicButton() {
        if (PlayerPrefs.GetInt("MuteMusic") == 0) {
            mutedMusic = 1;
            musicImg.sprite = musicOffImg;
        } else {
            mutedMusic = 0;
            musicImg.sprite = musicOnImg;
        }

        PlayerPrefs.SetInt("MuteMusic", mutedMusic);
        PlayerPrefs.Save();
    }
}
