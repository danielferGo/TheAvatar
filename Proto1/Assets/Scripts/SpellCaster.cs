using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Hands;

public class SpellCaster : MonoBehaviour
{
    public SpellLibrary spellLibrary;
    public TMP_Text Text;
    public ElementType currentElement;
    public Avatar avatar;
    public CanvasGroup canvasGroup;

    private SpellCommand currenSpell;

    public void OnGestureRecognized(HandContext handContext)
    {
        if (currenSpell)
        {
            currenSpell.Desactivate();
        }

        var spell = spellLibrary.GetSpell(handContext.gestureId, currentElement);
        if (spell == null)
        {
            Debug.Log("Spell not found");
            return;
        }

        if (!spell) return;
        currenSpell = spell;
        Text.text = currenSpell.SpellName;

        spell?.Execute(handContext);
    }

    public void OnGestureCanceled()
    {
        currenSpell?.Desactivate();
        currenSpell = null;
    }

    public void SetElement(int element)
    {
        if ((ElementType)element == currentElement) return;
        currentElement = (ElementType)element;
        Text.text = currentElement.ToString();
        StartCoroutine(SetElementImage());
    }

    private IEnumerator SetElementImage()
    {
        canvasGroup.alpha = 2;
        float fadeDuration = 2;
        while (fadeDuration > 0)
        {
            fadeDuration -= Time.deltaTime;
            canvasGroup.alpha = fadeDuration;
            yield return null;
        }

        canvasGroup.alpha = 0;
    }
}