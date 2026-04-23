using UnityEngine;

public class AABBbolumenes : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject cube2;
    [SerializeField] double cubeXmin;
    [SerializeField] double cubeXmax;
    [SerializeField] double cubeYmin;
    [SerializeField] double cubeYmax;
    [SerializeField] double cubeZmax;
    [SerializeField] double cubeZmin;
    [SerializeField] double cube2Xmin;
    [SerializeField] double cube2Xmax;
    [SerializeField] double cube2Ymin;
    [SerializeField] double cube2Ymax;
    [SerializeField] double cube2Zmax;
    [SerializeField] double cube2Zmin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cubeXmin = cube.transform.position.x - 0.5;
        cubeXmax = cube.transform.position.x + 0.5;
        cubeYmin = cube.transform.position.y - 0.5;
        cubeYmax = cube.transform.position.y + 0.5;
        cubeZmax = cube.transform.position.z + 0.5;
        cubeZmin = cube.transform.position.z - 0.5;
        cube2Xmin = cube2.transform.position.x - 0.5;
        cube2Xmax = cube2.transform.position.x + 0.5;
        cube2Ymin = cube2.transform.position.y - 0.5;
        cube2Ymax = cube2.transform.position.y + 0.5;
        cube2Zmax = cube2.transform.position.z + 0.5;
        cube2Zmin = cube2.transform.position.z - 0.5;

        if (cube2Xmin <= cubeXmax && cubeXmax <= cube2Xmax || cubeXmax >= cube2Xmin && cubeXmax <= cube2Xmax)
        {
            if (cube2Ymin <= cubeYmax && cubeYmax <= cube2Ymax || cubeYmax >= cube2Ymin && cubeYmax <= cube2Ymax)
            {
                if (cube2Zmin <= cubeZmax && cubeZmax <= cube2Zmax || cubeZmax >= cube2Zmin && cubeZmax <= cube2Zmax)
                {
                    Debug.Log("AAAAAAAAAAHH");
                }
            }
        }

        if (cube2Xmax >= cubeXmin && cubeXmin >= cube2Xmin || cubeXmin <= cube2Xmax && cubeXmin >= cube2Xmin)
        {
            if (cube2Ymax >= cubeYmin && cubeYmin >= cube2Ymin || cubeYmin <= cube2Ymax && cubeYmin >= cube2Ymax)
            {
                if (cube2Zmax >= cubeZmin && cubeZmin >= cube2Zmin || cubeZmin <= cube2Zmax && cubeZmin >= cube2Zmin)
                {
                    Debug.Log("AAAAAAAAAAHH");
                }
            }
        }
    }
}
