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

namespace Tizen.Multimedia.MediaController
{

    /// <summary>
    /// PlaybackStateCommand event arguments
    /// </summary>
    /// <remarks>
    /// PlaybackStateCommand event arguments
    /// </remarks>
    public class PlaybackStateCommandEventArgs : EventArgs
    {
        internal PlaybackStateCommandEventArgs(string name, MediaControllerPlaybackState state)
        {
            ClientName = name;
            State = state;
        }

        /// <summary>
        /// Get the Client Name.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string ClientName { get; }

        /// <summary>
        /// Get the State of playback.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public MediaControllerPlaybackState State { get; }
    }
}
