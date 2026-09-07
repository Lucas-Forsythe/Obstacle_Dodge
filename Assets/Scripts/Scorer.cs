using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitNumber = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Untagged") && !collision.gameObject.CompareTag("Hit"))
        {
            hitNumber++;
            Debug.Log("Scorer: Collision detected. Hit number: " + hitNumber);
        }
    }
}
