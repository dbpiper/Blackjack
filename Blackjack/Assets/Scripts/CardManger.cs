using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class CardManger : MonoBehaviour
    {
        public List<GameObject> PlayerCards;
        public List<GameObject> OpponentCards;
        // Use this for initialization
        public void Start () {
        
            //foreach (var playerCard in PlayerCards) {
            //    //Debug.Log("trying to make visible");
            //    //SpriteRenderer spriteRenderer = playerCard.GetComponent<SpriteRenderer>();
            //    //spriteRenderer.SetAc
            //    playerCard.SetActive(false);
            //}
        }
    
        // Update is called once per frame
        public void Update () {
        
        }

        public void Stand()
        {
        }

        public void Deal()
        {
            foreach (var playerCard in PlayerCards) {
                playerCard.SetActive(true);
            }
            foreach (var opponentCard in OpponentCards) {
                opponentCard.SetActive(true);
            }
        }

        public void Hit()
        {
        }
    }
}
