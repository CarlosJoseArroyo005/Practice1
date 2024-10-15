using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator 
    [SerializeField] float speed = 1000f;
    /
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime, 0);
            scale.x = -1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime, 0);
            scale.x = 1;
        }

        aniamtor.SetBool("isWalking", true);
        transform.localScale = scale;

        if (Input.GetKeyDown(KeyCode.A))


       

    }
}