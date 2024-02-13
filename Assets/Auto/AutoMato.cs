using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matory;
using System;

namespace Mator
{
    public class AutoMato : MonoBehaviour
    {
        // Start is called before the first frame update
        static Mato runner = null;
        private bool swich = false;
        void Awake()
        {
            if (runner == null)
            {
                runner = gameObject.AddComponent<Mato>();
                try
                {
                    if (runner != null)
                    {
                        runner.Init();
                    }
                }
                catch (Exception ex)
                {
                    Debug.LogException(ex);
                }
            }
        }
    }
}
