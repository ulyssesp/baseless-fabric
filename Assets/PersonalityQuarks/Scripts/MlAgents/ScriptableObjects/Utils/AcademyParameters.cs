using MLAgents;
using UnityEngine;

static class AcademyParameters {

    public static float FetchOrParse(Academy academy, string key) {
      float prop = academy.FloatProperties.GetPropertyWithDefault(key, -1);
      if(prop == -1) {
          return float.Parse(key);
      }

      return prop;
    }

    public static float Update(Academy academy, string key, float current) {
      return academy.FloatProperties.GetPropertyWithDefault(key, current);
    }
}
