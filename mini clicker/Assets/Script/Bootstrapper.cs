using UnityEngine;

public class Bootstrapper : MonoBehaviour {
    [SerializeField] private Score scorePrefab;
    public Score Score { get; private set; }

    void Awake() {
        Score = Instantiate(scorePrefab);
        gameObject.AddComponent<Game>();
    }
}
