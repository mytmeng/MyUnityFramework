#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
public class AssetManager
{
    public T LoadAssets<T>(string path) where T : Object
    {
#if UNITY_EDITOR
        return AssetDatabase.LoadAssetAtPath<T>(path);
#endif
    }
    public static void TestCS2Lua()
    {
        Debug.LogError("lua调用c#成功");
    }
}
