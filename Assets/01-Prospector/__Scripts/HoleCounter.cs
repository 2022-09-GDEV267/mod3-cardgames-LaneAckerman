using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{


    public class HoleCounter : MonoBehaviour
    {
        // Start is called before the first frame update
        public int count = 1;

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
