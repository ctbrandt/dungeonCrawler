using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Reference to Rigidbody component called "rb"
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Light flashlight;

    public float movementSpeed = 1f;
    float horizontalMove = 0f;
    float verticalMove = 0f;

    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        if(horizontalMove < 0){
            sr.flipX = true;
        } else if( horizontalMove > 0){
            sr.flipX = false;
        }

        if( Input.GetButtonDown("Fire1") ){
            flashlight.enabled = !flashlight.enabled;
        }
    }

    // We marked this as "fixed" update because
    // we are using it to alter physics
    void FixedUpdate()
    {
        rb.MovePosition(new Vector2(horizontalMove * Time.fixedDeltaTime * movementSpeed, verticalMove * Time.fixedDeltaTime * movementSpeed) + rb.position);
    }
}
