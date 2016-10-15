using UnityEngine;
using UnityEditor;
using System.Collections;

public class SpriteProcessor : AssetPostprocessor {
    
    void OnPostprocessTexture(Texture2D texture)
    {
        string lowerCaseAssetPath = assetPath.ToLower();
        bool isInSpritesDirectory = (lowerCaseAssetPath.IndexOf("/sprites/") != -1);


        if (isInSpritesDirectory)
        {
            TextureImporter importer = (TextureImporter)assetImporter;
            importer.textureType = TextureImporterType.Sprite;
        }
    }

}
