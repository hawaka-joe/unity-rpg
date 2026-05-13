using UnityEngine;

public class MountEntry : MonoBehaviour
{

    public Collider2D[] mountColliders;
    public Collider2D[] boundaryColliders;
    private bool inMount = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"MountEntry OnTriggerEnter2D tag: {collision.gameObject.tag}");
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D collider in mountColliders)
            {
                collider.enabled = inMount;
            }
            foreach (Collider2D collider in boundaryColliders)
            {
                collider.enabled = !inMount;
            }
        }
        collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = inMount ? 5 : 15;
        inMount = !inMount;
    }
}
