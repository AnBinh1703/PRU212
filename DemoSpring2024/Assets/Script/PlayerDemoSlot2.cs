using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDemoSlot2 : MonoBehaviour
{
    //transform
    // spriteRenderer

    public float moveSpeed = 5.0f;
    public Vector3 moveInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;

        if (moveInput.x != 0)
        {
            if (moveInput.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 0);

            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 0);
            }
        }
    }
}
