using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    Vector3 kamar1 = new Vector3(16, 4, 16);
    Vector3 kamar2 = new Vector3((float)-13.9, (float)0.5, (float)9.5);
    Vector3 kamar3 = new Vector3(7, (float)2.4, (float)23.5);
    Vector3 kamar4 = new Vector3(-20, (float)1.8, (float)-11.2);

    void Start()
    {
        // Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 17), 4, Random.Range(-18, 38));
        // Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        // int lokasi = new Random(1, 4);
        int lokasi = Random.Range(1, 5);
        switch (lokasi)
        {
            case 1:
                Instantiate(cubePrefab, kamar1, Quaternion.identity);
                break;
            case 2:
                Instantiate(cubePrefab, kamar2, Quaternion.identity);
                break;
            case 3:
                Instantiate(cubePrefab, kamar3, Quaternion.identity);
                break;
            case 4:
                Instantiate(cubePrefab, kamar4, Quaternion.identity);
                break;
        }
    }
    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.RightAlt))
    //     {
    //         int lokasi = Random.Range(1, 5);
    //         switch (lokasi)
    //         {
    //             case 1:
    //                 Instantiate(cubePrefab, kamar1, Quaternion.identity);
    //                 break;
    //             case 2:
    //                 Instantiate(cubePrefab, kamar2, Quaternion.identity);
    //                 break;
    //             case 3:
    //                 Instantiate(cubePrefab, kamar3, Quaternion.identity);
    //                 break;
    //             case 4:
    //                 Instantiate(cubePrefab, kamar4, Quaternion.identity);
    //                 break;
    //         }
    //         // Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 17), 4, Random.Range(-18, 38));
    //         // Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
    //     }
    // }
}
