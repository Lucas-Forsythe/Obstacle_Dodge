using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Use WASD or arrow keys to move the object.");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
