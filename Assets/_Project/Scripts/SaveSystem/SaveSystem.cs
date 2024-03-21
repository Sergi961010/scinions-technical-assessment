using UnityEngine;

public static class SaveSystem
{
    public static void SaveInt(string key, int value) => PlayerPrefs.SetInt(key, value);
    public static int LoadInt(string key) => PlayerPrefs.GetInt(key, 0);
}