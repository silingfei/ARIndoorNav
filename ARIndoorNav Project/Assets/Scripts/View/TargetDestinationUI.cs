﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetDestinationUI : MonoBehaviour
{
    public TMP_Text _DestinationDistance;
    public TMP_Text _DestinationName;
    public TMP_Text _LastMarkerText;
  
    public void DisplayTargetInformation(string destinationName, float targetDistance)
    {
        _DestinationName.text = "Destination: " + destinationName;
        _DestinationDistance.text = "(" + targetDistance.ToString("0.00") + " m)";
    }

    public void UpdateDistance(float targetDistance)
    {
        _DestinationDistance.text = "(" + targetDistance.ToString("0.00") + " m)";
    }

    public void UpdateLastMarker(string markerName)
    {
        _LastMarkerText.text = "Last Marker: " + markerName;
    }

    public void ResetTargetInformation()
    {
        _DestinationDistance.text = "(0.00m)";
        _DestinationName.text = "Last destination: " + _DestinationName;
        _LastMarkerText.text = "";
    }

}
