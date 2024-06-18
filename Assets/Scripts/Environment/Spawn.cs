using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Boat CloneBoatPrefab;
    public Cars cars;
    public Transform PrefabTransform;
    public int ClonePersent;
    public float CloneDelaySec;

    private float NextClone = 0f;

    void Update()
    {
        float currentTime = Time.time;
        if (NextClone <= currentTime)
        {
            if (gameObject.tag == "Road")
            {
                int random = Random.Range(0, 100);
                if (random < ClonePersent)
                {
                    CloneCar();
                }
                NextClone = currentTime + CloneDelaySec;
            }
            else if (gameObject.tag == "Water")
            {
                int random = Random.Range(0, 100);
                if (random < ClonePersent)
                {
                    CloneBoat();
                }
                NextClone = currentTime + CloneDelaySec;
            }
        }
    }

    private void CloneBoat()
    {
        Transform transform = PrefabTransform;
        Vector3 height = transform.position;
        height.y = 0.42f;

        GameObject cloneoObj = Instantiate(CloneBoatPrefab.gameObject, height, PrefabTransform.rotation, this.transform);

        cloneoObj.SetActive(true);
    }

    private void CloneCar()
    {
        Transform transform = PrefabTransform;
        Vector3 height = transform.position;
        height.y = 1f;

        int randomCar = Random.Range(0, cars.car.Length);

        GameObject cloneoObj = Instantiate(cars.car[randomCar], height, PrefabTransform.rotation, this.transform);

        cloneoObj.SetActive(true);
    }
}
