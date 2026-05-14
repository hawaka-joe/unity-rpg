using UnityEngine;

public class Enemy_Torch : MonoBehaviour
{
    public int damageAmount = 50;

    private void OnCollisionEnter2D(Collision2D collision) {
        collision.gameObject.GetComponent<PlayerHealth>().Change(-damageAmount);
    }
}
