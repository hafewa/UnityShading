﻿using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
public class PerPixelCookTorranceShader : MonoBehaviour
{
  [SerializeField]
  private Material specular;

  [SerializeField]
  private Transform lightTransform;

  [SerializeField]
  private float k_diffuse;

  [SerializeField]
  private float k_ambient;

  [SerializeField]
  private float k_specular;

  [SerializeField]
  private float roughness;

  [SerializeField]
  private float complexRefractiveIndex;

  public void Update()
  {
    Vector4 lightPos = lightTransform.position;

    specular.SetVector("light_pos", lightPos);
    specular.SetFloat("k_diffuse", k_diffuse);
    specular.SetFloat("k_ambient", k_ambient);
    specular.SetFloat("k_specular", k_specular);
    specular.SetFloat("roughness", roughness);
    specular.SetFloat("complex_refractive_index", complexRefractiveIndex);
  }
}