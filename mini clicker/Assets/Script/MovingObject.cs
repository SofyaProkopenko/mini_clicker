using UnityEngine;

public class MovingObject : MonoBehaviour {
    [SerializeField] private float speed = 2f;
    [SerializeField] private float distance = 5f;
    
    void Update() {
        float x = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }

    void OnMouseDown() => FindObjectOfType<Score>().Add(1);

}
