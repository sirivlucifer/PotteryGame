using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Wood : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    [SerializeField] private Transform woodTransform;
    [SerializeField] private float rotationDuration;
    [SerializeField] private Vector3 rotationVector;
    


    private void Start()
    {
        woodTransform.DORotate(rotationVector, rotationDuration, RotateMode.FastBeyond360)
        .SetLoops(-1, LoopType.Restart).
        SetEase(Ease.Linear);
    }

    public void Hit(int keyIndex, float damage){
        float colliderHeight = 2.390238f;
        float newWeight = skinnedMeshRenderer.GetBlendShapeWeight(keyIndex) + damage *(100f/colliderHeight);
        skinnedMeshRenderer.SetBlendShapeWeight(keyIndex, newWeight);
    }
}
