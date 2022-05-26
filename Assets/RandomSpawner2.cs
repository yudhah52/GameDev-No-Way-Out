using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner2 : MonoBehaviour
{
    public GameObject cubePrefab;

    Vector3 location1 = new Vector3(27, 2, 19);
    Vector3 location2 = new Vector3(5, 4, -19);
    Vector3 location3 = new Vector3(-14, 2, 11);
    Vector3 location4 = new Vector3(18, 3, 4);

    void Start()
    {
        // Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 17), 4, Random.Range(-18, 38));
        // Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        // int lokasi = new Random(1, 4);
        int lokasi = Random.Range(1, 5);
        switch (lokasi)
        {
            case 1:
                Instantiate(cubePrefab, location1, Quaternion.identity);
                break;
            case 2:
                Instantiate(cubePrefab, location2, Quaternion.identity);
                break;
            case 3:
                Instantiate(cubePrefab, location3, Quaternion.identity);
                break;
            case 4:
                Instantiate(cubePrefab, location4, Quaternion.identity);
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
    //                 Instantiate(cubePrefab, location1, Quaternion.identity);
    //                 break;
    //             case 2:
    //                 Instantiate(cubePrefab, location2, Quaternion.identity);
    //                 break;
    //             case 3:
    //                 Instantiate(cubePrefab, location3, Quaternion.identity);
    //                 break;
    //             case 4:
    //                 Instantiate(cubePrefab, location4, Quaternion.identity);
    //                 break;
    //         }
    //         // Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 17), 4, Random.Range(-18, 38));
    //         // Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
    //     }
    // }
}
