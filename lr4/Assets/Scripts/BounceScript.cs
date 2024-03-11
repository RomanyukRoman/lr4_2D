using UnityEngine;

public class BounceScript : MonoBehaviour
{
    public float bounceForce = 10f; // ���� �������

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GameController") // �������� ���� ���������
        {
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflectedDirection = Vector2.Reflect(transform.up, normal);

            // ����������� ���� �������
            GetComponent<Rigidbody2D>().velocity = reflectedDirection.normalized * bounceForce;
        }
    }
}
