using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private Rigidbody rb;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            rb.AddForce(new Vector3(0, 250, 0));
        }
        if (transform.position.y < -5||transform.position.y>5)
        {
            SceneManager.LoadScene("losescene");
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag.Equals("obs"))
        {
            SceneManager.LoadScene("losescene");
        }
    }
}
