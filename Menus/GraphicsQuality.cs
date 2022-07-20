using System;
using UnityEngine;

public class GraphicsQuality : MonoBehaviour
{
    private const string quality = "graphicsQuality";
    private int GQuality;
    public void SetGraphicsQuality(int GraphicsQuality)
    {
        QualitySettings.SetQualityLevel(GraphicsQuality);
        PlayerPrefs.SetInt(quality, GraphicsQuality);
        PlayerPrefs.Save();
        Debug.Log($"Graphics quality {GraphicsQuality}");
    }

    private void Start()
    {
        GQuality = PlayerPrefs.GetInt(quality);
        Debug.Log($"has key {PlayerPrefs.HasKey(quality)}");
    }
}
