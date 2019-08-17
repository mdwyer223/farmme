using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private float movementSmoothing = .05f;
    
    private Vector3 velocity = Vector3.zero;
    private bool facingRight = false;
    private Rigidbody2D rbody;
    private float speed = 100f;

    private void Awake() {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        // check for collisions here
    }

    public void Move(float moveX, float moveY) {
        Vector3 targetVelo = new Vector2(moveX * speed, moveY * speed);
        rbody.velocity = Vector3.SmoothDamp(rbody.velocity, targetVelo, ref velocity, movementSmoothing);
    }

    private void Flip(){
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}