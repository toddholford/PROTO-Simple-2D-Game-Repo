using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    [SerializeField]
    Vector2 playerInput;
    Rigidbody2D playerRigidbody;

    [SerializeField]
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        playerRigidbody.velocity = playerInput.normalized * moveSpeed;
    }
}
