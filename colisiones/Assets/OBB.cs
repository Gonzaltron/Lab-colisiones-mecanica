using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class OBB : MonoBehaviour
{

    [SerializeField] GameObject cubo;
    [SerializeField] GameObject cubo2;
    Vector3 up1;
    Vector3 up2;
    Vector3 forward1;
    Vector3 forward2;
    Vector3 point11;
    Vector3 point12;
    Vector3 point13;
    Vector3 point14;
    Vector3 point21;
    Vector3 point22;
    Vector3 point23;
    Vector3 point24;
    Vector3 x;
    Vector3 y;
    Vector3 xMax1;
    Vector3 xMax2;
    Vector3 xMin1;
    Vector3 xMin2;
    Vector3 yMax1;
    Vector3 yMin2;
    Vector3 yMax2;
    Vector3 yMin1;
    float dotX1Min;
    float dotY1Min;
    float dotX1Max;
    float dotY1Max;
    float dotX2Min;
    float dotY2Min;
    float dotX2Max;
    float dotY2Max;
    List <float> pointsX1 = new List<float>();
    List <float> pointsY1 = new List<float>();
    List <float> pointsX2 = new List<float>();
    List <float> pointsY2 = new List<float>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = new Vector3(1, 0, 0);
        y = new Vector3(0, 1, 0);
        dotX1Min = 1110;
        dotY1Min = 1110;
        dotX1Max = 0;
        dotY1Max = 0;
        dotX2Min = 1110;
        dotY2Min = 1110;
        dotX2Max = 0;
        dotY2Max = 0;
    }

    // Update is called once per frame
    void Update()
    {
        dotX1Min = 1110;
        dotY1Min = 1110;
        dotX1Max = 0;
        dotY1Max = 0;
        dotX2Min = 1110;
        dotY2Min = 1110;
        dotX2Max = 0;
        dotY2Max = 0;
        point11 = cubo.transform.position + 0.5f * cubo.transform.right + 0.5f * cubo.transform.up;
        point12 = cubo.transform.position + 0.5f * cubo.transform.right - 0.5f * cubo.transform.up;
        point13 = cubo.transform.position - 0.5f * cubo.transform.right + 0.5f * cubo.transform.up;
        point14 = cubo.transform.position - 0.5f * cubo.transform.right - 0.5f * cubo.transform.up;
        point21 = cubo2.transform.position + 0.5f * cubo2.transform.right + 0.5f * cubo2.transform.up;
        point22 = cubo2.transform.position + 0.5f * cubo2.transform.right - 0.5f * cubo2.transform.up;
        point23 = cubo2.transform.position - 0.5f * cubo2.transform.right + 0.5f * cubo2.transform.up;
        point24 = cubo2.transform.position - 0.5f * cubo2.transform.right - 0.5f * cubo2.transform.up;
        up1 = cubo.transform.up;
        up2 = cubo2.transform.up;
        forward1 = cubo2.transform.right;
        forward2 = cubo2.transform.right;

        pointsX1.Add(Vector3.Dot(point11, x));
        pointsX1.Add(Vector3.Dot(point12, x));
        pointsX1.Add(Vector3.Dot(point13, x));
        pointsX1.Add(Vector3.Dot(point14, x));
        pointsY1.Add(Vector3.Dot(point11, y));
        pointsY1.Add(Vector3.Dot(point12, y));
        pointsY1.Add(Vector3.Dot(point13, y));
        pointsY1.Add(Vector3.Dot(point14, y));
        pointsX2.Add(Vector3.Dot(point21, x));
        pointsX2.Add(Vector3.Dot(point22, x));
        pointsX2.Add(Vector3.Dot(point23, x));
        pointsX2.Add(Vector3.Dot(point24, x));
        pointsY2.Add(Vector3.Dot(point21, y));
        pointsY2.Add(Vector3.Dot(point22, y));
        pointsY2.Add(Vector3.Dot(point23, y));
        pointsY2.Add(Vector3.Dot(point24, y));

        for (int i = 0; i < 4; i++)
        {
            if (pointsX1[i] < dotX1Min)
            {
                dotX1Min = pointsX1[i];
            }
            else if (pointsX1[i] > dotX1Max)
            {
                dotX1Max = pointsX1[i];
            }
            if (pointsY1[i] < dotY1Min)
            {
                dotY1Min = pointsY1[i];
            }
            else if (pointsY1[i] > dotY1Max)
            {
                dotY1Max = pointsY1[i];
            }
            if (pointsX2[i] < dotX2Min)
            {
                dotX2Min = pointsX2[i];
            }
            else if (pointsX2[i] > dotX2Max)
            {
                dotX2Max = pointsX2[i];
            }
            if (pointsY2[i] < dotY2Min)
            {
                dotY2Min = pointsY2[i];
            }
            else if (pointsY2[i] > dotY2Max)
            {
                dotY2Max = pointsY2[i];
            }
        }

        pointsX1.Clear();
        pointsX2.Clear();
        pointsY1.Clear();
        pointsY2.Clear();

        if(dotX1Max < dotX2Max && dotX1Max > dotX2Min)
        {
            if(dotY1Max <  dotY2Max && dotY1Max > dotY2Min)
            {
                Debug.Log("AAAAH");
            }
        }
        if(dotX1Min < dotX2Max && dotX1Min > dotX2Min)
        {
            if(dotY1Min <  dotY2Max && dotY1Min > dotY2Min)
            {
                Debug.Log("AAAAH");
            }
        }
        if(dotX2Max < dotX1Max && dotX2Max > dotX1Min)
        {
            if(dotY2Max <  dotY1Max && dotY2Max > dotY1Min)
            {
                Debug.Log("AAAAH");
            }
        }
        if(dotX2Min < dotX1Max && dotX2Min > dotX1Min)
        {
            if(dotY2Min <  dotY1Max && dotY2Min > dotY1Min)
            {
                Debug.Log("AAAAH");
            }
        }
    }
}
