using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPawnesndfgjibhihfghfgd : MonoBehaviour
{
    public GameObject cube;
    public int number;
    public int minX, maxX, minZ, maxZ, minY, maxY;

    void Start()
    {
        PlaceCubes();
    }

    void PlaceCubes()
    {
        for(int i = 0; i < number; i++)
        {
            Instantiate(cube, GeneratedPostion(), Quaternion.identity);
            cube.transform.localPosition = Vector3.zero;
        }
    }
    Vector3 GeneratedPostion()
    {
        int x, y, z;
        x = UnityEngine.Random.Range(minX, maxX);
        y = UnityEngine.Random.Range(minY, maxY);
        z = UnityEngine.Random.Range(minZ, maxZ);
        return new Vector3(x, y, z);
    }
}
