using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireController : MonoBehaviour
{
    [SerializeField] private Transform firePointL;
    [SerializeField] private Transform firePointR;

    [SerializeField] private GameObject firePrefab;

    [SerializeField] private float fireRate;
    [SerializeField] private float destroyTime;

    private bool isFire = false;

    private void Update()
    {
        if (!isFire)
        {
            StartCoroutine(PrefabFireController());
        }       
    }

    IEnumerator PrefabFireController()
    {
        isFire = true;

        while (true)
        {
            GameObject prefabL = Instantiate(firePrefab, firePointL.position, Quaternion.identity);
            Destroy(prefabL, destroyTime);

            yield return new WaitForSeconds(fireRate);

            GameObject prefabR = Instantiate(firePrefab, firePointR.position, Quaternion.identity);
            Destroy(prefabR, destroyTime);

            yield return new WaitForSeconds(fireRate);
        }
    }
}
