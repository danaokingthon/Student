using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = MyMoveTowards(position.x, target.position.x, speed * Time.deltaTime);
        transform.position = position;
    }

    float MyMoveTowards(float current, float target, float maxDelta)
    {
        //distancia que falta
        float distance = target - current;
        float direction = target - current;
        //llegamos en este frame?
        if (distance <= maxDelta)
        {
            return target;
        }
        if (direction < 0)
        {
            return current - maxDelta;
        }
        else
        {
            return current + maxDelta;
        }
    }
}