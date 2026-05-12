using UnityEngine;

public class MountEntry : MonoBehaviour
{

    public Collider2D[] mountColliders;
    public Collider2D[] boundaryColliders;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"MountEntry OnTriggerEnter2D tag: {collision.gameObject.tag}");
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D collider in mountColliders)
            {
                collider.enabled = false;
            }
            foreach (Collider2D collider in boundaryColliders)
            {
                collider.enabled = true;
            }
        }
        collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
    }
}
