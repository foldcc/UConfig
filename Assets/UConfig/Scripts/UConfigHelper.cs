using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 namespace UConfig {
    public static class UConfigHelper
    {
        /// <summary>
        /// 将指定的配置文件转化为指定对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="script"></param>
        /// <returns></returns>
        public static T GetObjectWithUConfig<T>(ScriptableObject script) where T : ScriptableObject {
            return script as T;
        }
    }
}


