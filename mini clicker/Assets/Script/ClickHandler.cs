using UnityEngine;

public class ClickHandler : MonoBehaviour {
    [SerializeField] private Score score;
    [SerializeField] private int clickDelta = -1;

    void OnMouseDown() => score.Add(clickDelta);
}

