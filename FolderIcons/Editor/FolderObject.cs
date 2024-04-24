using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

[CreateAssetMenu(fileName = "FolderObject", menuName = "FolderScriptableObject", order = 1)]
public class FolderObject : ScriptableObject
{
    [Header("Texture")]
    [Tooltip("Folder Icon")]
    public Texture2D texture;
    [Space(8)]

    [Header("List of names")]
    [Tooltip("List of names you wish for the icon to apply to")]
    public List<string> names = new();
     
    private void OnValidate()
    {
        if (texture != null)
        {
            if (names.Count <= 0)
            {
                names.Add(texture.name);
            }
            else
            {
                names[0] = texture.name;
            }
        }
        else 
        {
            if (AssetDatabase.FindAssets(name + " t:texture2D").Length > 0)
            {
                texture = (Texture2D)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(AssetDatabase.FindAssets(name + " t:texture2D", new[] { AssetDatabase.GetAssetPath(this).Remove(AssetDatabase.GetAssetPath(this).Length - (name.Length + 6)) } )[0]), typeof(Texture2D));
                if (names.Count <= 0)
                {
                    names.Add(texture.name);
                }
                else
                {
                    names[0] = texture.name;
                }
            }
            else
            {
                Debug.LogWarning(@"Error: Couldn't find Texture2D sharing the name """ + name + @""", please assign one manually.");
            }
        }
    }
    private void OnEnable()
    {
        if (texture != null)
        {
            if (names.Count <= 0)
            {
                names.Add(texture.name);
            }
            else
            {
                names[0] = texture.name;
            }
        }
        else
        {
            if (AssetDatabase.FindAssets(name + " t:texture2D").Length > 0)
            {
                texture = (Texture2D)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(AssetDatabase.FindAssets(name + " t:texture2D", new[] { AssetDatabase.GetAssetPath(this).Remove(AssetDatabase.GetAssetPath(this).Length - (name.Length + 6)) })[0]), typeof(Texture2D));
                if (names.Count <= 0)
                {
                    names.Add(texture.name);
                }
                else
                {
                    names[0] = texture.name;
                }
            }
            else
            {
                Debug.LogWarning(@"Error: Couldn't find Texture2D sharing the name """ + name + @""", please assign one manually.");
            }
        }
    }
}