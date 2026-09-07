using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private MeshRenderer myMeshRenderer;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ObjectHit: Collision with Player detected.");
            gameObject.tag = "Hit";
            ChangeColor();
        }
    }

    private void ChangeColor()
    {
        if (myMeshRenderer == null)
        {
            myMeshRenderer = GetComponent<MeshRenderer>();
        }
        myMeshRenderer.material.color = Color.blue;
    }
}
