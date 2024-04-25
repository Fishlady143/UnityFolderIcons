using UnityEngine;
using UnityEditor;

[CustomPreview(typeof(FolderObject))]
public class FOpreview : ObjectPreview
{
    public override bool HasPreviewGUI()
    {
        return true;
    }

    public override void OnPreviewGUI(Rect r, GUIStyle background)
    {
        FolderObject fObj = (FolderObject)target;
        GUI.DrawTexture(r, fObj.texture);
    }
}