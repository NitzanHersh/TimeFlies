using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyboxColor : MonoBehaviour
{
    public Color[] colors;

    public Material PlayerMaterial;
    public Material ObstacleMaterial;
    public Material GroundMaterial;
    public Material CollectableMaterial;


    void Start()
    {
        RenderSettings.skybox.SetFloat("_Exposure", 1f);

    }

  public void ChangeExposure(bool newBool)
    {
        if(newBool == true)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 0.5f);
            PlayerMaterial.SetFloat("_Brightness", 0.5f);
            ObstacleMaterial.SetFloat("_Brightness", 0.5f);
            GroundMaterial.SetFloat("_Brightness", 0.5f);
            CollectableMaterial.SetFloat("_Brightness", 0.5f);

        }
        if (newBool == false)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 1f);
            PlayerMaterial.SetFloat("_Brightness", 1f);
            ObstacleMaterial.SetFloat("_Brightness", 1f);
            GroundMaterial.SetFloat("_Brightness", 1f);
            CollectableMaterial.SetFloat("_Brightness", 1f);
        }
    }

    public void ChangeColor()
    {
        int nextColor = Random.Range(0, colors.Length);
        RenderSettings.skybox.SetColor("_Tint", colors[nextColor]);
        
    }
}
