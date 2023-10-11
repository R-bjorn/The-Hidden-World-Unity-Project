using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanes : MonoBehaviour
{
    public GameObject plane;

    private float spawnLimitXLeft = -120;
    private float spawnLimitXRight = 120;

    private float spawnPosY = 150;
    private float spawnPosZ = -400;

    private float spawnInterval = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnPlane", spawnInterval);
    }

    void SpawnPlane()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, spawnPosZ);

        Instantiate(plane, spawnPos, plane.transform.rotation);
        spawnInterval = Random.Range(3f, 7f);
        Invoke("SpawnPlane", spawnInterval);
    }
}
