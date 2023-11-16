using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;
public class AnimationContorller : MonoBehaviour
{

    public Transform couture;
    public Button moveButton;
    Sequence sequence = DOTween.Sequence();



    private void Start()
    {
        moveButton.onClick.AddListener(MoveCoutire);


    }

    private void MoveCoutire()
    {
        couture.DOMove(new Vector3(0, 0, 0), 3);
        Tween tween1 = couture.DOMoveX(5, 2f);
        Tween tween2 = couture.DOScale(Vector3.one * 2, 1f);
        Tween tween3 = couture.DORotate(Vector3.up * 90, 1.5f);
        sequence.Join(tween1);
        sequence.Join(tween2);
        sequence.Join(tween3);
    }
}
