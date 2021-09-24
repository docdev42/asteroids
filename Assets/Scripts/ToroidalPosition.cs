using UnityEngine;
public class ToroidalPosition : MonoBehaviour
{
    const float MARGIN = 0.5F;
    public Rigidbody2D mRigidbody;
    void Update()
    {
        Camera camera = GameplayCamera.instancia.mCamera;
        var maxX = camera.orthographicSize * camera.aspect + MARGIN;
        var maxY = camera.orthographicSize + MARGIN;
        float leftEdge = -maxX;
        float rightEdge = maxX;
        float topEdge = maxY;
        float bottomEdge = -maxY;

        Vector2 pos = mRigidbody.position;
        if(pos.x < leftEdge - MARGIN)
        {
            pos.x = rightEdge + MARGIN;
        }
        else if (pos.x > rightEdge + MARGIN)
        {
            pos.x = leftEdge - MARGIN;
        }

        if (pos.y < bottomEdge - MARGIN)
        {
            pos.y = topEdge + MARGIN;
        }
        else if (pos.y > topEdge + MARGIN)
        {
            pos.y = bottomEdge - MARGIN;
        }

        mRigidbody.position = pos;
    }
}
