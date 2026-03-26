using UnityEngine;

public class CollisionEsfera : MonoBehaviour
{
    [SerializeField] Color color1;
    [SerializeField] Color color2;
    float radius;
    [SerializeField] GameObject point;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        radius = transform.localScale.x * 0.5f;
        gameObject.GetComponent<SpriteRenderer>().color = color1;
    }

    // Update is called once per frame
    void Update()
    {
        //calcular distancia
        float distanceX = transform.position.x - point.transform.position.x;
        float distanceY = transform.position.y - point.transform.position.y;
        float distanceZ = transform.position.z - point.transform.position.z;
        float distance = Mathf.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
        if (distance <= radius)
        {
            gameObject.GetComponent<SpriteRenderer>().color = color2;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = color1;
        }
    }
}
