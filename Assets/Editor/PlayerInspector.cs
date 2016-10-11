using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Player))]
public class PlayerInspector : Editor {

    Player player;
    Color defaultColor;

    void OnEnable()
    {
        defaultColor = GUI.color;
        player = (Player)target;
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();

        //Not editable value
        EditorGUILayout.LabelField("Player id " + player.id);
        //Editable value
        player.playerName = EditorGUILayout.TextField("Player name ", player.playerName);
        //Slider
        player.damage = EditorGUILayout.Slider("Damage ", player.damage, 10, 20);

        //Editable text area
        EditorGUILayout.LabelField("Player Back Story ");
        player.backStory = EditorGUILayout.TextArea(player.backStory, GUILayout.MaxHeight(70));
        
        //Change color by value
        if (player.health < 30)
            GUI.color = Color.red;
        else if (player.health < 60)
            GUI.color = Color.yellow;
        else
            GUI.color = Color.green;

        Rect progressRect = GUILayoutUtility.GetRect(50, 25);
        EditorGUI.ProgressBar(progressRect, player.health / 100, "Health");
        GUI.color = defaultColor;
        //player.health = EditorGUILayout.FloatField("Health ", player.health);
        player.health = EditorGUILayout.Slider("Health ", player.health, 0, 100);


        EditorGUILayout.EndVertical();
    }

}
