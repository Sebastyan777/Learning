using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<string> namesList = new List<string>();

    private void Start()
    {
        namesList.Add("Sasha");
        namesList.Add("Masha");
    }
}
