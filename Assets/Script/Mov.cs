using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;

    private Rigidbody2D direct;

    void Start()
    {
        direct = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        direct.velocity = new Vector2(move * speed, direct.velocity.y);
    }
}
