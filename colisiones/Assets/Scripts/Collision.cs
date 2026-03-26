using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color color1;
    [SerializeField] Color color2;
    float radius;
    [SerializeField] GameObject point;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        radius = transform.localScale.x;
        gameObject.GetComponent<SpriteRenderer>().color = color1;
    }

    // Update is called once per frame
    void Update()
    {
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
