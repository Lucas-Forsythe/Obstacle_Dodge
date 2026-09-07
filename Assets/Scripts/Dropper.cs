using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToDrop = 3f;
    private Rigidbody myRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToDrop && transform.position.y > 0f)
        {
            myRigidBody.useGravity = true;
        }
    }
}
