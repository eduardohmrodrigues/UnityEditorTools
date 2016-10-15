using UnityEngine;
using UnityEditor;
using System.Collections;

public class CloneObjects : ScriptableWizard {

    [Tooltip("The Object to Clone")]
    public GameObject objectToClone;

    [Tooltip("The number of clones")]
    public int numberOfCopies = 0;

    [Tooltip("The distance of the clones in the x y z axis")]
    public Vector3 clonesTranslationDistance;

    [Tooltip("If is the first instance then the first clone is created in the object initial position, else the first clone will be created already in the new position")]
    public bool isFirstInstace = false;

    [MenuItem("My Tools/Clone Objects")]
    static void CloneObjectsWizard()
    {
        ScriptableWizard.DisplayWizard<CloneObjects>("Clone Objects", "Clone");
    }


    void OnWizardCreate()
    {
        if(objectToClone)
        {
            int initialTranslation = isFirstInstace ? 1 : 0;

            for(int i=0; i<numberOfCopies; i++)
            {
                Object clone = Instantiate(
                    objectToClone,
                    new Vector3(
                        ((i + initialTranslation) * clonesTranslationDistance.x) + objectToClone.transform.position.x,
                        ((i + initialTranslation) * clonesTranslationDistance.y) + objectToClone.transform.position.y,
                        ((i + initialTranslation) * clonesTranslationDistance.z) + objectToClone.transform.position.z
                        ),
                    Quaternion.identity);

                clone.name = objectToClone.name + (" Clone") + i;
            }
        }
    }

}
