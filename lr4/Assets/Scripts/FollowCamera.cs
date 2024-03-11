using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.3f;
    public Vector3 offset;

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = new Vector3(player.position.x, player.position.y, transform.position.z) + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
