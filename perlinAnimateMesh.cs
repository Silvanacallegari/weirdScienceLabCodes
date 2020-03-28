using UnityEngine;
using System.Collections;

public class perlinAnimateMesh : MonoBehaviour
{
    public float perlinScale = 4.56f;
    public float waveSpeed = 1f;
    public float waveHeight = 0f;
    private Transform target;
    public GameObject toucher;

    private Mesh mesh;


    void Update()
    {
        target = toucher.transform;
        AnimateMesh();

    }

    void AnimateMesh()
    {

        if (Vector3.Distance(transform.position, target.position) < 2f)
        {
            waveHeight = 0.5f;
        }
        else
        {
            waveHeight = 0f;
        }


            if (!mesh)
            mesh = GetComponent<MeshFilter>().mesh;

        Vector3[] vertices = mesh.vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            float pX = (vertices[i].x * perlinScale) + (Time.timeSinceLevelLoad * waveSpeed);
            float pZ = (vertices[i].z * perlinScale) + (Time.timeSinceLevelLoad * waveSpeed);

            vertices[i].y = (Mathf.PerlinNoise(pX, pZ) - 0.5f) * waveHeight;
        }

        mesh.vertices = vertices;
    }
}