using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterTMPro : MonoBehaviour
{
    public TextMeshProUGUI CounterText;

    private int Count = 0;

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count: " + Count;
    }
}
