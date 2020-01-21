  
using IVCam.Tools.Infrastructure.Logging;
using RealSense.Tools.ProjectorTester.Cmc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSense.Tools.IVCam2.Validation.Tests
{
    public interface ILightController
    {
        void TurnTesterLightOff(Logger logger);
        void TurnTesterLightOn(Logger logger);

        void SetStartupLights();
        void SetFailureLights();
        void SetPassLights();
        void SetQualityLights();
        bool Init();
    }
}
