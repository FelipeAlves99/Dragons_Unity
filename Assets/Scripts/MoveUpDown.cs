using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float heightVariance = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * heightVariance;
    }
}
