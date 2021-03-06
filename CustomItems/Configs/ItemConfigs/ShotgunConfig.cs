using System.Collections.Generic;
using System.ComponentModel;
using CustomItems.API;

namespace CustomItems.ItemConfigs
{
    public class ShotgunConfig
    {
        [Description("The amount of pellets fired at once. This amount of ammo will also be consumed from the weapons current clip. If the clip is lower than this amount, the amount in the clip is used instead.")]
        public int SpreadCount { get; set; } = 12;
        
        [Description("The 'randomness' factor used for the aimcone. Higher numbers = wider aimcone, which means less accuracy.")]
        public int AimconeSeverity { get; set; } = 5;
        
        [Description("The base damage each pellet should deal on a body shot.")]
        public float BaseDamage { get; set; } = 13.5f;
        
        [Description("The base weapon this one will be modeled after.")]
        public ItemType ItemType { get; set; } = ItemType.GunMP7;
        
        [Description("Where on the map items should spawn, and their % chance of spawning in each location.")]
        public Dictionary<SpawnLocation, float> SpawnLocations { get; set; } = new Dictionary<SpawnLocation, float>();
        
        [Description("Damage is reduced for every 1f away from the shooter the target is. This number signifies how much damage is 'carried over'. By default (0.9), every 1f further away, the damage each pellet can deal is reduced by 10%.")]
        public float DamageFalloffModifier { get; set; } = 0.9f;
    }
}