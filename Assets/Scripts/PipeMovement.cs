using UnityEngine;

// This class is used to move spawned pipes from right to left.

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }
}
