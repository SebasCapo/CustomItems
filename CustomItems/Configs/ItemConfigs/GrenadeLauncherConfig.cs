using System.Collections.Generic;
using System.ComponentModel;
using CustomItems.API;

namespace CustomItems.ItemConfigs
{
    public class GrenadeLauncherConfig
    {
        [Description("Whether or not players will need actual frag grenades in their inventory to use as ammo. If false, the weapon's base ammo type is used instead.")]
        public bool UseGrenades { get; set; } = true;
        
        [Description("How many rounds a single reload should give. Note that weapons that fire more quickly than others will want lower clip sizes to prevent a nightmare of explosions. Unless that's your thing.. No judgement.")]
        public int ClipSize { get; set; } = 1;
        
        [Description("The type of weapon this one will be modeled after.")]
        public ItemType ItemType { get; set; } = ItemType.GunLogicer;
        
        [Description("Where on the map items should spawn, and their % chance of spawning in each location.")]
        public Dictionary<SpawnLocation, float> SpawnLocations { get; set; } = new Dictionary<SpawnLocation, float>();
        
        [Description("The speed of grenades when they shoot out of the weapon.")]
        public float GrenadeSpeed { get; set; } = 1f;
        
        [Description("The max duration of the fuse of grenades shot from the weapon. Note, these grenades will always explode immediatly when they collide with something, but this can be used with slow-moving grenades to cause mid-air explosions.")]
        public float FuseTime { get; set; } = 1f;
    }
}