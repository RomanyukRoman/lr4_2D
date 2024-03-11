using UnityEngine;

public class BounceScript : MonoBehaviour
{
    public float bounceForce = 10f; // Сила відскоку

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GameController") // Перевірка тегу платформи
        {
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflectedDirection = Vector2.Reflect(transform.up, normal);

            // Застосовуємо силу відскоку
            GetComponent<Rigidbody2D>().velocity = reflectedDirection.normalized * bounceForce;
        }
    }
}
