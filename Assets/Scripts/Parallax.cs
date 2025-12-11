using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float animationSpeed = 1f;

    private void Awake()
    {
        
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
   
        Vector2 offset = meshRenderer.material.mainTextureOffset;
        offset.x += animationSpeed * Time.deltaTime;
        meshRenderer.material.mainTextureOffset = offset;
    }
}
