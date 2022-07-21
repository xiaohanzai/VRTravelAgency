using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Assertions;

public class TeleportButton : MonoBehaviour
{
    public List<GameObject> objects;
    private GameObject currentObject;

    public void InstantiateObject(int index)
    {
        GameObject previousObject = currentObject;
        currentObject = Instantiate(objects[index], transform.position, transform.rotation);
        if (previousObject != null)
        {
            Destroy(previousObject);
        }
    }
}
