using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.UI;
using ReflectionUtility;
using HarmonyLib;
using System.Reflection;
using Newtonsoft.Json;

namespace ModName{
    [ModEntry]
    class Main : MonoBehaviour{
        void Awake()
        {
            Debug.Log("Mod created");
        }
    }
}