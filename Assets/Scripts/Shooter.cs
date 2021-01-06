using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = Instantiate(
                projectilePrefab,
                transform.position,
                projectilePrefab.transform.rotation);
        }
    }
}
