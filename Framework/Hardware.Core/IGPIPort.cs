using System;
using Microsoft.SPOT;

/*
 * Copyright 2012-2014 Stefan Thoolen (http://www.netmftoolbox.com/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace Toolbox.NETMF.Hardware
{
    /// <summary>Generic Purpose Input Port interface</summary>
    public interface IGPIPort : IDisposable
    {
        /// <summary>Reads the pin value</summary>
        /// <returns>True when high, false when low</returns>
        bool Read();
        /// <summary>When true, the read value is inverted (useful when working with pull-up resistors)</summary>
        bool InvertReadings { get; set; }
    }
}
