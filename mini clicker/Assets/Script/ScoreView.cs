using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour {
    [SerializeField] private Text text;
    [SerializeField] private Score score;

    void Start() => score.OnChanged += UpdateView;
    
    private void UpdateView(int value) => text.text = $"Score: {value}";
}

