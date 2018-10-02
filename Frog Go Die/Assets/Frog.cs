using UnityEngine;

public class Frog : MonoBehaviour {

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKey(KeyCode.UpArrow)) {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            rb.MovePosition(rb.position + Vector2.down);
        }
	}
}
