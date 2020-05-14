using UnityEngine;

public class TouchMove : MonoBehaviour {
    void Update() {
        if (Input.GetMouseButton(0) || Input.touchCount > 0) {
            Vector3 screenPos = Input.mousePosition;                      // Get mouse position or touch position
            screenPos.z = 10.0f;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos); // Convert mouse position to world space
            Vector3 newPos = transform.position;                          // Get current position of this GameObject
            newPos.x = worldPos.x;
            transform.position = newPos;                                  // Apply new position

            // Make sure the player can't move the eraser off the screen
            if (transform.position.x < -2.5) {
                newPos.x = -2.5f;
                transform.position = newPos;
            } else if (transform.position.x > 2.5) {
                newPos.x = 2.5f;
                transform.position = newPos;
            }
        }
    }
}
