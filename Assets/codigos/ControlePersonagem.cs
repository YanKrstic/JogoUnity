using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float moveX;
    public float JumpForce = 10f;
    private Rigidbody2D rb;

    public Transform groundCheck;
    public Transform groundCheck2;
    public LayerMask groundLayer;

    private bool isGrounded;

    public Transform visual;
    private Animator anim;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = visual.GetComponent<Animator>();

    }
    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer) || Physics2D.OverlapCircle(groundCheck2.position, 0.1f, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
        Move();
    }

    void Move()
    {
        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);
        anim.SetBool("isRunning", Mathf.Abs(moveX) > 0f && isGrounded);
        anim.SetBool("isJumping", !isGrounded);
        if (moveX > 0.01f)
        {
            visual.localScale = new Vector3(9, 9, 9);
        }
        else if (moveX < -0.01f)
        {
            visual.localScale = new Vector3(-9, 9, 9);
        }
    }
    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
    }
}
