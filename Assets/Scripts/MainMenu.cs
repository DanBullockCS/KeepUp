// Controling the Main Menu
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    // Load other scenes
    public void GoToPlayGame() {
        SceneManager.LoadScene("MainGame");
    }
    public void GoToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToCredits() {
        SceneManager.LoadScene("Credits");
    }
    public void GoToEndScreen() {
        SceneManager.LoadScene("EndScreen");
    }
    public void QuitGame() {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
