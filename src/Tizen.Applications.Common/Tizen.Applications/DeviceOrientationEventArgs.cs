/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Applications
{
    /// <summary>
    /// The class for event arguments of the DeviceOrientationChanged.
    /// </summary>
    public class DeviceOrientationEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes the DeviceOrientationEventArgs class.
        /// </summary>
        /// <param name="orientation">The information of the DeviceOrientation</param>
        public DeviceOrientationEventArgs(DeviceOrientation orientation)
        {
            DeviceOrientation = orientation;
        }

        /// <summary>
        /// The received DeviceOrientation.
        /// </summary>
        public DeviceOrientation DeviceOrientation { get; private set; }
    }
}
