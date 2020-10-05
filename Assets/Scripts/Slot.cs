using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public void SlotClicked(GameObject buttonGameObject = null)
    {
        Debug.Log($"Slot clicked - {buttonGameObject.name}");
    }
}
