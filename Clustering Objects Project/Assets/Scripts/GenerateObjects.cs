using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour
{
    // public int numObjClass1 = 0;
    // public int numObjClass2 = 0;

    // private int numObj = numObjC1 + numObjC2;

    public float x_value;
    public float media_11;
    public float sigma_11;

    public void Start()
    {
        float result = NormalDistribution(x_value, media_11, sigma_11);
        Debug.Log(result * 2);
    }

    public static float NormalDistribution(float x, float media, float sigma)
    {
        float density = 1 / (Mathf.Sqrt(2 * Mathf.PI * Mathf.Pow(sigma, 2)));
        float expoent = Mathf.Pow((x - media), 2) / -(2 * Mathf.Pow((sigma), 2));
        float value = density * Mathf.Pow(2.718282f, 2);

        return density * Mathf.Pow(value, expoent);
    }
}


