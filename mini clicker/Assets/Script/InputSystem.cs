using UnityEngine;

public class InputSystem : MonoBehaviour {
    private Game _game;

    void Start() => _game = FindObjectOfType<Game>();
    
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) 
            _game.Quit();
    }
}

