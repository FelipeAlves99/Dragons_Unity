using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector2 jumpForce;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
            GetComponent<AudioSource>().Play();
        }
    }
}
