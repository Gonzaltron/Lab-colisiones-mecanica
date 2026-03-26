using UnityEngine;

public class ColisionNoAA : MonoBehaviour
{
    [SerializeField] Color color1;
    [SerializeField] Color color2;
    [SerializeField] GameObject point;
    [SerializeField] float colliderWidth;
    [SerializeField] float colliderDepth;
    [SerializeField] float colliderHeight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CalculateColision())
        {
            gameObject.GetComponent<SpriteRenderer>().color = color2;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = color1;
        }
    }

    bool CalculateColision()
    {
        bool x = point.transform.position.x < transform.position.x + colliderWidth * 0.5f && point.transform.position.x > transform.position.x - colliderWidth * 0.5f;
        bool y = point.transform.position.y < transform.position.y + colliderHeight * 0.5f && point.transform.position.y > transform.position.y - colliderHeight * 0.5f;
        bool z = point.transform.position.z < transform.position.z + colliderDepth * 0.5f && point.transform.position.z > transform.position.z - colliderDepth * 0.5f;

        return x && y && z;
    }
}
