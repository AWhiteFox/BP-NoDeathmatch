﻿/*
    This file is part of BP-NoDeathmatch.
    
    BP-NoDeathmatch is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
    
    BP-NoDeathmatch is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
    
    You should have received a copy of the GNU General Public License
    along with BP-NoDeathmatch.  If not, see <https://www.gnu.org/licenses/>.
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NoDeathmatch
{
    [Serializable]
    public class Faction
    {
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public List<int> Jobs { get; set; } = new List<int>();
        [JsonProperty]
        public List<string> CanDamage { get; set; } = new List<string>();
        [JsonProperty]
        public List<string> CanKill { get; set; } = new List<string>();
    }
}
