using UnityEngine;

public class Game : MonoBehaviour {
    private Score _score;
    private const int START_SCORE = 5;

    void Awake() {
        _score = GetComponent<Bootstrapper>().Score;
        _score.Set(START_SCORE);
    }

    public void Quit() {
        _score.Set(0);
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

