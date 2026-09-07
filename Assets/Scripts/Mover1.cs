using System.Threading;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Mover1 : MonoBehaviour
{
    [SerializeField] private float xValue = 0f;
    [SerializeField] private float yValue = 0f;
    [SerializeField] private float zValue = 1f;
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float timeToMove = 5f;
    private float Timer = 0f;
    private float TimeToMove = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(xValue * Time.deltaTime, yValue * Time.deltaTime, zValue * speed * Time.deltaTime);

        Timer += Time.deltaTime;

        if ( Timer >= TimeToMove)
        {
            zValue = -zValue;
            Timer = 0f;
        }
    }
}
