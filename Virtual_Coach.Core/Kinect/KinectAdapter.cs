using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Virtual_Coach.Core
{
    class KinectAdapter
    {
        public KinectSensor kinectsonsor {get ;set; }

        private static KinectAdapter instance;

        private Skeleton[] skeletondata; //All skeletons


    }
}
