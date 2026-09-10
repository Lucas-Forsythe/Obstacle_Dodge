using UnityEngine;

public class BounceBack : MonoBehaviour
{
    [SerializeField] private float bounceForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 bounceDirection = collision.transform.position - transform.position;
            bounceDirection.y = 0; // Keep the bounce in the horizontal plane
            bounceDirection.Normalize();

            collision.transform.position += bounceDirection * bounceForce * Time.deltaTime;
        }
    }
}
