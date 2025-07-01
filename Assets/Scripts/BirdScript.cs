using UnityEngine;

// This class controls the jump movement of the bird.

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRB;
    [SerializeField] private float jump_speed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            birdRB.velocity = Vector2.up * jump_speed;
            AudioManager.instance.PlaySFX(0);
        }
    }
}
