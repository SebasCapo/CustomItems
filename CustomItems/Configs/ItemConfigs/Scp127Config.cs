using System.Collections.Generic;
using System.ComponentModel;
using CustomItems.API;

namespace CustomItems.ItemConfigs
{
    public class Scp127Config
    {
        [Description("How often ammo will be regenerated. Regeneration occurs at all times, however this timer is reset when the weapon is picked up or dropped.")]
        public float RegenDelay { get; set; } = 10f;
        
        [Description("The amount of ammo that will be regenerated each regeneration cycle.")]
        public int RegenAmount { get; set; } = 2;
        
        [Description("The max clip size for the weapon.")]
        public int ClipSize { get; set; } = 12;
        
        [Description("The base weapon this one will be modeled after.")]
        public ItemType ItemType { get; set; } = ItemType.GunCOM15;
        
        [Description("Where on the map items should spawn, and their % chance of spawning in each location.")]
        public Dictionary<SpawnLocation, float> SpawnLocations { get; set; } = new Dictionary<SpawnLocation, float>();
    }
}