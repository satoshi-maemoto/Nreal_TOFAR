using System.Collections;
using System.Collections.Generic;
using TofAr.V0;
using TofAr.V0.Hand;
using TofAr.V0.Tof;
using UnityEngine;

namespace NrealTofAr
{
    public class ContentsController : MonoBehaviour
    {
        public void OnTofConfigurationSelected(CameraConfigurationProperty configuration, bool isProcessTexture)
        {
            TofArHandManager.Instance.StopStream();
            TofArTofManager.Instance.StopStream();
            TofArManager.Logger.WriteLog(LogLevel.Debug, $"Selected {configuration.name} isProcessTexture:{isProcessTexture}");
            TofArTofManager.Instance.StartStream(configuration, isProcessTexture);
            TofArHandManager.Instance.StartStream();
        }
    }
}